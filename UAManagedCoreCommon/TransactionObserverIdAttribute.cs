// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TransactionObserverIdAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class TransactionObserverIdAttribute : Attribute
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static TransactionObserverType GetObserverId(Type transactionObserverType)
    {
      TransactionObserverIdAttribute customAttribute = transactionObserverType.GetCustomAttribute<TransactionObserverIdAttribute>();
      if (customAttribute == null)
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
        interpolatedStringHandler.AppendLiteral("Type ");
        interpolatedStringHandler.AppendFormatted<Type>(transactionObserverType);
        interpolatedStringHandler.AppendLiteral(" has no TransactionObserverIdAttribute");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      return customAttribute.TransactionObserverId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<TransactionObserverType> GetObserverIds(Type transactionObserverType)
    {
      Type baseInterfaceType = typeof (ITransactionObserver);
      if (!transactionObserverType.IsInterface || !baseInterfaceType.IsAssignableFrom(transactionObserverType))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return ((IEnumerable<Type>) transactionObserverType.GetTypeInfo().GetInterfaces()).Where<Type>((Func<Type, bool>) (interfaceType => baseInterfaceType.IsAssignableFrom(interfaceType) && interfaceType != baseInterfaceType && interfaceType != typeof (ITransactionVariableObserver))).Select<Type, TransactionObserverType>(TransactionObserverIdAttribute.\u003C\u003EO.\u003C0\u003E__GetObserverId ?? (TransactionObserverIdAttribute.\u003C\u003EO.\u003C0\u003E__GetObserverId = new Func<Type, TransactionObserverType>(TransactionObserverIdAttribute.GetObserverId)));
      }
      return (IEnumerable<TransactionObserverType>) new List<TransactionObserverType>()
      {
        TransactionObserverIdAttribute.GetObserverId(transactionObserverType)
      };
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static TransactionObserverType GetObserverTypeMask(Type transactionObserverType)
    {
      TransactionObserverType observerTypeMask = (TransactionObserverType) 0;
      if (transactionObserverType.IsInterface)
        return TransactionObserverIdAttribute.GetObserverId(transactionObserverType);
      foreach (TransactionObserverType observerId in TransactionObserverIdAttribute.GetObserverIds(transactionObserverType))
        observerTypeMask |= observerId;
      return observerTypeMask;
    }

    public TransactionObserverIdAttribute(TransactionObserverType transactionObserverId)
    {
      this.TransactionObserverId = transactionObserverId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public TransactionObserverType TransactionObserverId { get; private set; }
  }
}
