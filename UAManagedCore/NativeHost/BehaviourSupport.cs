// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.BehaviourSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class BehaviourSupport
  {
    public static int IsExecutable(IntPtr behaviourPtr)
    {
      return typeof (IExecutableBehaviour).IsAssignableFrom(ObjectMarshal.FromIntPtr<IBehaviour>(behaviourPtr).GetType()) ? 1 : 0;
    }

    public static void Start(IntPtr behaviourPtr)
    {
      ObjectMarshal.FromIntPtr<IBehaviour>(behaviourPtr).Start();
    }

    public static void Stop(IntPtr behaviourPtr)
    {
      ObjectMarshal.FromIntPtr<IBehaviour>(behaviourPtr).Stop();
    }

    public static int ExecuteMethod(
      IntPtr behaviourPtr,
      IntPtr targetNodePtr,
      IntPtr methodNamePtr,
      IntPtr inputArgsPtr,
      out IntPtr outputArgsPtr)
    {
      object[] outputArgs;
      bool flag = ObjectMarshal.FromIntPtr<IExecutableBehaviour>(behaviourPtr).ExecuteMethod(ObjectMarshal.FromIntPtr<IUANode>(targetNodePtr), StringMarshal.StringFromIntPtr(methodNamePtr), ArrayMarshal.ToManagedArray<object>(inputArgsPtr), out outputArgs);
      outputArgsPtr = ArrayMarshal.ToNative(outputArgs);
      return flag ? 1 : 0;
    }

    public delegate int IsExecutableDelegate(IntPtr behaviourPtr);

    public delegate void StartDelegate(IntPtr behaviourPtr);

    public delegate void StopDelegate(IntPtr behaviourPtr);

    public delegate int ExecuteMethodDelegate(
      IntPtr behaviourPtr,
      IntPtr targetNodePtr,
      IntPtr methodNamePtr,
      IntPtr inputArgsPtr,
      out IntPtr outputArgsPtr);
  }
}
