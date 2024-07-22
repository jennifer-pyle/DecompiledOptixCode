// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.TagInfo
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  [MapDataType(NamespaceUri = "urn:FTOptix:CommunicationDriver", Number = 101)]
  public class TagInfo : BasePlcItem
  {
    [StructFieldInfo(3, null, ValueRank.Scalar, null)]
    public NodeId TagType { get; set; }

    [StructFieldInfo(4, null, ValueRank.Scalar, null)]
    public NodeId DataType { get; set; }

    [StructFieldInfo(5, null, ValueRank.OneDimension, null)]
    public uint[] ArrayDimensions { get; set; }

    [StructFieldInfo(6, null, ValueRank.Scalar, null)]
    public UAValue Value { get; set; }

    [StructFieldInfo(7, null, ValueRank.OneDimension, null)]
    public TagAttribute[] TagAttributes { get; set; }
  }
}
