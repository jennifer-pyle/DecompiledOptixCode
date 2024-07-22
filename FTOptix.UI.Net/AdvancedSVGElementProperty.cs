// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AdvancedSVGImageElementProperty
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1108)]
  public class AdvancedSVGImageElementProperty : UAObject
  {
    public string ID
    {
      get => (string) this.Refs.GetVariable(nameof (ID)).Value.Value;
      set => this.Refs.GetVariable(nameof (ID)).SetValue((object) value);
    }

    public IUAVariable IDVariable => this.Refs.GetVariable("ID");

    public AdvancedSVGImagePropertyClass Property
    {
      get => (AdvancedSVGImagePropertyClass) this.Refs.GetVariable(nameof (Property)).Value.Value;
      set => this.Refs.GetVariable(nameof (Property)).SetValue((object) (int) value);
    }

    public IUAVariable PropertyVariable => this.Refs.GetVariable("Property");

    public object Value
    {
      get => this.Refs.GetVariable(nameof (Value)).Value.Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue(value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");
  }
}
