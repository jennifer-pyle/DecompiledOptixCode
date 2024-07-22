// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NamespaceMap
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class NamespaceMap : INamespaceMap
  {
    public int GetNamespaceIndex(string namespaceName)
    {
      InteropCallResult interopCallResult = namespaceName != null ? NamespaceMap.Interop.NamespaceMapGetNamespaceIndex(namespaceName) : throw new ArgumentNullException(nameof (namespaceName));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetInt();
    }

    internal static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NamespaceMapGetNamespaceIndex([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string namespaceName);
    }
  }
}
