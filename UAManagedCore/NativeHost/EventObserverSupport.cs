// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.EventObserverSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class EventObserverSupport
  {
    public static void OnAttributeChanged(
      IntPtr observerPtr,
      IntPtr nodePtr,
      uint attributeId,
      IntPtr newValuePtr,
      IntPtr oldValuePtr,
      ulong senderId)
    {
      IAttributeChangeObserver attributeChangeObserver = ObjectMarshal.FromIntPtr<IAttributeChangeObserver>(observerPtr);
      IUANode node = ObjectMarshal.FromIntPtr<IUANode>(nodePtr);
      UAValue newValue = ObjectMarshal.ReleaseGCHandle<UAValue>(newValuePtr);
      UAValue oldValue = ObjectMarshal.ReleaseGCHandle<UAValue>(oldValuePtr);
      try
      {
        attributeChangeObserver.OnAttributeChanged(node, (AttributeId) attributeId, newValue, oldValue, senderId);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, "Uncaught managed exception when executing OnAttributeChanged on " + Log.Node(node) + ": " + ex?.ToString(), "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 26, nameof (OnAttributeChanged));
      }
    }

    public static void OnVariableChanged(
      IntPtr observerPtr,
      IntPtr variablePtr,
      IntPtr newValuePtr,
      IntPtr oldValuePtr,
      IntPtr indexesPtr,
      ulong senderId)
    {
      IVariableChangeObserver variableChangeObserver = ObjectMarshal.FromIntPtr<IVariableChangeObserver>(observerPtr);
      IUAVariable uaVariable = ObjectMarshal.FromIntPtr<IUAVariable>(variablePtr);
      UAValue newValue = ObjectMarshal.ReleaseGCHandle<UAValue>(newValuePtr);
      UAValue oldValue = ObjectMarshal.ReleaseGCHandle<UAValue>(oldValuePtr);
      uint[] managedUint32Array = ArrayMarshal.ToManagedUInt32Array(indexesPtr);
      try
      {
        variableChangeObserver.OnVariableChanged(uaVariable, newValue, oldValue, managedUint32Array, senderId);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, "Uncaught managed exception when executing OnVariableChanged on " + Log.Node((IUANode) uaVariable) + ": " + ex?.ToString(), "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 48, nameof (OnVariableChanged));
      }
    }

    public static void OnEvent(
      IntPtr observerPtr,
      IntPtr eventNotifierPtr,
      IntPtr eventTypePtr,
      IntPtr argsPtr,
      ulong senderId)
    {
      IUAEventObserver uaEventObserver = ObjectMarshal.FromIntPtr<IUAEventObserver>(observerPtr);
      IUAObject uaObject = ObjectMarshal.FromIntPtr<IUAObject>(eventNotifierPtr);
      IUAObjectType eventType = ObjectMarshal.FromIntPtr<IUAObjectType>(eventTypePtr);
      object[] managedArray = ArrayMarshal.ToManagedArray<object>(argsPtr);
      try
      {
        uaEventObserver.OnEvent(uaObject, eventType, (IReadOnlyList<object>) managedArray, senderId);
      }
      catch (Exception ex)
      {
        ICoreLogger coreLogger = LogManager.CoreLogger;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 2);
        interpolatedStringHandler.AppendLiteral("Uncaught managed exception when executing OnEvent on notifier ");
        interpolatedStringHandler.AppendFormatted(Log.Node((IUANode) uaObject));
        interpolatedStringHandler.AppendLiteral(" ");
        interpolatedStringHandler.AppendLiteral("of type ");
        interpolatedStringHandler.AppendFormatted<QualifiedName>(uaObject.QualifiedBrowseName);
        interpolatedStringHandler.AppendLiteral(": ");
        string message = interpolatedStringHandler.ToStringAndClear() + ex?.ToString();
        coreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 69, nameof (OnEvent));
      }
    }

    public static void OnReferenceAdded(
      IntPtr observerPtr,
      IntPtr sourceNodePtr,
      IntPtr targetNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId)
    {
      IReferenceObserver referenceObserver = ObjectMarshal.FromIntPtr<IReferenceObserver>(observerPtr);
      IUANode uaNode1 = ObjectMarshal.FromIntPtr<IUANode>(sourceNodePtr);
      IUANode uaNode2 = ObjectMarshal.FromIntPtr<IUANode>(targetNodePtr);
      NodeId referenceTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(referenceTypeIdPtr);
      try
      {
        referenceObserver.OnReferenceAdded(uaNode1, uaNode2, referenceTypeId, senderId);
      }
      catch (Exception ex)
      {
        ICoreLogger coreLogger = LogManager.CoreLogger;
        string[] strArray = new string[7]
        {
          "Uncaught managed exception when executing OnReferenceAdded from ",
          uaNode1.IsValid ? Log.Node(uaNode1) : "disposed node",
          " to ",
          uaNode2.IsValid ? Log.Node(uaNode2) : "disposed node",
          " ",
          null,
          null
        };
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
        interpolatedStringHandler.AppendLiteral("of type ");
        interpolatedStringHandler.AppendFormatted<NodeId>(referenceTypeId);
        interpolatedStringHandler.AppendLiteral(": ");
        strArray[5] = interpolatedStringHandler.ToStringAndClear();
        strArray[6] = ex?.ToString();
        string message = string.Concat(strArray);
        coreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 91, nameof (OnReferenceAdded));
      }
    }

    public static void OnReferenceRemoved(
      IntPtr observerPtr,
      IntPtr sourceNodePtr,
      IntPtr targetNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId)
    {
      IReferenceObserver referenceObserver = ObjectMarshal.FromIntPtr<IReferenceObserver>(observerPtr);
      IUANode uaNode1 = ObjectMarshal.FromIntPtr<IUANode>(sourceNodePtr);
      IUANode uaNode2 = ObjectMarshal.FromIntPtr<IUANode>(targetNodePtr);
      NodeId referenceTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(referenceTypeIdPtr);
      try
      {
        referenceObserver.OnReferenceRemoved(uaNode1, uaNode2, referenceTypeId, senderId);
      }
      catch (Exception ex)
      {
        ICoreLogger coreLogger = LogManager.CoreLogger;
        string[] strArray = new string[7]
        {
          "Uncaught managed exception when executing OnReferenceRemoved from ",
          uaNode1.IsValid ? Log.Node(uaNode1) : "disposed node",
          " to ",
          uaNode2.IsValid ? Log.Node(uaNode2) : "disposed node",
          " ",
          null,
          null
        };
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
        interpolatedStringHandler.AppendLiteral("of type ");
        interpolatedStringHandler.AppendFormatted<NodeId>(referenceTypeId);
        interpolatedStringHandler.AppendLiteral(": ");
        strArray[5] = interpolatedStringHandler.ToStringAndClear();
        strArray[6] = ex?.ToString();
        string message = string.Concat(strArray);
        coreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 115, nameof (OnReferenceRemoved));
      }
    }

    public static void OnNodeAttached(
      IntPtr observerPtr,
      IntPtr parentNodePtr,
      IntPtr childNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId)
    {
      INodeAttachedObserver attachedObserver = ObjectMarshal.FromIntPtr<INodeAttachedObserver>(observerPtr);
      IUANode uaNode1 = ObjectMarshal.FromIntPtr<IUANode>(parentNodePtr);
      IUANode uaNode2 = ObjectMarshal.FromIntPtr<IUANode>(childNodePtr);
      NodeId referenceTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(referenceTypeIdPtr);
      try
      {
        attachedObserver.OnNodeAttached(uaNode1, uaNode2, referenceTypeId, senderId);
      }
      catch (Exception ex)
      {
        ICoreLogger coreLogger = LogManager.CoreLogger;
        string[] strArray = new string[7]
        {
          "Uncaught managed exception when executing OnNodeAttached ",
          uaNode2.IsValid ? Log.Node(uaNode2) : "disposed node",
          " to ",
          uaNode1.IsValid ? Log.Node(uaNode1) : "disposed node",
          " ",
          null,
          null
        };
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
        interpolatedStringHandler.AppendLiteral("with reference type ");
        interpolatedStringHandler.AppendFormatted<NodeId>(referenceTypeId);
        interpolatedStringHandler.AppendLiteral(": ");
        strArray[5] = interpolatedStringHandler.ToStringAndClear();
        strArray[6] = ex?.ToString();
        string message = string.Concat(strArray);
        coreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 139, nameof (OnNodeAttached));
      }
    }

    public static void OnNodeDetached(
      IntPtr observerPtr,
      IntPtr parentNodePtr,
      IntPtr childNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId)
    {
      INodeDetachedObserver detachedObserver = ObjectMarshal.FromIntPtr<INodeDetachedObserver>(observerPtr);
      IUANode uaNode1 = ObjectMarshal.FromIntPtr<IUANode>(parentNodePtr);
      IUANode uaNode2 = ObjectMarshal.FromIntPtr<IUANode>(childNodePtr);
      NodeId referenceTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(referenceTypeIdPtr);
      try
      {
        detachedObserver.OnNodeDetached(uaNode1, uaNode2, referenceTypeId, senderId);
      }
      catch (Exception ex)
      {
        ICoreLogger coreLogger = LogManager.CoreLogger;
        string[] strArray = new string[7]
        {
          "Uncaught managed exception when executing OnNodeDetached ",
          uaNode2.IsValid ? Log.Node(uaNode2) : "disposed node",
          " from ",
          uaNode1.IsValid ? Log.Node(uaNode1) : "disposed node",
          " ",
          null,
          null
        };
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
        interpolatedStringHandler.AppendLiteral("with reference type ");
        interpolatedStringHandler.AppendFormatted<NodeId>(referenceTypeId);
        interpolatedStringHandler.AppendLiteral(": ");
        strArray[5] = interpolatedStringHandler.ToStringAndClear();
        strArray[6] = ex?.ToString();
        string message = string.Concat(strArray);
        coreLogger.Log(LogLevel.Error, "UAManagedProxy", (ushort) 220, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\NET5\\NativeHost\\EventObserverSupport.cs", 163, nameof (OnNodeDetached));
      }
    }

    public delegate void OnAttributeChangedDelegate(
      IntPtr observerPtr,
      IntPtr nodePtr,
      uint attributeId,
      IntPtr newValuePtr,
      IntPtr oldValuePtr,
      ulong senderId);

    public delegate void OnVariableChangedDelegate(
      IntPtr observerPtr,
      IntPtr variablePtr,
      IntPtr newValuePtr,
      IntPtr oldValuePtr,
      IntPtr indexesPtr,
      ulong senderId);

    public delegate void OnEventDelegate(
      IntPtr observerPtr,
      IntPtr eventNotifierPtr,
      IntPtr eventTypePtr,
      IntPtr argsPtr,
      ulong senderId);

    public delegate void OnReferenceAddedDelegate(
      IntPtr observerPtr,
      IntPtr sourceNodePtr,
      IntPtr targetNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId);

    public delegate void OnReferenceRemovedDelegate(
      IntPtr observerPtr,
      IntPtr sourceNodePtr,
      IntPtr targetNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId);

    public delegate void OnNodeAttachedDelegate(
      IntPtr observerPtr,
      IntPtr parentNodePtr,
      IntPtr childNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId);

    public delegate void OnNodeDetachedDelegate(
      IntPtr observerPtr,
      IntPtr parentNodePtr,
      IntPtr childNodePtr,
      IntPtr referenceTypeIdPtr,
      ulong senderId);
  }
}
