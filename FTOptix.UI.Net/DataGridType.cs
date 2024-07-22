// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DataGridType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 186)]
  public class DataGridType : ItemType
  {
    public NodeId Model
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Model)).Value.Value;
      set => this.Refs.GetVariable(nameof (Model)).SetValue((object) value);
    }

    public NodePointer ModelVariable => (NodePointer) this.Refs.GetVariable("Model");

    public string Query
    {
      get => (string) this.Refs.GetVariable(nameof (Query)).Value.Value;
      set => this.Refs.GetVariable(nameof (Query)).SetValue((object) value);
    }

    public IUAVariable QueryVariable => this.Refs.GetVariable("Query");

    public double AutoRefreshTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (AutoRefreshTime));
      set => this.SetOptionalVariableValue(nameof (AutoRefreshTime), new UAValue(value));
    }

    public IUAVariable AutoRefreshTimeVariable => this.GetOrCreateVariable("AutoRefreshTime");

    public PlaceholderChildNodeCollection<DataGridColumn> Columns
    {
      get => new PlaceholderChildNodeCollection<DataGridColumn>((IUANode) this, nameof (Columns));
    }

    public NodeId SelectedItem
    {
      get => (NodeId) this.Refs.GetVariable(nameof (SelectedItem)).Value.Value;
      set => this.Refs.GetVariable(nameof (SelectedItem)).SetValue((object) value);
    }

    public NodePointer SelectedItemVariable => (NodePointer) this.Refs.GetVariable("SelectedItem");

    public NodeId UISelectedItem
    {
      get => (NodeId) this.Refs.GetVariable(nameof (UISelectedItem)).Value.Value;
    }

    public IUAVariable UISelectedItemVariable => this.Refs.GetVariable("UISelectedItem");

    public bool AllowDeselection
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AllowDeselection));
      set => this.SetOptionalVariableValue(nameof (AllowDeselection), new UAValue(value));
    }

    public IUAVariable AllowDeselectionVariable => this.GetOrCreateVariable("AllowDeselection");

    public NodeId SortColumn
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (SortColumn));
      set => this.SetOptionalVariableValue(nameof (SortColumn), new UAValue(value));
    }

    public IUAVariable SortColumnVariable => this.GetOrCreateVariable("SortColumn");

    public SortOrder SortOrder
    {
      get => (SortOrder) (int) this.GetOptionalVariableValue(nameof (SortOrder));
      set => this.SetOptionalVariableValue(nameof (SortOrder), new UAValue((int) value));
    }

    public IUAVariable SortOrderVariable => this.GetOrCreateVariable("SortOrder");

    public IUAObject ViewModels => this.GetOrCreateObject(nameof (ViewModels));

    public Color RowBackgroundColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (RowBackgroundColor)));
      set => this.SetOptionalVariableValue(nameof (RowBackgroundColor), new UAValue(value.ARGB));
    }

    public IUAVariable RowBackgroundColorVariable => this.GetOrCreateVariable("RowBackgroundColor");

    public Color RowTextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (RowTextColor)));
      set => this.SetOptionalVariableValue(nameof (RowTextColor), new UAValue(value.ARGB));
    }

    public IUAVariable RowTextColorVariable => this.GetOrCreateVariable("RowTextColor");

    public string InputBoxStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (InputBoxStyle));
      set => this.SetOptionalVariableValue(nameof (InputBoxStyle), new UAValue(value));
    }

    public IUAVariable InputBoxStyleVariable => this.GetOrCreateVariable("InputBoxStyle");

    public string DataListStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (DataListStyle));
      set => this.SetOptionalVariableValue(nameof (DataListStyle), new UAValue(value));
    }

    public IUAVariable DataListStyleVariable => this.GetOrCreateVariable("DataListStyle");

    public string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
      set => this.SetOptionalVariableValue(nameof (ScrollBarStyle), new UAValue(value));
    }

    public IUAVariable ScrollBarStyleVariable => this.GetOrCreateVariable("ScrollBarStyle");

    public void Refresh() => this.ExecuteMethod(nameof (Refresh));

    public IUAMethod RefreshMethod => this.Refs.GetMethod("Refresh");

    public InstanceNodeCollection<DataGrid> Instances
    {
      get => new InstanceNodeCollection<DataGrid>((IUANode) this);
    }
  }
}
