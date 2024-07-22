// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ScrollViewType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 362)]
  public class ScrollViewType : ContainerType
  {
    public bool Zoommable
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Zoommable));
      set => this.SetOptionalVariableValue(nameof (Zoommable), new UAValue(value));
    }

    public IUAVariable ZoommableVariable => this.GetOrCreateVariable("Zoommable");

    public int MaxZoomIn
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaxZoomIn));
      set => this.SetOptionalVariableValue(nameof (MaxZoomIn), new UAValue(value));
    }

    public IUAVariable MaxZoomInVariable => this.GetOrCreateVariable("MaxZoomIn");

    public int MinZoomOut
    {
      get => (int) this.GetOptionalVariableValue(nameof (MinZoomOut));
      set => this.SetOptionalVariableValue(nameof (MinZoomOut), new UAValue(value));
    }

    public IUAVariable MinZoomOutVariable => this.GetOrCreateVariable("MinZoomOut");

    public ScrollAxesEnabled ScrollAxesEnabled
    {
      get => (ScrollAxesEnabled) (int) this.GetOptionalVariableValue(nameof (ScrollAxesEnabled));
      set => this.SetOptionalVariableValue(nameof (ScrollAxesEnabled), new UAValue((int) value));
    }

    public IUAVariable ScrollAxesEnabledVariable => this.GetOrCreateVariable("ScrollAxesEnabled");

    public string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
      set => this.SetOptionalVariableValue(nameof (ScrollBarStyle), new UAValue(value));
    }

    public IUAVariable ScrollBarStyleVariable => this.GetOrCreateVariable("ScrollBarStyle");

    public InstanceNodeCollection<ScrollView> Instances
    {
      get => new InstanceNodeCollection<ScrollView>((IUANode) this);
    }

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
