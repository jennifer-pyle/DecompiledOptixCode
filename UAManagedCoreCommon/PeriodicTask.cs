// Decompiled with JetBrains decompiler
// Type: UAManagedCore.PeriodicTask
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Threading.Tasks;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public class PeriodicTask : BaseTaskWrapper
  {
    private readonly Action<PeriodicTask, object> action;
    private readonly int periodMilliseconds;

    public PeriodicTask(Action action, int periodMilliseconds, IUANode executingNode)
      : this((Action<PeriodicTask, object>) ((_, __) => action()), (object) null, periodMilliseconds, executingNode)
    {
    }

    public PeriodicTask(Action action, TimeSpan period, IUANode executingNode)
      : this((Action<PeriodicTask, object>) ((_, __) => action()), (object) null, (int) period.TotalMilliseconds, executingNode)
    {
    }

    public PeriodicTask(Action<PeriodicTask> action, int periodMilliseconds, IUANode executingNode)
      : this((Action<PeriodicTask, object>) ((task, _) => action(task)), (object) null, periodMilliseconds, executingNode)
    {
    }

    public PeriodicTask(Action<PeriodicTask> action, TimeSpan period, IUANode executingNode)
      : this((Action<PeriodicTask, object>) ((task, _) => action(task)), (object) null, (int) period.TotalMilliseconds, executingNode)
    {
    }

    public PeriodicTask(
      Action<PeriodicTask, object> action,
      object actionArgument,
      int periodMilliseconds,
      IUANode executingNode)
      : base(actionArgument, executingNode)
    {
      this.action = action;
      this.periodMilliseconds = periodMilliseconds;
    }

    public PeriodicTask(
      Action<PeriodicTask, object> action,
      object actionArgument,
      TimeSpan period,
      IUANode executingNode)
      : this(action, actionArgument, (int) period.TotalMilliseconds, executingNode)
    {
    }

    protected override Task CreateUnderlyingTask()
    {
      return Task.Factory.StartNew((Action) (() =>
      {
        using (this.executingNode.Context.Sessions.ImpersonateSessionTemporary(this.sessionHandler))
        {
          this.SetDefaultNamespaceIndexIfNeeded();
          try
          {
            while (this.isRunning && !this.cancellationToken.IsCancellationRequested)
            {
              this.action(this, this.actionArgument);
              Task.Delay(this.periodMilliseconds, this.cancellationToken).Wait(this.cancellationToken);
            }
          }
          catch (OperationCanceledException ex)
          {
          }
          catch (Exception ex)
          {
            LogManager.CoreLogger.Log(LogLevel.Warning, "UAManagedCore", (ushort) 220, (ushort) 0, "Error running periodic task by " + this.executingNode.BrowseName + ": " + ex?.ToString(), string.Empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\PeriodicTask.cs", 66, nameof (CreateUnderlyingTask));
          }
          finally
          {
            this.isRunning = false;
          }
        }
      }), this.cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
    }
  }
}
