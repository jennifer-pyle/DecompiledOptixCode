// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.TransactionalTaskFactoryProvider
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore.ExternalVariableSynchronizer
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class TransactionalTaskFactoryProvider
  {
    private static ITransactionalTaskFactory _factory;
    private static bool _configurationLocked;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ITransactionalTaskFactory Factory
    {
      get => TransactionalTaskFactoryProvider._factory;
      set
      {
        if (TransactionalTaskFactoryProvider._configurationLocked)
          throw new InvalidOperationException("TransactionalTaskFactoryProvider configuration locked");
        TransactionalTaskFactoryProvider._factory = value;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void LockConfiguration()
    {
      TransactionalTaskFactoryProvider._configurationLocked = true;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ITransactionalGetTask MakeTransactionalGetTask(
      this IContext context,
      IEnumerable<IUAVariable> variables,
      GetCallback callback)
    {
      return TransactionalTaskFactoryProvider._factory.MakeTransactionalGetTask(context, variables, callback);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ITransactionalSetTask MakeTransactionalSetTask(
      this IContext context,
      IEnumerable<VariableValue> variableValues,
      SetCallback callback)
    {
      return TransactionalTaskFactoryProvider._factory.MakeTransactionalSetTask(context, variableValues, callback);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ISynchronizerContext MakeSynchronizerContext(
      this IContext context,
      TimeSpan interval)
    {
      return TransactionalTaskFactoryProvider._factory.MakeSynchronizerContext(context, interval);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ITransactionalRecipeCopyTask MakeTransactionalRecipeCopyTask(
      IContext context,
      IUAObject source,
      IUAObject destination,
      TransactionalRecipesCopyErrorPolicy errorPolicy,
      RecipesCopyCallback callback)
    {
      return TransactionalTaskFactoryProvider._factory.MakeTransactionalRecipeCopyTask(context, source, destination, errorPolicy, callback);
    }
  }
}
