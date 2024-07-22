// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.TransactionalTaskStationsFailureException
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore.ExternalVariableSynchronizer
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class TransactionalTaskStationsFailureException : CoreException
  {
    public TransactionalTaskStationsFailureException(
      string message,
      string moduleName,
      ushort moduleCode,
      ushort errorCode,
      string stackTrace,
      IReadOnlyList<NodeId> stationsInError,
      IReadOnlyList<NodeId> stationsInTimeout)
      : base(message, moduleName, moduleCode, errorCode, "")
    {
      this.StationsInError = stationsInError;
      this.StationsInTimeout = stationsInTimeout;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IReadOnlyList<NodeId> StationsInError { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IReadOnlyList<NodeId> StationsInTimeout { get; }
  }
}
