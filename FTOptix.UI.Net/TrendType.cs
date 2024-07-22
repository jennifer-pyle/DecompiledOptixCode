// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.TrendType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 223)]
  public class TrendType : ItemType
  {
    public PlaceholderChildNodeCollection<TrendPen> Pens
    {
      get => new PlaceholderChildNodeCollection<TrendPen>((IUANode) this, nameof (Pens));
    }

    public uint RefreshTime
    {
      get => (uint) this.GetOptionalVariableValue(nameof (RefreshTime));
      set => this.SetOptionalVariableValue(nameof (RefreshTime), new UAValue(value));
    }

    public IUAVariable RefreshTimeVariable => this.GetOrCreateVariable("RefreshTime");

    public ReferenceTimeZone ReferenceTimeZone
    {
      get => (ReferenceTimeZone) (int) this.GetOptionalVariableValue(nameof (ReferenceTimeZone));
      set => this.SetOptionalVariableValue(nameof (ReferenceTimeZone), new UAValue((int) value));
    }

    public IUAVariable ReferenceTimeZoneVariable => this.GetOrCreateVariable("ReferenceTimeZone");

    public DateTimeAxis XAxis => (DateTimeAxis) this.Refs.GetObject(nameof (XAxis));

    public ValueAxis YAxis => (ValueAxis) this.Refs.GetObject(nameof (YAxis));

    public bool LegendVisible
    {
      get => (bool) this.Refs.GetVariable(nameof (LegendVisible)).Value.Value;
      set => this.Refs.GetVariable(nameof (LegendVisible)).SetValue((object) value);
    }

    public IUAVariable LegendVisibleVariable => this.Refs.GetVariable("LegendVisible");

    public InstanceNodeCollection<Trend> Instances
    {
      get => new InstanceNodeCollection<Trend>((IUANode) this);
    }

    public NodeId Model
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (Model));
      set => this.SetOptionalVariableValue(nameof (Model), new UAValue(value));
    }

    public NodePointer ModelVariable => (NodePointer) this.GetOrCreateVariable("Model");

    public string Query
    {
      get => (string) this.GetOptionalVariableValue(nameof (Query));
      set => this.SetOptionalVariableValue(nameof (Query), new UAValue(value));
    }

    public IUAVariable QueryVariable => this.GetOrCreateVariable("Query");

    public void Refresh() => this.ExecuteMethod(nameof (Refresh));

    public IUAMethod RefreshMethod => this.Refs.GetMethod("Refresh");

    public TrendMode Mode
    {
      get => (TrendMode) (int) this.GetOptionalVariableValue(nameof (Mode));
      set => this.SetOptionalVariableValue(nameof (Mode), new UAValue((int) value));
    }

    public string ButtonStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ButtonStyle));
      set => this.SetOptionalVariableValue(nameof (ButtonStyle), new UAValue(value));
    }

    public IUAVariable ButtonStyleVariable => this.GetOrCreateVariable("ButtonStyle");

    public string ChartStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ChartStyle));
      set => this.SetOptionalVariableValue(nameof (ChartStyle), new UAValue(value));
    }

    public string ToolTipStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ToolTipStyle));
      set => this.SetOptionalVariableValue(nameof (ToolTipStyle), new UAValue(value));
    }

    public IUAVariable ToolTipStyleVariable => this.GetOrCreateVariable("ToolTipStyle");

    public IUAVariable ChartStyleVariable => this.GetOrCreateVariable("ChartStyle");

    public IUAVariable ModeVariable => this.GetOrCreateVariable("Mode");

    public void ClearTimeTraces() => this.ExecuteMethod(nameof (ClearTimeTraces));

    public IUAMethod ClearTimeTracesMethod => this.Refs.GetMethod("ClearTimeTraces");

    public PlaceholderReadOnlyChildNodeCollection<IUAVariable> TimeRanges
    {
      get
      {
        return new PlaceholderReadOnlyChildNodeCollection<IUAVariable>((IUANode) this, nameof (TimeRanges));
      }
    }

    public void ClearTimeRanges() => this.ExecuteMethod(nameof (ClearTimeRanges));

    public IUAMethod ClearTimeRangesMethod => this.Refs.GetMethod("ClearTimeRanges");
  }
}
