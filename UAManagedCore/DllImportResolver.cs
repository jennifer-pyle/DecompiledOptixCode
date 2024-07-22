// Decompiled with JetBrains decompiler
// Type: UAManagedCore.DllImportResolver
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class DllImportResolver
  {
    private static string nativeBindingsLibraryPath;
    private static bool alreadyInitialized;

    public static void Initialize(IntPtr baseBindingsPathPtr)
    {
      if (DllImportResolver.alreadyInitialized)
        return;
      DllImportResolver.nativeBindingsLibraryPath = Path.Combine(Marshal.PtrToStringUTF8(baseBindingsPathPtr), "Net.dll");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      NativeLibrary.SetDllImportResolver(typeof (DllImportResolver).Assembly, DllImportResolver.\u003C\u003EO.\u003C0\u003E__ImportResolver ?? (DllImportResolver.\u003C\u003EO.\u003C0\u003E__ImportResolver = new System.Runtime.InteropServices.DllImportResolver(DllImportResolver.ImportResolver)));
      DllImportResolver.alreadyInitialized = true;
    }

    private static IntPtr ImportResolver(
      string libraryName,
      Assembly assembly,
      DllImportSearchPath? searchPath)
    {
      IntPtr handle = IntPtr.Zero;
      if (libraryName == "Net")
        NativeLibrary.TryLoad(DllImportResolver.nativeBindingsLibraryPath, out handle);
      return handle;
    }

    public delegate void InitializeDelegate(IntPtr baseBindingsPathPtr);
  }
}
