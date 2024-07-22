// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackAttributeChangeObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackAttributeChangeObserver : IAttributeChangeObserver, IEventObserver
  {
    private readonly Action<IUANode, AttributeId, UAValue, UAValue, ulong> onAttributeChanged;

    public CallbackAttributeChangeObserver(
      Action<IUANode, AttributeId, UAValue, UAValue, ulong> onAttributeChanged_)
    {
      this.onAttributeChanged = onAttributeChanged_ != null ? onAttributeChanged_ : throw new ArgumentNullException(nameof (onAttributeChanged_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnAttributeChanged(
      IUANode node,
      AttributeId attributeId,
      UAValue newValue,
      UAValue oldValue,
      ulong senderId)
    {
      this.onAttributeChanged(node, attributeId, newValue, oldValue, senderId);
    }
  }
}
