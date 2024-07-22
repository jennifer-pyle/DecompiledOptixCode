// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.LogicBehavior
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UAManagedCore;
using UAManagedCore.Logging;

//#nullable disable
namespace FTOptix.NetLogic
{
  [Behaviour("df68f93b80294aaea09301182ffdf991")]
  public class LogicBehavior : IExecutableBehaviour, IBehaviour
  {
    private readonly NetLogicObject logicObject;
    private Type userLogicType;
    private BaseNetLogic userLogic;
    private static readonly object assemblyLock = new object();
    private static Assembly alreadyLoadedAssembly = (Assembly) null;

    public LogicBehavior(NetLogicObject logicObject) => this.logicObject = logicObject;

    public void Start()
    {
      if (this.logicObject.IsDesignTimeScript || !this.LoadLogicFromNetAssembly())
        return;
      this.userLogic.Initialize(this.logicObject);
      try
      {
        new NetCodeExecutor(this.userLogicType, (object) this.userLogic, (IUANode) this.logicObject).Start((Action) (() => this.userLogic.Start()));
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 3, "Error executing method Start() in NetLogic " + Log.Node((IUANode) this.logicObject) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.LogicBehavior.Start()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 35, nameof (Start));
      }
    }

    public void Stop()
    {
      try
      {
        this.userLogic?.Stop();
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 4, "Error executing method Stop() in NetLogic " + Log.Node((IUANode) this.logicObject) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.LogicBehavior.Stop()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 51, nameof (Stop));
      }
      try
      {
        this.userLogic?.Dispose();
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 6, "Error disposing NetLogic " + Log.Node((IUANode) this.logicObject) + ": " + Environment.NewLine + ex?.ToString(), "FTOptix.NetLogic.LogicBehavior.Stop()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 64, nameof (Stop));
      }
      lock (LogicBehavior.assemblyLock)
      {
        LogicBehavior.alreadyLoadedAssembly = (Assembly) null;
        this.userLogicType = (Type) null;
        this.userLogic = (BaseNetLogic) null;
      }
    }

    public bool ExecuteMethod(
      IUANode targetNode,
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      outputArgs = Array.Empty<object>();
      if (this.userLogic == null && this.logicObject.IsDesignTimeScript)
      {
        lock (LogicBehavior.assemblyLock)
        {
          if (!this.LoadLogicFromNetAssembly())
            return false;
        }
        this.userLogic.Initialize(this.logicObject);
      }
      try
      {
        NetCodeExecutor netCodeExecutor = new NetCodeExecutor(this.userLogicType, (object) this.userLogic, (IUANode) this.logicObject);
        outputArgs = netCodeExecutor.ExecuteMethod(methodName, inputArgs);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Warning, "FTOptix.NetLogic", (ushort) 223, (ushort) 2, "Error invoking method '" + methodName + "' in NetLogic " + Log.Node((IUANode) this.logicObject) + ": " + Environment.NewLine + (ex is TargetInvocationException ? (object) ex.InnerException : (object) ex)?.ToString(), "FTOptix.NetLogic.LogicBehavior.ExecuteMethod()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 102, nameof (ExecuteMethod));
        return true;
      }
      finally
      {
        if (this.logicObject.IsDesignTimeScript)
        {
          lock (LogicBehavior.assemblyLock)
          {
            LogicBehavior.alreadyLoadedAssembly = (Assembly) null;
            this.userLogicType = (Type) null;
            this.userLogic = (BaseNetLogic) null;
          }
        }
      }
      return true;
    }

    private bool LoadLogicFromNetAssembly()
    {
      try
      {
        int namespaceIndex = this.logicObject.NodeId.NamespaceIndex;
        string str = Path.Combine(this.logicObject.Context.GetProjectDirectory(namespaceIndex), "NetSolution", "bin", this.logicObject.Context.GetNamespaceUri(namespaceIndex) + ".dll");
        Assembly assembly = (Assembly) null;
        if (!File.Exists(str))
        {
          LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 5, "Unable to find the .NET assembly DLL file. Please make sure that the C# code in the NetSolution properly compiles before running the project.", "FTOptix.NetLogic.LogicBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 142, nameof (LoadLogicFromNetAssembly));
          return false;
        }
        lock (LogicBehavior.assemblyLock)
          assembly = !(LogicBehavior.alreadyLoadedAssembly != (Assembly) null) ? (this.logicObject.IsDesignTimeScript ? Assembly.Load(File.ReadAllBytes(str)) : Assembly.LoadFrom(str)) : LogicBehavior.alreadyLoadedAssembly;
        if (!assembly.ExportedTypes.Any<Type>((Func<Type, bool>) (t => t.Name == this.logicObject.BrowseName)))
        {
          LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 9, "User-defined logic type '" + this.logicObject.BrowseName + "' is missing in the .NET assembly. Please make sure that the C# class corresponding to this NetLogic has exactly the same name as the NetLogic object.", "FTOptix.NetLogic.LogicBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 177, nameof (LoadLogicFromNetAssembly));
          return false;
        }
        this.userLogicType = assembly.GetType(this.logicObject.BrowseName, true);
        this.userLogic = (BaseNetLogic) Activator.CreateInstance(this.userLogicType);
      }
      catch (Exception ex)
      {
        LogManager.CoreLogger.Log(LogLevel.Error, "FTOptix.NetLogic", (ushort) 223, (ushort) 1, "Error loading user-defined logic from .NET assembly: " + ex?.ToString(), "FTOptix.NetLogic.LogicBehavior.LoadLogicFromNetAssembly()", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\NetLogic\\NetLogic\\src\\LogicBehavior.cs", 193, nameof (LoadLogicFromNetAssembly));
        return false;
      }
      return true;
    }
  }
}
