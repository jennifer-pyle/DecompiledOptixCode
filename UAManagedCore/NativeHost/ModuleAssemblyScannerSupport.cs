// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.ModuleAssemblyScannerSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Reflection;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class ModuleAssemblyScannerSupport
  {
    public static void ScanAssembly(
      IntPtr contextPtr,
      IntPtr assemblyPathPtr,
      out IntPtr mappedTypesPtr,
      out IntPtr mappedDataTypesPtr,
      out IntPtr behavioursPtr)
    {
      AssemblyDescriptor assemblyDescriptor = new ModuleAssemblyScanner(ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr), Assembly.LoadFrom(StringMarshal.StringFromIntPtr(assemblyPathPtr))).Scan();
      mappedTypesPtr = StructMarshal.ToNativeArray(assemblyDescriptor.MappedTypes);
      mappedDataTypesPtr = StructMarshal.ToNativeArray(assemblyDescriptor.MappedDataTypes);
      behavioursPtr = StructMarshal.ToNativeArray(assemblyDescriptor.Behaviours);
    }

    public delegate void ScanAssemblyDelegate(
      IntPtr contextPtr,
      IntPtr assemblyPathPtr,
      out IntPtr mappedTypesPtr,
      out IntPtr mappedDataTypesPtr,
      out IntPtr behavioursPtr);
  }
}
