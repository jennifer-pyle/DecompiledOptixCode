// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.VariableTransitionEventDispatcher
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 110)]
  public class VariableTransitionEventDispatcher : VariableConditionEventDispatcher
  {
    public double Value
    {
      get => (double) this.Refs.GetVariable(nameof (Value)).Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue((object) value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");

    public VariableTransition Transition
    {
      get => (VariableTransition) (int) this.Refs.GetVariable(nameof (Transition)).Value;
      set => this.Refs.GetVariable(nameof (Transition)).SetValue((object) (int) value);
    }

    public IUAVariable TransitionVariable => this.Refs.GetVariable("Transition");

    public event EventHandler<VariableTransitionEvent> VariableValueChangedEvent
    {
      add
      {
        this.GetOrCreateCustomEventHandler(ObjectTypes.VariableTransitionEvent, typeof (EventHandler<VariableTransitionEvent>), typeof (VariableTransitionEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(ObjectTypes.VariableTransitionEvent, typeof (EventHandler<VariableTransitionEvent>), typeof (VariableTransitionEvent)).Remove((Delegate) value);
      }
    }
  }
}
