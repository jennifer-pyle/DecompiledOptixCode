// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.ObjectTypes
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase");
    public static readonly NodeId EventHandler = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId EUConverter = new NodeId(ObjectTypes.namespaceIndex, 3U);
    public static readonly NodeId LinearConverter = new NodeId(ObjectTypes.namespaceIndex, 104U);
    public static readonly NodeId Converter = new NodeId(ObjectTypes.namespaceIndex, 16U);
    public static readonly NodeId VariableConditionEvent = new NodeId(ObjectTypes.namespaceIndex, 38U);
    public static readonly NodeId VariableValueChangedEvent = new NodeId(ObjectTypes.namespaceIndex, 42U);
    public static readonly NodeId VariableTransitionEvent = new NodeId(ObjectTypes.namespaceIndex, 108U);
    public static readonly NodeId VariableRangeTransitionEvent = new NodeId(ObjectTypes.namespaceIndex, 120U);
    public static readonly NodeId VariableConditionEventDispatcher = new NodeId(ObjectTypes.namespaceIndex, 43U);
    public static readonly NodeId VariableChangedEventDispatcher = new NodeId(ObjectTypes.namespaceIndex, 45U);
    public static readonly NodeId VariableTransitionEventDispatcher = new NodeId(ObjectTypes.namespaceIndex, 109U);
    public static readonly NodeId VariableRangeTransitionEventDispatcher = new NodeId(ObjectTypes.namespaceIndex, 114U);
    public static readonly NodeId ValueMapConverter = new NodeId(ObjectTypes.namespaceIndex, 46U);
    public static readonly NodeId CoreContext = new NodeId(ObjectTypes.namespaceIndex, 51U);
    public static readonly NodeId StringFormatter = new NodeId(ObjectTypes.namespaceIndex, 55U);
    public static readonly NodeId ExpressionEvaluator = new NodeId(ObjectTypes.namespaceIndex, 59U);
    public static readonly NodeId ConditionalConverter = new NodeId(ObjectTypes.namespaceIndex, 87U);
    public static readonly NodeId ValueMapPair = new NodeId(ObjectTypes.namespaceIndex, 72U);
    public static readonly NodeId MethodInvocation = new NodeId(ObjectTypes.namespaceIndex, 93U);
  }
}
