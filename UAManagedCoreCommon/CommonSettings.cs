// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CommonSettings
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class CommonSettings
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const int OpcUaNamespaceIndex = 0;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const int CoreNamespaceIndex = 2;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly string OpcUaNamespaceUri = "http://opcfoundation.org/UA/";
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly string CoreNamespaceUri = "urn:FTOptix:Core";
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly string LocalServerNamespaceUri = "LocalServer";
  }
}
