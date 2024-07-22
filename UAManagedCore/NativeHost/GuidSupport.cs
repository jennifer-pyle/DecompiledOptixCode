// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.GuidSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class GuidSupport
  {
    public static IntPtr CreateGuid(IntPtr nativeBytesPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new Guid(GuidSupport.FromNativeBytes(nativeBytesPtr)));
    }

    public static IntPtr CreateEmptyGuid() => ObjectMarshal.ToIntPtr((object) new Guid());

    public static IntPtr GetByteArray(IntPtr guidPtr)
    {
      byte[] byteArray = ((Guid) ObjectMarshal.FromIntPtr<object>(guidPtr)).ToByteArray();
      GuidSupport.ReverseGuidByteArrayEndianness(ref byteArray);
      IntPtr destination = UAManagedCore.NativeMemory.Allocate(byteArray.Length);
      Marshal.Copy(byteArray, 0, destination, byteArray.Length);
      return destination;
    }

    internal static byte[] FromNativeBytes(IntPtr nativeBytesPtr)
    {
      byte[] guidArray = new byte[16];
      Marshal.Copy(nativeBytesPtr, guidArray, 0, 16);
      GuidSupport.ReverseGuidByteArrayEndianness(ref guidArray);
      return guidArray;
    }

    internal static void ReverseGuidByteArrayEndianness(ref byte[] guidArray)
    {
      GuidSupport.SwapByte(ref guidArray[0], ref guidArray[3]);
      GuidSupport.SwapByte(ref guidArray[1], ref guidArray[2]);
      GuidSupport.SwapByte(ref guidArray[4], ref guidArray[5]);
      GuidSupport.SwapByte(ref guidArray[6], ref guidArray[7]);
    }

    private static void SwapByte(ref byte a, ref byte b)
    {
      byte num = a;
      a = b;
      b = num;
    }

    public delegate IntPtr CreateGuidDelegate(IntPtr bytes);

    public delegate IntPtr CreateEmptyGuidDelegate();

    public delegate IntPtr GetByteArrayDelegate(IntPtr guidPtr);
  }
}
