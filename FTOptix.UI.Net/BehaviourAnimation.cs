﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.BehaviourAnimation
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 410)]
  public class BehaviourAnimation : UAObject
  {
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
  }
}
