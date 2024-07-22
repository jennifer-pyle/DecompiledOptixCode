// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DataGridColumn
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 190)]
  public class DataGridColumn : UAObject
  {
    public string Title
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (Title)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (Title), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText LocalizedTitle
    {
      get => (LocalizedText) this.Refs.GetVariable("Title").Value.Value;
      set => this.Refs.GetVariable("Title").SetValue((object) value);
    }

    public IUAVariable TitleVariable => this.Refs.GetVariable("Title");

    public float Width
    {
      get => (float) this.Refs.GetVariable(nameof (Width)).Value.Value;
      set => this.Refs.GetVariable(nameof (Width)).SetValue((object) value);
    }

    public IUAVariable WidthVariable => this.Refs.GetVariable("Width");

    public bool Visible
    {
      get => (bool) this.Refs.GetVariable(nameof (Visible)).Value.Value;
      set => this.Refs.GetVariable(nameof (Visible)).SetValue((object) value);
    }

    public IUAVariable VisibleVariable => this.Refs.GetVariable("Visible");

    public TextHorizontalAlignment HeaderAlignment
    {
      get => (TextHorizontalAlignment) (int) this.Refs.GetVariable(nameof (HeaderAlignment)).Value;
      set => this.Refs.GetVariable(nameof (HeaderAlignment)).SetValue((object) (int) value);
    }

    public IUAVariable HeaderAlignmentVariable => this.Refs.GetVariable("HeaderAlignment");

    public HorizontalAlignment ContentAlignment
    {
      get => (HorizontalAlignment) (int) this.Refs.GetVariable(nameof (ContentAlignment)).Value;
      set => this.Refs.GetVariable(nameof (ContentAlignment)).SetValue((object) (int) value);
    }

    public IUAVariable ContentAlignmentVariable => this.Refs.GetVariable("ContentAlignment");

    public string OrderBy
    {
      get => (string) this.Refs.GetVariable(nameof (OrderBy)).Value.Value;
      set => this.Refs.GetVariable(nameof (OrderBy)).SetValue((object) value);
    }

    public IUAVariable OrderByVariable => this.Refs.GetVariable("OrderBy");

    public DataGridItemTemplate DataItemTemplate
    {
      get => (DataGridItemTemplate) this.Refs.GetObject(nameof (DataItemTemplate));
      set
      {
        this.Refs.GetObject(nameof (DataItemTemplate))?.Delete();
        if (value == null)
          return;
        this.Refs.AddReference(UAManagedCore.OpcUa.ReferenceTypes.HasComponent, (IUANode) value);
      }
    }
  }
}
