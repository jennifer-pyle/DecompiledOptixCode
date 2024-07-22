// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackNodeDetachedObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackNodeDetachedObserver : INodeDetachedObserver, IEventObserver
  {
    private readonly Action<IUANode, IUANode, NodeId, ulong> onNodeDetached;

    public CallbackNodeDetachedObserver(
      Action<IUANode, IUANode, NodeId, ulong> onNodeDetached_)
    {
      this.onNodeDetached = onNodeDetached_ != null ? onNodeDetached_ : throw new ArgumentNullException(nameof (onNodeDetached_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnNodeDetached(
      IUANode parentNode,
      IUANode childNode,
      NodeId referenceTypeId,
      ulong senderId)
    {
      this.onNodeDetached(parentNode, childNode, referenceTypeId, senderId);
    }
  }
}
