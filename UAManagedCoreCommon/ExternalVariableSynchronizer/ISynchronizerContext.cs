// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.ISynchronizerContext
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
  public interface ISynchronizerContext : IDisposable
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void AddVariables(IEnumerable<IUAVariable> variables, bool startReadingImmediately = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RemoveVariables(IEnumerable<IUAVariable> variables, bool stopReadingImmediately = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void AddVariables(IEnumerable<IndexedVariable> indexedVariables, bool startReadingImmediately = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RemoveVariables(IEnumerable<IndexedVariable> indexedVariables, bool stopReadingImmediately = true);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int Period { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyList<NodeId> AddedVariables { get; }
  }
}
