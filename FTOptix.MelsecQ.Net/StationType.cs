// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecQ.StationType
// Assembly: FTOptix.MelsecQ.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 82AF5AD0-6CA3-446B-98F5-2FEAD20A318F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecQ.Net\1.0.8.38\Any\FTOptix.MelsecQ.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecQ
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecQ", Number = 8)]
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

    public uint NetworkNumber
    {
      get => (uint) this.Refs.GetVariable(nameof (NetworkNumber)).Value.Value;
      set => this.Refs.GetVariable(nameof (NetworkNumber)).SetValue((object) value);
    }

    public IUAVariable NetworkNumberVariable => this.Refs.GetVariable("NetworkNumber");

    public uint PcNumber
    {
      get => (uint) this.Refs.GetVariable(nameof (PcNumber)).Value.Value;
      set => this.Refs.GetVariable(nameof (PcNumber)).SetValue((object) value);
    }

    public IUAVariable PcNumberVariable => this.Refs.GetVariable("PcNumber");

    public NumberBase NumberBase
    {
      get => (NumberBase) (int) this.GetOptionalVariableValue(nameof (NumberBase));
      set => this.SetOptionalVariableValue(nameof (NumberBase), new UAValue((int) value));
    }

    public IUAVariable NumberBaseVariable => this.GetOrCreateVariable("NumberBase");

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
