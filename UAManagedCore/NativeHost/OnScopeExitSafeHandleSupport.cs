// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.OnScopeExitSafeHandleSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class OnScopeExitSafeHandleSupport
  {
    public static IntPtr CreateOnScopeExitSafeHandle(IntPtr handle)
    {
      OnScopeExitSafeHandle scopeExitSafeHandle = new OnScopeExitSafeHandle();
      scopeExitSafeHandle.Initialize(handle);
      return ObjectMarshal.ToIntPtr((object) scopeExitSafeHandle);
    }

    public delegate IntPtr CreateOnScopeExitSafeHandleDelegate(IntPtr handle);
  }
}
