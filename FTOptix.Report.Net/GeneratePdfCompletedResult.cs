﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.GeneratePdfCompletedResult
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

#nullable disable
namespace FTOptix.Report
{
  public enum GeneratePdfCompletedResult
  {
    PdfSuccessfullyGenerated,
    UnsupportedLocaleId,
    FailedToProcessTemplate,
    UnableToOverwriteOutputFile,
    UnableToGeneratePdf,
    EmptyOrInvalidOutputResourceUri,
  }
}
