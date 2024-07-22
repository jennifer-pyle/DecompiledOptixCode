// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.NumberAnimation
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 424)]
  public class NumberAnimation : AbstractAnimation
  {
    public float From
    {
      get => (float) this.GetOptionalVariableValue(nameof (From));
      set => this.SetOptionalVariableValue(nameof (From), new UAValue(value));
    }

    public IUAVariable FromVariable => this.GetOrCreateVariable("From");

    public float To
    {
      get => (float) this.Refs.GetVariable(nameof (To)).Value.Value;
      set => this.Refs.GetVariable(nameof (To)).SetValue((object) value);
    }

    public IUAVariable ToVariable => this.Refs.GetVariable("To");

    public int Duration
    {
      get => (int) this.GetOptionalVariableValue(nameof (Duration));
      set => this.SetOptionalVariableValue(nameof (Duration), new UAValue(value));
    }

    public IUAVariable DurationVariable => this.GetOrCreateVariable("Duration");

    public EasingCurve EasingCurve
    {
      get => (EasingCurve) (int) this.GetOptionalVariableValue(nameof (EasingCurve));
      set => this.SetOptionalVariableValue(nameof (EasingCurve), new UAValue((int) value));
    }

    public IUAVariable EasingCurveVariable => this.GetOrCreateVariable("EasingCurve");

    public NodeId Target
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Target)).Value.Value;
      set => this.Refs.GetVariable(nameof (Target)).SetValue((object) value);
    }

    public NodePointer TargetVariable => (NodePointer) this.Refs.GetVariable("Target");
  }
}
