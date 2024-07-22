// Decompiled with JetBrains decompiler
// Type: FTOptix.SQLiteStore.ObjectTypes
// Assembly: FTOptix.SQLiteStore.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: 935C598C-845E-4DF3-A45C-6ADE39178AC2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.SQLiteStore.Net\1.0.8.39\Any\FTOptix.SQLiteStore.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.SQLiteStore
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:SQLiteStore");
    public static readonly NodeId SQLiteStore = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId SQLiteStoreTable = new NodeId(ObjectTypes.namespaceIndex, 3U);
  }
}
