// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.SparklineType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1223)]
  public class SparklineType : ItemType
  {
    public object PenValue
    {
      get => this.Refs.GetVariable(nameof (PenValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (PenValue)).SetValue(value);
    }

    public IUAVariable PenValueVariable => this.Refs.GetVariable("PenValue");

    public Color PenColor
    {
      get => (Color) this.GetOptionalVariableValue(nameof (PenColor));
      set => this.SetOptionalVariableValue(nameof (PenColor), new UAValue((object) value));
    }

    public IUAVariable PenColorVariable => this.GetOrCreateVariable("PenColor");

    public float PenThickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (PenThickness));
      set => this.SetOptionalVariableValue(nameof (PenThickness), new UAValue(value));
    }

    public IUAVariable PenThicknessVariable => this.GetOrCreateVariable("PenThickness");

    public double TimeWindow
    {
      get => (double) this.Refs.GetVariable(nameof (TimeWindow)).Value.Value;
      set => this.Refs.GetVariable(nameof (TimeWindow)).SetValue((object) value);
    }

    public IUAVariable TimeWindowVariable => this.Refs.GetVariable("TimeWindow");

    public double RefreshTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (RefreshTime));
      set => this.SetOptionalVariableValue(nameof (RefreshTime), new UAValue(value));
    }

    public IUAVariable RefreshTimeVariable => this.GetOrCreateVariable("RefreshTime");

    public double YAxisMaximum
    {
      get => (double) this.GetOptionalVariableValue(nameof (YAxisMaximum));
      set => this.SetOptionalVariableValue(nameof (YAxisMaximum), new UAValue(value));
    }

    public IUAVariable YAxisMaximumVariable => this.GetOrCreateVariable("YAxisMaximum");

    public double YAxisMinimum
    {
      get => (double) this.GetOptionalVariableValue(nameof (YAxisMinimum));
      set => this.SetOptionalVariableValue(nameof (YAxisMinimum), new UAValue(value));
    }

    public IUAVariable YAxisMinimumVariable => this.GetOrCreateVariable("YAxisMinimum");

    public double RangeHigh
    {
      get => (double) this.GetOptionalVariableValue(nameof (RangeHigh));
      set => this.SetOptionalVariableValue(nameof (RangeHigh), new UAValue(value));
    }

    public IUAVariable RangeHighVariable => this.GetOrCreateVariable("RangeHigh");

    public double RangeLow
    {
      get => (double) this.GetOptionalVariableValue(nameof (RangeLow));
      set => this.SetOptionalVariableValue(nameof (RangeLow), new UAValue(value));
    }

    public IUAVariable RangeLowVariable => this.GetOrCreateVariable("RangeLow");

    public Color RangeColor
    {
      get => (Color) this.GetOptionalVariableValue(nameof (RangeColor));
      set => this.SetOptionalVariableValue(nameof (RangeColor), new UAValue((object) value));
    }

    public IUAVariable RangeColorVariable => this.GetOrCreateVariable("RangeColor");

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public InstanceNodeCollection<Sparkline> Instances
    {
      get => new InstanceNodeCollection<Sparkline>((IUANode) this);
    }
  }
}
