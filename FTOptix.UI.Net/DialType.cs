// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DialType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 100)]
  public class DialType : ItemType
  {
    public double Position
    {
      get => (double) this.Refs.GetVariable(nameof (Position)).Value.Value;
      set => this.Refs.GetVariable(nameof (Position)).SetValue((object) value);
    }

    public IUAVariable PositionVariable => this.Refs.GetVariable("Position");

    public ValueChangeBehaviour ValueChangeBehaviour
    {
      get
      {
        return (ValueChangeBehaviour) (int) this.Refs.GetVariable(nameof (ValueChangeBehaviour)).Value;
      }
      set => this.Refs.GetVariable(nameof (ValueChangeBehaviour)).SetValue((object) (int) value);
    }

    public IUAVariable ValueChangeBehaviourVariable
    {
      get => this.Refs.GetVariable("ValueChangeBehaviour");
    }

    public InstanceNodeCollection<Dial> Instances
    {
      get => new InstanceNodeCollection<Dial>((IUANode) this);
    }
  }
}
