// Decompiled with JetBrains decompiler
// Type: UAManagedCore.EnumDefinition
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class EnumDefinition : IEquatable<EnumDefinition>
  {
    public static readonly EnumDefinition Empty = new EnumDefinition("", NodeId.Empty, (IReadOnlyList<EnumField>) Array.Empty<EnumField>(), false);

    public EnumDefinition(string name, NodeId dataTypeId, IReadOnlyList<EnumField> fields)
      : this(name, dataTypeId, fields, false)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentNullException(nameof (name));
      if (dataTypeId == (NodeId) null || dataTypeId.IsEmpty)
        throw new ArgumentNullException(nameof (dataTypeId));
      if (fields == null || fields.Count == 0)
        throw new ArgumentNullException(nameof (fields));
    }

    private EnumDefinition(
      string name,
      NodeId dataTypeId,
      IReadOnlyList<EnumField> fields,
      bool _)
    {
      this.Name = name;
      this.DataTypeId = dataTypeId;
      this.Fields = fields;
    }

    public string Name { get; }

    public NodeId DataTypeId { get; }

    public IReadOnlyList<EnumField> Fields { get; }

    public bool IsEmpty => this == EnumDefinition.Empty;

    public bool Equals(EnumDefinition other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return this.Name.Equals(other.Name, StringComparison.Ordinal) && this.DataTypeId.Equals(other.DataTypeId) && this.Fields.SequenceEqual<EnumField>((IEnumerable<EnumField>) other.Fields);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((EnumDefinition) obj);
    }

    public override int GetHashCode()
    {
      return (this.Name.GetHashCode() * 397 ^ this.DataTypeId.GetHashCode()) * 397 ^ this.Fields.Aggregate<EnumField, int>(0, (Func<int, EnumField, int>) ((acc, v) => acc ^ 4973 * v.GetHashCode()));
    }
  }
}
