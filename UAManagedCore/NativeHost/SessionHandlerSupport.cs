// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.SessionHandlerSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class SessionHandlerSupport
  {
    public static IntPtr CreateSessionHandler(IntPtr contextPtr, IntPtr safeHandlePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new SessionHandler(ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr), ObjectMarshal.FromIntPtr<SessionHandlerSafeHandle>(safeHandlePtr)));
    }

    public delegate IntPtr CreateSessionHandlerDelegate(IntPtr contextPtr, IntPtr safeHandlePtr);
  }
}
