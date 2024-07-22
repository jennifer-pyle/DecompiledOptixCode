// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ButtonStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 710)]
  public class ButtonStyleType : ControlStyleType
  {
    public Color Color
    {
      get => new Color(this.GetOptionalVariableValue(nameof (Color)));
      set => this.SetOptionalVariableValue(nameof (Color), new UAValue(value.ARGB));
    }

    public IUAVariable ColorVariable => this.GetOrCreateVariable("Color");

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public Color PressedColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (PressedColor)));
      set => this.SetOptionalVariableValue(nameof (PressedColor), new UAValue(value.ARGB));
    }

    public IUAVariable PressedColorVariable => this.GetOrCreateVariable("PressedColor");

    public Color PressedBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (PressedBorderColor)));
      set => this.SetOptionalVariableValue(nameof (PressedBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable PressedBorderColorVariable => this.GetOrCreateVariable("PressedBorderColor");

    public Color PressedTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (PressedTextColor)));
      set => this.SetOptionalVariableValue(nameof (PressedTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable PressedTextColorVariable => this.GetOrCreateVariable("PressedTextColor");

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

    public float BorderWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderWidth));
      set => this.SetOptionalVariableValue(nameof (BorderWidth), new UAValue(value));
    }

    public IUAVariable BorderWidthVariable => this.GetOrCreateVariable("BorderWidth");

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");

    public bool IconUsesTextColor
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IconUsesTextColor));
      set => this.SetOptionalVariableValue(nameof (IconUsesTextColor), new UAValue(value));
    }

    public IUAVariable IconUsesTextColorVariable => this.GetOrCreateVariable("IconUsesTextColor");

    public float HorizontalPaddingPercent
    {
      get => (float) this.GetOptionalVariableValue(nameof (HorizontalPaddingPercent));
      set => this.SetOptionalVariableValue(nameof (HorizontalPaddingPercent), new UAValue(value));
    }

    public IUAVariable HorizontalPaddingPercentVariable
    {
      get => this.GetOrCreateVariable("HorizontalPaddingPercent");
    }

    public float VerticalPaddingPercent
    {
      get => (float) this.GetOptionalVariableValue(nameof (VerticalPaddingPercent));
      set => this.SetOptionalVariableValue(nameof (VerticalPaddingPercent), new UAValue(value));
    }

    public IUAVariable VerticalPaddingPercentVariable
    {
      get => this.GetOrCreateVariable("VerticalPaddingPercent");
    }

    public InstanceNodeCollection<ButtonStyle> Instances
    {
      get => new InstanceNodeCollection<ButtonStyle>((IUANode) this);
    }
  }
}
