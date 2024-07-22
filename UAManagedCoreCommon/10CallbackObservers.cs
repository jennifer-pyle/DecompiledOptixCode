// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackAfterTrySetVariableObserver
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
  public sealed class CallbackAfterTrySetVariableObserver : 
    CallbackTransactionVariableObserverBase,
    IAfterTrySetVariableObserver,
    ITransactionVariableObserver,
    ITransactionObserver
  {
    private readonly Func<IUAVariable, OutputVariables> getOutputNodes;
    private readonly Func<IUAVariable, MethodsToExecute> getMethodsToExecute;
    private readonly Action<uint, IUAVariable, uint[]> afterTrySetVariable;
    private readonly Action<uint> executeAfterTrySet;

    public CallbackAfterTrySetVariableObserver(
      Action<uint, IUAVariable, uint[]> afterTrySetVariable_,
      Action<uint> executeAfterTrySet_,
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_ = null,
      Func<IUAVariable, LockType> getLockType_ = null,
      Func<IUAVariable, OutputVariables> getOutputNodes_ = null,
      Func<IUAVariable, MethodsToExecute> getMethodsToExecute_ = null)
      : base(getInputNodes_, getLockType_)
    {
      if (afterTrySetVariable_ == null)
        throw new ArgumentNullException(nameof (afterTrySetVariable_));
      if (executeAfterTrySet_ == null)
        throw new ArgumentNullException(nameof (executeAfterTrySet_));
      this.getOutputNodes = getOutputNodes_;
      this.getMethodsToExecute = getMethodsToExecute_;
      this.afterTrySetVariable = afterTrySetVariable_;
      this.executeAfterTrySet = executeAfterTrySet_;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public OutputVariables GetOutputNodes(IUAVariable variable)
    {
      return this.getOutputNodes == null ? OutputVariables.WithNoAction : this.getOutputNodes(variable);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public MethodsToExecute GetMethodsToExecute(IUAVariable variable)
    {
      return this.getMethodsToExecute == null ? MethodsToExecute.WithNoAction : this.getMethodsToExecute(variable);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AfterTrySetVariable(uint transactionId, IUAVariable variable, uint[] indexes)
    {
      this.afterTrySetVariable(transactionId, variable, indexes);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void ExecuteAfterTrySet(uint transactionId) => this.executeAfterTrySet(transactionId);
  }
}
