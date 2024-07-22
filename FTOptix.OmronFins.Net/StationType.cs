// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronFins.StationType
// Assembly: FTOptix.OmronFins.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 4638714C-7F4C-46B4-B420-EAFE85857675
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronFins.Net\1.0.8.38\Any\FTOptix.OmronFins.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.OmronFins
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronFins", Number = 18)]
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

    public byte SourceNetworkAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (SourceNetworkAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (SourceNetworkAddress)).SetValue((object) value);
    }

    public IUAVariable SourceNetworkAddressVariable
    {
      get => this.Refs.GetVariable("SourceNetworkAddress");
    }

    public byte SourceNodeAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (SourceNodeAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (SourceNodeAddress)).SetValue((object) value);
    }

    public IUAVariable SourceNodeAddressVariable => this.Refs.GetVariable("SourceNodeAddress");

    public byte SourceUnitAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (SourceUnitAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (SourceUnitAddress)).SetValue((object) value);
    }

    public IUAVariable SourceUnitAddressVariable => this.Refs.GetVariable("SourceUnitAddress");

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

    public OptimizationType OptimizationType
    {
      get => (OptimizationType) (int) this.Refs.GetVariable(nameof (OptimizationType)).Value;
      set => this.Refs.GetVariable(nameof (OptimizationType)).SetValue((object) (int) value);
    }

    public IUAVariable OptimizationTypeVariable => this.Refs.GetVariable("OptimizationType");

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
