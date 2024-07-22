// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ListBox
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 181)]
  public class ListBox : Item
  {
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

    public string DataListStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (DataListStyle));
      set => this.SetOptionalVariableValue(nameof (DataListStyle), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("DataListStyle");

    public string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
      set => this.SetOptionalVariableValue(nameof (ScrollBarStyle), new UAValue(value));
    }

    public IUAVariable ScrollBarStyleVariable => this.GetOrCreateVariable("ScrollBarStyle");

    public void Refresh() => this.ExecuteMethod(nameof (Refresh));

    public IUAMethod RefreshMethod => this.Refs.GetMethod("Refresh");

    public event EventHandler<UserSelectionChangedEvent> OnUserSelectionChanged
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 674U), typeof (EventHandler<UserSelectionChangedEvent>), typeof (UserSelectionChangedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 674U), typeof (EventHandler<UserSelectionChangedEvent>), typeof (UserSelectionChangedEvent)).Remove((Delegate) value);
      }
    }
  }
}
