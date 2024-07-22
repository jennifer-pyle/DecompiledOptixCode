// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ScaleLayout
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1140)]
  public class ScaleLayout : Container
  {
    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);

    public FillMode FillMode
    {
      get => (FillMode) (int) this.GetOptionalVariableValue(nameof (FillMode));
      set => this.SetOptionalVariableValue(nameof (FillMode), new UAValue((int) value));
    }

    public IUAVariable FillModeVariable => this.GetOrCreateVariable("FillMode");

    public bool FontScaling
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FontScaling));
      set => this.SetOptionalVariableValue(nameof (FontScaling), new UAValue(value));
    }

    public IUAVariable FontScalingVariable => this.GetOrCreateVariable("FontScaling");

    public float OriginalWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (OriginalWidth));
      set => this.SetOptionalVariableValue(nameof (OriginalWidth), new UAValue(value));
    }

    public IUAVariable OriginalWidthVariable => this.GetOrCreateVariable("OriginalWidth");

    public float OriginalHeight
    {
      get => (float) this.GetOptionalVariableValue(nameof (OriginalHeight));
      set => this.SetOptionalVariableValue(nameof (OriginalHeight), new UAValue(value));
    }

    public IUAVariable OriginalHeightVariable => this.GetOrCreateVariable("OriginalHeight");
  }
}
