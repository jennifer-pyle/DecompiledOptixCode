// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StructField
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class StructField : IEquatable<StructField>
  {
    private static readonly uint[] ArrayDimensionsForScalar = Array.Empty<uint>();

    public StructField(string name, NodeId dataTypeId)
      : this(name, dataTypeId, ValueRank.Scalar, (IReadOnlyList<uint>) StructField.ArrayDimensionsForScalar, (object) null)
    {
    }

    public StructField(
      string name,
      NodeId dataTypeId,
      ValueRank valueRank,
      IReadOnlyList<uint> arrayDimensions,
      object initValue,
      bool isOptional = false,
      bool allowSubtypes = false,
      uint maxStringLength = 0,
      LocalizedText description = null)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentNullException(nameof (name));
      if (dataTypeId == (NodeId) null || dataTypeId.IsEmpty)
        throw new ArgumentNullException(nameof (dataTypeId));
      if (arrayDimensions == null)
        throw new ArgumentNullException(nameof (arrayDimensions));
      this.Name = name;
      this.DataTypeId = dataTypeId;
      this.ValueRank = valueRank;
      this.ArrayDimensions = arrayDimensions;
      this.InitValue = initValue;
      this.IsOptional = isOptional;
      this.AllowSubtypes = allowSubtypes;
      this.MaxStringLength = maxStringLength;
      LocalizedText localizedText = description;
      if ((object) localizedText == null)
        localizedText = LocalizedText.Empty;
      this.Description = localizedText;
    }

    public string Name { get; }

    public NodeId DataTypeId { get; }

    public ValueRank ValueRank { get; }

    public IReadOnlyList<uint> ArrayDimensions { get; }

    public object InitValue { get; }

    public bool IsOptional { get; }

    public bool AllowSubtypes { get; }

    public uint MaxStringLength { get; }

    public LocalizedText Description { get; }

    public bool Equals(StructField other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return string.Equals(this.Name, other.Name) && this.DataTypeId.Equals(other.DataTypeId) && this.ValueRank == other.ValueRank && this.ArrayDimensions.SequenceEqual<uint>((IEnumerable<uint>) other.ArrayDimensions) && object.Equals(this.InitValue, other.InitValue) && this.IsOptional == other.IsOptional && this.AllowSubtypes == other.AllowSubtypes && (int) this.MaxStringLength == (int) other.MaxStringLength && this.Description.Equals(other.Description);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((StructField) obj);
    }

    public override int GetHashCode()
    {
      int num = (int) ((ValueRank) ((this.Name.GetHashCode() * 397 ^ this.DataTypeId.GetHashCode()) * 397) ^ this.ValueRank) * 397 ^ this.ArrayDimensions.Aggregate<uint, int>(0, (Func<int, uint, int>) ((acc, v) => acc ^ 4973 * (int) v));
      if (this.InitValue != null)
        num = num * 397 ^ this.InitValue.GetHashCode();
      return (num * 397 ^ (int) this.MaxStringLength) * 397 ^ this.Description.GetHashCode();
    }
  }
}
