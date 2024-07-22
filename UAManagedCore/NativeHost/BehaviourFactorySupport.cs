﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.BehaviourFactorySupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class BehaviourFactorySupport
  {
    public static IntPtr CreateManagedBehaviourFactory(IntPtr typePtr)
    {
      return ObjectMarshal.ToIntPtr((object) new ManagedBehaviourFactory(ObjectMarshal.FromIntPtr<Type>(typePtr)));
    }

    public static IntPtr MakeBehaviour(IntPtr behaviourFactoryPtr, IntPtr nodePtr)
    {
      return ObjectMarshal.ToIntPtr((object) ObjectMarshal.FromIntPtr<IBehaviourFactory>(behaviourFactoryPtr).MakeBehaviour(ObjectMarshal.FromIntPtr<IUANode>(nodePtr)));
    }

    public delegate IntPtr CreateManagedBehaviourFactoryDelegate(IntPtr typePtr);

    public delegate IntPtr MakeBehaviourDelegate(IntPtr behaviourFactoryPtr, IntPtr nodePtr);
  }
}
