// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteVariableSynchronizer
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UAManagedCore.ExternalVariableSynchronizer;

#nullable disable
namespace UAManagedCore
{
  public sealed class RemoteVariableSynchronizer : IDisposable
  {
    private readonly UACoreContext context;
    private readonly ISynchronizerContext synchronizerContext;
    private readonly List<IndexedVariable> synchronizedVariables;
    private bool disposed;

    public RemoteVariableSynchronizer()
    {
      this.context = ManagedContextStore.Context;
      this.synchronizerContext = this.context.SynchronizerContext;
      this.synchronizedVariables = new List<IndexedVariable>();
    }

    public RemoteVariableSynchronizer(TimeSpan pollingTime)
    {
      this.context = ManagedContextStore.Context;
      this.synchronizerContext = (ISynchronizerContext) new SynchronizerContextWrapper((IContext) this.context, pollingTime);
      this.synchronizedVariables = new List<IndexedVariable>();
    }

    public void Add(IUAVariable variable)
    {
      this.Add((IEnumerable<IUAVariable>) new IUAVariable[1]
      {
        variable
      });
    }

    public void Add(RemoteVariable variable)
    {
      this.Add((IEnumerable<RemoteVariable>) new RemoteVariable[1]
      {
        variable
      });
    }

    public void Add(IEnumerable<IUAVariable> variables)
    {
      this.synchronizerContext.AddVariables(variables);
      this.AddToSynchronizedVariables(this.GetIndexedVariables(variables));
    }

    public void Add(IEnumerable<RemoteVariable> variables)
    {
      List<IndexedVariable> indexedVariables = this.GetIndexedVariables(variables);
      this.synchronizerContext.AddVariables((IEnumerable<IndexedVariable>) indexedVariables);
      this.AddToSynchronizedVariables(indexedVariables);
    }

    public void Remove(IUAVariable variable)
    {
      this.Remove((IEnumerable<IUAVariable>) new IUAVariable[1]
      {
        variable
      });
    }

    public void Remove(RemoteVariable variable)
    {
      this.Remove((IEnumerable<RemoteVariable>) new RemoteVariable[1]
      {
        variable
      });
    }

    public void Remove(IEnumerable<IUAVariable> variables)
    {
      this.synchronizerContext.RemoveVariables(variables);
      this.RemoveFromSynchronizedVariables(this.GetIndexedVariables(variables));
    }

    public void Remove(IEnumerable<RemoteVariable> variables)
    {
      List<IndexedVariable> indexedVariables = this.GetIndexedVariables(variables);
      this.synchronizerContext.RemoveVariables((IEnumerable<IndexedVariable>) indexedVariables);
      this.RemoveFromSynchronizedVariables(indexedVariables);
    }

    public IReadOnlyList<RemoteVariable> SynchronizedVariables
    {
      get
      {
        List<RemoteVariable> synchronizedVariables = new List<RemoteVariable>(this.synchronizedVariables.Count);
        foreach (IndexedVariable synchronizedVariable in this.synchronizedVariables)
          synchronizedVariables.Add(new RemoteVariable(synchronizedVariable.Variable, synchronizedVariable.Indexes));
        return (IReadOnlyList<RemoteVariable>) synchronizedVariables;
      }
    }

    public void Dispose() => this.Dispose(true);

    private void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        if (this.synchronizedVariables.Count > 0)
        {
          this.synchronizerContext.RemoveVariables((IEnumerable<IndexedVariable>) this.synchronizedVariables);
          this.synchronizedVariables.Clear();
        }
        if (this.synchronizerContext != this.context.SynchronizerContext)
          this.synchronizerContext.Dispose();
      }
      this.disposed = true;
    }

    private List<IndexedVariable> GetIndexedVariables(IEnumerable<IUAVariable> variables)
    {
      List<IndexedVariable> indexedVariables = new List<IndexedVariable>(variables.Count<IUAVariable>());
      foreach (IUAVariable variable in variables)
        indexedVariables.Add(new IndexedVariable(variable, Array.Empty<uint>()));
      return indexedVariables;
    }

    private List<IndexedVariable> GetIndexedVariables(IEnumerable<RemoteVariable> variables)
    {
      List<IndexedVariable> indexedVariables = new List<IndexedVariable>(variables.Count<RemoteVariable>());
      foreach (RemoteVariable variable in variables)
        indexedVariables.Add(new IndexedVariable(variable.Variable, variable.Index));
      return indexedVariables;
    }

    private void AddToSynchronizedVariables(List<IndexedVariable> indexedVariables)
    {
      foreach (IndexedVariable indexedVariable in indexedVariables)
      {
        if (this.synchronizedVariables.Contains(indexedVariable))
          throw new InvalidOperationException(Log.Node((IUANode) indexedVariable.Variable) + " variable has already been added to the remote variable synchronizer");
        this.synchronizedVariables.Add(indexedVariable);
      }
    }

    private void RemoveFromSynchronizedVariables(List<IndexedVariable> indexedVariables)
    {
      foreach (IndexedVariable indexedVariable in indexedVariables)
      {
        if (!this.synchronizedVariables.Contains(indexedVariable))
          throw new InvalidOperationException(Log.Node((IUANode) indexedVariable.Variable) + " variable is no longer being synchronized by the remote variable synchronizer");
        this.synchronizedVariables.Remove(indexedVariable);
      }
    }
  }
}
