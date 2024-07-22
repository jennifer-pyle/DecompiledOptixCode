﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.CheckBoxStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1317)]
  public class CheckBoxStyleType : ControlStyleType
  {
    public float IndicatorSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (IndicatorSize));
      set => this.SetOptionalVariableValue(nameof (IndicatorSize), new UAValue(value));
    }

    public IUAVariable IndicatorSizeVariable => this.GetOrCreateVariable("IndicatorSize");

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

    public Color ActiveBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActiveBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (ActiveBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActiveBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("ActiveBackgroundColor");
    }

    public Color ActiveTickColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActiveTickColor)));
      set => this.SetOptionalVariableValue(nameof (ActiveTickColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActiveTickColorVariable => this.GetOrCreateVariable("ActiveTickColor");

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

    public InstanceNodeCollection<CheckBoxStyle> Instances
    {
      get => new InstanceNodeCollection<CheckBoxStyle>((IUANode) this);
    }
  }
}
