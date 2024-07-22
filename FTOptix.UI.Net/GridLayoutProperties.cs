// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.GridLayoutProperties
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1345)]
  public class GridLayoutProperties : UAObject
  {
    public int ColumnStart
    {
      get => (int) this.GetOptionalVariableValue(nameof (ColumnStart));
      set => this.SetOptionalVariableValue(nameof (ColumnStart), new UAValue(value));
    }

    public IUAVariable ColumnStartVariable => this.GetOrCreateVariable("ColumnStart");

    public int ColumnSpan
    {
      get => (int) this.GetOptionalVariableValue(nameof (ColumnSpan));
      set => this.SetOptionalVariableValue(nameof (ColumnSpan), new UAValue(value));
    }

    public IUAVariable ColumnSpanVariable => this.GetOrCreateVariable("ColumnSpan");

    public int RowStart
    {
      get => (int) this.GetOptionalVariableValue(nameof (RowStart));
      set => this.SetOptionalVariableValue(nameof (RowStart), new UAValue(value));
    }

    public IUAVariable RowStartVariable => this.GetOrCreateVariable("RowStart");

    public int RowSpan
    {
      get => (int) this.GetOptionalVariableValue(nameof (RowSpan));
      set => this.SetOptionalVariableValue(nameof (RowSpan), new UAValue(value));
    }

    public IUAVariable RowSpanVariable => this.GetOrCreateVariable("RowSpan");

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
