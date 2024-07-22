// Decompiled with JetBrains decompiler
// Type: FTOptix.ODBCStore.ObjectTypes
// Assembly: FTOptix.ODBCStore.Net, Version=1.0.8.40, Culture=neutral, PublicKeyToken=null
// MVID: 84834374-1E7D-4D92-B33A-27ADBA3C996C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.ODBCStore.Net\1.0.8.40\Any\FTOptix.ODBCStore.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.ODBCStore
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:ODBCStore");
    public static readonly NodeId ODBCStore = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId ODBCStoreTable = new NodeId(ObjectTypes.namespaceIndex, 3U);
  }
}
