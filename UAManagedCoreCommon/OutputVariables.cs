// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OutputVariables
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class OutputVariables
  {
    private static readonly IReadOnlyList<IUAVariable> EmptyVariableList = (IReadOnlyList<IUAVariable>) new List<IUAVariable>(0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static OutputVariables WithNoAction { get; } = new OutputVariables(false);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static OutputVariables WithAction { get; } = new OutputVariables(true);

    private OutputVariables(bool observerHasAction)
    {
      this.ObserverHasAction = observerHasAction;
      this.Variables = OutputVariables.EmptyVariableList;
    }

    public OutputVariables(IReadOnlyList<IUAVariable> variables)
    {
      this.ObserverHasAction = true;
      this.Variables = variables;
    }

    public OutputVariables(params IUAVariable[] variables)
      : this((IReadOnlyList<IUAVariable>) variables)
    {
    }

    public OutputVariables(IEnumerable<IUAVariable> variables)
      : this((IReadOnlyList<IUAVariable>) variables.ToList<IUAVariable>())
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ObserverHasAction { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IReadOnlyList<IUAVariable> Variables { get; private set; }
  }
}
