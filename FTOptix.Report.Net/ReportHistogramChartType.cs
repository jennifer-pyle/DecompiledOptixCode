﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.ReportHistogramChartType
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 527)]
  public class ReportHistogramChartType : PieChartType
  {
    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public new string Style => (string) this.GetOptionalVariableValue(nameof (Style));

    public InstanceNodeCollection<ReportHistogramChart> Instances
    {
      get => new InstanceNodeCollection<ReportHistogramChart>((IUANode) this);
    }
  }
}
