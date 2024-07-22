// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NamespaceInfoInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  internal struct NamespaceInfoInterop
  {
    public IntPtr NamespaceUri;
    public IntPtr ServerUri;
    public int NamespaceType;

    public static implicit operator NamespaceInfo(NamespaceInfoInterop v)
    {
      NamespaceInfo namespaceInfo = new NamespaceInfo(Marshal.PtrToStringUTF8(v.NamespaceUri), Marshal.PtrToStringUTF8(v.ServerUri), (UAManagedCore.NamespaceType) v.NamespaceType);
      NativeMemory.Free(v.NamespaceUri);
      NativeMemory.Free(v.ServerUri);
      return namespaceInfo;
    }
  }
}
