// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.VariableConditionEvent
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [CustomEventType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 38)]
  public class VariableConditionEvent : BaseEvent
  {
    public NodeId VariableNodeId { get; set; }

    public object NewValue { get; set; }

    public object OldValue { get; set; }
  }
}
