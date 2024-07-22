// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.RangeSlider
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 93)]
  public class RangeSlider : Item
  {
    public double FirstPosition
    {
      get => (double) this.Refs.GetVariable(nameof (FirstPosition)).Value.Value;
      set => this.Refs.GetVariable(nameof (FirstPosition)).SetValue((object) value);
    }

    public IUAVariable FirstPositionVariable => this.Refs.GetVariable("FirstPosition");

    public double SecondPosition
    {
      get => (double) this.Refs.GetVariable(nameof (SecondPosition)).Value.Value;
      set => this.Refs.GetVariable(nameof (SecondPosition)).SetValue((object) value);
    }

    public IUAVariable SecondPositionVariable => this.Refs.GetVariable("SecondPosition");

    public bool Horizontal
    {
      get => (bool) this.Refs.GetVariable(nameof (Horizontal)).Value.Value;
      set => this.Refs.GetVariable(nameof (Horizontal)).SetValue((object) value);
    }

    public IUAVariable HorizontalVariable => this.Refs.GetVariable("Horizontal");

    public ValueChangeBehaviour ValueChangeBehaviour
    {
      get
      {
        return (ValueChangeBehaviour) (int) this.Refs.GetVariable(nameof (ValueChangeBehaviour)).Value;
      }
      set => this.Refs.GetVariable(nameof (ValueChangeBehaviour)).SetValue((object) (int) value);
    }

    public IUAVariable ValueChangeBehaviourVariable
    {
      get => this.Refs.GetVariable("ValueChangeBehaviour");
    }
  }
}
