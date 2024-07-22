// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TemplatedVariableMapTypeAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = true)]
  public sealed class TemplatedVariableMapTypeAttribute : 
    TemplatedMapTypeAttributeBase,
    IMapTypeAttribute
  {
    private string dataType;
    private Type netDataType;

    public TemplatedVariableMapTypeAttribute() => this.ValueRank = ValueRank.Scalar;

    public TemplatedVariableMapTypeAttribute(uint number, Type netDataType)
      : this()
    {
      this.Number = number;
      this.NetDataType = netDataType;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ValueRank ValueRank { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string DataType
    {
      get => this.dataType;
      set
      {
        this.CheckDataTypeSpecified();
        this.dataType = value;
        this.DataTypeSpecified = true;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override Type NetDataType
    {
      get => this.netDataType;
      set
      {
        this.CheckDataTypeSpecified();
        this.netDataType = value;
        this.DataTypeSpecified = true;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint[] ArrayDimensions { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool DataTypeSpecified { get; private set; }

    private void CheckDataTypeSpecified()
    {
      if (this.DataTypeSpecified)
        throw new InvalidOperationException("Specify DataType or NetDataType not both");
    }
  }
}
