// Decompiled with JetBrains decompiler
// Type: FTOptix.InfluxDBStore.ObjectTypes
// Assembly: FTOptix.InfluxDBStore.Net, Version=1.0.1.44, Culture=neutral, PublicKeyToken=null
// MVID: D250D165-EF05-42CD-BF7B-B79EF31B07C8
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.InfluxDBStore.Net\1.0.1.44\Any\FTOptix.InfluxDBStore.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.InfluxDBStore
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:InfluxDBStore");
    public static readonly NodeId InfluxDBStore = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId InfluxDBStoreTable = new NodeId(ObjectTypes.namespaceIndex, 3U);
    public static readonly NodeId InfluxDBTag = new NodeId(ObjectTypes.namespaceIndex, 10U);
  }
}
