﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteVariableValueInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct RemoteVariableValueInterop
  {
    public IntPtr Variable;
    public IntPtr Value;
    public IntPtr Index;

    public static implicit operator RemoteVariableValue(RemoteVariableValueInterop v)
    {
      return new RemoteVariableValue((IUAVariable) ObjectMarshal.FromIntPtr<UAVariable>(v.Variable), ObjectMarshal.ReleaseGCHandle<UAValue>(v.Value), ArrayMarshal.ToManagedUInt32Array(v.Index));
    }
  }
}
