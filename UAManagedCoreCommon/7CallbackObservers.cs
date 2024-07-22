// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackBeforeGetVariableObserver
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
  public sealed class CallbackBeforeGetVariableObserver : 
    CallbackTransactionVariableObserverBase,
    IBeforeGetVariableObserver,
    ITransactionVariableObserver,
    ITransactionObserver
  {
    private readonly CallbackBeforeGetVariableObserver.BeforeGetVariableDelegate beforeGetVariable;

    public CallbackBeforeGetVariableObserver(
      CallbackBeforeGetVariableObserver.BeforeGetVariableDelegate beforeGetVariable_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null)
      : base(getInputNodes_, getLockType_)
    {
      this.beforeGetVariable = beforeGetVariable_ != null ? beforeGetVariable_ : throw new ArgumentNullException(nameof (beforeGetVariable_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void BeforeGetVariable(
      uint transactionid,
      IUAVariable variable,
      ref UAValue outputValue,
      uint[] indexes)
    {
      this.beforeGetVariable(transactionid, variable, ref outputValue, indexes);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public delegate void BeforeGetVariableDelegate(
      uint transactionid,
      IUAVariable variable,
      ref UAValue outputValue,
      uint[] indexes);
  }
}
