// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackVariableChangeObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackVariableChangeObserver : IVariableChangeObserver, IEventObserver
  {
    private readonly Action<IUAVariable, UAValue, UAValue, uint[], ulong> variableChange;

    public CallbackVariableChangeObserver(
      Action<IUAVariable, UAValue, UAValue, uint[], ulong> variableChange_)
    {
      this.variableChange = variableChange_ != null ? variableChange_ : throw new ArgumentNullException(nameof (variableChange_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void OnVariableChanged(
      IUAVariable variable,
      UAValue newValue,
      UAValue oldValue,
      uint[] indexes,
      ulong senderId)
    {
      this.variableChange(variable, newValue, oldValue, indexes, senderId);
    }
  }
}
