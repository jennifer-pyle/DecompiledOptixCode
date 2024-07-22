// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackAfterCommitObserver
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
  public sealed class CallbackAfterCommitObserver : 
    CallbackTransactionVariableObserverBase,
    IAfterCommitTransactionObserver,
    ITransactionObserver,
    IAfterCommitVariableObserver,
    ITransactionVariableObserver
  {
    private readonly Action<uint> afterCommitTransaction;
    private readonly Action<uint, IUAVariable> afterCommitVariable;

    public CallbackAfterCommitObserver(
      Action<uint> afterCommitTransaction_,
      Action<uint, IUAVariable> afterCommitVariable_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null)
      : base(getInputNodes_, getLockType_)
    {
      if (afterCommitTransaction_ == null)
        throw new ArgumentNullException(nameof (afterCommitTransaction_));
      if (afterCommitVariable_ == null)
        throw new ArgumentNullException(nameof (afterCommitVariable_));
      this.afterCommitTransaction = afterCommitTransaction_;
      this.afterCommitVariable = afterCommitVariable_;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AfterCommitTransaction(uint transactionId)
    {
      this.afterCommitTransaction(transactionId);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AfterCommitVariable(uint transactionId, IUAVariable variable)
    {
      this.afterCommitVariable(transactionId, variable);
    }
  }
}
