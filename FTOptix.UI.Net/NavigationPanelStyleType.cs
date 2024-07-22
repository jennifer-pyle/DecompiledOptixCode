// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.NavigationPanelStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using System.ComponentModel;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 847)]
  public class NavigationPanelStyleType : ControlStyleType
  {
    public Color InactiveColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (InactiveColor)));
      set => this.SetOptionalVariableValue(nameof (InactiveColor), new UAValue(value.ARGB));
    }

    public IUAVariable InactiveColorVariable => this.GetOrCreateVariable("InactiveColor");

    public Color InactiveTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (InactiveTextColor)));
      set => this.SetOptionalVariableValue(nameof (InactiveTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable InactiveTextColorVariable => this.GetOrCreateVariable("InactiveTextColor");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is deprecated, please use ActivePrimaryColor instead")]
    public Color ActiveColor
    {
      get => this.ActivePrimaryColor;
      set => this.ActivePrimaryColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is deprecated, please use ActivePrimaryColorVariable instead")]
    public IUAVariable ActiveColorVariable => this.ActivePrimaryColorVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is deprecated, please use ActiveSecondaryColor instead")]
    public Color ActiveTextColor
    {
      get => this.ActiveSecondaryColor;
      set => this.ActiveSecondaryColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is deprecated, please use ActiveSecondaryColorVariable instead")]
    public IUAVariable ActiveTextColorVariable => this.ActiveSecondaryColorVariable;

    public Color ActivePrimaryColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActivePrimaryColor)));
      set => this.SetOptionalVariableValue(nameof (ActivePrimaryColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActivePrimaryColorVariable => this.GetOrCreateVariable("ActivePrimaryColor");

    public Color ActiveSecondaryColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ActiveSecondaryColor)));
      set => this.SetOptionalVariableValue(nameof (ActiveSecondaryColor), new UAValue(value.ARGB));
    }

    public IUAVariable ActiveSecondaryColorVariable
    {
      get => this.GetOrCreateVariable("ActiveSecondaryColor");
    }

    public Color BackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (BackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable BackgroundColorVariable => this.GetOrCreateVariable("BackgroundColor");

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

    public bool IconUsesTextColor
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IconUsesTextColor));
      set => this.SetOptionalVariableValue(nameof (IconUsesTextColor), new UAValue(value));
    }

    public IUAVariable IconUsesTextColorVariable => this.GetOrCreateVariable("IconUsesTextColor");

    public float TabSpacing
    {
      get => (float) this.GetOptionalVariableValue(nameof (TabSpacing));
      set => this.SetOptionalVariableValue(nameof (TabSpacing), new UAValue(value));
    }

    public IUAVariable TabSpacingVariable => this.GetOrCreateVariable("TabSpacing");

    public float TabPadding
    {
      get => (float) this.GetOptionalVariableValue(nameof (TabPadding));
      set => this.SetOptionalVariableValue(nameof (TabPadding), new UAValue(value));
    }

    public IUAVariable TabPaddingVariable => this.GetOrCreateVariable("TabPadding");

    public InstanceNodeCollection<NavigationPanelStyle> Instances
    {
      get => new InstanceNodeCollection<NavigationPanelStyle>((IUANode) this);
    }
  }
}
