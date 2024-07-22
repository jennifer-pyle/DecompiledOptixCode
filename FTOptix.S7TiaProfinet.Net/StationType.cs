// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TiaProfinet.StationType
// Assembly: FTOptix.S7TiaProfinet.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 04D0A327-9B8D-4FD1-B415-024D37158081
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TiaProfinet.Net\1.1.2.38\Any\FTOptix.S7TiaProfinet.Net.dll

using FTOptix.CommunicationDriver;
using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.S7TiaProfinet
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TiaProfinet", Number = 8)]
  public class StationType : CommunicationStationType
  {
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

    public ResourceUri CertificateFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (CertificateFile)));
      set => this.SetOptionalVariableValue(nameof (CertificateFile), new UAValue((string) value));
    }

    public IUAVariable CertificateFileVariable => this.GetOrCreateVariable("CertificateFile");

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
