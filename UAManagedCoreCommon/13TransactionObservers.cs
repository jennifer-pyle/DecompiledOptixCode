// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ITransactionMethodObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [TransactionObserverId(TransactionObserverType.TryExecuteMethod)]
  public interface ITransactionMethodObserver : ITransactionObserver
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    bool HandlesMethod(IUANode targetNode, string method);

    [EditorBrowsable(EditorBrowsableState.Never)]
    LockType GetLockType(IUANode targetNode, string method);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerable<IUAVariable> GetInputVariables(IUANode targetNode, string method);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerable<IUAVariable> GetOutputVariables(IUANode targetNode, string method);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerable<UAMethodInfo> GetMethodsToExecute(IUANode targetNode, string method);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void TryExecuteMethod(
      uint transactionId,
      IUANode targetNode,
      string method,
      object[] inputArgs,
      out object[] outputArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void AfterCommitMethod(uint transactionId, IUANode targetNode, string method);
  }
}
