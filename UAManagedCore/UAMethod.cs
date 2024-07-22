// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAMethod
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAMethod : UANode, IUAMethod, IUANode
  {
    public void Execute(IUANode targetNode)
    {
      UAMethod.Interop.UAMethodExecute((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle).CheckOutcome();
    }

    public void Execute(IUANode targetNode, object[] args)
    {
      UAMethod.Interop.UAMethodExecuteArgs((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void Execute(IUANode targetNode, object[] inputArgs, out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAMethod.Interop.UAMethodExecuteOutputArgs((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public void ExecuteNoPermissions(IUANode targetNode)
    {
      UAMethod.Interop.UAMethodExecuteNoPermission((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle).CheckOutcome();
    }

    public void ExecuteNoPermissions(IUANode targetNode, object[] args)
    {
      UAMethod.Interop.UAMethodExecuteArgsNoPermission((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void ExecuteNoPermissions(
      IUANode targetNode,
      object[] inputArgs,
      out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAMethod.Interop.UAMethodExecuteOutputArgsNoPermission((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public bool IsExecutable(IUANode targetNode)
    {
      InteropCallResult interopCallResult = UAMethod.Interop.UAMethodIsExecutable((IntPtr) this.nodeHandle, (IntPtr) ((UANode) targetNode).nodeHandle);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    protected override NodeClass GetNodeClass() => NodeClass.Method;

    protected override void InitializeDerivedNodeClass()
    {
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecute(
        IntPtr nodeHandle,
        IntPtr targetNodePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecuteArgs(
        IntPtr nodeHandle,
        IntPtr targetNodePtr,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecuteOutputArgs(
        IntPtr nodeHandle,
        IntPtr targetNodePtr,
        IntPtr argsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecuteNoPermission(
        IntPtr nodeHandle,
        IntPtr targetNodePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecuteArgsNoPermission(
        IntPtr nodeHandle,
        IntPtr targetNodePtr,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodExecuteOutputArgsNoPermission(
        IntPtr nodeHandle,
        IntPtr targetNodePtr,
        IntPtr argsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAMethodIsExecutable(
        IntPtr nodeHandle,
        IntPtr targetNodePtr);
    }
  }
}
