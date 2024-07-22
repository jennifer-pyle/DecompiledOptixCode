// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NetSolutionAssemblyInfo
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  internal class NetSolutionAssemblyInfo
  {
    public List<NetSolutionClassInfo> Classes;
    public List<string> ReferencedAssemblies;

    public NetSolutionAssemblyInfo()
    {
      this.Classes = new List<NetSolutionClassInfo>();
      this.ReferencedAssemblies = new List<string>();
    }

    public NetSolutionAssemblyInfo(
      List<NetSolutionClassInfo> classes,
      List<string> referencedAssemblies)
    {
      this.Classes = classes;
      this.ReferencedAssemblies = referencedAssemblies;
    }
  }
}
