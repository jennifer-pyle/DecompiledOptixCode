﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.NamespaceMapSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class NamespaceMapSupport
  {
    public static void InitializeNamespaceMapWrapper()
    {
      NamespaceMapProvider.SetProvider((INamespaceMap) new NamespaceMap());
    }

    public delegate void InitializeNamespaceMapWrapperDelegate();
  }
}
