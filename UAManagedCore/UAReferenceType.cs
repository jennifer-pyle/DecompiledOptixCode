// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAReferenceType
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAReferenceType : UANode, IUAReferenceType, IUANode
  {
    public bool IsAbstract
    {
      get
      {
        InteropCallResult interopCallResult = UAReferenceType.Interop.UAReferenceTypeIsAbstract(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public IUAReferenceType SuperType
    {
      get
      {
        InteropCallResult superType = UAReferenceType.Interop.UAReferenceTypeGetSuperType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        superType.CheckOutcome();
        return (IUAReferenceType) superType.Get<UAReferenceType>();
      }
    }

    public bool IsSubTypeOf(NodeId referenceTypeNodeId)
    {
      InteropCallResult interopCallResult = UAReferenceType.Interop.UAReferenceTypeIsSubTypeOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) referenceTypeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    protected override NodeClass GetNodeClass() => NodeClass.ReferenceType;

    protected override void InitializeDerivedNodeClass()
    {
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferenceTypeIsAbstract(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferenceTypeGetSuperType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferenceTypeIsSubTypeOf(
        IntPtr nodeHandle,
        IntPtr referenceTypeNodeId);
    }
  }
}
