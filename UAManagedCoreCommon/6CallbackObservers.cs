// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CallbackTransactionVariableObserverBase
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class CallbackTransactionVariableObserverBase : ITransactionObserver
  {
    private readonly Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes;
    private readonly Func<IUAVariable, LockType> getLockType;

    protected CallbackTransactionVariableObserverBase(
      Func<IUAVariable, IEnumerable<IUAVariable>> getInputNodes_,
      Func<IUAVariable, LockType> getLockType_)
    {
      this.getInputNodes = getInputNodes_ ?? (Func<IUAVariable, IEnumerable<IUAVariable>>) (x => Enumerable.Empty<IUAVariable>());
      this.getLockType = getLockType_ ?? (Func<IUAVariable, LockType>) (x => LockType.Shared);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IEnumerable<IUAVariable> GetInputNodes(IUAVariable variable)
    {
      return this.getInputNodes(variable);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public LockType GetLockType(IUAVariable variable) => this.getLockType(variable);
  }
}
