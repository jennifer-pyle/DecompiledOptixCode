﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.ReportDataGridImageItemTemplateType
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 386)]
  public class ReportDataGridImageItemTemplateType : DataGridImageItemTemplateType
  {
    public InstanceNodeCollection<ReportDataGridImageItemTemplate> Instances
    {
      get => new InstanceNodeCollection<ReportDataGridImageItemTemplate>((IUANode) this);
    }
  }
}
