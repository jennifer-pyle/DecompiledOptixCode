// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ScreenType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1170)]
  public class ScreenType : PanelType
  {
    public Color BackgroundColor
    {
      get => (Color) this.GetOptionalVariableValue(nameof (BackgroundColor));
      set => this.SetOptionalVariableValue(nameof (BackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable BackgroundColorVariable => this.GetOrCreateVariable("BackgroundColor");

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public float BorderThickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderThickness));
      set => this.SetOptionalVariableValue(nameof (BorderThickness), new UAValue(value));
    }

    public IUAVariable BorderThicknessVariable => this.GetOrCreateVariable("BorderThickness");

    public InstanceNodeCollection<Screen> Instances
    {
      get => new InstanceNodeCollection<Screen>((IUANode) this);
    }

    public new ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
