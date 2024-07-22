// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TemplatedObjectMapTypeAttribute
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
  public sealed class TemplatedObjectMapTypeAttribute : TemplatedMapTypeAttributeBase
  {
    public TemplatedObjectMapTypeAttribute() => this.ValueRank = ValueRank.Scalar;

    public TemplatedObjectMapTypeAttribute(uint number, Type netDataType)
      : this()
    {
      this.Number = number;
      this.NetDataType = netDataType;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ValueRank ValueRank { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override Type NetDataType { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint[] ArrayDimensions { get; set; }
  }
}
