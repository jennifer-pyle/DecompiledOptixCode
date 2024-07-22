// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ScrollBarStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 957)]
  public class ScrollBarStyleType : ControlStyleType
  {
    public bool AutoHide
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AutoHide));
      set => this.SetOptionalVariableValue(nameof (AutoHide), new UAValue(value));
    }

    public IUAVariable AutoHideVariable => this.GetOrCreateVariable("AutoHide");

    public Color BackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (BackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable BackgroundColorVariable => this.GetOrCreateVariable("BackgroundColor");

    public float Size
    {
      get => (float) this.GetOptionalVariableValue(nameof (Size));
      set => this.SetOptionalVariableValue(nameof (Size), new UAValue(value));
    }

    public IUAVariable SizeVariable => this.GetOrCreateVariable("Size");

    public Color HandleColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HandleColor)));
      set => this.SetOptionalVariableValue(nameof (HandleColor), new UAValue(value.ARGB));
    }

    public IUAVariable HandleColorVariable => this.GetOrCreateVariable("HandleColor");

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

    public float HandleRadius
    {
      get => (float) this.GetOptionalVariableValue(nameof (HandleRadius));
      set => this.SetOptionalVariableValue(nameof (HandleRadius), new UAValue(value));
    }

    public IUAVariable HandleRadiusVariable => this.GetOrCreateVariable("HandleRadius");

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");

    public bool ShowButtons
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ShowButtons));
      set => this.SetOptionalVariableValue(nameof (ShowButtons), new UAValue(value));
    }

    public IUAVariable ShowButtonsVariable => this.GetOrCreateVariable("ShowButtons");

    public InstanceNodeCollection<ScrollBarStyle> Instances
    {
      get => new InstanceNodeCollection<ScrollBarStyle>((IUANode) this);
    }
  }
}
