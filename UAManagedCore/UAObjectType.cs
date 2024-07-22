// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAObjectType
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAObjectType : UANode, IUAObjectType, IUANode
  {
    public bool IsAbstract
    {
      get
      {
        InteropCallResult interopCallResult = UAObjectType.Interop.UAObjectTypeIsAbstract(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public IUAObjectType SuperType
    {
      get
      {
        InteropCallResult superType = UAObjectType.Interop.UAObjectTypeGetSuperType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        superType.CheckOutcome();
        return (IUAObjectType) superType.Get<UAObjectType>();
      }
    }

    public IEventArguments EventArguments
    {
      get
      {
        InteropCallResult eventArguments = UAObjectType.Interop.UAObjectTypeGetEventArguments((IntPtr) this.nodeHandle);
        eventArguments.CheckOutcome();
        return (IEventArguments) new UAManagedCore.EventArguments(eventArguments.GetStringArray());
      }
    }

    public void ExecuteMethod(string methodName)
    {
      UAObjectType.Interop.UAObjectTypeExecuteMethod((IntPtr) this.nodeHandle, methodName).CheckOutcome();
    }

    public void ExecuteMethod(string methodName, object[] args)
    {
      UAObjectType.Interop.UAObjectTypeExecuteMethodArgs((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void ExecuteMethod(string methodName, object[] inputArgs, out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAObjectType.Interop.UAObjectTypeExecuteMethodOutputArgs((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public void ExecuteMethodNoPermissions(string methodName)
    {
      UAObjectType.Interop.UAObjectTypeExecuteMethodNoPermission((IntPtr) this.nodeHandle, methodName).CheckOutcome();
    }

    public void ExecuteMethodNoPermissions(string methodName, object[] args)
    {
      UAObjectType.Interop.UAObjectTypeExecuteMethodArgsNoPermission((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void ExecuteMethodNoPermissions(
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAObjectType.Interop.UAObjectTypeExecuteMethodOutputArgsNoPermission((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public bool IsSubTypeOf(NodeId typeNodeId)
    {
      InteropCallResult interopCallResult = UAObjectType.Interop.UAObjectTypeIsSubTypeOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) typeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    protected override NodeClass GetNodeClass() => NodeClass.ObjectType;

    protected override void InitializeDerivedNodeClass()
    {
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeIsAbstract(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeGetSuperType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeGetEventArguments(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethod(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethodArgs(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethodOutputArgs(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr inputArgsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethodNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethodArgsNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeExecuteMethodOutputArgsNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr inputArgsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectTypeIsSubTypeOf(
        IntPtr nodeHandle,
        IntPtr objectTypeNodeIdPtr);
    }
  }
}
