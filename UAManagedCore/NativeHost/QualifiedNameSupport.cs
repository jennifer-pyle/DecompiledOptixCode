// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.QualifiedNameSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class QualifiedNameSupport
  {
    public static IntPtr CreateQualifiedName(int namespaceIndex, IntPtr namePtr)
    {
      string name = StringMarshal.StringFromIntPtr(namePtr);
      return ObjectMarshal.ToIntPtr((object) new QualifiedName(namespaceIndex, name));
    }

    public static void DecomposeQualifiedName(
      IntPtr qualifiedNamePtr,
      out int namespaceIndex,
      out IntPtr name)
    {
      QualifiedName qualifiedName = ObjectMarshal.FromIntPtr<QualifiedName>(qualifiedNamePtr);
      if (qualifiedName == (QualifiedName) null)
        qualifiedName = QualifiedName.Empty;
      namespaceIndex = qualifiedName.NamespaceIndex;
      name = StringMarshal.StringToIntPtr(qualifiedName.Name);
    }

    public delegate IntPtr CreateQualifiedNameDelegate(int namespaceIndex, IntPtr namePtr);

    public delegate void DecomposeQualifiedNameDelegate(
      IntPtr qualifiedNamePtr,
      out int namespaceIndex,
      out IntPtr name);
  }
}
