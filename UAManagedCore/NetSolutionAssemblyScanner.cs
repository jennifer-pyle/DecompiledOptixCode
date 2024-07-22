// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NetSolutionAssemblyScanner
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  internal class NetSolutionAssemblyScanner : IDisposable
  {
    private readonly string assemblyFileName;
    private readonly MetadataLoadContext assemblyLoadContext;
    private readonly List<NetSolutionClassInfo> scannedClasses;
    private readonly List<string> referencedAssemblies;
    private bool disposed;
    private const string baseNetLogicClassName = "BaseNetLogic";
    private const string baseNetBehaviorClassName = "BaseNetBehavior";
    private const string exportAttributeName = "ExportMethodAttribute";

    public NetSolutionAssemblyScanner(string assemblyFileName)
    {
      this.assemblyFileName = assemblyFileName;
      this.assemblyLoadContext = new MetadataLoadContext((MetadataAssemblyResolver) new NetSolutionAssemblyScanner.NetSolutionAssemblyResolver());
      this.scannedClasses = new List<NetSolutionClassInfo>();
      this.referencedAssemblies = new List<string>();
    }

    public NetSolutionAssemblyInfo ScanAssembly(bool collectReferencedAssemblies)
    {
      try
      {
        Assembly assembly1;
        using (MemoryStream assembly2 = new MemoryStream(File.ReadAllBytes(this.assemblyFileName)))
          assembly1 = this.assemblyLoadContext.LoadFromStream((Stream) assembly2);
        foreach (Type type in assembly1.GetTypes())
        {
          NetSolutionClassKind classKind = NetSolutionAssemblyScanner.GetClassKind(type);
          if (type.IsClass && classKind != NetSolutionClassKind.ModelIndependent)
            this.ScanClassType(type, classKind);
        }
        if (collectReferencedAssemblies)
          this.CollectReferencedAssemblies(assembly1);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "NetHelper", (ushort) 222, (ushort) 2, "Unable to scan .NET solution assembly: " + ex?.ToString(), "UAMangedCore.NetSolutionAssemblyScanner.ScanAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 119, nameof (ScanAssembly));
      }
      return new NetSolutionAssemblyInfo(this.scannedClasses, this.referencedAssemblies);
    }

    public NetSolutionAssemblyInfo UpdateAssemblyInfo(
      HashSet<string> sourceFileNames,
      bool collectReferencedAssemblies)
    {
      try
      {
        Assembly assembly = this.assemblyLoadContext.LoadFromAssemblyPath(this.assemblyFileName);
        foreach (string sourceFileName in sourceFileNames)
        {
          Type type = assembly.GetType(sourceFileName);
          if (!(type == (Type) null))
          {
            NetSolutionClassKind classKind = NetSolutionAssemblyScanner.GetClassKind(type);
            if (classKind != NetSolutionClassKind.ModelIndependent)
              this.ScanClassType(type, classKind);
          }
        }
        if (collectReferencedAssemblies)
          this.CollectReferencedAssemblies(assembly);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "NetHelper", (ushort) 222, (ushort) 3, "Unable to update .NET solution assembly info: " + ex?.ToString(), "UAMangedCore.NetSolutionAssemblyScanner.UpdateAssemblyInfo()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 159, nameof (UpdateAssemblyInfo));
      }
      return new NetSolutionAssemblyInfo(this.scannedClasses, this.referencedAssemblies);
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
        this.assemblyLoadContext.Dispose();
      this.disposed = true;
    }

    private static NetSolutionClassKind GetClassKind(Type type)
    {
      Type baseType = type.BaseType;
      if (baseType == (Type) null)
        return NetSolutionClassKind.ModelIndependent;
      if (baseType.Name == "BaseNetLogic")
        return NetSolutionClassKind.NetLogic;
      for (; baseType != (Type) null; baseType = baseType.BaseType)
      {
        if (baseType.Name == "BaseNetBehavior")
          return NetSolutionClassKind.NetBehavior;
      }
      return NetSolutionClassKind.ModelIndependent;
    }

    private void ScanClassType(Type type, NetSolutionClassKind classKind)
    {
      NetSolutionClassInfo classInfo = new NetSolutionClassInfo(type.Name, classKind);
      foreach (MethodInfo method in (IEnumerable<MethodInfo>) ((IEnumerable<MethodInfo>) type.GetMethods()).OrderBy<MethodInfo, string>((Func<MethodInfo, string>) (m => m.Name)))
        this.ScanMethod(method, classInfo);
      NetSolutionAssemblyScanner.EnsureNoOverloadedMethodsInClass(type, classInfo);
      this.scannedClasses.Add(classInfo);
    }

    private void ScanMethod(MethodInfo method, NetSolutionClassInfo classInfo)
    {
      if (!method.GetCustomAttributesData().Any<CustomAttributeData>((Func<CustomAttributeData, bool>) (a => a.AttributeType.Name == "ExportMethodAttribute")))
        return;
      ExportedMethodInfo methodInfo = new ExportedMethodInfo(method.Name);
      NetSolutionAssemblyScanner.ExtractMethodParameters(method, methodInfo);
      classInfo.Methods.Add(methodInfo);
    }

    private static void ExtractMethodParameters(MethodInfo method, ExportedMethodInfo methodInfo)
    {
      uint num1 = 0;
      uint num2 = 0;
      foreach (ParameterInfo parameter in method.GetParameters())
      {
        ExportedMethodParameterInfo methodParameterInfo = new ExportedMethodParameterInfo(parameter.Name);
        Type parameterType = parameter.ParameterType;
        methodParameterInfo.Type = parameterType.IsByRef ? parameterType.GetElementType().FullName : parameterType.FullName;
        if (!parameter.IsOut)
        {
          methodParameterInfo.Direction = ExportedMethodParameterDirection.Input;
          ++num1;
        }
        else
        {
          methodParameterInfo.Direction = ExportedMethodParameterDirection.Output;
          ++num2;
        }
        methodInfo.Parameters.Add(methodParameterInfo);
      }
      methodInfo.InputParameterCount = num1;
      methodInfo.OutputParameterCount = num2;
    }

    private static void EnsureNoOverloadedMethodsInClass(Type type, NetSolutionClassInfo classInfo)
    {
      HashSet<string> stringSet = new HashSet<string>();
      HashSet<string> methodNamesWithOverloads = new HashSet<string>();
      foreach (ExportedMethodInfo method in classInfo.Methods)
      {
        if (!stringSet.Add(method.Name))
        {
          ICoreLogger coreLogger = LogManager.CoreLogger;
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
          interpolatedStringHandler.AppendLiteral("Overloaded C# method '");
          interpolatedStringHandler.AppendFormatted(method.Name);
          interpolatedStringHandler.AppendLiteral("' in class '");
          interpolatedStringHandler.AppendFormatted(classInfo.Name);
          interpolatedStringHandler.AppendLiteral("' cannot be exported ");
          string message = interpolatedStringHandler.ToStringAndClear() + "as OPC UA method. Please rename the method overload(s) in order to export them.";
          coreLogger.Log(LogLevel.Warning, "NetHelper", (ushort) 222, (ushort) 48, message, "UAManagedCore.NetSolutionAssemblyScanner.EnsureNoOverloadedMethodsInClass()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 281, nameof (EnsureNoOverloadedMethodsInClass));
          methodNamesWithOverloads.Add(method.Name);
        }
      }
      if (classInfo.Kind == NetSolutionClassKind.NetBehavior)
      {
        for (Type baseType = type.BaseType; baseType != (Type) null; baseType = baseType.BaseType)
        {
          foreach (ExportedMethodInfo method in classInfo.Methods)
          {
            if (!(baseType.GetMethod(method.Name) == (MethodInfo) null))
            {
              try
              {
                type.GetMethod(method.Name);
              }
              catch (AmbiguousMatchException ex)
              {
                ICoreLogger coreLogger = LogManager.CoreLogger;
                DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
                interpolatedStringHandler.AppendLiteral("Overloaded C# method '");
                interpolatedStringHandler.AppendFormatted(method.Name);
                interpolatedStringHandler.AppendLiteral("' in class '");
                interpolatedStringHandler.AppendFormatted(classInfo.Name);
                interpolatedStringHandler.AppendLiteral("' cannot be exported ");
                string message = interpolatedStringHandler.ToStringAndClear() + "as OPC UA method since it is already defined with a different signature in base class '" + baseType.Name + "'. Please either align to the signature of the method in the base class, or rename the method overload(s) in order to export them.";
                coreLogger.Log(LogLevel.Warning, "NetHelper", (ushort) 222, (ushort) 48, message, "UAManagedCore.NetSolutionAssemblyScanner.EnsureNoOverloadedMethodsInClass()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 308, nameof (EnsureNoOverloadedMethodsInClass));
              }
            }
          }
        }
      }
      classInfo.Methods.RemoveAll((Predicate<ExportedMethodInfo>) (m => methodNamesWithOverloads.Contains(m.Name)));
    }

    private void CollectReferencedAssemblies(Assembly assembly)
    {
      DirectoryInfo parent = new FileInfo(this.assemblyFileName).Directory.Parent;
      string bindingsFolder = ManagedContextStore.Context.GetBindingsFolder();
      try
      {
        this.referencedAssemblies.AddRange((IEnumerable<string>) new ReferencedNamespaceCollector(this.assemblyFileName, parent.FullName, bindingsFolder).CollectReferencedNamespaces());
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "NetHelper", (ushort) 222, (ushort) 57, "Unable to collect references to security-critical assemblies: " + ex?.ToString(), "UAManagedCore.NetSolutionAssemblyScanner.CollectReferencedAssemblies()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 338, nameof (CollectReferencedAssemblies));
      }
      this.CollectNuGetAndThirdPartyReferences(parent);
    }

    private void CollectNuGetAndThirdPartyReferences(DirectoryInfo netSolutionDirectory)
    {
      string withoutExtension = Path.GetFileNameWithoutExtension(this.assemblyFileName);
      string str = Path.Combine(netSolutionDirectory.FullName, withoutExtension + ".csproj");
      if (!File.Exists(str))
        return;
      try
      {
        XDocument node = XDocument.Load(str);
        foreach (XElement xpathSelectElement in node.XPathSelectElements("/Project/ItemGroup/PackageReference"))
        {
          XAttribute xattribute = xpathSelectElement.Attribute((XName) "Include");
          if (xattribute != null)
            this.referencedAssemblies.Add(xattribute.Value + " (NuGet package)");
        }
        foreach (XElement xpathSelectElement in node.XPathSelectElements("/Project/ItemGroup/Reference"))
        {
          XAttribute xattribute = xpathSelectElement.Attribute((XName) "Include");
          if (xattribute != null)
            this.referencedAssemblies.Add(xattribute.Value + " (third-party assembly)");
        }
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "NetHelper", (ushort) 222, (ushort) 56, "Unable to collect references to NuGet packages and third-party assemblies: " + ex?.ToString(), "UAManagedCore.NetSolutionAssemblyScanner.CollectNuGetAndThirdPartyReferences()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NetSolutionAssemblyScanner.cs", 375, nameof (CollectNuGetAndThirdPartyReferences));
      }
    }

    private class NetSolutionAssemblyResolver : MetadataAssemblyResolver
    {
      private readonly UACoreContext uaCoreContext;
      private readonly string bindingsFolder;
      private readonly string netRuntimeDirectory;

      public NetSolutionAssemblyResolver()
      {
        this.uaCoreContext = ManagedContextStore.Context;
        this.bindingsFolder = this.uaCoreContext.GetBindingsFolder();
        string str = Path.Combine(this.bindingsFolder, "dotnet", "shared", "Microsoft.NETCore.App");
        string name = ((IEnumerable<DirectoryInfo>) new DirectoryInfo(str).GetDirectories()).First<DirectoryInfo>().Name;
        this.netRuntimeDirectory = Path.Combine(str, name);
      }

      public override Assembly Resolve(MetadataLoadContext loadContext, AssemblyName assemblyName)
      {
        string assemblySimpleName = assemblyName.Name;
        if (assemblySimpleName == "mscorlib" || assemblySimpleName.Contains("System."))
          return loadContext.LoadFromAssemblyPath(Path.Combine(this.netRuntimeDirectory, assemblySimpleName + ".dll"));
        if (assemblySimpleName == "UAManagedCore" || assemblySimpleName == "UAManagedCoreCommon")
          return loadContext.LoadFromAssemblyPath(Path.Combine(this.bindingsFolder, assemblySimpleName + ".dll"));
        Assembly assembly = loadContext.GetAssemblies().FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => a.GetName().Name == assemblySimpleName));
        if (assembly != (Assembly) null)
          return assembly;
        Version version = assemblyName.Version;
        if (version != (Version) null)
        {
          string moduleVersion = this.uaCoreContext.GetModuleVersion(assemblySimpleName);
          if (string.IsNullOrEmpty(moduleVersion))
            moduleVersion = version.ToString();
          string moduleLibraryFilePath = this.uaCoreContext.GetModuleLibraryFilePath(assemblySimpleName, moduleVersion);
          if (File.Exists(moduleLibraryFilePath))
            return loadContext.LoadFromAssemblyPath(moduleLibraryFilePath);
        }
        if (this.uaCoreContext.DefaultNamespaceIndex != NodeId.InvalidNamespaceIndex)
        {
          string str = Path.Combine(this.uaCoreContext.GetProjectDirectory(this.uaCoreContext.DefaultNamespaceIndex), "NetSolution", "bin", assemblySimpleName + ".dll");
          if (File.Exists(str))
            return loadContext.LoadFromAssemblyPath(str);
        }
        return (Assembly) null;
      }
    }
  }
}
