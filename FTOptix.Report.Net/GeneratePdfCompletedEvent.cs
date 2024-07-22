// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.GeneratePdfCompletedEvent
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [CustomEventType(NamespaceUri = "urn:FTOptix:Report", Number = 378)]
  public class GeneratePdfCompletedEvent
  {
    public ResourceUri OutputPath { get; set; }

    public GeneratePdfCompletedResult Result { get; set; }

    public Guid OperationId { get; set; }
  }
}
