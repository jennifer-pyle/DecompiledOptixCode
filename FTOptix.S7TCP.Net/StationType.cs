// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TCP.StationType
// Assembly: FTOptix.S7TCP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: CE29D4F9-3A52-4C85-9774-D6DA74ACB2D2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TCP.Net\1.0.8.38\Any\FTOptix.S7TCP.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.S7TCP
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TCP", Number = 7)]
  public class StationType : CommunicationStationType
  {
    public uint MaximumJobSizeInBytes
    {
      get => (uint) this.Refs.GetVariable(nameof (MaximumJobSizeInBytes)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaximumJobSizeInBytes)).SetValue((object) value);
    }

    public IUAVariable MaximumJobSizeInBytesVariable
    {
      get => this.Refs.GetVariable("MaximumJobSizeInBytes");
    }

    public uint MaximumGapInBytes
    {
      get => (uint) this.Refs.GetVariable(nameof (MaximumGapInBytes)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaximumGapInBytes)).SetValue((object) value);
    }

    public IUAVariable MaximumGapInBytesVariable => this.Refs.GetVariable("MaximumGapInBytes");

    public string IPAddress
    {
      get => (string) this.Refs.GetVariable(nameof (IPAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (IPAddress)).SetValue((object) value);
    }

    public IUAVariable IPAddressVariable => this.Refs.GetVariable("IPAddress");

    public ushort Port
    {
      get => (ushort) this.Refs.GetVariable(nameof (Port)).Value.Value;
      set => this.Refs.GetVariable(nameof (Port)).SetValue((object) value);
    }

    public IUAVariable PortVariable => this.Refs.GetVariable("Port");

    public double Timeout
    {
      get => (double) this.Refs.GetVariable(nameof (Timeout)).Value.Value;
      set => this.Refs.GetVariable(nameof (Timeout)).SetValue((object) value);
    }

    public IUAVariable TimeoutVariable => this.Refs.GetVariable("Timeout");

    public byte RemoteDeviceId
    {
      get => (byte) this.Refs.GetVariable(nameof (RemoteDeviceId)).Value.Value;
      set => this.Refs.GetVariable(nameof (RemoteDeviceId)).SetValue((object) value);
    }

    public IUAVariable RemoteDeviceIdVariable => this.Refs.GetVariable("RemoteDeviceId");

    public byte RemoteRack
    {
      get => (byte) this.Refs.GetVariable(nameof (RemoteRack)).Value.Value;
      set => this.Refs.GetVariable(nameof (RemoteRack)).SetValue((object) value);
    }

    public IUAVariable RemoteRackVariable => this.Refs.GetVariable("RemoteRack");

    public byte RemoteSlot
    {
      get => (byte) this.Refs.GetVariable(nameof (RemoteSlot)).Value.Value;
      set => this.Refs.GetVariable(nameof (RemoteSlot)).SetValue((object) value);
    }

    public IUAVariable RemoteSlotVariable => this.Refs.GetVariable("RemoteSlot");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }

    public InstanceNodeCollection<Station> Instances
    {
      get => new InstanceNodeCollection<Station>((IUANode) this);
    }
  }
}
