// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronEthernetIP.Station
// Assembly: FTOptix.OmronEthernetIP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 41B722E7-479B-45E5-98C5-B6231316318E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronEthernetIP.Net\1.0.8.38\Any\FTOptix.OmronEthernetIP.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.OmronEthernetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronEthernetIP", Number = 5)]
  public class Station : CommunicationStation
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

    public uint CpuSlot
    {
      get => (uint) this.Refs.GetVariable(nameof (CpuSlot)).Value.Value;
      set => this.Refs.GetVariable(nameof (CpuSlot)).SetValue((object) value);
    }

    public IUAVariable CpuSlotVariable => this.Refs.GetVariable("CpuSlot");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }
  }
}
