// Decompiled with JetBrains decompiler
// Type: UAManagedCore.SynchronizerContextWrapper
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UAManagedCore.ExternalVariableSynchronizer;

#nullable disable
namespace UAManagedCore
{
  public class SynchronizerContextWrapper : ISynchronizerContext, IDisposable
  {
    private UACoreContext context;
    private int periodMilliseconds;
    private bool disposed;

    public SynchronizerContextWrapper(IContext context, TimeSpan interval)
    {
      this.context = context != null ? (UACoreContext) context : throw new ArgumentNullException(nameof (context));
      this.periodMilliseconds = (int) Math.Truncate(interval.TotalMilliseconds);
    }

    public IReadOnlyList<NodeId> AddedVariables
    {
      get
      {
        InteropCallResult borderVariables = SynchronizerContextWrapper.Interop.SynchronizerContextWrapperGetBorderVariables(this.context.nativeContextPtr);
        borderVariables.CheckOutcome();
        return (IReadOnlyList<NodeId>) borderVariables.GetArray<NodeId>();
      }
    }

    public void AddVariables(IEnumerable<IUAVariable> variables, bool startReadingImmediately = true)
    {
      IndexedVariable[] indexedVariableArray = new IndexedVariable[variables.Count<IUAVariable>()];
      int num = 0;
      foreach (IUAVariable variable in variables)
        indexedVariableArray[num++] = new IndexedVariable(variable, Array.Empty<uint>());
      SynchronizerContextWrapper.Interop.SynchronizerContextWrapperAddVariables(this.context.nativeContextPtr, StructMarshal.ToNativeArray((IEnumerable<IndexedVariable>) indexedVariableArray), startReadingImmediately ? 1 : 0, this.periodMilliseconds).CheckOutcome();
    }

    public void AddVariables(
      IEnumerable<IndexedVariable> indexedVariables,
      bool startReadingImmediately = true)
    {
      SynchronizerContextWrapper.Interop.SynchronizerContextWrapperAddIndexedVariables(this.context.nativeContextPtr, StructMarshal.ToNativeArray(indexedVariables), startReadingImmediately ? 1 : 0, this.periodMilliseconds).CheckOutcome();
    }

    public void RemoveVariables(IEnumerable<IUAVariable> variables, bool stopReadingImmediately = true)
    {
      NodeId[] managedArray = new NodeId[variables.Count<IUAVariable>()];
      int num = 0;
      foreach (IUAVariable variable in variables)
        managedArray[num++] = variable.NodeId;
      SynchronizerContextWrapper.Interop.SynchronizerContextWrapperRemoveVariables(this.context.nativeContextPtr, ArrayMarshal.ToNative((object[]) managedArray), stopReadingImmediately ? 1 : 0, this.periodMilliseconds).CheckOutcome();
    }

    public void RemoveVariables(
      IEnumerable<IndexedVariable> indexedVariables,
      bool stopReadingImmediately = true)
    {
      SynchronizerContextWrapper.Interop.SynchronizerContextWrapperRemoveIndexedVariables(this.context.nativeContextPtr, StructMarshal.ToNativeArray(indexedVariables), stopReadingImmediately ? 1 : 0, this.periodMilliseconds).CheckOutcome();
    }

    public int Period => this.periodMilliseconds;

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      this.disposed = true;
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SynchronizerContextWrapperGetBorderVariables(
        IntPtr contextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SynchronizerContextWrapperAddVariables(
        IntPtr contextPtr,
        IntPtr variablesPtr,
        int startReadingImmediately,
        int periodMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SynchronizerContextWrapperAddIndexedVariables(
        IntPtr contextPtr,
        IntPtr variablesPtr,
        int startReadingImmediately,
        int periodMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SynchronizerContextWrapperRemoveVariables(
        IntPtr contextPtr,
        IntPtr variableIdsPtr,
        int startReadingImmediately,
        int periodMilliseconds);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SynchronizerContextWrapperRemoveIndexedVariables(
        IntPtr contextPtr,
        IntPtr variablesPtr,
        int startReadingImmediately,
        int periodMilliseconds);
    }
  }
}
