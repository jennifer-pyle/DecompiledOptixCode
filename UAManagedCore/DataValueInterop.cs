// Decompiled with JetBrains decompiler
// Type: UAManagedCore.DataValueInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct DataValueInterop
  {
    public IntPtr value;
    public uint statusCode;
    public IntPtr sourceTimestamp;
    public IntPtr serverTimestamp;

    public static implicit operator DataValue(DataValueInterop v)
    {
      return new DataValue(ObjectMarshal.ReleaseGCHandle<UAValue>(v.value), v.statusCode, (DateTime) ObjectMarshal.ReleaseGCHandle<object>(v.sourceTimestamp), (DateTime) ObjectMarshal.ReleaseGCHandle<object>(v.serverTimestamp));
    }
  }
}
