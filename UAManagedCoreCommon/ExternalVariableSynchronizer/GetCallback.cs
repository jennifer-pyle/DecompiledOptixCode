// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.GetCallback
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore.ExternalVariableSynchronizer
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate void GetCallback(
    ITransactionalGetTask getTask,
    TransactionalTaskResultCode resultCode,
    IReadOnlyList<Tuple<IUAVariable, object>> results,
    Exception exception);
}
