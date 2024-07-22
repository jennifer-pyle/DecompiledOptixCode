// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronFins.Driver
// Assembly: FTOptix.OmronFins.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 4638714C-7F4C-46B4-B420-EAFE85857675
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronFins.Net\1.0.8.38\Any\FTOptix.OmronFins.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.OmronFins
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronFins", Number = 17)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public byte StationID
    {
      get => (byte) this.Refs.GetVariable(nameof (StationID)).Value.Value;
      set => this.Refs.GetVariable(nameof (StationID)).SetValue((object) value);
    }

    public IUAVariable StationIDVariable => this.Refs.GetVariable("StationID");

    public byte DestinationNetworkAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (DestinationNetworkAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (DestinationNetworkAddress)).SetValue((object) value);
    }

    public IUAVariable DestinationNetworkAddressVariable
    {
      get => this.Refs.GetVariable("DestinationNetworkAddress");
    }

    public byte DestinationNodeAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (DestinationNodeAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (DestinationNodeAddress)).SetValue((object) value);
    }

    public IUAVariable DestinationNodeAddressVariable
    {
      get => this.Refs.GetVariable("DestinationNodeAddress");
    }

    public byte DestinationUnitAddress
    {
      get => (byte) this.Refs.GetVariable(nameof (DestinationUnitAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (DestinationUnitAddress)).SetValue((object) value);
    }

    public IUAVariable DestinationUnitAddressVariable
    {
      get => this.Refs.GetVariable("DestinationUnitAddress");
    }

    public Protocol Protocol
    {
      get => (Protocol) (int) this.Refs.GetVariable(nameof (Protocol)).Value;
      set => this.Refs.GetVariable(nameof (Protocol)).SetValue((object) (int) value);
    }

    public IUAVariable ProtocolVariable => this.Refs.GetVariable("Protocol");

    public string SerialPort
    {
      get => (string) this.Refs.GetVariable(nameof (SerialPort)).Value.Value;
      set => this.Refs.GetVariable(nameof (SerialPort)).SetValue((object) value);
    }

    public IUAVariable SerialPortVariable => this.Refs.GetVariable("SerialPort");

    public uint Baudrate
    {
      get => (uint) this.Refs.GetVariable(nameof (Baudrate)).Value.Value;
      set => this.Refs.GetVariable(nameof (Baudrate)).SetValue((object) value);
    }

    public IUAVariable BaudrateVariable => this.Refs.GetVariable("Baudrate");

    public byte DataSize
    {
      get => (byte) this.Refs.GetVariable(nameof (DataSize)).Value.Value;
      set => this.Refs.GetVariable(nameof (DataSize)).SetValue((object) value);
    }

    public IUAVariable DataSizeVariable => this.Refs.GetVariable("DataSize");

    public Parity Parity
    {
      get => (Parity) (int) this.Refs.GetVariable(nameof (Parity)).Value;
      set => this.Refs.GetVariable(nameof (Parity)).SetValue((object) (int) value);
    }

    public IUAVariable ParityVariable => this.Refs.GetVariable("Parity");

    public StopBits StopBits
    {
      get => (StopBits) (int) this.Refs.GetVariable(nameof (StopBits)).Value;
      set => this.Refs.GetVariable(nameof (StopBits)).SetValue((object) (int) value);
    }

    public IUAVariable StopBitsVariable => this.Refs.GetVariable("StopBits");

    public FlowControl FlowControl
    {
      get => (FlowControl) (int) this.Refs.GetVariable(nameof (FlowControl)).Value;
      set => this.Refs.GetVariable(nameof (FlowControl)).SetValue((object) (int) value);
    }

    public IUAVariable FlowControlVariable => this.Refs.GetVariable("FlowControl");

    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
