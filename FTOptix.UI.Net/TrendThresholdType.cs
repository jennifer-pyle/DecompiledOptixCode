// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.TrendThresholdType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1204)]
  public class TrendThresholdType : UAObjectType
  {
    public Color Color
    {
      get => new Color(this.GetOptionalVariableValue(nameof (Color)));
      set => this.SetOptionalVariableValue(nameof (Color), new UAValue(value.ARGB));
    }

    public IUAVariable ColorVariable => this.GetOrCreateVariable("Color");

    public float Value
    {
      get => (float) this.Refs.GetVariable(nameof (Value)).Value.Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue((object) value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");

    public InstanceNodeCollection<TrendThreshold> Instances
    {
      get => new InstanceNodeCollection<TrendThreshold>((IUANode) this);
    }

    public float Thickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (Thickness));
      set => this.SetOptionalVariableValue(nameof (Thickness), (UAValue) value);
    }

    public IUAVariable ThicknessVariable => this.GetOrCreateVariable("Thickness");
  }
}
