// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IReferenceObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [EventId(EventType.ReferenceChanged)]
  public interface IReferenceObserver : IEventObserver
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void OnReferenceAdded(
      IUANode sourceNode,
      IUANode targetNode,
      NodeId referenceTypeId,
      ulong senderId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void OnReferenceRemoved(
      IUANode sourceNode,
      IUANode targetNode,
      NodeId referenceTypeId,
      ulong senderId);
  }
}
