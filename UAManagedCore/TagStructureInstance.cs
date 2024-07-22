// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TagStructureInstance
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class TagStructureInstance
  {
    public static bool IsLocalTagStructureInstance(IUAVariable variable)
    {
      InteropCallResult interopCallResult = variable != null ? TagStructureInstance.Interop.IsLocalTagStructureInstance(ObjectMarshal.ToIntPtr((object) ((UANode) variable).nodeHandle)) : throw new ArgumentNullException(nameof (variable));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult IsLocalTagStructureInstance(IntPtr variable);
    }
  }
}
