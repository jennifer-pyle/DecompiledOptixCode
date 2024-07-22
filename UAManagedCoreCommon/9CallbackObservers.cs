// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackBeforeTryVariableSetObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class CallbackBeforeTryVariableSetObserver : 
    CallbackTransactionVariableObserverBase,
    IBeforeTrySetVariableObserver,
    ITransactionVariableObserver,
    ITransactionObserver
  {
    private readonly CallbackBeforeTryVariableSetObserver.BeforeTrySetVariableDelegate beforeTrySetVariable;

    public CallbackBeforeTryVariableSetObserver(
      CallbackBeforeTryVariableSetObserver.BeforeTrySetVariableDelegate beforeTrySetVariable_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null)
      : base(getInputNodes_, getLockType_)
    {
      this.beforeTrySetVariable = beforeTrySetVariable_ != null ? beforeTrySetVariable_ : throw new ArgumentNullException(nameof (beforeTrySetVariable_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void BeforeTrySetVariable(
      uint transactionId,
      IUAVariable variable,
      ref UAValue outputValue,
      uint[] indexes)
    {
      this.beforeTrySetVariable(transactionId, variable, ref outputValue, indexes);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public delegate void BeforeTrySetVariableDelegate(
      uint transactionId,
      IUAVariable variable,
      ref UAValue outputValue,
      uint[] indexes);
  }
}
