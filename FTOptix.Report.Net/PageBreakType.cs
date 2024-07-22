// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.PageBreakType
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.Core;
using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 27)]
  public class PageBreakType : RectangleType
  {
    public new HorizontalAlignment HorizontalAlignment
    {
      get
      {
        return (HorizontalAlignment) (int) this.GetOptionalVariableValue(nameof (HorizontalAlignment));
      }
    }

    public new VerticalAlignment VerticalAlignment
    {
      get => (VerticalAlignment) (int) this.GetOptionalVariableValue(nameof (VerticalAlignment));
    }

    public new float Width => (float) this.GetOptionalVariableValue(nameof (Width));

    public new float Height => (float) this.GetOptionalVariableValue(nameof (Height));

    public new float LeftMargin => (float) this.GetOptionalVariableValue(nameof (LeftMargin));

    public new float RightMargin => (float) this.GetOptionalVariableValue(nameof (RightMargin));

    public new float TopMargin => (float) this.GetOptionalVariableValue(nameof (TopMargin));

    public new float BottomMargin => (float) this.GetOptionalVariableValue(nameof (BottomMargin));

    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new Color BorderColor => (Color) this.GetOptionalVariableValue(nameof (BorderColor));

    public new Color FillColor => (Color) this.GetOptionalVariableValue(nameof (FillColor));

    public new float BorderThickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderThickness));
    }

    public new float CornerRadius => (float) this.GetOptionalVariableValue(nameof (CornerRadius));

    public new bool HitTestVisible => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible));

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public InstanceNodeCollection<PageBreak> Instances
    {
      get => new InstanceNodeCollection<PageBreak>((IUANode) this);
    }
  }
}
