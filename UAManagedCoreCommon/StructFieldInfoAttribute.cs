// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StructFieldInfoAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [AttributeUsage(AttributeTargets.Property, Inherited = false)]
  public sealed class StructFieldInfoAttribute : Attribute
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int Order { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public object DefaultValue { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ValueRank ValueRank { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint[] ArrayDimensions { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string DataType { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Type NetDataType { get; set; }

    public StructFieldInfoAttribute(
      int order,
      object defaultValue = null,
      ValueRank valueRank = ValueRank.Scalar,
      uint[] arrayDimensions = null)
    {
      if (order < 0)
        throw new ArgumentOutOfRangeException(nameof (order));
      arrayDimensions = arrayDimensions ?? new uint[0];
      this.Order = order;
      this.DefaultValue = defaultValue;
      this.ValueRank = valueRank;
      this.ArrayDimensions = arrayDimensions;
    }
  }
}
