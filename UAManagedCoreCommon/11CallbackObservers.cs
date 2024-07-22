// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackVerifyVariableObserver
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
  public sealed class CallbackVerifyVariableObserver : 
    CallbackTransactionVariableObserverBase,
    IVerifyVariableObserver,
    ITransactionVariableObserver,
    ITransactionObserver
  {
    private readonly Func<uint, IUAVariable, bool> verifyVariable;

    public CallbackVerifyVariableObserver(
      Func<uint, IUAVariable, bool> verifyVariable_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null)
      : base(getInputNodes_, getLockType_)
    {
      this.verifyVariable = verifyVariable_ != null ? verifyVariable_ : throw new ArgumentNullException(nameof (verifyVariable_));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool VerifyVariable(uint transactionId, IUAVariable variable)
    {
      return this.verifyVariable(transactionId, variable);
    }
  }
}
