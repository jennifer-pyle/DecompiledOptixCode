﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.TransactionResourceSafeHandleSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class TransactionResourceSafeHandleSupport
  {
    public static IntPtr CreateTransactionResourceSafeHandle(IntPtr handle)
    {
      TransactionResourceSafeHandle resourceSafeHandle = new TransactionResourceSafeHandle();
      resourceSafeHandle.Initialize(handle);
      return ObjectMarshal.ToIntPtr((object) resourceSafeHandle);
    }

    public delegate IntPtr CreateTransactionResourceSafeHandleDelegate(IntPtr handle);
  }
}
