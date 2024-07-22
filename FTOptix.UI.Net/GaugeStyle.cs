﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.GaugeStyle
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 813)]
  public class GaugeStyle : ControlStyle
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

    public float BorderWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderWidth));
      set => this.SetOptionalVariableValue(nameof (BorderWidth), new UAValue(value));
    }

    public IUAVariable BorderWidthVariable => this.GetOrCreateVariable("BorderWidth");

    public Color HandleBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HandleBorderColor)));
      set => this.SetOptionalVariableValue(nameof (HandleBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable HandleBorderColorVariable => this.GetOrCreateVariable("HandleBorderColor");

    public float HandleBorderWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (HandleBorderWidth));
      set => this.SetOptionalVariableValue(nameof (HandleBorderWidth), new UAValue(value));
    }

    public IUAVariable HandleBorderWidthVariable => this.GetOrCreateVariable("HandleBorderWidth");

    public Color HandleColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HandleColor)));
      set => this.SetOptionalVariableValue(nameof (HandleColor), new UAValue(value.ARGB));
    }

    public IUAVariable HandleColorVariable => this.GetOrCreateVariable("HandleColor");

    public float HandleSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (HandleSize));
      set => this.SetOptionalVariableValue(nameof (HandleSize), new UAValue(value));
    }

    public IUAVariable HandleSizeVariable => this.GetOrCreateVariable("HandleSize");

    public Color ForegroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ForegroundColor)));
      set => this.SetOptionalVariableValue(nameof (ForegroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable ForegroundColorVariable => this.GetOrCreateVariable("ForegroundColor");

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

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public Color ToolTipBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ToolTipBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (ToolTipBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable ToolTipBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("ToolTipBackgroundColor");
    }

    public Color ToolTipTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ToolTipTextColor)));
      set => this.SetOptionalVariableValue(nameof (ToolTipTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable ToolTipTextColorVariable => this.GetOrCreateVariable("ToolTipTextColor");
  }
}
