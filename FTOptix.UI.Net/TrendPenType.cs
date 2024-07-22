// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.TrendPenType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 221)]
  public class TrendPenType : UAVariableType
  {
    public Color Color
    {
      get => new Color(this.GetOptionalVariableValue(nameof (Color)));
      set => this.SetOptionalVariableValue(nameof (Color), new UAValue(value.ARGB));
    }

    public IUAVariable ColorVariable => this.GetOrCreateVariable("Color");

    public float Thickness
    {
      get => (float) this.Refs.GetVariable(nameof (Thickness)).Value.Value;
      set => this.Refs.GetVariable(nameof (Thickness)).SetValue((object) value);
    }

    public IUAVariable ThicknessVariable => this.Refs.GetVariable("Thickness");

    public bool Enabled
    {
      get => (bool) this.Refs.GetVariable(nameof (Enabled)).Value.Value;
      set => this.Refs.GetVariable(nameof (Enabled)).SetValue((object) value);
    }

    public IUAVariable EnabledVariable => this.Refs.GetVariable("Enabled");

    public LocalizedText Title
    {
      get => (LocalizedText) this.GetOptionalVariableValue(nameof (Title));
      set => this.SetOptionalVariableValue(nameof (Title), new UAValue(value));
    }

    public IUAVariable TitleVariable => this.GetOrCreateVariable("Title");

    public PlaceholderChildNodeCollection<TrendThreshold> Thresholds
    {
      get
      {
        return new PlaceholderChildNodeCollection<TrendThreshold>((IUANode) this, nameof (Thresholds));
      }
    }

    public InstanceNodeCollection<TrendPen> Instances
    {
      get => new InstanceNodeCollection<TrendPen>((IUANode) this);
    }
  }
}
