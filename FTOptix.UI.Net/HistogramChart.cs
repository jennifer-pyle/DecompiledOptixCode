// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.HistogramChart
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1073)]
  public class HistogramChart : Item
  {
    public NodeId Model
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Model)).Value.Value;
      set => this.Refs.GetVariable(nameof (Model)).SetValue((object) value);
    }

    public NodePointer ModelVariable => (NodePointer) this.Refs.GetVariable("Model");

    public string Query
    {
      get => (string) this.GetOptionalVariableValue(nameof (Query));
      set => this.SetOptionalVariableValue(nameof (Query), new UAValue(value));
    }

    public IUAVariable QueryVariable => this.GetOrCreateVariable("Query");

    public LocalizedText Label
    {
      get => (LocalizedText) this.Refs.GetVariable(nameof (Label)).Value.Value;
      set => this.Refs.GetVariable(nameof (Label)).SetValue((object) value);
    }

    public IUAVariable LabelVariable => this.Refs.GetVariable("Label");

    public double Value
    {
      get => (double) this.Refs.GetVariable(nameof (Value)).Value.Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue((object) value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");

    public bool LabelVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (LabelVisible));
      set => this.SetOptionalVariableValue(nameof (LabelVisible), new UAValue(value));
    }

    public IUAVariable LabelVisibleVariable => this.GetOrCreateVariable("LabelVisible");

    public bool ValueVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ValueVisible));
      set => this.SetOptionalVariableValue(nameof (ValueVisible), new UAValue(value));
    }

    public IUAVariable ValueVisibleVariable => this.GetOrCreateVariable("ValueVisible");

    public bool ValueAxisVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ValueAxisVisible));
      set => this.SetOptionalVariableValue(nameof (ValueAxisVisible), new UAValue(value));
    }

    public IUAVariable ValueAxisVisibleVariable => this.GetOrCreateVariable("ValueAxisVisible");

    public Orientation Orientation
    {
      get => (Orientation) (int) this.GetOptionalVariableValue(nameof (Orientation));
      set => this.SetOptionalVariableValue(nameof (Orientation), new UAValue((object) value));
    }

    public IUAVariable OrientationVariable => this.GetOrCreateVariable("OrientationVisible");

    public Color BarColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BarColor)));
      set => this.SetOptionalVariableValue(nameof (BarColor), new UAValue(value.ARGB));
    }

    public IUAVariable BarColorVariable => this.GetOrCreateVariable("BarColor");

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
