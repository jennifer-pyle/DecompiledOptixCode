// Decompiled with JetBrains decompiler
// Type: UAManagedCore.MethodsToExecute
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
  public class MethodsToExecute
  {
    private static readonly IReadOnlyList<UAMethodInfo> EmptyMethodList = (IReadOnlyList<UAMethodInfo>) new List<UAMethodInfo>(0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MethodsToExecute WithNoAction { get; } = new MethodsToExecute(false);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static MethodsToExecute WithAction { get; } = new MethodsToExecute(true);

    private MethodsToExecute(bool observerHasAction)
    {
      this.ObserverHasAction = observerHasAction;
      this.Methods = MethodsToExecute.EmptyMethodList;
    }

    public MethodsToExecute(IReadOnlyList<UAMethodInfo> methods)
    {
      this.ObserverHasAction = true;
      this.Methods = methods;
    }

    public MethodsToExecute(params UAMethodInfo[] methods)
      : this((IReadOnlyList<UAMethodInfo>) methods)
    {
    }

    public MethodsToExecute(IEnumerable<UAMethodInfo> methods)
      : this((IReadOnlyList<UAMethodInfo>) methods.ToList<UAMethodInfo>())
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ObserverHasAction { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IReadOnlyList<UAMethodInfo> Methods { get; private set; }
  }
}
