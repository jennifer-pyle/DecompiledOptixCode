// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAExecutableBehaviourBase`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using UAManagedCore.OpcUa;

#nullable enable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class UAExecutableBehaviourBase<T> : 
    UABehaviourBase<
    #nullable disable
    T>,
    IExecutableBehaviour,
    IBehaviour
    where T : IUANode
  {
    private readonly Dictionary<string, UAExecutableBehaviourBase<T>.MethodInfoEx> methods;

    protected UAExecutableBehaviourBase(T obj)
      : base(obj)
    {
      this.methods = this.CreateMethodDictionary();
    }

    bool IExecutableBehaviour.ExecuteMethod(
      IUANode targetNode,
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      UAExecutableBehaviourBase<T>.MethodInfoEx methodInfoEx;
      if (this.methods.TryGetValue(methodName, out methodInfoEx))
      {
        bool flag = methodInfoEx.MethodInfo.ReturnType != typeof (void);
        outputArgs = flag ? new object[1] : new object[methodInfoEx.OutParameterInfos.Length];
        object[] arguments = this.CreateArguments(inputArgs, methodInfoEx.InParameterInfos, flag ? (object[]) null : outputArgs);
        object obj;
        try
        {
          obj = methodInfoEx.MethodInfo.Invoke((object) this, arguments);
        }
        catch (TargetInvocationException ex)
        {
          ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
          return false;
        }
        if (flag)
          outputArgs[0] = obj;
        else if (outputArgs.Length != 0)
          this.CopyOutArguments(arguments, outputArgs);
        return true;
      }
      outputArgs = new object[0];
      return false;
    }

    protected virtual bool ExecuteNotFoundMethod(
      string methodName,
      object[] inputArgs,
      out object[] outputArgs)
    {
      throw new MissingMethodException(this.GetType().Name, methodName);
    }

    private Dictionary<string, UAExecutableBehaviourBase<T>.MethodInfoEx> CreateMethodDictionary()
    {
      Type type = this.GetType();
      HashSet<string> methodNameSet = new HashSet<string>(this.MyObject.Refs.GetNodes(ReferenceTypes.HasChild).OfType<IUAMethod>().Select<IUAMethod, string>((Func<IUAMethod, string>) (m => m.BrowseName)));
      IEnumerable<UAExecutableBehaviourBase<T>.MethodInfoEx> source = type.GetRuntimeMethodsStoppingAt<UAExecutableBehaviourBase<T>>().Where<MethodInfo>((Func<MethodInfo, bool>) (methodInfo => methodNameSet.Contains(methodInfo.Name))).Select(methodInfo => new
      {
        methodInfo = methodInfo,
        parameterInfos = methodInfo.GetParameters()
      }).Select(_param1 => new UAExecutableBehaviourBase<T>.MethodInfoEx()
      {
        MethodInfo = _param1.methodInfo,
        InParameterInfos = ((IEnumerable<ParameterInfo>) _param1.parameterInfos).Where<ParameterInfo>((Func<ParameterInfo, bool>) (p => !p.IsOut)).ToArray<ParameterInfo>(),
        OutParameterInfos = ((IEnumerable<ParameterInfo>) _param1.parameterInfos).Where<ParameterInfo>((Func<ParameterInfo, bool>) (p => p.IsOut)).ToArray<ParameterInfo>()
      });
      try
      {
        return source.ToDictionary<UAExecutableBehaviourBase<T>.MethodInfoEx, string>((Func<UAExecutableBehaviourBase<T>.MethodInfoEx, string>) (m => m.MethodInfo.Name));
      }
      catch (Exception ex)
      {
        throw new NotSupportedException("Method overloads are not supported (yet).", ex);
      }
    }

    private object[] CreateArguments(
      object[] inputArgs,
      ParameterInfo[] inParameterInfos,
      object[] outputArgs)
    {
      int length = outputArgs != null ? outputArgs.Length : 0;
      object[] arguments = new object[inputArgs.Length + length];
      for (int index = 0; index < inputArgs.Length; ++index)
      {
        if (!(inputArgs[index] is Struct[] inputArg1))
        {
          arguments[index] = inputArgs[index];
        }
        else
        {
          Type parameterType = inParameterInfos[index].ParameterType;
          if (!parameterType.HasElementType)
            throw new InvalidOperationException("!paramInfoType.HasElementType: " + parameterType?.ToString());
          Array inputArg = (Array) inputArgs[index];
          Array instance = Array.CreateInstance(parameterType.GetElementType(), inputArg.Length);
          Array.Copy((Array) inputArg1, instance, inputArg1.Length);
          arguments[index] = (object) instance;
        }
      }
      return arguments;
    }

    private void CopyOutArguments(object[] args, object[] outputArgs)
    {
      int num = args.Length - outputArgs.Length;
      for (int index = 0; index < outputArgs.Length; ++index)
        outputArgs[index] = args[num + index];
    }

    private struct MethodInfoEx
    {
      public MethodInfo MethodInfo;
      public ParameterInfo[] InParameterInfos;
      public ParameterInfo[] OutParameterInfos;
    }
  }
}
