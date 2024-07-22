// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NodePath
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class NodePath
  {
    public static string EscapeNodePathBrowseName(string browseName)
    {
      InteropCallResult interopCallResult = NodePath.Interop.EscapeNodePathBrowseName(browseName);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetString();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult EscapeNodePathBrowseName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);
    }
  }
}
