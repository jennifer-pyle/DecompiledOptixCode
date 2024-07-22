// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.SafeHandleSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class SafeHandleSupport
  {
    public static bool DangerousAddRef(IntPtr safeHandlePtr)
    {
      SafeHandle safeHandle = ObjectMarshal.FromIntPtr<SafeHandle>(safeHandlePtr);
      bool success = true;
      safeHandle.DangerousAddRef(ref success);
      return success;
    }

    public static IntPtr DangerousGetHandle(IntPtr safeHandlePtr)
    {
      return ObjectMarshal.FromIntPtr<SafeHandle>(safeHandlePtr).DangerousGetHandle();
    }

    public static void DangerousRelease(IntPtr safeHandlePtr)
    {
      ObjectMarshal.FromIntPtr<SafeHandle>(safeHandlePtr).DangerousRelease();
    }

    public delegate bool DangerousAddRefDelegate(IntPtr safeHandlePtr);

    public delegate IntPtr DangerousGetHandleDelegate(IntPtr safeHandlePtr);

    public delegate void DangerousReleaseDelegate(IntPtr safeHandlePtr);
  }
}
