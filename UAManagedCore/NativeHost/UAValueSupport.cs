// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.UAValueSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class UAValueSupport
  {
    public static IntPtr CreateEmpty() => ObjectMarshal.ToIntPtr((object) new UAValue());

    public static IntPtr FromInt8(sbyte value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromInt16(short value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromInt32(int value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromInt64(long value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromUInt8(byte value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromUInt16(ushort value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromUInt32(uint value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromUInt64(ulong value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromBool(int value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value != 0));
    }

    public static IntPtr FromFloat(float value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromDouble(double value)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(value));
    }

    public static IntPtr FromString(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(StringMarshal.StringFromIntPtr(valuePtr)));
    }

    public static IntPtr FromNodeId(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<NodeId>(valuePtr)));
    }

    public static IntPtr FromDateTime(long ticks)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(DateTimeSupport.DateTimeFromTicksSinceEpoch(ticks)));
    }

    public static IntPtr FromGuid(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue((Guid) ObjectMarshal.ReleaseGCHandle<object>(valuePtr)));
    }

    public static IntPtr FromByteString(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<ByteString>(valuePtr)));
    }

    public static IntPtr FromQualifiedName(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<QualifiedName>(valuePtr)));
    }

    public static IntPtr FromExpandedNodeId(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<ExpandedNodeId>(valuePtr)));
    }

    public static IntPtr FromLocalizedText(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<LocalizedText>(valuePtr)));
    }

    public static IntPtr FromStruct(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue(ObjectMarshal.ReleaseGCHandle<Struct>(valuePtr)));
    }

    public static IntPtr FromArray(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new UAValue((object) ObjectMarshal.ReleaseGCHandle<Array>(valuePtr)));
    }

    public static IntPtr GetUnderlyingValue(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr(ObjectMarshal.FromIntPtr<UAValue>(valuePtr).Value);
    }

    public delegate IntPtr CreateEmptyDelegate();

    public delegate IntPtr FromInt8Delegate(sbyte value);

    public delegate IntPtr FromInt16Delegate(short value);

    public delegate IntPtr FromInt32Delegate(int value);

    public delegate IntPtr FromInt64Delegate(long value);

    public delegate IntPtr FromUInt8Delegate(byte value);

    public delegate IntPtr FromUInt16Delegate(ushort value);

    public delegate IntPtr FromUInt32Delegate(uint value);

    public delegate IntPtr FromUInt64Delegate(ulong value);

    public delegate IntPtr FromBoolDelegate(int value);

    public delegate IntPtr FromFloatDelegate(float value);

    public delegate IntPtr FromDoubleDelegate(double value);

    public delegate IntPtr FromStringDelegate(IntPtr valuePtr);

    public delegate IntPtr FromNodeIdDelegate(IntPtr valuePtr);

    public delegate IntPtr FromDateTimeDelegate(long ticks);

    public delegate IntPtr FromGuidDelegate(IntPtr valuePtr);

    public delegate IntPtr FromByteStringDelegate(IntPtr valuePtr);

    public delegate IntPtr FromQualifiedNameDelegate(IntPtr valuePtr);

    public delegate IntPtr FromExpandedNodeIdDelegate(IntPtr valuePtr);

    public delegate IntPtr FromLocalizedTextDelegate(IntPtr valuePtr);

    public delegate IntPtr FromStructDelegate(IntPtr valuePtr);

    public delegate IntPtr FromArrayDelegate(IntPtr valuePtr);

    public delegate IntPtr GetUnderlyingValueDelegate(IntPtr valuePtr);
  }
}
