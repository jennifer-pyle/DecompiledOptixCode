// Decompiled with JetBrains decompiler
// Type: UAManagedCore.AssemblyResolver
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

#nullable disable
namespace UAManagedCore
{
  public static class AssemblyResolver
  {
    private static UACoreContext storedContext;
    private static int projectNamespaceIndex;

    public static void Initialize(IntPtr contextPtr)
    {
      AssemblyResolver.storedContext = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      AssemblyResolver.projectNamespaceIndex = NodeId.InvalidNamespaceIndex;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolver.\u003C\u003EO.\u003C0\u003E__ResolveHandler ?? (AssemblyResolver.\u003C\u003EO.\u003C0\u003E__ResolveHandler = new ResolveEventHandler(AssemblyResolver.ResolveHandler));
    }

    public static void SetProjectNamespaceIndex(int namespaceIndex)
    {
      AssemblyResolver.projectNamespaceIndex = namespaceIndex;
    }

    public static void Terminate()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      AppDomain.CurrentDomain.AssemblyResolve -= AssemblyResolver.\u003C\u003EO.\u003C0\u003E__ResolveHandler ?? (AssemblyResolver.\u003C\u003EO.\u003C0\u003E__ResolveHandler = new ResolveEventHandler(AssemblyResolver.ResolveHandler));
      AssemblyResolver.storedContext = (UACoreContext) null;
    }

    private static Assembly ResolveHandler(object sender, ResolveEventArgs args)
    {
      AssemblyName assemblyName = new AssemblyName(args.Name);
      string assemblySimpleName = assemblyName.Name;
      Assembly assembly = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => a.GetName().Name == assemblySimpleName));
      if (assembly != (Assembly) null)
        return assembly;
      Version version = assemblyName.Version;
      if (version != (Version) null)
      {
        string moduleVersion = AssemblyResolver.storedContext.GetModuleVersion(assemblySimpleName);
        if (string.IsNullOrEmpty(moduleVersion))
          moduleVersion = version.ToString();
        string moduleLibraryFilePath = AssemblyResolver.storedContext.GetModuleLibraryFilePath(assemblySimpleName, moduleVersion);
        if (File.Exists(moduleLibraryFilePath))
          return Assembly.LoadFrom(moduleLibraryFilePath);
      }
      if (AssemblyResolver.projectNamespaceIndex != NodeId.InvalidNamespaceIndex)
      {
        string str = Path.Combine(AssemblyResolver.storedContext.GetProjectDirectory(AssemblyResolver.projectNamespaceIndex), "NetSolution", "bin", assemblySimpleName + ".dll");
        if (File.Exists(str))
          return Assembly.LoadFrom(str);
      }
      return (Assembly) null;
    }

    public delegate void InitializeDelegate(IntPtr context);

    public delegate void SetProjectNamespaceIndexDelegate(int namespaceIndex);

    public delegate void TerminateDelegate();
  }
}
