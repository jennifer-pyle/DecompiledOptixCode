// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.DataTypes
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  public static class DataTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CommunicationDriver");
    public static readonly NodeId TagAttribute = new NodeId(DataTypes.namespaceIndex, 98U);
    public static readonly NodeId BasePlcItem = new NodeId(DataTypes.namespaceIndex, 99U);
    public static readonly NodeId StructureInfo = new NodeId(DataTypes.namespaceIndex, 100U);
    public static readonly NodeId TagInfo = new NodeId(DataTypes.namespaceIndex, 101U);
    public static readonly NodeId PrototypeInfo = new NodeId(DataTypes.namespaceIndex, 102U);
    public static readonly NodeId GenericItem = new NodeId(DataTypes.namespaceIndex, 103U);
    public static readonly NodeId FolderInfo = new NodeId(DataTypes.namespaceIndex, 106U);
  }
}
