// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.NetCodeExecutor
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UAManagedCore;
using UAManagedCore.Logging;

//#nullable disable
namespace FTOptix.NetLogic
{
  internal class NetCodeExecutor
  {
    private readonly Type classType;
    private readonly object callingObject;
    private readonly IUANode node;
    private readonly long maxExecutionTimeMilliseconds = 2000;

    public NetCodeExecutor(Type classType, object callingObject, IUANode node)
    {
      this.classType = classType;
      this.callingObject = callingObject;
      this.node = node;
    }

    public void Start(Action action)
    {
      this.SetDefaultNamespaceIndexIfNeeded();
      this.InvokeStartMethod(action);
    }

    public object[] ExecuteMethod(string methodName, object[] inputArgs)
    {
      this.SetDefaultNamespaceIndexIfNeeded();
      MethodInfo methodInfo = this.classType.GetMethod(methodName);
      Array.Empty<object>();
      object[] sourceArray = !(methodInfo.ReturnType != typeof (void)) ? new object[((IEnumerable<ParameterInfo>) methodInfo.GetParameters()).Count<ParameterInfo>((Func<ParameterInfo, bool>) (p => p.IsOut))] : new object[1];
      object[] arguments = new object[inputArgs.Length + sourceArray.Length];
      Array.Copy((Array) inputArgs, 0, (Array) arguments, 0, inputArgs.Length);
      Array.Copy((Array) sourceArray, 0, (Array) arguments, inputArgs.Length, sourceArray.Length);
      this.InvokeUserMethod((Action) (() => methodInfo.Invoke(this.callingObject, arguments)), methodName);
      for (int index = 0; index < sourceArray.Length; ++index)
        sourceArray[index] = arguments[inputArgs.Length + index];
      return sourceArray;
    }

    private void SetDefaultNamespaceIndexIfNeeded()
    {
      if (this.node.Context.DefaultNamespaceIndex != NodeId.InvalidNamespaceIndex)
        return;
      this.node.Context.DefaultNamespaceIndex = this.node.NodeId.NamespaceIndex;
    }

    private void InvokeStartMethod(Action action)
    {
      if (this.Invoke(action) < this.maxExecutionTimeMilliseconds)
        return;
      LogManager.CoreLogger.Log(LogLevel.Verbose1, "FTOptix.NetLogic", (ushort) 223, (ushort) 7, "Start method on " + Log.Node(this.node) + " took too long to execute. Long tasks should alternatively be implemented inside a LongRunningTask.", string.Empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\NetCodeExecutor.cs", 84, nameof (InvokeStartMethod));
    }

    private void InvokeUserMethod(Action action, string methodName)
    {
      long num = this.Invoke(action);
      if (this.node.IsDesignTimeScript() || num < this.maxExecutionTimeMilliseconds)
        return;
      ICoreLogger coreLogger = LogManager.CoreLogger;
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(156, 2);
      interpolatedStringHandler.AppendLiteral("'");
      interpolatedStringHandler.AppendFormatted(methodName);
      interpolatedStringHandler.AppendLiteral("' method on ");
      interpolatedStringHandler.AppendFormatted(Log.Node(this.node));
      interpolatedStringHandler.AppendLiteral(" took too long to execute ");
      interpolatedStringHandler.AppendLiteral("and can negatively impact the runtime logic. ");
      interpolatedStringHandler.AppendLiteral("Long tasks should alternatively be implemented inside a LongRunningTask.");
      string stringAndClear = interpolatedStringHandler.ToStringAndClear();
      string empty = string.Empty;
      coreLogger.Log(LogLevel.Verbose1, "FTOptix.NetLogic", (ushort) 223, (ushort) 8, stringAndClear, empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\NetCodeExecutor.cs", 98, nameof (InvokeUserMethod));
    }

    private long Invoke(Action action)
    {
      Stopwatch stopwatch = Stopwatch.StartNew();
      action();
      stopwatch.Stop();
      return stopwatch.ElapsedMilliseconds;
    }
  }
}
