// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecFX3U.Station
// Assembly: FTOptix.MelsecFX3U.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 6BE706AB-E05A-4E2F-AFFF-E26ED6578923
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecFX3U.Net\1.0.8.38\Any\FTOptix.MelsecFX3U.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecFX3U
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecFX3U", Number = 8)]
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

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }
  }
}
