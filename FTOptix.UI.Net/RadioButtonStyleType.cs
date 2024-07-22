// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.RadioButtonStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1305)]
  public class RadioButtonStyleType : ControlStyleType
  {
    public float IndicatorSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (IndicatorSize));
      set => this.SetOptionalVariableValue(nameof (IndicatorSize), new UAValue(value));
    }

    public IUAVariable IndicatorSizeVariable => this.GetOrCreateVariable("IndicatorSize");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public Color ActiveColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActiveColor)));
      set => this.SetOptionalVariableValue(nameof (ActiveColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActiveColorVariable => this.GetOrCreateVariable("ActiveColor");

    public Color ActiveTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActiveTextColor)));
      set => this.SetOptionalVariableValue(nameof (ActiveTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActiveTextColorVariable => this.GetOrCreateVariable("ActiveTextColor");

    public string FontFamily
    {
      get => (string) this.GetOptionalVariableValue(nameof (FontFamily));
      set => this.SetOptionalVariableValue(nameof (FontFamily), new UAValue(value));
    }

    public IUAVariable FontFamilyVariable => this.GetOrCreateVariable("FontFamily");

    public FontWeight FontWeight
    {
      get => (FontWeight) (int) this.GetOptionalVariableValue(nameof (FontWeight));
      set => this.SetOptionalVariableValue(nameof (FontWeight), new UAValue((int) value));
    }

    public IUAVariable FontWeightVariable => this.GetOrCreateVariable("FontWeight");

    public bool FontItalic
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FontItalic));
      set => this.SetOptionalVariableValue(nameof (FontItalic), new UAValue(value));
    }

    public IUAVariable FontItalicVariable => this.GetOrCreateVariable("FontItalic");

    public float FontSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (FontSize));
      set => this.SetOptionalVariableValue(nameof (FontSize), new UAValue(value));
    }

    public IUAVariable FontSizeVariable => this.GetOrCreateVariable("FontSize");

    public InstanceNodeCollection<RadioButtonStyle> Instances
    {
      get => new InstanceNodeCollection<RadioButtonStyle>((IUANode) this);
    }
  }
}
