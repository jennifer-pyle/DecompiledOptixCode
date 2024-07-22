// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Struct
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class Struct : IEquatable<Struct>
  {
    private static bool StructObjectEqual(object o1, object o2, IEqualityComparer<object> comparer)
    {
      if (!(o1 is IReadOnlyList<object> first))
        return comparer.Equals(o1, o2);
      return o2 is IReadOnlyList<object> second && Struct.StructSequenceEqual(first, second);
    }

    private static bool StructSequenceEqual(
      IReadOnlyList<object> first,
      IReadOnlyList<object> second)
    {
      int count = first.Count;
      if (count != second.Count)
        return false;
      EqualityComparer<object> comparer = EqualityComparer<object>.Default;
      for (int index = 0; index < count; ++index)
      {
        if (!Struct.StructObjectEqual(first[index], second[index], (IEqualityComparer<object>) comparer))
          return false;
      }
      return true;
    }

    public Struct(NodeId dataTypeId, params object[] values)
      : this(dataTypeId, (IReadOnlyList<object>) values)
    {
    }

    public Struct(NodeId dataTypeId, IReadOnlyList<object> values)
      : this(dataTypeId, (Func<IReadOnlyList<object>>) (() => values))
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
    }

    public Struct(params object[] values)
      : this((NodeId) null, values)
    {
    }

    protected Struct(NodeId dataTypeId, Func<IReadOnlyList<object>> valuesGetter)
      : this(dataTypeId)
    {
      if (valuesGetter == null)
        throw new ArgumentNullException(nameof (valuesGetter));
      this.DataTypeId = dataTypeId;
      this.ValuesGetter = valuesGetter;
    }

    protected Struct(NodeId dataTypeId) => this.DataTypeId = dataTypeId;

    internal virtual void SetValues(IReadOnlyList<object> values)
    {
      this.ValuesGetter = (Func<IReadOnlyList<object>>) (() => values);
    }

    public NodeId DataTypeId { get; protected set; }

    public IReadOnlyList<object> Values => this.ValuesGetter();

    public bool HasDataTypeId => this.DataTypeId != (NodeId) null;

    public object Get(uint index) => this.Values[(int) index];

    public bool Equals(Struct other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return Struct.StructSequenceEqual(this.Values, other.Values) && object.Equals((object) this.DataTypeId, (object) other.DataTypeId);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((Struct) obj);
    }

    public override int GetHashCode()
    {
      int num = this.Values.Aggregate<object, int>(0, (Func<int, object, int>) ((acc, v) => acc ^ 4973 * v.GetHashCode())) * 397;
      NodeId dataTypeId = this.DataTypeId;
      int hashCode = (object) dataTypeId != null ? dataTypeId.GetHashCode() : 0;
      return num ^ hashCode;
    }

    protected Func<IReadOnlyList<object>> ValuesGetter { get; set; }
  }
}
