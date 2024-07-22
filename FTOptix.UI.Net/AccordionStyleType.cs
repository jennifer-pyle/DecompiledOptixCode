// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AccordionStyleType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 985)]
  public class AccordionStyleType : ControlStyleType
  {
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

    public float Radius
    {
      get => (float) this.GetOptionalVariableValue(nameof (Radius));
      set => this.SetOptionalVariableValue(nameof (Radius), new UAValue(value));
    }

    public IUAVariable RadiusVariable => this.GetOrCreateVariable("Radius");

    public Color HeaderBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (HeaderBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (HeaderBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable HeaderBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("HeaderBackgroundColor");
    }

    public HeaderIconPosition HeaderIconPosition
    {
      get => (HeaderIconPosition) (int) this.GetOptionalVariableValue(nameof (HeaderIconPosition));
      set => this.SetOptionalVariableValue(nameof (HeaderIconPosition), new UAValue((int) value));
    }

    public IUAVariable HeaderIconPositionVariable => this.GetOrCreateVariable("HeaderIconPosition");

    public Color ContentBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (ContentBackgroundColor)));
      set
      {
        this.SetOptionalVariableValue(nameof (ContentBackgroundColor), new UAValue(value.ARGB));
      }
    }

    public IUAVariable ContentBackgroundColorVariable
    {
      get => this.GetOrCreateVariable("ContentBackgroundColor");
    }

    public InstanceNodeCollection<AccordionStyle> Instances
    {
      get => new InstanceNodeCollection<AccordionStyle>((IUANode) this);
    }
  }
}
