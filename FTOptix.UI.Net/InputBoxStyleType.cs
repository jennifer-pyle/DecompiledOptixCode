// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.InputBoxStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 749)]
  public class InputBoxStyleType : ControlStyleType
  {
    public Color BackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (BackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable BackgroundColorVariable => this.GetOrCreateVariable("BackgroundColor");

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

    public Color FocusBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FocusBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (FocusBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable FocusBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("FocusBackgroundColor");
    }

    public Color FocusBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FocusBorderColor)));
      set => this.SetOptionalVariableValue(nameof (FocusBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable FocusBorderColorVariable => this.GetOrCreateVariable("FocusBorderColor");

    public Color FocusTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FocusTextColor)));
      set => this.SetOptionalVariableValue(nameof (FocusTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable FocusTextColorVariable => this.GetOrCreateVariable("FocusTextColor");

    public Color PlaceHolderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (PlaceHolderColor)));
      set => this.SetOptionalVariableValue(nameof (PlaceHolderColor), new UAValue(value.ARGB));
    }

    public IUAVariable PlaceHolderColorVariable => this.GetOrCreateVariable("PlaceHolderColor");

    public Color SelectionColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (SelectionColor)));
      set => this.SetOptionalVariableValue(nameof (SelectionColor), new UAValue(value.ARGB));
    }

    public IUAVariable SelectionColorVariable => this.GetOrCreateVariable("SelectionColor");

    public Color SelectionTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (SelectionTextColor)));
      set => this.SetOptionalVariableValue(nameof (SelectionTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable SelectionTextColorVariable => this.GetOrCreateVariable("SelectionTextColor");

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

    public InstanceNodeCollection<InputBoxStyle> Instances
    {
      get => new InstanceNodeCollection<InputBoxStyle>((IUANode) this);
    }
  }
}
