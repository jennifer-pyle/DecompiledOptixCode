// Decompiled with JetBrains decompiler
// Type: UAManagedCore.MappedDataTypeDescriptor
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct MappedDataTypeDescriptor
  {
    public string Namespace;
    public string Class;
    public NodeId TypeNodeId;
    public Type ManagedType;

    public MappedDataTypeDescriptor(Type type, NodeId nodeId)
    {
      this.Namespace = type.Namespace;
      this.Class = type.Name;
      this.TypeNodeId = nodeId;
      this.ManagedType = type;
    }
  }
}
