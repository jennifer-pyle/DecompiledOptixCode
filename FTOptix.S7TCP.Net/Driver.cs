// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TCP.Driver
// Assembly: FTOptix.S7TCP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: CE29D4F9-3A52-4C85-9774-D6DA74ACB2D2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TCP.Net\1.0.8.38\Any\FTOptix.S7TCP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.S7TCP
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TCP", Number = 6)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public byte LocalDeviceId
    {
      get => (byte) this.Refs.GetVariable(nameof (LocalDeviceId)).Value.Value;
      set => this.Refs.GetVariable(nameof (LocalDeviceId)).SetValue((object) value);
    }

    public IUAVariable LocalDeviceIdVariable => this.Refs.GetVariable("LocalDeviceId");

    public byte LocalRack
    {
      get => (byte) this.Refs.GetVariable(nameof (LocalRack)).Value.Value;
      set => this.Refs.GetVariable(nameof (LocalRack)).SetValue((object) value);
    }

    public IUAVariable LocalRackVariable => this.Refs.GetVariable("LocalRack");

    public byte LocalSlot
    {
      get => (byte) this.Refs.GetVariable(nameof (LocalSlot)).Value.Value;
      set => this.Refs.GetVariable(nameof (LocalSlot)).SetValue((object) value);
    }

    public IUAVariable LocalSlotVariable => this.Refs.GetVariable("LocalSlot");

    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
