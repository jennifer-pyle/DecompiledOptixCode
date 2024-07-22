// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.XYChartArrayLinePenType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 574)]
  public class XYChartArrayLinePenType : XYChartLinePenType
  {
    public double[,] PointArray
    {
      get => (double[,]) this.Refs.GetVariable(nameof (PointArray)).Value.Value;
      set => this.Refs.GetVariable(nameof (PointArray)).SetValue((object) value);
    }

    public IUAVariable PointArrayVariable => this.Refs.GetVariable("PointArray");

    public bool Editable
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Editable));
      set => this.SetOptionalVariableValue(nameof (Editable), new UAValue(value));
    }

    public IUAVariable EditableVariable => this.GetOrCreateVariable("Editable");

    public InstanceNodeCollection<XYChartArrayLinePen> Instances
    {
      get => new InstanceNodeCollection<XYChartArrayLinePen>((IUANode) this);
    }
  }
}
