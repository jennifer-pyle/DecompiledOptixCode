// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ReferencedNamespaceCollector
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  internal class ReferencedNamespaceCollector
  {
    private readonly string assemblyName;
    private readonly string netSolutionDirectory;
    private readonly string dotnetSdkDirectory;

    public ReferencedNamespaceCollector(
      string assemblyFileName,
      string netSolutionDirectory,
      string bindingsFolder)
    {
      this.assemblyName = Path.GetFileNameWithoutExtension(assemblyFileName);
      this.netSolutionDirectory = netSolutionDirectory;
      this.dotnetSdkDirectory = new DirectoryInfo(Path.Combine(new DirectoryInfo(bindingsFolder).Parent.Parent.Parent.Parent.FullName, "Tools", "DotNetSdk", "sdk")).EnumerateDirectories().First<DirectoryInfo>().FullName;
    }

    public List<string> CollectReferencedNamespaces()
    {
      if (!MSBuildLocator.IsRegistered)
        MSBuildLocator.RegisterMSBuildPath(this.dotnetSdkDirectory);
      return this.CollectReferencedNamespacesInternal();
    }

    private List<string> CollectReferencedNamespacesInternal()
    {
      using (MSBuildWorkspace msBuildWorkspace = MSBuildWorkspace.Create())
      {
        Compilation result = msBuildWorkspace.OpenProjectAsync(Path.Combine(this.netSolutionDirectory, this.assemblyName + ".csproj")).Result.GetCompilationAsync().Result;
        NetSolutionFileSyntaxWalker fileSyntaxWalker = new NetSolutionFileSyntaxWalker();
        foreach (SyntaxTree syntaxTree in result.SyntaxTrees)
        {
          if (!ReferencedNamespaceCollector.IsInObjSubdirectory(syntaxTree.FilePath))
          {
            fileSyntaxWalker.SemanticModel = result.GetSemanticModel(syntaxTree);
            fileSyntaxWalker.Visit((SyntaxNode) syntaxTree.GetCompilationUnitRoot());
          }
        }
        return fileSyntaxWalker.ReferencedNamespaces;
      }
    }

    private static bool IsInObjSubdirectory(string sourceFilePath)
    {
      FileInfo fileInfo = new FileInfo(sourceFilePath);
      return fileInfo.DirectoryName.EndsWith(Path.Combine("obj", "Debug")) || fileInfo.DirectoryName.EndsWith(Path.Combine("obj", "Release"));
    }
  }
}
