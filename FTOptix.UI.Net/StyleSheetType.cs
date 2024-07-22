// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.StyleSheetType
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
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 447)]
  public class StyleSheetType : UAObjectType
  {
    public Color AccentColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (AccentColor)));
      set => this.SetOptionalVariableValue(nameof (AccentColor), new UAValue(value.ARGB));
    }

    public IUAVariable AccentColorVariable => this.GetOrCreateVariable("AccentColor");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use AccentColor instead.")]
    public Color AccentBackgroundColor
    {
      get => this.AccentColor;
      set => this.AccentColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use AccentColorVariable instead.")]
    public IUAVariable AccentBackgroundColorVariable => this.AccentColorVariable;

    public Color AccentTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (AccentTextColor)));
      set => this.SetOptionalVariableValue(nameof (AccentTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable AccentTextColorVariable => this.GetOrCreateVariable("AccentTextColor");

    public Color AccentBorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (AccentBorderColor)));
      set => this.SetOptionalVariableValue(nameof (AccentBorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable AccentBorderColorVariable => this.GetOrCreateVariable("AccentBorderColor");

    public Color WindowColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (WindowColor)));
      set => this.SetOptionalVariableValue(nameof (WindowColor), new UAValue(value.ARGB));
    }

    public IUAVariable WindowColorVariable => this.GetOrCreateVariable("WindowColor");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use WindowColor instead.")]
    public Color BackgroundColor
    {
      get => this.WindowColor;
      set => this.WindowColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use WindowColorVariable instead.")]
    public IUAVariable BackgroundColorVariable => this.WindowColorVariable;

    public Color ScreenColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ScreenColor)));
      set => this.SetOptionalVariableValue(nameof (ScreenColor), new UAValue(value.ARGB));
    }

    public IUAVariable ScreenColorVariable => this.GetOrCreateVariable("ScreenColor");

    public Color InteractiveBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (InteractiveBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (InteractiveBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable InteractiveBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("InteractiveBackgroundColor");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InteractiveBackgroundColor instead.")]
    public Color ControlBackgroundColor
    {
      get => this.InteractiveBackgroundColor;
      set => this.InteractiveBackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InteractiveBackgroundColorVariable instead.")]
    public IUAVariable ControlBackgroundColorVariable => this.InteractiveBackgroundColorVariable;

    public Color InteractiveColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (InteractiveColor)));
      set => this.SetOptionalVariableValue(nameof (InteractiveColor), new UAValue(value.ARGB));
    }

    public IUAVariable InteractiveColorVariable => this.GetOrCreateVariable("InteractiveColor");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InteractiveColor instead.")]
    public Color ButtonBackgroundColor
    {
      get => this.InteractiveColor;
      set => this.InteractiveColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InteracticeColorVariable instead.")]
    public IUAVariable ButtonBackgroundColorVariable => this.InteractiveColorVariable;

    public float InteractiveColorGradientPercent
    {
      get => (float) this.GetOptionalVariableValue(nameof (InteractiveColorGradientPercent));
      set
      {
        this.SetOptionalVariableValue(nameof (InteractiveColorGradientPercent), new UAValue(value));
      }
    }

    public IUAVariable InteractiveColorGradientPercentVariable
    {
      get => this.GetOrCreateVariable("InteractiveColorGradientPercent");
    }

    public float InteractiveDropShadowSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (InteractiveDropShadowSize));
      set => this.SetOptionalVariableValue(nameof (InteractiveDropShadowSize), new UAValue(value));
    }

    public IUAVariable InteractiveDropShadowSizeVariable
    {
      get => this.GetOrCreateVariable("InteractiveDropShadowSize");
    }

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

    public Color DataInputBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (DataInputBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (DataInputBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable DataInputBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("DataInputBackgroundColor");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataInputBackgroundColor instead.")]
    public Color InputBackgroundColor
    {
      get => this.DataInputBackgroundColor;
      set => this.DataInputBackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataInputBackgroundColorVariable instead.")]
    public IUAVariable InputBackgroundColorVariable => this.DataInputBackgroundColorVariable;

    public Color DataInputTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (DataInputTextColor)));
      set => this.SetOptionalVariableValue(nameof (DataInputTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable DataInputTextColorVariable => this.GetOrCreateVariable("DataInputTextColor");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataInputTextColor instead.")]
    public Color InputTextColor
    {
      get => this.DataInputTextColor;
      set => this.DataInputTextColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataInputTextColorVariable instead.")]
    public IUAVariable InputTextColorVariable => this.DataInputTextColorVariable;

    public Color InputPlaceholderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (InputPlaceholderColor)));
      set => this.SetOptionalVariableValue(nameof (InputPlaceholderColor), new UAValue(value.ARGB));
    }

    public IUAVariable InputPlaceholderColorVariable
    {
      get => this.GetOrCreateVariable("InputPlaceholderColor");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InputBoxStyle.SelectionColor instead.")]
    public Color SelectionColor
    {
      get => this.InputBoxStyle.SelectionColor;
      set => this.InputBoxStyle.SelectionColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InputBoxStyle.SelectionColorVariable instead.")]
    public IUAVariable SelectionColorVariable => this.InputBoxStyle.SelectionColorVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InputBoxStyle.SelectionTextColor instead.")]
    public Color SelectionTextColor
    {
      get => this.InputBoxStyle.SelectionTextColor;
      set => this.InputBoxStyle.SelectionTextColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InputBoxStyle.SelectionTextColorVariable instead.")]
    public IUAVariable SelectionTextColorVariable => this.InputBoxStyle.SelectionTextColorVariable;

    public Color FocusColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FocusColor)));
      set => this.SetOptionalVariableValue(nameof (FocusColor), new UAValue(value.ARGB));
    }

    public IUAVariable FocusColorVariable => this.GetOrCreateVariable("FocusColor");

    public float FocusGlowSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (FocusGlowSize));
      set => this.SetOptionalVariableValue(nameof (FocusGlowSize), new UAValue(value));
    }

    public IUAVariable FocusGlowSizeVariable => this.GetOrCreateVariable("FocusGlowSize");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.HeaderBackgroundColor instead.")]
    public Color DataGridHeaderBackgroundColor
    {
      get => this.DataListStyle.HeaderBackgroundColor;
      set => this.DataListStyle.HeaderBackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.HeaderBackgroundColorVariable instead.")]
    public IUAVariable DataGridHeaderBackgroundColorVariable
    {
      get => this.DataListStyle.HeaderBackgroundColorVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.HeaderTextColor instead.")]
    public Color DataGridHeaderTextColor
    {
      get => this.DataListStyle.HeaderTextColor;
      set => this.DataListStyle.HeaderTextColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.HeaderTextColorVariable instead.")]
    public IUAVariable DataGridHeaderTextColorVariable
    {
      get => this.DataListStyle.HeaderTextColorVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.BackgroundColor instead.")]
    public Color DataGridBaseColor
    {
      get => this.DataListStyle.BackgroundColor;
      set => this.DataListStyle.BackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.BackgroundColorVariable instead.")]
    public IUAVariable DataGridBaseColorVariable => this.DataListStyle.BackgroundColorVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.AlternateBackgroundColor instead.")]
    public Color DataGridAlternateColor
    {
      get => this.DataListStyle.AlternateBackgroundColor;
      set => this.DataListStyle.AlternateBackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use DataListStyle.AlternateBackgroundColorVariable instead.")]
    public IUAVariable DataGridAlternateColorVariable
    {
      get => this.DataListStyle.AlternateBackgroundColorVariable;
    }

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

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use Radius instead.")]
    public float BorderRadius
    {
      get => this.Radius;
      set => this.Radius = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use RadiusVariable instead.")]
    public IUAVariable BorderRadiusVariable => this.RadiusVariable;

    public float BorderWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderWidth));
      set => this.SetOptionalVariableValue(nameof (BorderWidth), new UAValue(value));
    }

    public IUAVariable BorderWidthVariable => this.GetOrCreateVariable("BorderWidth");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete and will always return 1")]
    public float Opacity
    {
      get => 1f;
      set
      {
      }
    }

    public float DisabledOpacity
    {
      get => (float) this.GetOptionalVariableValue(nameof (DisabledOpacity));
      set => this.SetOptionalVariableValue(nameof (DisabledOpacity), new UAValue(value));
    }

    public IUAVariable DisabledOpacityVariable => this.GetOrCreateVariable("DisabledOpacity");

    public uint AnimationDuration
    {
      get => (uint) this.GetOptionalVariableValue(nameof (AnimationDuration));
      set => this.SetOptionalVariableValue(nameof (AnimationDuration), new UAValue(value));
    }

    public IUAVariable AnimationDurationVariable => this.GetOrCreateVariable("AnimationDuration");

    public double BlinkingPeriod
    {
      get => (double) this.GetOptionalVariableValue(nameof (BlinkingPeriod));
      set => this.SetOptionalVariableValue(nameof (BlinkingPeriod), new UAValue(value));
    }

    public IUAVariable BlinkingPeriodVariable => this.GetOrCreateVariable("BlinkingPeriod");

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

    public float FontPixelSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (FontPixelSize));
      set => this.SetOptionalVariableValue(nameof (FontPixelSize), new UAValue(value));
    }

    public IUAVariable FontPixelSizeVariable => this.GetOrCreateVariable("FontPixelSize");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ChartStyle.BackgroundColor instead.")]
    public Color ChartBackgroundColor
    {
      get => this.ChartStyle.BackgroundColor;
      set => this.ChartStyle.BackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ChartStyle.BackgroundColorVariable instead.")]
    public IUAVariable ChartBackgroundColorVariable => this.ChartStyle.BackgroundColorVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ChartStyle.GridColor instead.")]
    public Color ChartGridColor
    {
      get => this.ChartStyle.GridColor;
      set => this.ChartStyle.GridColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ChartStyle.GridColorVariable instead.")]
    public IUAVariable ChartGridColorVariable => this.ChartStyle.GridColorVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.AutoHide instead.")]
    public bool ScrollBarAutoHide
    {
      get => this.ScrollBarStyle.AutoHide;
      set => this.ScrollBarStyle.AutoHide = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.AutoHideVariable instead.")]
    public IUAVariable ScrollBarAutoHideVariable => this.ScrollBarStyle.AutoHideVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.BackgroundColor instead.")]
    public Color ScrollBarBackgroundColor
    {
      get => this.ScrollBarStyle.BackgroundColor;
      set => this.ScrollBarStyle.BackgroundColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.BackgroundColorVariable instead.")]
    public IUAVariable ScrollBarBackgroundColorVariable
    {
      get => this.ScrollBarStyle.BackgroundColorVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.Size instead.")]
    public float ScrollBarSize
    {
      get => this.ScrollBarStyle.Size;
      set => this.ScrollBarStyle.Size = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.SizeVariable instead.")]
    public IUAVariable ScrollBarSizeVariable => this.ScrollBarStyle.SizeVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleColor instead.")]
    public Color ScrollBarHandleBackgroundColor
    {
      get => this.ScrollBarStyle.HandleColor;
      set => this.ScrollBarStyle.HandleColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleColor instead.")]
    public IUAVariable ScrollBarHandleBackgroundColorVariable
    {
      get => this.ScrollBarStyle.HandleColorVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleBorderColor instead.")]
    public Color ScrollBarHandleBorderColor
    {
      get => this.ScrollBarStyle.HandleBorderColor;
      set => this.ScrollBarStyle.HandleBorderColor = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleBorderColorVariable instead.")]
    public IUAVariable ScrollBarHandleBorderColorVariable
    {
      get => this.ScrollBarStyle.HandleBorderColorVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleBorderWidth instead.")]
    public float ScrollBarHandleBorderWidth
    {
      get => this.ScrollBarStyle.HandleBorderWidth;
      set => this.ScrollBarStyle.HandleBorderWidth = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleBorderWidth instead.")]
    public IUAVariable ScrollBarHandleBorderWidthVariable
    {
      get => this.ScrollBarStyle.HandleBorderWidthVariable;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleRadius instead.")]
    public float ScrollBarHandleRadius
    {
      get => this.ScrollBarStyle.HandleRadius;
      set => this.ScrollBarStyle.HandleRadius = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use ScrollBarStyle.HandleRadiusVariable instead.")]
    public IUAVariable ScrollBarHandleRadiusVariable => this.ScrollBarStyle.HandleRadiusVariable;

    public ButtonStyle ButtonStyle => this.ButtonStyles.Get<ButtonStyle>((QualifiedName) "Default");

    public ButtonStyle ButtonAccentStyle
    {
      get => this.ButtonStyles.Get<ButtonStyle>((QualifiedName) "Accent");
    }

    public PlaceholderChildNodeCollection<ButtonStyle> ButtonStyles
    {
      get => new PlaceholderChildNodeCollection<ButtonStyle>((IUANode) this, nameof (ButtonStyles));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete. Use InputBoxStyle instead.")]
    public InputBoxStyle DataInputStyle => this.InputBoxStyle;

    public InputBoxStyle InputBoxStyle
    {
      get => this.InputBoxStyles.Get<InputBoxStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<InputBoxStyle> InputBoxStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<InputBoxStyle>((IUANode) this, nameof (InputBoxStyles));
      }
    }

    public SwitchStyle SwitchStyle => this.SwitchStyles.Get<SwitchStyle>((QualifiedName) "Default");

    public PlaceholderChildNodeCollection<SwitchStyle> SwitchStyles
    {
      get => new PlaceholderChildNodeCollection<SwitchStyle>((IUANode) this, nameof (SwitchStyles));
    }

    public GaugeStyle GaugeStyle => this.GaugeStyles.Get<GaugeStyle>((QualifiedName) "Default");

    public PlaceholderChildNodeCollection<GaugeStyle> GaugeStyles
    {
      get => new PlaceholderChildNodeCollection<GaugeStyle>((IUANode) this, nameof (GaugeStyles));
    }

    public NavigationPanelStyle NavigationPanelStyle
    {
      get => this.NavigationPanelStyles.Get<NavigationPanelStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<NavigationPanelStyle> NavigationPanelStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<NavigationPanelStyle>((IUANode) this, nameof (NavigationPanelStyles));
      }
    }

    public ChartStyle ChartStyle => this.ChartStyles.Get<ChartStyle>((QualifiedName) "Default");

    public PlaceholderChildNodeCollection<ChartStyle> ChartStyles
    {
      get => new PlaceholderChildNodeCollection<ChartStyle>((IUANode) this, nameof (ChartStyles));
    }

    public DataListStyle DataListStyle
    {
      get => this.DataListStyles.Get<DataListStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<DataListStyle> DataListStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<DataListStyle>((IUANode) this, nameof (DataListStyles));
      }
    }

    public ToolTipStyle ToolTipStyle
    {
      get => this.ToolTipStyles.Get<ToolTipStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<ToolTipStyle> ToolTipStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<ToolTipStyle>((IUANode) this, nameof (ToolTipStyles));
      }
    }

    public ScrollBarStyle ScrollBarStyle
    {
      get => this.ScrollBarStyles.Get<ScrollBarStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<ScrollBarStyle> ScrollBarStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<ScrollBarStyle>((IUANode) this, nameof (ScrollBarStyles));
      }
    }

    public AccordionStyle AccordionStyle
    {
      get => this.AccordionStyles.Get<AccordionStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<AccordionStyle> AccordionStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<AccordionStyle>((IUANode) this, nameof (AccordionStyles));
      }
    }

    public PieChartStyle PieChartStyle
    {
      get => this.PieChartStyles.Get<PieChartStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<PieChartStyle> PieChartStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<PieChartStyle>((IUANode) this, nameof (PieChartStyles));
      }
    }

    public HistogramChartStyle HistogramChartStyle
    {
      get => this.HistogramChartStyles.Get<HistogramChartStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<HistogramChartStyle> HistogramChartStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<HistogramChartStyle>((IUANode) this, nameof (HistogramChartStyles));
      }
    }

    public LabelStyle LabelStyle => this.LabelStyles.Get<LabelStyle>((QualifiedName) "Default");

    public PlaceholderChildNodeCollection<LabelStyle> LabelStyles
    {
      get => new PlaceholderChildNodeCollection<LabelStyle>((IUANode) this, nameof (LabelStyles));
    }

    public RadioButtonStyle RadioButtonStyle
    {
      get => this.RadioButtonStyles.Get<RadioButtonStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<RadioButtonStyle> RadioButtonStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<RadioButtonStyle>((IUANode) this, nameof (RadioButtonStyles));
      }
    }

    public CheckBoxStyle CheckBoxStyle
    {
      get => this.CheckBoxStyles.Get<CheckBoxStyle>((QualifiedName) "Default");
    }

    public PlaceholderChildNodeCollection<CheckBoxStyle> CheckBoxStyles
    {
      get
      {
        return new PlaceholderChildNodeCollection<CheckBoxStyle>((IUANode) this, nameof (CheckBoxStyles));
      }
    }

    public InstanceNodeCollection<StyleSheet> Instances
    {
      get => new InstanceNodeCollection<StyleSheet>((IUANode) this);
    }
  }
}
