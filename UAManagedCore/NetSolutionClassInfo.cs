// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NetSolutionClassInfo
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  internal class NetSolutionClassInfo
  {
    public readonly string Name;
    public readonly NetSolutionClassKind Kind;
    public List<ExportedMethodInfo> Methods;

    public NetSolutionClassInfo(string name, NetSolutionClassKind kind)
    {
      this.Name = name;
      this.Kind = kind;
      this.Methods = new List<ExportedMethodInfo>();
    }
  }
}
