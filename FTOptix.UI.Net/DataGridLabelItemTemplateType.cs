// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DataGridLabelItemTemplateType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 197)]
  public class DataGridLabelItemTemplateType : DataGridItemTemplateType
  {
    public LocalizedText Text
    {
      get => (LocalizedText) this.Refs.GetVariable(nameof (Text)).Value.Value;
      set => this.Refs.GetVariable(nameof (Text)).SetValue((object) value);
    }

    public IUAVariable TextVariable => this.Refs.GetVariable("Text");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public InstanceNodeCollection<DataGridLabelItemTemplate> Instances
    {
      get => new InstanceNodeCollection<DataGridLabelItemTemplate>((IUANode) this);
    }
  }
}
