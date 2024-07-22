// Decompiled with JetBrains decompiler
// Type: FTOptix.Store.ObjectTypes
// Assembly: FTOptix.Store.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: F643F557-C95B-47D5-ABBF-593703F6DBCF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Store.Net\1.0.8.38\Any\FTOptix.Store.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Store
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Store");
    public static readonly NodeId Store = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId Table = new NodeId(ObjectTypes.namespaceIndex, 3U);
    public static readonly NodeId StoreColumn = new NodeId(ObjectTypes.namespaceIndex, 5U);
  }
}
