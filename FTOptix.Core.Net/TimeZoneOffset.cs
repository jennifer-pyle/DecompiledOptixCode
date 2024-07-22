// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.TimeZoneOffset
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  public struct TimeZoneOffset
  {
    public TimeZoneOffset(short offset, bool daylightSavingInOffset)
    {
      this.Offset = offset;
      this.DaylightSavingInOffset = daylightSavingInOffset;
    }

    public TimeZoneOffset(TimeZoneOffset other)
      : this(other.Offset, other.DaylightSavingInOffset)
    {
    }

    public TimeZoneOffset(UAValue value)
      : this((TimeZoneOffset) value)
    {
    }

    public static implicit operator TimeZoneOffset(UAValue value)
    {
      Struct @struct = (Struct) value;
      return new TimeZoneOffset((short) @struct.Values[0], (bool) @struct.Values[1]);
    }

    public static implicit operator UAValue(TimeZoneOffset timeZone)
    {
      return new UAValue(new Struct(UAManagedCore.OpcUa.DataTypes.TimeZoneDataType, new object[2]
      {
        (object) timeZone.Offset,
        (object) timeZone.DaylightSavingInOffset
      }));
    }

    public short Offset { get; }

    public bool DaylightSavingInOffset { get; }
  }
}
