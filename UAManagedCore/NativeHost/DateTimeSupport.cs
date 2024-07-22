// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.DateTimeSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class DateTimeSupport
  {
    public static IntPtr CreateDateTime(long ticks)
    {
      return ObjectMarshal.ToIntPtr((object) DateTimeSupport.DateTimeFromTicksSinceEpoch(ticks));
    }

    public static long TicksSinceEpoch(IntPtr dateTimePtr)
    {
      return ((DateTime) ObjectMarshal.FromIntPtr<object>(dateTimePtr)).Ticks - new DateTime(1601, 1, 1, 0, 0, 0).Ticks;
    }

    internal static DateTime DateTimeFromTicksSinceEpoch(long ticks)
    {
      return new DateTime(1601, 1, 1, 0, 0, 0).AddTicks(ticks);
    }

    public delegate IntPtr CreateDateTimeDelegate(long ticks);

    public delegate long TicksSinceEpochDelegate(IntPtr dateTimePtr);
  }
}
