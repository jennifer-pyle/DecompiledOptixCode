// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.XYChartScalarLinePenType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 569)]
  public class XYChartScalarLinePenType : XYChartLinePenType
  {
    public double X
    {
      get => (double) this.Refs.GetVariable(nameof (X)).Value.Value;
      set => this.Refs.GetVariable(nameof (X)).SetValue((object) value);
    }

    public IUAVariable XVariable => this.Refs.GetVariable("X");

    public double Y
    {
      get => (double) this.Refs.GetVariable(nameof (Y)).Value.Value;
      set => this.Refs.GetVariable(nameof (Y)).SetValue((object) value);
    }

    public IUAVariable YVariable => this.Refs.GetVariable("Y");

    public InstanceNodeCollection<XYChartScalarLinePen> Instances
    {
      get => new InstanceNodeCollection<XYChartScalarLinePen>((IUANode) this);
    }
  }
}
