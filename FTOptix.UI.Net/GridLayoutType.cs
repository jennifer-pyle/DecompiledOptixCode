// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.GridLayoutType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1350)]
  public class GridLayoutType : ContainerType
  {
    public string[] Columns
    {
      get => (string[]) this.GetOptionalVariableValue(nameof (Columns)).Value;
      set => this.SetOptionalVariableValue(nameof (Columns), new UAValue(value));
    }

    public IUAVariable ColumnsVariable => this.GetOrCreateVariable("Columns");

    public string[] Rows
    {
      get => (string[]) this.GetOptionalVariableValue(nameof (Rows)).Value;
      set => this.SetOptionalVariableValue(nameof (Rows), new UAValue(value));
    }

    public IUAVariable RowsVariable => this.GetOrCreateVariable("Rows");

    public IUAVariable ItemsHorizontalAlignmentVariable
    {
      get => this.GetOrCreateVariable("ItemsHorizontalAlignment");
    }

    public VerticalAlignment ItemsVerticalAlignment
    {
      get
      {
        return (VerticalAlignment) (int) this.GetOptionalVariableValue(nameof (ItemsVerticalAlignment));
      }
      set
      {
        this.SetOptionalVariableValue(nameof (ItemsVerticalAlignment), new UAValue((int) value));
      }
    }

    public IUAVariable ItemsVerticalAlignmentVariable
    {
      get => this.GetOrCreateVariable("ItemsVerticalAlignment");
    }

    public float HorizontalGap
    {
      get => (float) this.GetOptionalVariableValue(nameof (HorizontalGap));
      set => this.SetOptionalVariableValue(nameof (HorizontalGap), new UAValue(value));
    }

    public IUAVariable HorizontalGapVariable => this.GetOrCreateVariable("HorizontalGap");

    public float VerticalGap
    {
      get => (float) this.GetOptionalVariableValue(nameof (VerticalGap));
      set => this.SetOptionalVariableValue(nameof (VerticalGap), new UAValue(value));
    }

    public IUAVariable VerticalGapVariable => this.GetOrCreateVariable("VerticalGap");

    public InstanceNodeCollection<RowLayout> Instances
    {
      get => new InstanceNodeCollection<RowLayout>((IUANode) this);
    }

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
