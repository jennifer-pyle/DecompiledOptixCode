// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.ReportImage
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.Core;
using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 327)]
  public class ReportImage : Image
  {
    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new bool HitTestVisible => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible));

    public new float ImageLeftMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageLeftMargin));
    }

    public new float ImageTopMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageTopMargin));
    }

    public new float ImageRightMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageRightMargin));
    }

    public new float ImageBottomMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageBottomMargin));
    }

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public new Color DynamicColor => (Color) this.GetOptionalVariableValue(nameof (DynamicColor));

    public new ColorizationMode ColorizationMode
    {
      get => (ColorizationMode) (int) this.GetOptionalVariableValue(nameof (ColorizationMode));
    }
  }
}
