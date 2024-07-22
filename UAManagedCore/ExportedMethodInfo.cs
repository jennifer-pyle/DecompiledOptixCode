// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExportedMethodInfo
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  internal class ExportedMethodInfo
  {
    public readonly string Name;
    public List<ExportedMethodParameterInfo> Parameters;
    public uint InputParameterCount;
    public uint OutputParameterCount;

    public ExportedMethodInfo(string name)
    {
      this.Name = name;
      this.Parameters = new List<ExportedMethodParameterInfo>();
    }
  }
}
