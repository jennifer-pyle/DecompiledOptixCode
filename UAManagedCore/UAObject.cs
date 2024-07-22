// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAObject
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore
{
  public class UAObject : UANode, IUAObject, IUANode, IUAEventObserver, IEventObserver
  {
    private IEventRegistration uaEventRegistration;
    private CoreEventHandler<UAEventArgs> uaEventHandler;
    private Dictionary<NodeId, IEventRegistration> customEventRegistrations;
    private Dictionary<NodeId, CustomEventHandler> customEventHandlers;

    public IUAObjectType ObjectType
    {
      get
      {
        InteropCallResult objectType = UAObject.Interop.UAObjectGetObjectType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        objectType.CheckOutcome();
        return (IUAObjectType) objectType.Get<UAObjectType>();
      }
    }

    public IUAObject Prototype
    {
      get
      {
        InteropCallResult prototype = UAObject.Interop.UAObjectGetPrototype((IntPtr) this.nodeHandle);
        prototype.CheckOutcome();
        return (IUAObject) prototype.Get<UAObject>();
      }
      set
      {
        UAObject uaObject = (UAObject) value;
        IntPtr nodeHandle1 = (IntPtr) this.nodeHandle;
        UANodeSafeHandle nodeHandle2 = uaObject?.nodeHandle;
        IntPtr prototypeHandle = nodeHandle2 != null ? (IntPtr) nodeHandle2 : IntPtr.Zero;
        UAObject.Interop.UAObjectSetPrototype(nodeHandle1, prototypeHandle).CheckOutcome();
      }
    }

    public void DispatchUAEvent(NodeId eventTypeNodeId, IReadOnlyList<object> eventArgs)
    {
      UAObject.Interop.UAObjectDispatchUAEvent(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) eventTypeNodeId), ArrayMarshal.ToNative(eventArgs.ToArray<object>())).CheckOutcome();
    }

    public void ExecuteMethod(string methodName)
    {
      UAObject.Interop.UAObjectExecuteMethod((IntPtr) this.nodeHandle, methodName).CheckOutcome();
    }

    public void ExecuteMethod(string methodName, object[] args)
    {
      UAObject.Interop.UAObjectExecuteMethodArgs((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void ExecuteMethod(string methodName, object[] inputArgs, out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAObject.Interop.UAObjectExecuteMethodOutputArgs((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public void ExecuteMethodNoPermissions(string methodName)
    {
      UAObject.Interop.UAObjectExecuteMethodNoPermission((IntPtr) this.nodeHandle, methodName).CheckOutcome();
    }

    public void ExecuteMethodNoPermissions(string methodName, object[] args)
    {
      UAObject.Interop.UAObjectExecuteMethodArgsNoPermission((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(args)).CheckOutcome();
    }

    public void ExecuteMethodNoPermissions(
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      IntPtr outputArgsPtr;
      UAObject.Interop.UAObjectExecuteMethodOutputArgsNoPermission((IntPtr) this.nodeHandle, methodName, ArrayMarshal.ToNative(inputArgs), out outputArgsPtr).CheckOutcome();
      outputArgs = ArrayMarshal.ToManagedArray<object>(outputArgsPtr);
    }

    public IReadOnlyCollection<BehaviourStartedInfo> GetBehaviourStartedInfos()
    {
      InteropCallResult behaviourStartedInfos1 = UAObject.Interop.UAObjectGetBehaviourStartedInfos((IntPtr) this.nodeHandle);
      behaviourStartedInfos1.CheckOutcome();
      BehaviourStartedInfoInterop[] structArray = behaviourStartedInfos1.GetStructArray<BehaviourStartedInfoInterop>();
      BehaviourStartedInfo[] behaviourStartedInfos2 = new BehaviourStartedInfo[structArray.Length];
      for (int index = 0; index < structArray.Length; ++index)
        behaviourStartedInfos2[index] = (BehaviourStartedInfo) structArray[index];
      return (IReadOnlyCollection<BehaviourStartedInfo>) behaviourStartedInfos2;
    }

    public IEventRegistration RegisterUAEventObserver(
      IUAEventObserver observer,
      NodeId eventTypeNodeId,
      uint affinityId = 0)
    {
      InteropCallResult interopCallResult = UAObject.Interop.UAObjectRegisterUAEventObserver((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) observer), ObjectMarshal.ToIntPtr((object) eventTypeNodeId), affinityId);
      interopCallResult.CheckOutcome();
      return (IEventRegistration) new EventRegistration(interopCallResult.Get<EventRegistrationSafeHandle>());
    }

    public void Start(bool recursive = true)
    {
      UAObject.Interop.UAObjectStartWithDefaultPriorityRange((IntPtr) this.nodeHandle, recursive ? 1 : 0).CheckOutcome();
    }

    public void Start(byte minPriority, byte maxPriority, bool recursive = true)
    {
      UAObject.Interop.UAObjectStart((IntPtr) this.nodeHandle, minPriority, maxPriority, recursive ? 1 : 0).CheckOutcome();
    }

    public void Stop(bool recursive = true)
    {
      UAObject.Interop.UAObjectStopWithDefaultPriorityRange((IntPtr) this.nodeHandle, recursive ? 1 : 0).CheckOutcome();
    }

    public void Stop(byte minPriority, byte maxPriority, bool recursive = true)
    {
      UAObject.Interop.UAObjectStop((IntPtr) this.nodeHandle, minPriority, maxPriority, recursive ? 1 : 0).CheckOutcome();
    }

    public bool IsInstanceOf(NodeId typeNodeId)
    {
      InteropCallResult interopCallResult = UAObject.Interop.UAObjectIsInstanceOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) typeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public CustomEventHandler GetOrCreateCustomEventHandler(
      NodeId eventTypeId,
      Type eventHandlerType,
      Type eventArgsType)
    {
      if (!this.customEventHandlers.ContainsKey(eventTypeId))
      {
        CustomEventHandler customEventHandler = new CustomEventHandler(eventTypeId, eventHandlerType, eventArgsType, (Action<NodeId>) (id => this.SubscribedToCustomEvent(id)), (Action<NodeId>) (id => this.UnsubscribedFromCustomEvent(id)));
        this.customEventHandlers.Add(eventTypeId, customEventHandler);
      }
      return this.customEventHandlers[eventTypeId];
    }

    public event EventHandler<UAEventArgs> UAEvent
    {
      add => this.uaEventHandler.Add(value);
      remove => this.uaEventHandler.Remove(value);
    }

    public void OnEvent(
      IUAObject eventNotifier,
      IUAObjectType eventType,
      IReadOnlyList<object> eventArgs,
      ulong senderId)
    {
      NodeId nodeId = eventType.NodeId;
      UAEventArgs uaEventArgs = new UAEventArgs(eventType, new UAEventArgumentList(eventArgs, eventType.EventArguments), senderId);
      if (!this.customEventHandlers.ContainsKey(nodeId))
        this.uaEventHandler.Raise((object) this, uaEventArgs);
      else
        this.customEventHandlers[nodeId].Raise((object) this, uaEventArgs);
    }

    protected override NodeClass GetNodeClass() => NodeClass.Object;

    protected override void InitializeDerivedNodeClass()
    {
      this.uaEventHandler = new CoreEventHandler<UAEventArgs>((Action) (() => this.SubscribedToUAEvent()), (Action) (() => this.UnsubscribedFromUAEvent()));
      this.customEventRegistrations = new Dictionary<NodeId, IEventRegistration>();
      this.customEventHandlers = new Dictionary<NodeId, CustomEventHandler>();
    }

    protected override void Dispose(bool disposing)
    {
      this.uaEventRegistration?.Dispose();
      this.uaEventRegistration = (IEventRegistration) null;
      IList<IEventRegistration> list = (IList<IEventRegistration>) this.customEventRegistrations.Values.ToList<IEventRegistration>();
      this.customEventRegistrations.Clear();
      foreach (IDisposable disposable in (IEnumerable<IEventRegistration>) list)
        disposable.Dispose();
      this.customEventHandlers.Clear();
      base.Dispose(disposing);
    }

    private void SubscribedToUAEvent()
    {
      this.uaEventRegistration = this.RegisterUAEventObserver((IUAEventObserver) this, ObjectTypes.BaseEventType, 0U);
    }

    private void UnsubscribedFromUAEvent()
    {
      this.uaEventRegistration?.Dispose();
      this.uaEventRegistration = (IEventRegistration) null;
    }

    private void SubscribedToCustomEvent(NodeId eventTypeId)
    {
      if (this.customEventRegistrations.ContainsKey(eventTypeId))
        this.UnsubscribedFromCustomEvent(eventTypeId);
      IEventRegistration eventRegistration = this.RegisterUAEventObserver((IUAEventObserver) this, eventTypeId, 0U);
      this.customEventRegistrations.Add(eventTypeId, eventRegistration);
    }

    private void UnsubscribedFromCustomEvent(NodeId eventTypeId)
    {
      IEventRegistration eventRegistration = this.customEventRegistrations[eventTypeId];
      this.customEventRegistrations.Remove(eventTypeId);
      eventRegistration.Dispose();
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectGetObjectType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectGetPrototype(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectSetPrototype(
        IntPtr nodeHandle,
        IntPtr prototypeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectDispatchUAEvent(
        IntPtr nodeHandle,
        IntPtr eventTypeNodeId,
        IntPtr eventArgs);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethod(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethodArgs(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethodOutputArgs(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr inputArgsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethodNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethodArgsNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr argsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectExecuteMethodOutputArgsNoPermission(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string methodName,
        IntPtr inputArgsPtr,
        out IntPtr outputArgsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectGetBehaviourStartedInfos(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectRegisterUAEventObserver(
        IntPtr nodeHandle,
        IntPtr observerPtr,
        IntPtr eventTypeNodeIdPtr,
        uint affinityId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectIsInstanceOf(
        IntPtr nodeHandle,
        IntPtr variableTypeNodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectStartWithDefaultPriorityRange(
        IntPtr nodeHandle,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectStart(
        IntPtr nodeHandle,
        byte minPriority,
        byte maxPriority,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectStopWithDefaultPriorityRange(
        IntPtr nodeHandle,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAObjectStop(
        IntPtr nodeHandle,
        byte minPriority,
        byte maxPriority,
        int recursive);
    }
  }
}
