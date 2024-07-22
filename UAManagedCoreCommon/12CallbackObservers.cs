// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackBeforeCommitObserver
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
  public sealed class CallbackBeforeCommitObserver : 
    CallbackTransactionVariableObserverBase,
    IBeforeCommitTransactionObserver,
    ITransactionObserver,
    IBeforeCommitVariableObserver,
    ITransactionVariableObserver
  {
    private readonly Func<uint, bool> beforeCommitTransaction;
    private readonly Func<uint, IUAVariable, bool> beforeCommitVariable;

    public CallbackBeforeCommitObserver(
      Func<uint, bool> beforeCommitTransaction_,
      Func<uint, IUAVariable, bool> beforeCommitVariable_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null)
      : base(getInputNodes_, getLockType_)
    {
      if (beforeCommitTransaction_ == null)
        throw new ArgumentNullException(nameof (beforeCommitTransaction_));
      if (beforeCommitVariable_ == null)
        throw new ArgumentNullException(nameof (beforeCommitVariable_));
      this.beforeCommitTransaction = beforeCommitTransaction_;
      this.beforeCommitVariable = beforeCommitVariable_;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool BeforeCommitTransaction(uint transactionId)
    {
      return this.beforeCommitTransaction(transactionId);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool BeforeCommitVariable(uint transactionId, IUAVariable variable)
    {
      return this.beforeCommitVariable(transactionId, variable);
    }
  }
}
