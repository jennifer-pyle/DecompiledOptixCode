// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.MomentaryButton
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1211)]
  public class MomentaryButton : Button
  {
    public bool Active => (bool) this.Refs.GetVariable(nameof (Active)).Value;

    public IUAVariable ActiveVariable => this.Refs.GetVariable("Active");

    public double MinHoldTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (MinHoldTime));
      set => this.SetOptionalVariableValue(nameof (MinHoldTime), new UAValue(value));
    }

    public IUAVariable MinHoldTimeVariable => this.GetOrCreateVariable("MinHoldTime");

    public double MaxHoldTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (MaxHoldTime));
      set => this.SetOptionalVariableValue(nameof (MaxHoldTime), new UAValue(value));
    }

    public IUAVariable MaxHoldTimeVariable => this.GetOrCreateVariable("MaxHoldTime");
  }
}
