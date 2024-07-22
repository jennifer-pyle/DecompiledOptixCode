// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DataGridImageItemTemplateType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 200)]
  public class DataGridImageItemTemplateType : DataGridItemTemplateType
  {
    public ResourceUri Path
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (Path)).Value);
      set => this.Refs.GetVariable(nameof (Path)).SetValue((object) (string) value);
    }

    public IUAVariable PathVariable => this.Refs.GetVariable("Path");

    public float Width
    {
      get => (float) this.Refs.GetVariable(nameof (Width)).Value.Value;
      set => this.Refs.GetVariable(nameof (Width)).SetValue((object) value);
    }

    public IUAVariable WidthVariable => this.Refs.GetVariable("Width");

    public float Height
    {
      get => (float) this.Refs.GetVariable(nameof (Height)).Value.Value;
      set => this.Refs.GetVariable(nameof (Height)).SetValue((object) value);
    }

    public IUAVariable HeightVariable => this.Refs.GetVariable("Height");

    public InstanceNodeCollection<DataGridImageItemTemplate> Instances
    {
      get => new InstanceNodeCollection<DataGridImageItemTemplate>((IUANode) this);
    }
  }
}
