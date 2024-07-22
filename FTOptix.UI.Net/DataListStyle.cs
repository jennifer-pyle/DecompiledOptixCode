// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DataListStyle
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 887)]
  public class DataListStyle : ControlStyle
  {
    public Color BackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (BackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable BackgroundColorVariable => this.GetOrCreateVariable("BackgroundColor");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public Color HorizontalLineColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HorizontalLineColor)));
      set => this.SetOptionalVariableValue(nameof (HorizontalLineColor), new UAValue(value.ARGB));
    }

    public IUAVariable HorizontalLineColorVariable
    {
      get => this.GetOrCreateVariable("HorizontalLineColor");
    }

    public Color VerticalLineColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (VerticalLineColor)));
      set => this.SetOptionalVariableValue(nameof (VerticalLineColor), new UAValue(value.ARGB));
    }

    public IUAVariable VerticalLineColorVariable => this.GetOrCreateVariable("VerticalLineColor");

    public Color SelectionBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (SelectionBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (SelectionBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable SelectionBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("SelectionBackgroundColor");
    }

    public Color SelectionBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (SelectionBorderColor)));
      set => this.SetOptionalVariableValue(nameof (SelectionBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable SelectionBorderColorVariable
    {
      get => this.GetOrCreateVariable("SelectionBorderColor");
    }

    public Color SelectionTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (SelectionTextColor)));
      set => this.SetOptionalVariableValue(nameof (SelectionTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable SelectionTextColorVariable => this.GetOrCreateVariable("SelectionTextColor");

    public Color HoverBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HoverBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (HoverBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable HoverBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("HoverBackgroundColor");
    }

    public Color HoverBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HoverBorderColor)));
      set => this.SetOptionalVariableValue(nameof (HoverBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable HoverBorderColorVariable => this.GetOrCreateVariable("HoverBorderColor");

    public Color HoverTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HoverTextColor)));
      set => this.SetOptionalVariableValue(nameof (HoverTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable HoverTextColorVariable => this.GetOrCreateVariable("HoverTextColor");

    public Color AlternateBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (AlternateBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (AlternateBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable AlternateBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("AlternateBackgroundColor");
    }

    public float BorderWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderWidth));
      set => this.SetOptionalVariableValue(nameof (BorderWidth), new UAValue(value));
    }

    public IUAVariable BorderWidthVariable => this.GetOrCreateVariable("BorderWidth");

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

    public Color HeaderBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HeaderBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (HeaderBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable HeaderBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("HeaderBackgroundColor");
    }

    public Color HeaderTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HeaderTextColor)));
      set => this.SetOptionalVariableValue(nameof (HeaderTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable HeaderTextColorVariable => this.GetOrCreateVariable("HeaderTextColor");

    public Color HeaderBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HeaderBorderColor)));
      set => this.SetOptionalVariableValue(nameof (HeaderBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable HeaderBorderColorVariable => this.GetOrCreateVariable("HeaderBorderColor");

    public string HeaderFontFamily
    {
      get => (string) this.GetOptionalVariableValue(nameof (HeaderFontFamily));
      set => this.SetOptionalVariableValue(nameof (HeaderFontFamily), new UAValue(value));
    }

    public IUAVariable HeaderFontFamilyVariable => this.GetOrCreateVariable("HeaderFontFamily");

    public FontWeight HeaderFontWeight
    {
      get => (FontWeight) (int) this.GetOptionalVariableValue(nameof (HeaderFontWeight));
      set => this.SetOptionalVariableValue(nameof (HeaderFontWeight), new UAValue((int) value));
    }

    public IUAVariable HeaderFontWeightVariable => this.GetOrCreateVariable("HeaderFontWeight");

    public bool HeaderFontItalic
    {
      get => (bool) this.GetOptionalVariableValue(nameof (HeaderFontItalic));
      set => this.SetOptionalVariableValue(nameof (HeaderFontItalic), new UAValue(value));
    }

    public IUAVariable HeaderFontItalicVariable => this.GetOrCreateVariable("HeaderFontItalic");

    public float HeaderFontSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (HeaderFontSize));
      set => this.SetOptionalVariableValue(nameof (HeaderFontSize), new UAValue(value));
    }

    public IUAVariable HeaderFontSizeVariable => this.GetOrCreateVariable("HeaderFontSize");

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");
  }
}
