// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NamespaceInfo
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public struct NamespaceInfo
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string NamespaceUri { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ServerUri { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NamespaceType NamespaceType { get; }

    public NamespaceInfo(string namespaceUri, string serverUri, NamespaceType type)
    {
      this.NamespaceUri = namespaceUri;
      this.ServerUri = serverUri;
      this.NamespaceType = type;
    }
  }
}
