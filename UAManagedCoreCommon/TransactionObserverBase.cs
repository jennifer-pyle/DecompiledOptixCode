// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TransactionObserverBase
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class TransactionObserverBase : ITransactionObserver
  {
    private static readonly IUAVariable[] EmptyNodeArray = new IUAVariable[0];

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual IEnumerable<IUAVariable> GetInputNodes(IUAVariable variable)
    {
      return (IEnumerable<IUAVariable>) TransactionObserverBase.EmptyNodeArray;
    }
  }
}
