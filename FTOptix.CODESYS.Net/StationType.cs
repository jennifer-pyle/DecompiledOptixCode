// Decompiled with JetBrains decompiler
// Type: FTOptix.CODESYS.StationType
// Assembly: FTOptix.CODESYS.Net, Version=2.0.4.38, Culture=neutral, PublicKeyToken=null
// MVID: 8A6E538D-4FC1-46A5-B5C8-EC5F861CEF6D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CODESYS.Net\2.0.4.38\Any\FTOptix.CODESYS.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.CODESYS
{
  [MapType(NamespaceUri = "urn:FTOptix:CODESYS", Number = 4)]
  public class StationType : CommunicationStationType
  {
    public string GatewayIP
    {
      get => (string) this.Refs.GetVariable(nameof (GatewayIP)).Value.Value;
      set => this.Refs.GetVariable(nameof (GatewayIP)).SetValue((object) value);
    }

    public IUAVariable GatewayIPVariable => this.Refs.GetVariable("GatewayIP");

    public ushort Port
    {
      get => (ushort) this.Refs.GetVariable(nameof (Port)).Value.Value;
      set => this.Refs.GetVariable(nameof (Port)).SetValue((object) value);
    }

    public IUAVariable PortVariable => this.Refs.GetVariable("Port");

    public string PLCAddress
    {
      get => (string) this.Refs.GetVariable(nameof (PLCAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (PLCAddress)).SetValue((object) value);
    }

    public IUAVariable PLCAddressVariable => this.Refs.GetVariable("PLCAddress");

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

    public InstanceNodeCollection<Station> Instances
    {
      get => new InstanceNodeCollection<Station>((IUANode) this);
    }
  }
}
