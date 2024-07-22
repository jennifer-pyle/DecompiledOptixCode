// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.RowLayoutType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 7)]
  public class RowLayoutType : ContainerType
  {
    public ContentHorizontalAlignment ContentAlignment
    {
      get
      {
        return (ContentHorizontalAlignment) (int) this.GetOptionalVariableValue(nameof (ContentAlignment));
      }
      set => this.SetOptionalVariableValue(nameof (ContentAlignment), new UAValue((int) value));
    }

    public IUAVariable ContentAlignmentVariable => this.GetOrCreateVariable("ContentAlignment");

    public bool Wrap
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Wrap));
      set => this.SetOptionalVariableValue(nameof (Wrap), new UAValue(value));
    }

    public IUAVariable WrapVariable => this.GetOrCreateVariable("Wrap");

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
