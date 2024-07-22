// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.DeleteReferencesItem
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapDataType(NamespaceUri = "http://opcfoundation.org/UA/", Number = 385)]
  public class DeleteReferencesItem : TypedStruct
  {
    [StructFieldInfo(0, null, ValueRank.Scalar, null)]
    public NodeId SourceNodeId { get; set; }

    [StructFieldInfo(1, null, ValueRank.Scalar, null)]
    public NodeId ReferenceTypeId { get; set; }

    [StructFieldInfo(2, null, ValueRank.Scalar, null)]
    public bool IsForward { get; set; }

    [StructFieldInfo(3, null, ValueRank.Scalar, null)]
    public NodeId TargetNodeId { get; set; }

    [StructFieldInfo(4, null, ValueRank.Scalar, null)]
    public bool Bidirectional { get; set; }
  }
}
