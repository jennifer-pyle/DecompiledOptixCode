// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.BaseUserDefinedTypeBehavior
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;
using System.IO;
using System.Reflection;
using UAManagedCore;
using UAManagedCore.Logging;

//#nullable disable
namespace FTOptix.NetLogic
{
  public abstract class BaseUserDefinedTypeBehavior : IExecutableBehaviour, IBehaviour
  {
    private readonly IUANode node;
    private Type userBehaviorType;
    private BaseNetBehavior behaviorInstance;

    public BaseUserDefinedTypeBehavior(IUANode node) => this.node = node;

    public void Start()
    {
      if (!this.LoadLogicFromNetAssembly())
        return;
      this.behaviorInstance.Initialize(this.node);
      try
      {
        new NetCodeExecutor(this.userBehaviorType, (object) this.behaviorInstance, this.node).Start((Action) (() => this.behaviorInstance.Start()));
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 3, "Error executing method Start() on node " + Log.Node(this.node) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.Start()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 30, nameof (Start));
      }
    }

    public void Stop()
    {
      try
      {
        this.behaviorInstance?.Stop();
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 4, "Error executing method Stop() on node " + Log.Node(this.node) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.Stop()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 46, nameof (Stop));
      }
      try
      {
        this.behaviorInstance?.Dispose();
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 6, "Error disposing behavior on node " + Log.Node(this.node) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.Stop()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 59, nameof (Stop));
      }
    }

    public bool ExecuteMethod(
      IUANode targetNode,
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      outputArgs = Array.Empty<object>();
      try
      {
        NetCodeExecutor netCodeExecutor = new NetCodeExecutor(this.userBehaviorType, (object) this.behaviorInstance, this.node);
        outputArgs = netCodeExecutor.ExecuteMethod(methodName, inputArgs);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 2, "Error invoking method '" + methodName + "' on node " + Log.Node(this.node) + ": " + Environment.NewLine + (ex is TargetInvocationException ? (object) ex.InnerException : (object) ex)?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.ExecuteMethod()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 78, nameof (ExecuteMethod));
        return true;
      }
      return true;
    }

    private bool LoadLogicFromNetAssembly()
    {
      try
      {
        string typeBrowseName = this.GetTypeBrowseName();
        if (typeBrowseName == null)
          return false;
        int namespaceIndex = this.node.NodeId.NamespaceIndex;
        string str = Path.Combine(this.node.Context.GetProjectDirectory(namespaceIndex), "NetSolution", "bin", this.node.Context.GetNamespaceUri(namespaceIndex) + ".dll");
        if (!File.Exists(str))
        {
          LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 5, "Unable to find the .NET assembly DLL file. Please make sure that the C# code in the NetSolution properly compiles before running the project.", "FTOptix.NetLogic.UserDefinedTypeBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 105, nameof (LoadLogicFromNetAssembly));
          return false;
        }
        this.userBehaviorType = Assembly.LoadFrom(str).GetType(typeBrowseName + "Behavior", true);
        this.behaviorInstance = (BaseNetBehavior) Activator.CreateInstance(this.userBehaviorType);
      }
      catch (TypeLoadException ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 1, "Error loading user-defined behavior from .NET assembly: " + ex?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 120, nameof (LoadLogicFromNetAssembly));
        return false;
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 1, "Error loading user-defined behavior from .NET assembly: " + ex?.ToString(), "FTOptix.NetLogic.UserDefinedTypeBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\BaseUserDefinedTypeBehavior.cs", 128, nameof (LoadLogicFromNetAssembly));
        return false;
      }
      return true;
    }

    private string GetTypeBrowseName()
    {
      if (this.node is IUAObject node1)
        return node1.ObjectType.BrowseName;
      return this.node is IUAVariable node2 ? node2.VariableType.BrowseName : (string) null;
    }
  }
}
