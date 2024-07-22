// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.ITransactionalTaskFactory
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
  public interface ITransactionalTaskFactory
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionalGetTask MakeTransactionalGetTask(
      IContext context,
      IEnumerable<IUAVariable> variables,
      GetCallback callback);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionalSetTask MakeTransactionalSetTask(
      IContext context,
      IEnumerable<VariableValue> variableValues,
      SetCallback callback);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISynchronizerContext MakeSynchronizerContext(IContext context, TimeSpan interval);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionalRecipeCopyTask MakeTransactionalRecipeCopyTask(
      IContext context,
      IUAObject source,
      IUAObject destination,
      TransactionalRecipesCopyErrorPolicy errorPolicy,
      RecipesCopyCallback callback);
  }
}
