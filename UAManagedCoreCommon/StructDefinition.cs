// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StructDefinition
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class StructDefinition : IEquatable<StructDefinition>
  {
    public static readonly StructDefinition Empty = new StructDefinition("", NodeId.Empty, (IReadOnlyList<StructField>) Array.Empty<StructField>(), false);

    public StructDefinition(string name, NodeId dataTypeId, IReadOnlyList<StructField> fields)
      : this(name, dataTypeId, fields, false)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentNullException(nameof (name));
      if (dataTypeId == (NodeId) null || dataTypeId.IsEmpty)
        throw new ArgumentNullException(nameof (dataTypeId));
      if (fields == null || fields.Count == 0)
        throw new ArgumentNullException(nameof (fields));
    }

    private StructDefinition(
      string name,
      NodeId dataTypeId,
      IReadOnlyList<StructField> fields,
      bool _)
    {
      this.Name = name;
      this.DataTypeId = dataTypeId;
      this.Fields = fields;
    }

    public string Name { get; }

    public NodeId DataTypeId { get; }

    public IReadOnlyList<StructField> Fields { get; }

    public bool IsEmpty => this == StructDefinition.Empty;

    public bool Equals(StructDefinition other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return this.Name.Equals(other.Name, StringComparison.Ordinal) && this.DataTypeId.Equals(other.DataTypeId) && this.Fields.SequenceEqual<StructField>((IEnumerable<StructField>) other.Fields);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((StructDefinition) obj);
    }

    public override int GetHashCode()
    {
      return (this.Name.GetHashCode() * 397 ^ this.DataTypeId.GetHashCode()) * 397 ^ this.Fields.Aggregate<StructField, int>(0, (Func<int, StructField, int>) ((acc, v) => acc ^ 4973 * v.GetHashCode()));
    }
  }
}
