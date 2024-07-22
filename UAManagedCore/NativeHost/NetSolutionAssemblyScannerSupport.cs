// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.NetSolutionAssemblyScannerSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class NetSolutionAssemblyScannerSupport
  {
    public static IntPtr ScanAssembly(IntPtr assemblyFilenamePtr, int collectReferencedAssemblies)
    {
      using (NetSolutionAssemblyScanner solutionAssemblyScanner = new NetSolutionAssemblyScanner(StringMarshal.StringFromIntPtr(assemblyFilenamePtr)))
        return StructMarshal.ToNative(solutionAssemblyScanner.ScanAssembly(collectReferencedAssemblies != 0));
    }

    public static IntPtr UpdateAssemblyInfo(
      IntPtr assemblyFileNamePtr,
      IntPtr sourceFileNamesPtr,
      int collectReferencedAssemblies)
    {
      string assemblyFileName = StringMarshal.StringFromIntPtr(assemblyFileNamePtr);
      using (NetSolutionAssemblyScanner solutionAssemblyScanner = new NetSolutionAssemblyScanner(assemblyFileName))
      {
        HashSet<string> sourceFileNames = new HashSet<string>((IEnumerable<string>) StringMarshal.ToManagedStringArray(sourceFileNamesPtr));
        return StructMarshal.ToNative(solutionAssemblyScanner.UpdateAssemblyInfo(sourceFileNames, collectReferencedAssemblies != 0));
      }
    }

    public delegate IntPtr ScanAssemblyDelegate(
      IntPtr assemblyFilenamePtr,
      int collectReferencedAssemblies);

    public delegate IntPtr UpdateAssemblyInfoDelegate(
      IntPtr assemblyFileNamePtr,
      IntPtr sourceFileNamesPtr,
      int collectReferencedAssemblies);
  }
}
