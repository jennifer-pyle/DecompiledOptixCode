// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.ResourceUri
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using System;
using System.IO;
using System.Runtime.CompilerServices;
using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  public class ResourceUri
  {
    private const string namespacePrefix = "ns=";
    private const string projectDirectoryPrefix = "%PROJECTDIR%";
    private const string applicationDirectoryPrefix = "%APPLICATIONDIR%";
    private const string fileUriPrefix = "file://";
    private readonly string underlyingValue;

    public ResourceUri(UAValue value)
    {
      this.UriType = ResourceUri.DetermineUriType((string) value);
      this.underlyingValue = (string) value;
    }

    public static ResourceUri FromProjectRelativePath(string path)
    {
      return ResourceUri.FromProjectRelativePath(path, ManagedContextStore.Context.DefaultNamespaceIndex);
    }

    public static ResourceUri FromProjectRelativePath(string path, int namespaceIndex)
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
      interpolatedStringHandler.AppendFormatted("ns=");
      interpolatedStringHandler.AppendFormatted<int>(namespaceIndex);
      interpolatedStringHandler.AppendLiteral(";");
      interpolatedStringHandler.AppendFormatted("%PROJECTDIR%");
      interpolatedStringHandler.AppendLiteral("/");
      return new ResourceUri(UriType.ProjectRelative, interpolatedStringHandler.ToStringAndClear() + path);
    }

    public static ResourceUri FromApplicationRelativePath(string path)
    {
      return ResourceUri.FromApplicationRelativePath(path, ManagedContextStore.Context.DefaultNamespaceIndex);
    }

    public static ResourceUri FromApplicationRelativePath(string path, int namespaceIndex)
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
      interpolatedStringHandler.AppendFormatted("ns=");
      interpolatedStringHandler.AppendFormatted<int>(namespaceIndex);
      interpolatedStringHandler.AppendLiteral(";");
      interpolatedStringHandler.AppendFormatted("%APPLICATIONDIR%");
      interpolatedStringHandler.AppendLiteral("/");
      return new ResourceUri(UriType.ApplicationRelative, interpolatedStringHandler.ToStringAndClear() + path);
    }

    public static ResourceUri FromAbsoluteFilePath(string path)
    {
      string filePath = path.Replace('\\', '/');
      return new ResourceUri(UriType.AbsoluteFilePath, "file://" + (Environment.OSVersion.Platform != PlatformID.Unix ? (!ResourceUri.IsWindowsAbsoluteDeviceDrivePath(filePath) ? (!ResourceUri.IsAbsoluteNetworkPath(filePath) ? filePath : filePath.Substring("//".Length)) : "/" + filePath) : (ResourceUri.IsAbsoluteNetworkPath(filePath) ? filePath.Substring("//".Length) : filePath)));
    }

    public static ResourceUri FromUri(string uri) => new ResourceUri(UriType.Uri, uri);

    public static ResourceUri FromUSBRelativePath(uint usbNumber, string relativePath)
    {
      if (usbNumber < 1U)
        throw new ArgumentException("USB number must be equal to or greater than 1", nameof (usbNumber));
      if (relativePath.StartsWith("/"))
        throw new ArgumentException("A relative path cannot start with '/'", nameof (relativePath));
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
      interpolatedStringHandler.AppendLiteral("%USB");
      interpolatedStringHandler.AppendFormatted<uint>(usbNumber);
      interpolatedStringHandler.AppendLiteral("%/");
      interpolatedStringHandler.AppendFormatted(relativePath);
      return new ResourceUri(UriType.USBRelative, interpolatedStringHandler.ToStringAndClear());
    }

    public UriType UriType { get; }

    public string ProjectRelativePath
    {
      get
      {
        if (this.UriType != UriType.ProjectRelative)
          return (string) null;
        int num = this.underlyingValue.IndexOf("%PROJECTDIR%");
        return num == this.underlyingValue.Length - 1 ? "" : this.underlyingValue.Substring(num + "%PROJECTDIR%".Length + 1);
      }
    }

    public string ApplicationRelativePath
    {
      get
      {
        if (this.UriType != UriType.ApplicationRelative)
          return (string) null;
        int num = this.underlyingValue.IndexOf("%APPLICATIONDIR%");
        return num == this.underlyingValue.Length - 1 ? "" : this.underlyingValue.Substring(num + "%APPLICATIONDIR%".Length + 1);
      }
    }

    public string AbsoluteFilePath
    {
      get
      {
        if (this.UriType != UriType.AbsoluteFilePath)
          return (string) null;
        string str = this.underlyingValue.Substring("file://".Length);
        if (Environment.OSVersion.Platform == PlatformID.Unix)
          return str.StartsWith("/") ? str : "\\\\" + str.Replace('/', '\\');
        if (!str.StartsWith("/"))
          return "\\\\" + str.Replace('/', '\\');
        string filePath = str.Substring(1);
        if (!ResourceUri.IsWindowsAbsoluteDeviceDrivePath(filePath))
          filePath = "/" + filePath;
        return filePath;
      }
    }

    public string Uri
    {
      get
      {
        if (this.UriType == UriType.Uri)
          return this.underlyingValue;
        int namespaceIndex = this.ExtractNamespaceIndex();
        string path;
        switch (this.UriType)
        {
          case UriType.ProjectRelative:
            path = Path.Combine(this.context.GetProjectDirectory(namespaceIndex), this.ProjectRelativePath);
            break;
          case UriType.ApplicationRelative:
            path = Path.Combine(this.context.GetApplicationDirectory(namespaceIndex), this.ApplicationRelativePath);
            break;
          case UriType.AbsoluteFilePath:
            path = this.AbsoluteFilePath;
            break;
          case UriType.USBRelative:
            path = USBUriInterop.ToAbsolutePath(this.underlyingValue);
            break;
          default:
            DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
            interpolatedStringHandler.AppendLiteral("Invalid UriType: ");
            interpolatedStringHandler.AppendFormatted<UriType>(this.UriType);
            throw new UriFormatException(interpolatedStringHandler.ToStringAndClear());
        }
        return Path.GetFullPath(path);
      }
    }

    public uint USBNumber
    {
      get
      {
        return this.UriType != UriType.USBRelative ? 0U : USBUriInterop.ParseUSBNumber(this.underlyingValue);
      }
    }

    public string USBRelativePath
    {
      get
      {
        return this.UriType != UriType.USBRelative ? (string) null : USBUriInterop.ToRelativePath(this.underlyingValue);
      }
    }

    public static implicit operator string(ResourceUri resourceUri) => resourceUri.underlyingValue;

    public static implicit operator ResourceUri(string value)
    {
      return new ResourceUri(ResourceUri.DetermineUriType(value), value);
    }

    public static implicit operator UAValue(ResourceUri resourceUri)
    {
      return new UAValue(resourceUri.underlyingValue);
    }

    private ResourceUri(UriType type, string value)
    {
      this.UriType = type;
      this.underlyingValue = value;
    }

    private int ExtractNamespaceIndex()
    {
      if (!this.underlyingValue.StartsWith("ns="))
        return this.context.DefaultNamespaceIndex;
      int num1 = this.underlyingValue.IndexOf("=");
      if (num1 == -1)
        throw new UriFormatException("Invalid ResourceUri format");
      int num2 = this.underlyingValue.IndexOf(";");
      if (num2 == -1)
        throw new UriFormatException("Invalid ResourceUri format");
      return int.Parse(this.underlyingValue.Substring(num1 + 1, num2 - num1 - 1));
    }

    private IContext context => (IContext) ManagedContextStore.Context;

    private static UriType DetermineUriType(string s)
    {
      if (s.StartsWith("ns="))
      {
        int num1 = s.IndexOf('=');
        int num2 = num1 != -1 ? s.IndexOf(';', num1 + 1) : throw new UriFormatException("Invalid ResourceUri format");
        return num2 != -1 ? ResourceUri.DetermineUriType(s.Substring(num2 + 1)) : throw new UriFormatException("Invalid ResourceUri format");
      }
      if (s.StartsWith("%PROJECTDIR%"))
        return UriType.ProjectRelative;
      if (s.StartsWith("%APPLICATIONDIR%"))
        return UriType.ApplicationRelative;
      if (s.StartsWith("file://"))
        return UriType.AbsoluteFilePath;
      return USBUriInterop.IsRelativeToUSB(s) ? UriType.USBRelative : UriType.Uri;
    }

    private static bool IsWindowsAbsoluteDeviceDrivePath(string filePath)
    {
      return filePath.Length > 1 && filePath[0] != '/' && char.IsLetter(filePath[0]) && filePath[1] == ':';
    }

    private static bool IsAbsoluteNetworkPath(string filePath)
    {
      return filePath.Length > 1 && filePath.StartsWith("//");
    }
  }
}
