// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAVariableType
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAVariableType : UANode, IUAVariableType, IUANode
  {
    public bool IsAbstract
    {
      get
      {
        InteropCallResult interopCallResult = UAVariableType.Interop.UAVariableTypeIsAbstract(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public IUAVariableType SuperType
    {
      get
      {
        InteropCallResult superType = UAVariableType.Interop.UAVariableTypeGetSuperType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        superType.CheckOutcome();
        return (IUAVariableType) superType.Get<UAVariableType>();
      }
    }

    public NodeId DataType
    {
      get
      {
        InteropCallResult dataType = UAVariableType.Interop.UAVariableTypeGetDataType((IntPtr) this.nodeHandle);
        dataType.CheckOutcome();
        return dataType.Get<NodeId>();
      }
    }

    public ValueRank ValueRank
    {
      get
      {
        InteropCallResult valueRank = UAVariableType.Interop.UAVariableTypeGetValueRank((IntPtr) this.nodeHandle);
        valueRank.CheckOutcome();
        return (ValueRank) valueRank.GetInt();
      }
    }

    public uint[] ArrayDimensions
    {
      get
      {
        InteropCallResult arrayDimensions = UAVariableType.Interop.UAVariableTypeGetArrayDimensions((IntPtr) this.nodeHandle);
        arrayDimensions.CheckOutcome();
        return arrayDimensions.GetUIntArray();
      }
    }

    public uint GetArrayDimension(uint dimension)
    {
      uint[] arrayDimensions = this.ArrayDimensions;
      if ((long) dimension >= (long) arrayDimensions.Length)
        throw new ArgumentException("Dimension argument is not less than the number of array dimensions");
      return arrayDimensions[(int) dimension];
    }

    public bool IsSubTypeOf(NodeId typeNodeId)
    {
      InteropCallResult interopCallResult = UAVariableType.Interop.UAVariableTypeIsSubTypeOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) typeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    protected override NodeClass GetNodeClass() => NodeClass.VariableType;

    protected override void InitializeDerivedNodeClass()
    {
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeIsAbstract(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeGetSuperType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeGetDataType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeGetValueRank(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeGetArrayDimensions(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableTypeIsSubTypeOf(
        IntPtr nodeHandle,
        IntPtr dataTypeNodeId);
    }
  }
}
