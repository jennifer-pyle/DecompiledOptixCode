// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAVariable
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAVariable : UANode, IUAVariable, IUANode, IVariableChangeObserver, IEventObserver
  {
    private IEventRegistration variableChangeEventRegistration;
    private CoreEventHandler<VariableChangeEventArgs> variableChangeEventHandler;

    public IUAVariableType VariableType
    {
      get
      {
        InteropCallResult variableType = UAVariable.Interop.UAVariableGetVariableType(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        variableType.CheckOutcome();
        return (IUAVariableType) variableType.Get<UAVariableType>();
      }
    }

    public NodeId DataType
    {
      set
      {
        UAVariable.Interop.UAVariableSetDataType((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
      }
      get
      {
        InteropCallResult dataType = UAVariable.Interop.UAVariableGetDataType((IntPtr) this.nodeHandle);
        dataType.CheckOutcome();
        return dataType.Get<NodeId>();
      }
    }

    public ValueRank ValueRank
    {
      set
      {
        UAVariable.Interop.UAVariableSetValueRank((IntPtr) this.nodeHandle, (int) value).CheckOutcome();
      }
      get
      {
        InteropCallResult valueRank = UAVariable.Interop.UAVariableGetValueRank((IntPtr) this.nodeHandle);
        valueRank.CheckOutcome();
        return (ValueRank) valueRank.GetInt();
      }
    }

    public uint[] ArrayDimensions
    {
      set
      {
        UAVariable.Interop.UAVariableSetArrayDimensions((IntPtr) this.nodeHandle, ArrayMarshal.ToNative(value)).CheckOutcome();
      }
      get
      {
        InteropCallResult arrayDimensions = UAVariable.Interop.UAVariableGetArrayDimensions((IntPtr) this.nodeHandle);
        arrayDimensions.CheckOutcome();
        return arrayDimensions.GetUIntArray();
      }
    }

    public NodeId ActualDataType
    {
      set
      {
        UAVariable.Interop.UAVariableSetActualDataType((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
      }
      get
      {
        InteropCallResult actualDataType = UAVariable.Interop.UAVariableGetActualDataType((IntPtr) this.nodeHandle);
        actualDataType.CheckOutcome();
        return actualDataType.Get<NodeId>();
      }
    }

    public uint[] ActualArrayDimensions
    {
      set
      {
        UAVariable.Interop.UAVariableSetActualArrayDimensions((IntPtr) this.nodeHandle, ArrayMarshal.ToNative(value)).CheckOutcome();
      }
      get
      {
        InteropCallResult actualArrayDimensions = UAVariable.Interop.UAVariableGetActualArrayDimensions((IntPtr) this.nodeHandle);
        actualArrayDimensions.CheckOutcome();
        return actualArrayDimensions.GetUIntArray();
      }
    }

    public bool CanGet
    {
      get
      {
        InteropCallResult interopCallResult = UAVariable.Interop.UAVariableCanGet(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public bool CanSet
    {
      get
      {
        InteropCallResult interopCallResult = UAVariable.Interop.UAVariableCanSet(ObjectMarshal.ToIntPtr((object) this.nodeHandle));
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public UAValue Value
    {
      get => this.GetConvertibleValue();
      set => this.SetConvertibleValue(value);
    }

    public DataValue DataValue
    {
      set
      {
        UAVariable.Interop.UAVariableSetDataValue((IntPtr) this.nodeHandle, StructMarshal.ToNative(value)).CheckOutcome();
      }
      get
      {
        InteropCallResult dataValue = UAVariable.Interop.UAVariableGetDataValue((IntPtr) this.nodeHandle);
        dataValue.CheckOutcome();
        return (DataValue) dataValue.GetStruct<DataValueInterop>();
      }
    }

    public Quality Quality
    {
      get
      {
        InteropCallResult quality = UAVariable.Interop.UAVariableGetQuality((IntPtr) this.nodeHandle);
        quality.CheckOutcome();
        return (Quality) quality.GetInt();
      }
    }

    public uint StatusCode
    {
      get
      {
        InteropCallResult statusCode = UAVariable.Interop.UAVariableGetStatusCode((IntPtr) this.nodeHandle);
        statusCode.CheckOutcome();
        return statusCode.GetUInt();
      }
    }

    public DateTime SourceTimestamp
    {
      get
      {
        InteropCallResult sourceTimestamp = UAVariable.Interop.UAVariableGetSourceTimestamp((IntPtr) this.nodeHandle);
        sourceTimestamp.CheckOutcome();
        return sourceTimestamp.GetDateTime();
      }
    }

    public DateTime ServerTimestamp
    {
      get
      {
        InteropCallResult serverTimestamp = UAVariable.Interop.UAVariableGetServerTimestamp((IntPtr) this.nodeHandle);
        serverTimestamp.CheckOutcome();
        return serverTimestamp.GetDateTime();
      }
    }

    public IUAVariable Prototype
    {
      get
      {
        InteropCallResult prototype = UAVariable.Interop.UAVariableGetPrototype((IntPtr) this.nodeHandle);
        prototype.CheckOutcome();
        return (IUAVariable) prototype.Get<UAVariable>();
      }
      set
      {
        UAVariable uaVariable = (UAVariable) value;
        IntPtr nodeHandle1 = (IntPtr) this.nodeHandle;
        UANodeSafeHandle nodeHandle2 = uaVariable?.nodeHandle;
        IntPtr prototypeNodeHandle = nodeHandle2 != null ? (IntPtr) nodeHandle2 : IntPtr.Zero;
        UAVariable.Interop.UAVariableSetPrototype(nodeHandle1, prototypeNodeHandle).CheckOutcome();
      }
    }

    public uint GetActualArrayDimension(uint dimension)
    {
      uint[] actualArrayDimensions = this.ActualArrayDimensions;
      if ((long) dimension >= (long) actualArrayDimensions.Length)
        throw new ArgumentException("Dimension argument is not less than the number of actual array dimensions");
      return actualArrayDimensions[(int) dimension];
    }

    public uint GetArrayDimension(uint dimension)
    {
      uint[] arrayDimensions = this.ArrayDimensions;
      if ((long) dimension >= (long) arrayDimensions.Length)
        throw new ArgumentException("Dimension argument is not less than the number of array dimensions");
      return arrayDimensions[(int) dimension];
    }

    public IReadOnlyCollection<BehaviourStartedInfo> GetBehaviourStartedInfos()
    {
      InteropCallResult behaviourStartedInfos1 = UAVariable.Interop.UAVariableGetBehaviourStartedInfos((IntPtr) this.nodeHandle);
      behaviourStartedInfos1.CheckOutcome();
      BehaviourStartedInfoInterop[] structArray = behaviourStartedInfos1.GetStructArray<BehaviourStartedInfoInterop>();
      BehaviourStartedInfo[] behaviourStartedInfos2 = new BehaviourStartedInfo[structArray.Length];
      for (int index = 0; index < structArray.Length; ++index)
        behaviourStartedInfos2[index] = (BehaviourStartedInfo) structArray[index];
      return (IReadOnlyCollection<BehaviourStartedInfo>) behaviourStartedInfos2;
    }

    public UAValue GetConvertibleValue() => new UAValue(this.GetValue());

    public UAValue GetConvertibleValue(params uint[] indexes)
    {
      return new UAValue(this.GetValue(indexes));
    }

    public object GetOldValue()
    {
      InteropCallResult oldValue = UAVariable.Interop.UAVariableGetOldValue((IntPtr) this.nodeHandle);
      oldValue.CheckOutcome();
      return oldValue.Get<object>();
    }

    public object GetOldValue(params uint[] indexes)
    {
      InteropCallResult valueWithIndexes = UAVariable.Interop.UAVariableGetOldValueWithIndexes((IntPtr) this.nodeHandle, ArrayMarshal.ToNative(indexes));
      valueWithIndexes.CheckOutcome();
      return valueWithIndexes.Get<object>();
    }

    public object GetValue()
    {
      InteropCallResult interopCallResult = UAVariable.Interop.UAVariableGetValue((IntPtr) this.nodeHandle);
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<object>();
    }

    public object GetValue(params uint[] indexes)
    {
      InteropCallResult valueWithIndexes = UAVariable.Interop.UAVariableGetValueWithIndexes((IntPtr) this.nodeHandle, ArrayMarshal.ToNative(indexes));
      valueWithIndexes.CheckOutcome();
      return valueWithIndexes.Get<object>();
    }

    public bool IsInstanceOf(NodeId typeNodeId)
    {
      InteropCallResult interopCallResult = UAVariable.Interop.UAVariableIsInstanceOf(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) typeNodeId));
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public UAValue RemoteRead(double timeoutMilliseconds = 30000.0)
    {
      InteropCallResult interopCallResult = UAVariable.Interop.UAVariableRemoteRead((IntPtr) this.nodeHandle, timeoutMilliseconds);
      interopCallResult.CheckOutcome();
      return interopCallResult.Get<UAValue>();
    }

    public void RemoteWrite(UAValue value, double timeoutMilliseconds = 30000.0)
    {
      UAVariable.Interop.UAVariableRemoteWrite((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value), timeoutMilliseconds).CheckOutcome();
    }

    public void SetConvertibleValue(UAValue value) => this.SetValue(value.Value);

    public void SetConvertibleValue(UAValue value, params uint[] indexes)
    {
      this.SetValue(value.Value, indexes);
    }

    public void SetConvertibleValueNoPermissions(UAValue value)
    {
      this.SetValueNoPermissions(value.Value);
    }

    public void SetConvertibleValueNoPermissions(UAValue value, params uint[] indexes)
    {
      this.SetValueNoPermissions(value.Value, indexes);
    }

    public void SetValue(object value)
    {
      UAVariable.Interop.UAVariableSetValue((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr(value)).CheckOutcome();
    }

    public void SetValue(object value, params uint[] indexes)
    {
      UAVariable.Interop.UAVariableSetValueWithIndexes((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr(value), ArrayMarshal.ToNative(indexes)).CheckOutcome();
    }

    public void SetValueNoPermissions(object value)
    {
      UAVariable.Interop.UAVariableSetValueNoPermissions((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr(value)).CheckOutcome();
    }

    public void SetValueNoPermissions(object value, params uint[] indexes)
    {
      UAVariable.Interop.UAVariableSetValueNoPermissionsWithIndexes((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr(value), ArrayMarshal.ToNative(indexes)).CheckOutcome();
    }

    public void Start(bool recursive = true)
    {
      UAVariable.Interop.UAVariableStartWithDefaultPriorityRange((IntPtr) this.nodeHandle, recursive ? 1 : 0).CheckOutcome();
    }

    public void Start(byte minPriority, byte maxPriority, bool recursive = true)
    {
      UAVariable.Interop.UAVariableStart((IntPtr) this.nodeHandle, minPriority, maxPriority, recursive ? 1 : 0).CheckOutcome();
    }

    public void Stop(bool recursive = true)
    {
      UAVariable.Interop.UAVariableStopWithDefaultPriorityRange((IntPtr) this.nodeHandle, recursive ? 1 : 0).CheckOutcome();
    }

    public void Stop(byte minPriority, byte maxPriority, bool recursive = true)
    {
      UAVariable.Interop.UAVariableStop((IntPtr) this.nodeHandle, minPriority, maxPriority, recursive ? 1 : 0).CheckOutcome();
    }

    public event EventHandler<VariableChangeEventArgs> VariableChange
    {
      add => this.variableChangeEventHandler.Add(value);
      remove => this.variableChangeEventHandler.Remove(value);
    }

    public void OnVariableChanged(
      IUAVariable variable,
      UAValue newValue,
      UAValue oldValue,
      uint[] indexes,
      ulong senderId)
    {
      this.variableChangeEventHandler.Raise((object) this, new VariableChangeEventArgs(variable, newValue, oldValue, indexes, senderId));
    }

    protected override NodeClass GetNodeClass() => NodeClass.Variable;

    protected override void InitializeDerivedNodeClass()
    {
      this.variableChangeEventHandler = new CoreEventHandler<VariableChangeEventArgs>((Action) (() => this.SubscribedToVariableChange()), (Action) (() => this.UnsubscribedFromVariableChange()));
    }

    protected override void Dispose(bool disposing)
    {
      this.variableChangeEventRegistration?.Dispose();
      this.variableChangeEventRegistration = (IEventRegistration) null;
      base.Dispose(disposing);
    }

    private void SubscribedToVariableChange()
    {
      this.variableChangeEventRegistration = this.RegisterEventObserver((IEventObserver) this, EventType.VariableValueChanged, 0U);
    }

    private void UnsubscribedFromVariableChange()
    {
      this.variableChangeEventRegistration?.Dispose();
      this.variableChangeEventRegistration = (IEventRegistration) null;
    }

    private new static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetVariableType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetDataType(
        IntPtr nodeHandle,
        IntPtr dataTypeNodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetDataType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetValueRank(
        IntPtr nodeHandle,
        int valueRank);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetValueRank(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetArrayDimensions(
        IntPtr nodeHandle,
        IntPtr arrayDimensionsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetArrayDimensions(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetActualDataType(
        IntPtr nodeHandle,
        IntPtr dataTypeNodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetActualDataType(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetActualArrayDimensions(
        IntPtr nodeHandle,
        IntPtr arrayDimensionsPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetActualArrayDimensions(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableCanGet(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableCanSet(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetDataValue(
        IntPtr nodeHandle,
        IntPtr dataValuePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetDataValue(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetQuality(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetStatusCode(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetSourceTimestamp(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetServerTimestamp(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetPrototype(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetPrototype(
        IntPtr nodeHandle,
        IntPtr prototypeNodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetBehaviourStartedInfos(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableIsInstanceOf(
        IntPtr nodeHandle,
        IntPtr variableTypeNodeIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetValue(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetValueWithIndexes(
        IntPtr nodeHandle,
        IntPtr indexesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetValue(
        IntPtr nodeHandle,
        IntPtr valuePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetValueWithIndexes(
        IntPtr nodeHandle,
        IntPtr valuePtr,
        IntPtr indexesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetOldValue(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableGetOldValueWithIndexes(
        IntPtr nodeHandle,
        IntPtr indexesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetValueNoPermissions(
        IntPtr nodeHandle,
        IntPtr valuePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableSetValueNoPermissionsWithIndexes(
        IntPtr nodeHandle,
        IntPtr valuePtr,
        IntPtr indexesPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableRemoteRead(
        IntPtr nodeHandle,
        double timeoutMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableRemoteWrite(
        IntPtr nodeHandle,
        IntPtr valuePtr,
        double timeoutMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableStartWithDefaultPriorityRange(
        IntPtr nodeHandle,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableStart(
        IntPtr nodeHandle,
        byte minPriority,
        byte maxPriority,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableStopWithDefaultPriorityRange(
        IntPtr nodeHandle,
        int recursive);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAVariableStop(
        IntPtr nodeHandle,
        byte minPriority,
        byte maxPriority,
        int recursive);
    }
  }
}
