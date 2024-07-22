// Decompiled with JetBrains decompiler
// Type: DynamicLinkExtensions
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using FTOptix.CoreBase;
using System.Runtime.CompilerServices;
using UAManagedCore;

#nullable disable
public static class DynamicLinkExtensions
{
  public static void SetDynamicLink(
    this IUAVariable variable,
    IUAVariable source,
    DynamicLinkMode mode = DynamicLinkMode.Read)
  {
    DynamicLinkExtensions.SetDynamicLinkInternal(variable, source, mode);
  }

  public static void SetDynamicLink(
    this IUAVariable variable,
    IUAVariable source,
    uint sourceArrayIndex,
    DynamicLinkMode mode = DynamicLinkMode.Read)
  {
    DynamicLinkExtensions.SetDynamicLinkInternal(variable, source, mode, new uint?(sourceArrayIndex));
  }

  public static void ResetDynamicLink(this IUAVariable variable)
  {
    variable.Refs.GetVariable(FTOptix.CoreBase.ReferenceTypes.HasDynamicLink, false)?.Delete();
    variable.Refs.GetObject(FTOptix.CoreBase.ReferenceTypes.HasConverter, false)?.Delete();
  }

  private static void SetDynamicLinkInternal(
    IUAVariable variable,
    IUAVariable source,
    DynamicLinkMode mode,
    uint? sourceArrayIndex = null)
  {
    string initialValue = source != null ? DynamicLinkPath.MakePath((IUANode) variable, (IUANode) source) : string.Empty;
    DynamicLink variable1 = (DynamicLink) variable.Refs.GetVariable(FTOptix.CoreBase.ReferenceTypes.HasDynamicLink, false);
    variable.Refs.GetObject(FTOptix.CoreBase.ReferenceTypes.HasConverter, false)?.Delete();
    if (variable1 == null)
    {
      IContext context = variable.Context;
      int namespaceIndex1 = variable.NodeId.NamespaceIndex;
      DynamicLink target1 = (DynamicLink) context.NodeFactory.MakeVariable(NodeId.Random(namespaceIndex1), (QualifiedName) "DynamicLink", FTOptix.Core.DataTypes.NodePath, FTOptix.CoreBase.VariableTypes.DynamicLink, initialValue: (object) initialValue);
      if (mode != DynamicLinkMode.Read)
      {
        int namespaceIndex2 = context.GetVariableType(FTOptix.CoreBase.VariableTypes.DynamicLink).NodeId.NamespaceIndex;
        IUAVariable variable2 = context.GetVariable(new NodeId(namespaceIndex2, 12U));
        IUAVariable target2 = context.NodeFactory.MakeVariable(NodeId.Random(namespaceIndex1), new QualifiedName(namespaceIndex2, "Mode"), FTOptix.CoreBase.DataTypes.DynamicLinkMode, UAManagedCore.OpcUa.VariableTypes.BaseVariableType, false, (object) (int) mode);
        target2.Prototype = variable2;
        target1.Refs.AddReference(UAManagedCore.OpcUa.ReferenceTypes.HasComponent, (IUANode) target2);
      }
      if (sourceArrayIndex.HasValue)
      {
        string str1 = (string) target1.Value;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
        interpolatedStringHandler.AppendLiteral("[");
        interpolatedStringHandler.AppendFormatted<uint>(sourceArrayIndex.Value);
        interpolatedStringHandler.AppendLiteral("]");
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        string str2 = str1 + stringAndClear;
        target1.Value = (UAValue) str2;
      }
      variable.Refs.AddReference(FTOptix.CoreBase.ReferenceTypes.HasDynamicLink, (IUANode) target1);
      target1.SetModellingRuleRecursive();
      if (!DynamicLinkExtensions.IsInStartedSubtree((IUANode) variable))
        return;
      target1.Start(true);
    }
    else
    {
      variable1.Value = (UAValue) initialValue;
      variable1.Mode = mode;
    }
  }

  private static bool IsInStartedSubtree(IUANode node)
  {
    if (node.Status == NodeStatus.Detached)
      return false;
    for (; node != null; node = node.Owner)
    {
      if (node.Status == NodeStatus.Started)
        return true;
    }
    return false;
  }
}
