// Decompiled with JetBrains decompiler
// Type: UAManagedCore.LongRunningTask
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Threading.Tasks;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public class LongRunningTask : BaseTaskWrapper
  {
    private readonly Action<LongRunningTask, object> action;

    public LongRunningTask(Action action, IUANode executingNode)
      : this((Action<LongRunningTask, object>) ((_, __) => action()), (object) null, executingNode)
    {
    }

    public LongRunningTask(Action<LongRunningTask> action, IUANode executingNode)
      : this((Action<LongRunningTask, object>) ((task, _) => action(task)), (object) null, executingNode)
    {
    }

    public LongRunningTask(
      Action<LongRunningTask, object> action,
      object actionArgument,
      IUANode executingNode)
      : base(actionArgument, executingNode)
    {
      this.action = action;
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
            this.action(this, this.actionArgument);
          }
          catch (OperationCanceledException ex)
          {
          }
          catch (Exception ex)
          {
            LogManager.CoreLogger.Log(LogLevel.Warning, "UAManagedCore", (ushort) 220, (ushort) 0, "Error executing long-running task by " + this.executingNode.BrowseName + ": " + ex?.ToString(), string.Empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\LongRunningTask.cs", 42, nameof (CreateUnderlyingTask));
          }
          finally
          {
            this.isRunning = false;
          }
        }
      }), TaskCreationOptions.LongRunning);
    }
  }
}
