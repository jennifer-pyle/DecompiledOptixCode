// Decompiled with JetBrains decompiler
// Type: FTOptix.System.ObjectTypes
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:System");
    public static readonly NodeId System = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId NetworkInterface = new NodeId(ObjectTypes.namespaceIndex, 4U);
    public static readonly NodeId FTRemoteAccess = new NodeId(ObjectTypes.namespaceIndex, 62U);
    public static readonly NodeId RemoteConnectionRequestEvent = new NodeId(ObjectTypes.namespaceIndex, 14U);
    public static readonly NodeId LoadApplicationStatusEvent = new NodeId(ObjectTypes.namespaceIndex, 104U);
  }
}
