// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ComboBoxType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 209)]
  public class ComboBoxType : ItemType
  {
    public LocalizedText Text
    {
      get => (LocalizedText) this.Refs.GetVariable(nameof (Text)).Value.Value;
      set => this.Refs.GetVariable(nameof (Text)).SetValue((object) value);
    }

    public IUAVariable TextVariable => this.Refs.GetVariable("Text");

    public NodeId Model
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Model)).Value.Value;
      set => this.Refs.GetVariable(nameof (Model)).SetValue((object) value);
    }

    public NodePointer ModelVariable => (NodePointer) this.Refs.GetVariable("Model");

    public object SelectedValue
    {
      get => this.Refs.GetVariable(nameof (SelectedValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (SelectedValue)).SetValue(value);
    }

    public IUAVariable SelectedValueVariable => this.Refs.GetVariable("SelectedValue");

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

    public object UISelectedValue => this.Refs.GetVariable(nameof (UISelectedValue)).Value.Value;

    public IUAVariable UISelectedValueVariable => this.Refs.GetVariable("UISelectedValue");

    public bool AllowDeselection
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AllowDeselection));
      set => this.SetOptionalVariableValue(nameof (AllowDeselection), new UAValue(value));
    }

    public IUAVariable AllowDeselectionVariable => this.GetOrCreateVariable("AllowDeselection");

    public LocalizedText DisplayValuePath
    {
      get => (LocalizedText) this.GetOptionalVariableValue(nameof (DisplayValuePath));
      set => this.SetOptionalVariableValue(nameof (DisplayValuePath), new UAValue(value));
    }

    public IUAVariable DisplayValuePathVariable => this.GetOrCreateVariable("DisplayValuePath");

    public object SelectedValuePath
    {
      get => this.GetOptionalVariableValue(nameof (SelectedValuePath)).Value;
      set => this.SetOptionalVariableValue(nameof (SelectedValuePath), new UAValue(value));
    }

    public IUAVariable SelectedValuePathVariable => this.GetOrCreateVariable("SelectedValuePath");

    public string Query
    {
      get => (string) this.GetOptionalVariableValue(nameof (Query));
      set => this.SetOptionalVariableValue(nameof (Query), new UAValue(value));
    }

    public IUAVariable QueryVariable => this.GetOrCreateVariable("Query");

    public ComboBoxMode Mode
    {
      get => (ComboBoxMode) (int) this.GetOptionalVariableValue(nameof (Mode));
      set => this.SetOptionalVariableValue(nameof (Mode), new UAValue((int) value));
    }

    public IUAVariable ModeVariable => this.GetOrCreateVariable("Mode");

    public string FontFamily
    {
      get => (string) this.GetOptionalVariableValue(nameof (FontFamily));
      set => this.SetOptionalVariableValue(nameof (FontFamily), new UAValue(value));
    }

    public IUAVariable FontFamilyVariable => this.GetOrCreateVariable("FontFamily");

    public FontWeight FontWeight
    {
      get => (FontWeight) (int) this.GetOptionalVariableValue(nameof (FontWeight));
      set => this.SetOptionalVariableValue(nameof (FontWeight), new UAValue((int) value));
    }

    public IUAVariable FontWeightVariable => this.GetOrCreateVariable("FontWeight");

    public bool FontItalic
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FontItalic));
      set => this.SetOptionalVariableValue(nameof (FontItalic), new UAValue(value));
    }

    public IUAVariable FontItalicVariable => this.GetOrCreateVariable("FontItalic");

    public float FontSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (FontSize));
      set => this.SetOptionalVariableValue(nameof (FontSize), new UAValue(value));
    }

    public IUAVariable FontSizeVariable => this.GetOrCreateVariable("FontSize");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public SortOrder SortOrder
    {
      get => (SortOrder) (int) this.GetOptionalVariableValue(nameof (SortOrder));
      set => this.SetOptionalVariableValue(nameof (SortOrder), new UAValue((int) value));
    }

    public IUAVariable SortOrderVariable => this.GetOrCreateVariable("SortOrder");

    public string OrderBy
    {
      get => (string) this.GetOptionalVariableValue(nameof (OrderBy));
      set => this.SetOptionalVariableValue(nameof (OrderBy), new UAValue(value));
    }

    public IUAVariable OrderByVariable => this.GetOrCreateVariable("OrderBy");

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

    public InstanceNodeCollection<ComboBox> Instances
    {
      get => new InstanceNodeCollection<ComboBox>((IUANode) this);
    }
  }
}
