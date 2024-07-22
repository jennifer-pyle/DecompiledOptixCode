// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAObject
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUAObject : IUANode
  {
    void Start(bool recursive = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Start(byte minPriority, byte maxPriority, bool recursive = true);

    void Stop(bool recursive = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Stop(byte minPriority, byte maxPriority, bool recursive = true);

    IUAObjectType ObjectType { get; }

    bool IsInstanceOf(NodeId typeNodeId);

    void ExecuteMethod(string methodName);

    void ExecuteMethod(string methodName, object[] args);

    void ExecuteMethod(string methodName, object[] inputArgs, out object[] outputArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName, object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName, object[] inputArgs, out object[] outputArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEventRegistration RegisterUAEventObserver(
      IUAEventObserver observer,
      NodeId eventTypeNodeId,
      uint affinityId = 0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void DispatchUAEvent(NodeId eventTypeNodeId, IReadOnlyList<object> eventArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyCollection<BehaviourStartedInfo> GetBehaviourStartedInfos();

    IUAObject Prototype { get; set; }

    event EventHandler<UAEventArgs> UAEvent;
  }
}
