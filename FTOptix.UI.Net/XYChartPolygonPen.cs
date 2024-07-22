// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.XYChartPolygonPen
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 615)]
  public class XYChartPolygonPen : XYChartPen
  {
    public double[,] PointArray
    {
      get => (double[,]) this.Refs.GetVariable(nameof (PointArray)).Value.Value;
      set => this.Refs.GetVariable(nameof (PointArray)).SetValue((object) value);
    }

    public IUAVariable PointArrayVariable => this.Refs.GetVariable("PointArray");

    public Color FillColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FillColor)));
      set => this.SetOptionalVariableValue(nameof (FillColor), new UAValue(value.ARGB));
    }

    public IUAVariable FillColorVariable => this.GetOrCreateVariable("FillColor");

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public float Thickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (Thickness));
      set => this.SetOptionalVariableValue(nameof (Thickness), new UAValue(value));
    }

    public IUAVariable ThicknessVariable => this.GetOrCreateVariable("Thickness");
  }
}
