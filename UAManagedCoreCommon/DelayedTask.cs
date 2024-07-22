// Decompiled with JetBrains decompiler
// Type: UAManagedCore.DelayedTask
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Threading.Tasks;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public class DelayedTask : BaseTaskWrapper
  {
    private readonly Action<DelayedTask, object> action;
    private readonly int delayMilliseconds;

    public DelayedTask(Action action, int delayMilliseconds, IUANode executingNode)
      : this((Action<DelayedTask, object>) ((_, __) => action()), (object) null, delayMilliseconds, executingNode)
    {
    }

    public DelayedTask(Action action, TimeSpan delay, IUANode executingNode)
      : this((Action<DelayedTask, object>) ((_, __) => action()), (object) null, (int) delay.TotalMilliseconds, executingNode)
    {
    }

    public DelayedTask(Action<DelayedTask> action, int delayMilliseconds, IUANode executingNode)
      : this((Action<DelayedTask, object>) ((task, _) => action(task)), (object) null, delayMilliseconds, executingNode)
    {
      this.delayMilliseconds = delayMilliseconds;
    }

    public DelayedTask(Action<DelayedTask> action, TimeSpan delay, IUANode executingNode)
      : this((Action<DelayedTask, object>) ((task, _) => action(task)), (object) null, (int) delay.TotalMilliseconds, executingNode)
    {
    }

    public DelayedTask(
      Action<DelayedTask, object> action,
      object actionArgument,
      int delayMilliseconds,
      IUANode executingNode)
      : base(actionArgument, executingNode)
    {
      this.action = action;
      this.delayMilliseconds = delayMilliseconds;
    }

    public DelayedTask(
      Action<DelayedTask, object> action,
      object actionArgument,
      TimeSpan delay,
      IUANode executingNode)
      : this(action, actionArgument, (int) delay.TotalMilliseconds, executingNode)
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
            Task.Delay(this.delayMilliseconds, this.cancellationToken).Wait(this.cancellationToken);
            this.action(this, this.actionArgument);
          }
          catch (OperationCanceledException ex)
          {
          }
          catch (Exception ex)
          {
            LogManager.CoreLogger.Log(LogLevel.Warning, "UAManagedCore", (ushort) 220, (ushort) 0, "Error executing delayed task by " + this.executingNode.BrowseName + ": " + ex?.ToString(), string.Empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\DelayedTask.cs", 61, nameof (CreateUnderlyingTask));
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
