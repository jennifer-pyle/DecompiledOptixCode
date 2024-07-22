// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.DataGridSection
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 38)]
  public class DataGridSection : DataGrid
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

    public new float BottomMargin => (float) this.GetOptionalVariableValue(nameof (BottomMargin));

    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public new string InputBoxStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (InputBoxStyle));
    }

    public new string DataListStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (DataListStyle));
    }

    public new string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
    }

    public PlaceholderChildNodeCollection<ReportDataGridColumn> Columns
    {
      get
      {
        return new PlaceholderChildNodeCollection<ReportDataGridColumn>((IUANode) this, nameof (Columns));
      }
    }

    public new NodeId SelectedItem
    {
      get => (NodeId) this.Refs.GetVariable(nameof (SelectedItem)).Value.Value;
    }
  }
}
