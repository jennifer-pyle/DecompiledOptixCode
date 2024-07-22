// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StringMarshal
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class StringMarshal
  {
    public static IntPtr StringToIntPtr(string value)
    {
      return new StringMarshaler().MarshalManagedToNative((object) value);
    }

    public static string StringFromIntPtr(IntPtr pointer) => Marshal.PtrToStringUTF8(pointer);

    public static string ReleaseNativeString(IntPtr pointer)
    {
      string stringUtF8 = Marshal.PtrToStringUTF8(pointer);
      NativeMemory.Free(pointer);
      return stringUtF8;
    }

    public static string[] ToManagedStringArray(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<string>();
      string[] managedStringArray = new string[managed.Length];
      IntPtr data = managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        IntPtr pointer = Marshal.ReadIntPtr(data);
        managedStringArray[index] = StringMarshal.ReleaseNativeString(pointer);
        data += (IntPtr) IntPtr.Size;
      }
      NativeMemory.Free(managed.Data);
      return managedStringArray;
    }

    public static IntPtr ToNativeStringArray(IEnumerable<string> managedStrings)
    {
      int val = managedStrings.Count<string>();
      IntPtr nativeStringArray = NativeMemory.Allocate(Marshal.SizeOf<int>() + val * Marshal.SizeOf<IntPtr>());
      IntPtr ptr1 = nativeStringArray;
      Marshal.WriteInt32(ptr1, val);
      IntPtr ptr2 = ptr1 + (IntPtr) Marshal.SizeOf<int>();
      foreach (string managedString in managedStrings)
      {
        Marshal.WriteIntPtr(ptr2, StringMarshal.StringToIntPtr(managedString));
        ptr2 += (IntPtr) IntPtr.Size;
      }
      return nativeStringArray;
    }
  }
}
