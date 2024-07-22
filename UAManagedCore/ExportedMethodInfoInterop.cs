// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExportedMethodInfoInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct ExportedMethodInfoInterop
  {
    public readonly IntPtr Name;
    public readonly IntPtr Parameters;
    public readonly uint InputParameterCount;
    public readonly uint OutputParameterCount;

    public ExportedMethodInfoInterop(ExportedMethodInfo methodInfo)
    {
      this.Name = StringMarshal.StringToIntPtr(methodInfo.Name);
      this.Parameters = StructMarshal.ToNativeArray(methodInfo.Parameters);
      this.InputParameterCount = methodInfo.InputParameterCount;
      this.OutputParameterCount = methodInfo.OutputParameterCount;
    }
  }
}
