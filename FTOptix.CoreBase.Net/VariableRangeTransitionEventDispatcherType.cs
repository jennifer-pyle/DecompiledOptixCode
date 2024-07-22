// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.VariableRangeTransitionEventDispatcherType
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 114)]
  public class VariableRangeTransitionEventDispatcherType : VariableConditionEventDispatcherType
  {
    public double From
    {
      get => (double) this.Refs.GetVariable(nameof (From)).Value;
      set => this.Refs.GetVariable(nameof (From)).SetValue((object) value);
    }

    public IUAVariable FromVariable => this.Refs.GetVariable("From");

    public double To
    {
      get => (double) this.Refs.GetVariable(nameof (To)).Value;
      set => this.Refs.GetVariable(nameof (To)).SetValue((object) value);
    }

    public IUAVariable ToVariable => this.Refs.GetVariable("To");

    public VariableRangeTransition Transition
    {
      get => (VariableRangeTransition) (int) this.Refs.GetVariable(nameof (Transition)).Value;
      set => this.Refs.GetVariable(nameof (Transition)).SetValue((object) (int) value);
    }

    public IUAVariable TransitionVariable => this.Refs.GetVariable("Transition");

    public InstanceNodeCollection<VariableRangeTransitionEventDispatcher> Instances
    {
      get => new InstanceNodeCollection<VariableRangeTransitionEventDispatcher>((IUANode) this);
    }
  }
}
