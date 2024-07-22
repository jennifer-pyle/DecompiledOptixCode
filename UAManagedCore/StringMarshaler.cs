// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StringMarshaler
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace UAManagedCore
{
  internal class StringMarshaler : ICustomMarshaler
  {
    private UTF8Encoding utf8Encoding;

    public StringMarshaler() => this.utf8Encoding = new UTF8Encoding(false);

    public void CleanUpManagedData(object managedObject)
    {
    }

    public void CleanUpNativeData(IntPtr nativePtr) => NativeMemory.Free(nativePtr);

    public int GetNativeDataSize() => -1;

    public IntPtr MarshalManagedToNative(object managedObject)
    {
      if (managedObject == null)
        return this.MarshalManagedToNative((object) string.Empty);
      if (!(managedObject is string s))
        return IntPtr.Zero;
      byte[] bytes = this.utf8Encoding.GetBytes(s);
      IntPtr native = NativeMemory.Allocate(bytes.Length + 1);
      Marshal.Copy(bytes, 0, native, bytes.Length);
      Marshal.WriteByte(native, bytes.Length, (byte) 0);
      return native;
    }

    public object MarshalNativeToManaged(IntPtr nativePtr)
    {
      return (object) Marshal.PtrToStringUTF8(nativePtr);
    }

    public static ICustomMarshaler GetInstance(string cookie)
    {
      return (ICustomMarshaler) new StringMarshaler();
    }
  }
}
