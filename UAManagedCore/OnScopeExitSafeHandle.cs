﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OnScopeExitSafeHandle
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  internal sealed class OnScopeExitSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
  {
    internal OnScopeExitSafeHandle()
      : base(true)
    {
    }

    internal void Initialize(IntPtr handle) => this.SetHandle(handle);

    protected override bool ReleaseHandle()
    {
      return OnScopeExitSafeHandle.Interop.ReleaseOnScopeExitHandle(this.handle);
    }

    public delegate bool ReleaseHandleDelegate();

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      public static extern bool ReleaseOnScopeExitHandle(IntPtr handle);
    }
  }
}
