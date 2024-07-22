// Decompiled with JetBrains decompiler
// Type: FTOptix.System.NetworkInterfaceType
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [MapType(NamespaceUri = "urn:FTOptix:System", Number = 4)]
  public class NetworkInterfaceType : UAObjectType
  {
    public bool DHCPClientEnabled
    {
      get => (bool) this.DhcpClientEnabledVariable.Value;
      set => this.DhcpClientEnabledVariable.SetValue((object) value);
    }

    public IUAVariable DhcpClientEnabledVariable => this.Refs.GetVariable("DHCPClientEnabled");

    public string IPAddress
    {
      get => (string) this.IPAddressVariable.Value;
      set => this.IPAddressVariable.SetValue((object) value);
    }

    public MaskedIPAddress IPAddressVariable
    {
      get => (MaskedIPAddress) this.Refs.GetVariable("IPAddress");
    }

    public string Mask
    {
      get => (string) this.MaskVariable.Value;
      set => this.MaskVariable.SetValue((object) value);
    }

    public IUAVariable MaskVariable => this.IPAddressVariable.GetVariable("Mask");

    public string DNS1
    {
      get => (string) this.DNS1Variable.Value;
      set => this.DNS1Variable.SetValue((object) value);
    }

    public IUAVariable DNS1Variable => this.Refs.GetVariable("DNS1");

    public string DNS2
    {
      get => (string) this.DNS2Variable.Value;
      set => this.DNS2Variable.SetValue((object) value);
    }

    public IUAVariable DNS2Variable => this.Refs.GetVariable("DNS2");

    public string DefaultGateway
    {
      get => (string) this.DefaultGatewayVariable.Value;
      set => this.DefaultGatewayVariable.SetValue((object) value);
    }

    public IUAVariable DefaultGatewayVariable => this.Refs.GetVariable("DefaultGateway");

    public InstanceNodeCollection<NetworkInterface> Instances
    {
      get => new InstanceNodeCollection<NetworkInterface>((IUANode) this);
    }
  }
}
