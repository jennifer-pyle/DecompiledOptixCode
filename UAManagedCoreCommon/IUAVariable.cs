// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAVariable
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUAVariable : IUANode
  {
    void Start(bool recursive = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Start(byte minPriority, byte maxPriority, bool recursive = true);

    void Stop(bool recursive = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Stop(byte minPriority, byte maxPriority, bool recursive = true);

    IUAVariableType VariableType { get; }

    bool IsInstanceOf(NodeId typeNodeId);

    NodeId DataType { get; set; }

    ValueRank ValueRank { get; set; }

    uint[] ArrayDimensions { get; set; }

    NodeId ActualDataType { get; set; }

    uint[] ActualArrayDimensions { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool CanGet { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool CanSet { get; }

    UAValue Value { get; set; }

    DataValue DataValue { get; set; }

    Quality Quality { get; }

    uint StatusCode { get; }

    DateTime SourceTimestamp { get; }

    DateTime ServerTimestamp { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    object GetValue();

    [EditorBrowsable(EditorBrowsableState.Never)]
    object GetValue(params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValue(object value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValue(object value, params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValueNoPermissions(object value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetValueNoPermissions(object value, params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    UAValue GetConvertibleValue();

    [EditorBrowsable(EditorBrowsableState.Never)]
    UAValue GetConvertibleValue(params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetConvertibleValue(UAValue value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetConvertibleValue(UAValue value, params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetConvertibleValueNoPermissions(UAValue value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetConvertibleValueNoPermissions(UAValue value, params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    object GetOldValue();

    [EditorBrowsable(EditorBrowsableState.Never)]
    object GetOldValue(params uint[] indexes);

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint GetArrayDimension(uint dimension);

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint GetActualArrayDimension(uint dimension);

    IUAVariable Prototype { get; set; }

    UAValue RemoteRead(double timeoutMilliseconds = 30000.0);

    void RemoteWrite(UAValue value, double timeoutMilliseconds = 30000.0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyCollection<BehaviourStartedInfo> GetBehaviourStartedInfos();

    event EventHandler<VariableChangeEventArgs> VariableChange;
  }
}
