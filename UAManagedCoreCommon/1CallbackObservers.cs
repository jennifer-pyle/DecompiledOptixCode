// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackReferenceObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackReferenceObserver : IReferenceObserver, IEventObserver
  {
    private readonly Action<IUANode, IUANode, NodeId, ulong> onReferenceAddedAction;
    private readonly Action<IUANode, IUANode, NodeId, ulong> onReferenceRemovedAction;

    public CallbackReferenceObserver(
      Action<IUANode, IUANode, NodeId, ulong> onReferenceAddAction_,
      Action<IUANode, IUANode, NodeId, ulong> onReferenceRemoveAction_)
    {
      if (onReferenceAddAction_ == null)
        throw new ArgumentNullException(nameof (onReferenceAddAction_));
      if (onReferenceRemoveAction_ == null)
        throw new ArgumentNullException(nameof (onReferenceRemoveAction_));
      this.onReferenceAddedAction = onReferenceAddAction_;
      this.onReferenceRemovedAction = onReferenceRemoveAction_;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnReferenceAdded(
      IUANode sourceNode,
      IUANode targetNode,
      NodeId referenceTypeId,
      ulong senderId)
    {
      this.onReferenceAddedAction(sourceNode, targetNode, referenceTypeId, senderId);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnReferenceRemoved(
      IUANode sourceNode,
      IUANode targetNode,
      NodeId referenceTypeId,
      ulong senderId)
    {
      this.onReferenceRemovedAction(sourceNode, targetNode, referenceTypeId, senderId);
    }
  }
}
