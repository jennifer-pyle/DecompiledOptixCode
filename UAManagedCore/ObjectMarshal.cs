// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ObjectMarshal
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class ObjectMarshal
  {
    public static IntPtr ToIntPtr(object value)
    {
      return value == null ? IntPtr.Zero : GCHandle.ToIntPtr(GCHandle.Alloc(value));
    }

    public static T FromIntPtr<T>(IntPtr pointer) where T : class
    {
      return pointer == IntPtr.Zero ? default (T) : GCHandle.FromIntPtr(pointer).Target as T;
    }

    public static T ReleaseGCHandle<T>(IntPtr pointer) where T : class
    {
      if (pointer == IntPtr.Zero)
        return default (T);
      GCHandle gcHandle = GCHandle.FromIntPtr(pointer);
      T target = gcHandle.Target as T;
      gcHandle.Free();
      return target;
    }
  }
}
