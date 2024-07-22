// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackNodeAttachedObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackNodeAttachedObserver : INodeAttachedObserver, IEventObserver
  {
    private readonly Action<IUANode, IUANode, NodeId, ulong> onNodeAttached;

    public CallbackNodeAttachedObserver(
      Action<IUANode, IUANode, NodeId, ulong> onNodeAttached_)
    {
      this.onNodeAttached = onNodeAttached_ != null ? onNodeAttached_ : throw new ArgumentNullException(nameof (onNodeAttached_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnNodeAttached(
      IUANode parentNode,
      IUANode childNode,
      NodeId referenceTypeId,
      ulong senderId)
    {
      this.onNodeAttached(parentNode, childNode, referenceTypeId, senderId);
    }
  }
}
