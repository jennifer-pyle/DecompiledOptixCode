// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UADataType
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UADataType : UANode, IUADataType, IUANode
  {
    public bool IsAbstract
    {
      get
      {
        InteropCallResult interopCallResult = UADataType.Interop.UADataTypeIsAbstract(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public IUADataType SuperType
    {
      get
      {
        InteropCallResult superType = UADataType.Interop.UADataTypeGetSuperType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        superType.CheckOutcome();
        return (IUADataType) superType.Get<UADataType>();
      }
    }

    public StructDefinition StructDefinition
    {
      get
      {
        InteropCallResult structDefinition = UADataType.Interop.UADataTypeGetStructDefinition(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        structDefinition.CheckOutcome();
        return structDefinition.Get<StructDefinition>();
      }
    }

    public EnumDefinition EnumDefinition
    {
      get
      {
        InteropCallResult enumDefinition = UADataType.Interop.UADataTypeGetEnumDefinition(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        enumDefinition.CheckOutcome();
        return enumDefinition.Get<EnumDefinition>();
      }
    }

    public bool IsSubTypeOf(NodeId dataTypeNodeId)
    {
      InteropCallResult interopCallResult = UADataType.Interop.UADataTypeIsSubTypeOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) dataTypeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    protected override NodeClass GetNodeClass() => NodeClass.DataType;

    protected override void InitializeDerivedNodeClass()
    {
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UADataTypeIsAbstract(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UADataTypeGetSuperType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UADataTypeGetStructDefinition(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UADataTypeGetEnumDefinition(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UADataTypeIsSubTypeOf(
        IntPtr nodeHandle,
        IntPtr dataTypeNodeId);
    }
  }
}
