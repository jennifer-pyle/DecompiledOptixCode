﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.VariableAttributes
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapDataType(NamespaceUri = "http://opcfoundation.org/UA/", Number = 355)]
  public class VariableAttributes : TypedStruct
  {
    [StructFieldInfo(0, null, UAManagedCore.ValueRank.Scalar, null)]
    public uint SpecifiedAttributes { get; set; }

    [StructFieldInfo(1, null, UAManagedCore.ValueRank.Scalar, null)]
    public LocalizedText DisplayName { get; set; }

    [StructFieldInfo(2, null, UAManagedCore.ValueRank.Scalar, null)]
    public LocalizedText Description { get; set; }

    [StructFieldInfo(3, null, UAManagedCore.ValueRank.Scalar, null)]
    public uint WriteMask { get; set; }

    [StructFieldInfo(4, null, UAManagedCore.ValueRank.Scalar, null)]
    public uint UserWriteMask { get; set; }

    [StructFieldInfo(5, null, UAManagedCore.ValueRank.Any, null)]
    public object Value { get; set; }

    [StructFieldInfo(6, null, UAManagedCore.ValueRank.Scalar, null)]
    public NodeId DataType { get; set; }

    [StructFieldInfo(7, null, UAManagedCore.ValueRank.Scalar, null)]
    public int ValueRank { get; set; }

    [StructFieldInfo(8, new uint[] {}, UAManagedCore.ValueRank.OneDimension, new uint[] {0})]
    public uint[] ArrayDimensions { get; set; }

    [StructFieldInfo(9, null, UAManagedCore.ValueRank.Scalar, null)]
    public byte AccessLevel { get; set; }

    [StructFieldInfo(10, null, UAManagedCore.ValueRank.Scalar, null)]
    public byte UserAccessLevel { get; set; }

    [StructFieldInfo(11, null, UAManagedCore.ValueRank.Scalar, null)]
    public double MinimumSamplingInterval { get; set; }

    [StructFieldInfo(12, null, UAManagedCore.ValueRank.Scalar, null)]
    public bool Historizing { get; set; }
  }
}
