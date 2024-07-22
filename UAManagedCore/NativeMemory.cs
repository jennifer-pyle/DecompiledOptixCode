// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeMemory
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  internal static class NativeMemory
  {
    public static IntPtr Allocate(int size) => NativeMemory.Interop.AllocateNativeMemory(size);

    public static void Free(IntPtr nativePtr) => NativeMemory.Interop.FreeNativeMemory(nativePtr);

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern IntPtr AllocateNativeMemory(int size);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern void FreeNativeMemory(IntPtr nativePtr);
    }
  }
}
