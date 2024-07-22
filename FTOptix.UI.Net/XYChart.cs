// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.XYChart
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 558)]
  public class XYChart : Item
  {
    public PlaceholderChildNodeCollection<XYChartPen> Pens
    {
      get => new PlaceholderChildNodeCollection<XYChartPen>((IUANode) this, nameof (Pens));
    }

    public double Zoom
    {
      get => (double) this.GetOptionalVariableValue(nameof (Zoom));
      set => this.SetOptionalVariableValue(nameof (Zoom), new UAValue(value));
    }

    public IUAVariable ZoomVariable => this.GetOrCreateVariable("Zoom");

    public double CenterX
    {
      get => (double) this.GetOptionalVariableValue(nameof (CenterX));
      set => this.SetOptionalVariableValue(nameof (CenterX), new UAValue(value));
    }

    public IUAVariable CenterXVariable => this.GetOrCreateVariable("CenterX");

    public double CenterY
    {
      get => (double) this.GetOptionalVariableValue(nameof (CenterY));
      set => this.SetOptionalVariableValue(nameof (CenterY), new UAValue(value));
    }

    public IUAVariable CenterYVariable => this.GetOrCreateVariable("CenterY");

    public bool LegendVisible
    {
      get => (bool) this.Refs.GetVariable(nameof (LegendVisible)).Value.Value;
      set => this.Refs.GetVariable(nameof (LegendVisible)).SetValue((object) value);
    }

    public IUAVariable LegendVisibleVariable => this.Refs.GetVariable("LegendVisible");

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public void Refresh() => this.ExecuteMethod(nameof (Refresh));

    public IUAMethod RefreshMethod => this.Refs.GetMethod("Refresh");
  }
}
