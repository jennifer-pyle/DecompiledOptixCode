﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.MappedDataTypeDescriptorInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct MappedDataTypeDescriptorInterop
  {
    public readonly IntPtr Namespace;
    public readonly IntPtr Class;
    public readonly IntPtr TypeNodeId;
    public readonly IntPtr ManagedType;

    public MappedDataTypeDescriptorInterop(MappedDataTypeDescriptor descriptor)
    {
      this.Namespace = StringMarshal.StringToIntPtr(descriptor.Namespace);
      this.Class = StringMarshal.StringToIntPtr(descriptor.Class);
      this.TypeNodeId = ObjectMarshal.ToIntPtr((object) descriptor.TypeNodeId);
      this.ManagedType = ObjectMarshal.ToIntPtr((object) descriptor.ManagedType);
    }
  }
}
