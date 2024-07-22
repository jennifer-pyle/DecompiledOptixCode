// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.AddNodesItem
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapDataType(NamespaceUri = "http://opcfoundation.org/UA/", Number = 376)]
  public class AddNodesItem : TypedStruct
  {
    [StructFieldInfo(0, null, ValueRank.Scalar, null)]
    public NodeId ParentNodeId { get; set; }

    [StructFieldInfo(1, null, ValueRank.Scalar, null)]
    public NodeId ReferenceTypeId { get; set; }

    [StructFieldInfo(2, null, ValueRank.Scalar, null)]
    public NodeId RequestedNewNodeId { get; set; }

    [StructFieldInfo(3, null, ValueRank.Scalar, null)]
    public QualifiedName BrowseName { get; set; }

    [StructFieldInfo(4, null, ValueRank.Scalar, null)]
    public NodeClass NodeClass { get; set; }

    [StructFieldInfo(5, null, ValueRank.Scalar, null)]
    public Struct NodeAttributes { get; set; }

    [StructFieldInfo(6, null, ValueRank.Scalar, null)]
    public NodeId TypeDefinition { get; set; }
  }
}
