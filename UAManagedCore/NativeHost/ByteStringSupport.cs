// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.ByteStringSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class ByteStringSupport
  {
    public static IntPtr CreateByteString(IntPtr bytesPtr, int length)
    {
      return ObjectMarshal.ToIntPtr((object) new ByteString(ByteStringSupport.FromNativeBytes(bytesPtr, length)));
    }

    public static IntPtr CreateEmptyByteString()
    {
      return ObjectMarshal.ToIntPtr((object) new ByteString());
    }

    public static IntPtr GetBytes(IntPtr bytesPtr, out int length)
    {
      ByteString byteString = ObjectMarshal.FromIntPtr<ByteString>(bytesPtr);
      length = byteString.Bytes.Length;
      IntPtr destination = UAManagedCore.NativeMemory.Allocate(length);
      Marshal.Copy(byteString.Bytes, 0, destination, length);
      return destination;
    }

    internal static byte[] FromNativeBytes(IntPtr nativeBytesPtr, int length)
    {
      byte[] destination = new byte[length];
      Marshal.Copy(nativeBytesPtr, destination, 0, length);
      return destination;
    }

    public delegate IntPtr CreateByteStringDelegate(IntPtr bytesPtr, int length);

    public delegate IntPtr CreateEmptyByteStringDelegate();

    public delegate IntPtr GetBytesDelegate(IntPtr bytesPtr, out int length);
  }
}
