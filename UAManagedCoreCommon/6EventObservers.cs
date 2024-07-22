// Decompiled with JetBrains decompiler
// Type: UAManagedCore.INodeDetachedObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [EventId(EventType.NodeDetached)]
  public interface INodeDetachedObserver : IEventObserver
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void OnNodeDetached(
      IUANode parentNode,
      IUANode childNode,
      NodeId referenceTypeId,
      ulong senderId);
  }
}
