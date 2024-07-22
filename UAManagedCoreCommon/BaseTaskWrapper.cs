// Decompiled with JetBrains decompiler
// Type: UAManagedCore.BaseTaskWrapper
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace UAManagedCore
{
  public abstract class BaseTaskWrapper : IDisposable
  {
    protected readonly 
    #nullable disable
    IUANode executingNode;
    protected readonly object actionArgument;
    protected bool isRunning;
    protected CancellationTokenSource cancellationTokenSource;
    protected CancellationToken cancellationToken;
    protected ISessionHandler sessionHandler;
    protected Task underlyingTask;
    private bool disposedValue;

    protected BaseTaskWrapper(object actionArgument, IUANode executingNode)
    {
      this.actionArgument = actionArgument;
      this.executingNode = executingNode;
      this.isRunning = false;
    }

    public void Dispose() => this.Dispose(true);

    public void Start()
    {
      this.isRunning = !this.isRunning ? true : throw new InvalidOperationException("Task is already running");
      this.cancellationTokenSource = new CancellationTokenSource();
      this.cancellationToken = this.cancellationTokenSource.Token;
      this.sessionHandler = this.executingNode.Context.Sessions.CurrentSessionHandler;
      this.underlyingTask = this.CreateUnderlyingTask();
    }

    public void Cancel()
    {
      if (!this.isRunning)
        throw new InvalidOperationException("Task is not running");
      this.cancellationTokenSource?.Cancel();
      if (this.underlyingTask == null)
        return;
      int? currentId = Task.CurrentId;
      int id = this.underlyingTask.Id;
      if (currentId.GetValueOrDefault() == id & currentId.HasValue)
        return;
      this.AwaitUnderlyingTask();
    }

    public bool IsCancellationRequested => this.cancellationToken.IsCancellationRequested;

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposedValue)
        return;
      if (disposing)
      {
        if (this.isRunning && !this.cancellationToken.IsCancellationRequested)
          this.cancellationTokenSource?.Cancel();
        if (this.underlyingTask != null)
        {
          int? currentId = Task.CurrentId;
          int id = this.underlyingTask.Id;
          if (!(currentId.GetValueOrDefault() == id & currentId.HasValue))
            this.AwaitUnderlyingTask();
        }
      }
      this.disposedValue = true;
    }

    protected abstract Task CreateUnderlyingTask();

    protected void AwaitUnderlyingTask()
    {
      if (this.underlyingTask == null)
        return;
      this.isRunning = false;
      Task.Run((Func<Task>) (async () =>
      {
        try
        {
          await this.underlyingTask;
        }
        catch (OperationCanceledException ex)
        {
        }
      })).Wait();
      this.underlyingTask = (Task) null;
      this.cancellationToken = CancellationToken.None;
      this.cancellationTokenSource?.Dispose();
      this.cancellationTokenSource = (CancellationTokenSource) null;
      this.sessionHandler?.Dispose();
      this.sessionHandler = (ISessionHandler) null;
    }

    protected void SetDefaultNamespaceIndexIfNeeded()
    {
      if (this.executingNode.Context.DefaultNamespaceIndex != NodeId.InvalidNamespaceIndex)
        return;
      this.executingNode.Context.DefaultNamespaceIndex = this.executingNode.NodeId.NamespaceIndex;
    }
  }
}
