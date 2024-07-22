// Decompiled with JetBrains decompiler
// Type: UAManagedCore.DataValue
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  public struct DataValue
  {
    public DataValue(UAValue value, uint statusCode, DateTime sourceTimestamp)
      : this(value, statusCode, sourceTimestamp, UADateTime.MinValue)
    {
    }

    public DataValue(
      UAValue value,
      uint statusCode,
      DateTime sourceTimestamp,
      DateTime serverTimestamp)
    {
      this.Value = value;
      this.StatusCode = statusCode;
      this.SourceTimestamp = sourceTimestamp;
      this.ServerTimestamp = serverTimestamp;
    }

    public UAValue Value { get; }

    public uint StatusCode { get; }

    public DateTime SourceTimestamp { get; }

    public DateTime ServerTimestamp { get; }
  }
}
