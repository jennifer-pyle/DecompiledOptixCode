// Decompiled with JetBrains decompiler
// Type: FTOptix.MicroController.Station
// Assembly: FTOptix.MicroController.Net, Version=3.1.0.28, Culture=neutral, PublicKeyToken=null
// MVID: 3C2374A2-E7A9-4608-96D0-153AE54FA082
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MicroController.Net\3.1.0.28\Any\FTOptix.MicroController.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.MicroController
{
  [MapType(NamespaceUri = "urn:FTOptix:MicroController", Number = 5)]
  public class Station : CommunicationStation
  {
    public string IPAddress
    {
      get => (string) this.Refs.GetVariable(nameof (IPAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (IPAddress)).SetValue((object) value);
    }

    public IUAVariable IPAddressVariable => this.Refs.GetVariable("IPAddress");

    public ErrorChecking ErrorChecking
    {
      get => (ErrorChecking) (int) this.Refs.GetVariable(nameof (ErrorChecking)).Value;
      set => this.Refs.GetVariable(nameof (ErrorChecking)).SetValue((object) (int) value);
    }

    public IUAVariable ErrorCheckingVariable => this.Refs.GetVariable("ErrorChecking");

    public double Timeout
    {
      get => (double) this.Refs.GetVariable(nameof (Timeout)).Value.Value;
      set => this.Refs.GetVariable(nameof (Timeout)).SetValue((object) value);
    }

    public IUAVariable TimeoutVariable => this.Refs.GetVariable("Timeout");

    public byte NodeAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (NodeAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (NodeAddress)).SetValue((object) value);
    }

    public IUAVariable NodeAddressVariable => this.Refs.GetVariable("NodeAddress");

    public double ConnectionTimeout
    {
      get => (double) this.Refs.GetVariable(nameof (ConnectionTimeout)).Value.Value;
      set => this.Refs.GetVariable(nameof (ConnectionTimeout)).SetValue((object) value);
    }

    public IUAVariable ConnectionTimeoutVariable => this.Refs.GetVariable("ConnectionTimeout");

    public uint MaxRetries
    {
      get => (uint) this.Refs.GetVariable(nameof (MaxRetries)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaxRetries)).SetValue((object) value);
    }

    public IUAVariable MaxRetriesVariable => this.Refs.GetVariable("MaxRetries");

    public double ACKTimeout
    {
      get => (double) this.Refs.GetVariable(nameof (ACKTimeout)).Value.Value;
      set => this.Refs.GetVariable(nameof (ACKTimeout)).SetValue((object) value);
    }

    public IUAVariable ACKTimeoutVariable => this.Refs.GetVariable("ACKTimeout");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }
  }
}
