// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.UANodeSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class UANodeSupport
  {
    public static IntPtr MakeUAObject(IntPtr contextPtr, IntPtr safeHandlePtr, IntPtr typePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      Type type = ObjectMarshal.FromIntPtr<Type>(typePtr);
      UAObject uaObject = type == (Type) null ? new UAObject() : (UAObject) Activator.CreateInstance(type);
      uaObject.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaObject);
    }

    public static IntPtr MakeUAVariable(IntPtr contextPtr, IntPtr safeHandlePtr, IntPtr typePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      Type type = ObjectMarshal.FromIntPtr<Type>(typePtr);
      UAVariable uaVariable = type == (Type) null ? new UAVariable() : (UAVariable) Activator.CreateInstance(type);
      uaVariable.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaVariable);
    }

    public static IntPtr MakeUAObjectType(IntPtr contextPtr, IntPtr safeHandlePtr, IntPtr typePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      Type type = ObjectMarshal.FromIntPtr<Type>(typePtr);
      UAObjectType uaObjectType = type == (Type) null ? new UAObjectType() : (UAObjectType) Activator.CreateInstance(type);
      uaObjectType.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaObjectType);
    }

    public static IntPtr MakeUAVariableType(
      IntPtr contextPtr,
      IntPtr safeHandlePtr,
      IntPtr typePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      Type type = ObjectMarshal.FromIntPtr<Type>(typePtr);
      UAVariableType uaVariableType = type == (Type) null ? new UAVariableType() : (UAVariableType) Activator.CreateInstance(type);
      uaVariableType.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaVariableType);
    }

    public static IntPtr MakeUAMethod(IntPtr contextPtr, IntPtr safeHandlePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      UAMethod uaMethod = new UAMethod();
      uaMethod.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaMethod);
    }

    public static IntPtr MakeUADataType(IntPtr contextPtr, IntPtr safeHandlePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      UADataType uaDataType = new UADataType();
      uaDataType.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaDataType);
    }

    public static IntPtr MakeUAReferenceType(IntPtr contextPtr, IntPtr safeHandlePtr)
    {
      UACoreContext context = ObjectMarshal.FromIntPtr<UACoreContext>(contextPtr);
      UANodeSafeHandle safeHandle = ObjectMarshal.FromIntPtr<UANodeSafeHandle>(safeHandlePtr);
      UAReferenceType uaReferenceType = new UAReferenceType();
      uaReferenceType.Initialize(context, safeHandle);
      return ObjectMarshal.ToIntPtr((object) uaReferenceType);
    }

    public static void DisposeUANode(IntPtr uaNodePtr)
    {
      ObjectMarshal.FromIntPtr<UANode>(uaNodePtr).Dispose();
    }

    public delegate IntPtr MakeUAObjectDelegate(
      IntPtr contextPtr,
      IntPtr safeHandlePtr,
      IntPtr typePtr);

    public delegate IntPtr MakeUAVariableDelegate(
      IntPtr contextPtr,
      IntPtr safeHandlePtr,
      IntPtr typePtr);

    public delegate IntPtr MakeUAObjectTypeDelegate(
      IntPtr contextPtr,
      IntPtr safeHandlePtr,
      IntPtr typePtr);

    public delegate IntPtr MakeUAVariableTypeDelegate(
      IntPtr contextPtr,
      IntPtr safeHandlePtr,
      IntPtr typePtr);

    public delegate IntPtr MakeUAMethodDelegate(IntPtr contextPtr, IntPtr safeHandlePtr);

    public delegate IntPtr MakeUADataTypeDelegate(IntPtr contextPtr, IntPtr safeHandlePtr);

    public delegate IntPtr MakeUAReferenceTypeDelegate(IntPtr contextPtr, IntPtr safeHandlePtr);

    public delegate void DisposeUANodeDelegate(IntPtr uaNodePtr);
  }
}
