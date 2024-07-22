// Decompiled with JetBrains decompiler
// Type: FTOptix.MicroController.Driver
// Assembly: FTOptix.MicroController.Net, Version=3.1.0.28, Culture=neutral, PublicKeyToken=null
// MVID: 3C2374A2-E7A9-4608-96D0-153AE54FA082
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MicroController.Net\3.1.0.28\Any\FTOptix.MicroController.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.MicroController
{
  [MapType(NamespaceUri = "urn:FTOptix:MicroController", Number = 4)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public ControllerType ControllerType
    {
      get => (ControllerType) (int) this.Refs.GetVariable(nameof (ControllerType)).Value;
      set => this.Refs.GetVariable(nameof (ControllerType)).SetValue((object) (int) value);
    }

    public IUAVariable ControllerTypeVariable => this.Refs.GetVariable("ControllerType");

    public Protocol Protocol
    {
      get => (Protocol) (int) this.Refs.GetVariable(nameof (Protocol)).Value;
      set => this.Refs.GetVariable(nameof (Protocol)).SetValue((object) (int) value);
    }

    public IUAVariable ProtocolVariable => this.Refs.GetVariable("Protocol");

    public SerialProtocol SerialProtocol
    {
      get => (SerialProtocol) (int) this.Refs.GetVariable(nameof (SerialProtocol)).Value;
      set => this.Refs.GetVariable(nameof (SerialProtocol)).SetValue((object) (int) value);
    }

    public IUAVariable SerialProtocolVariable => this.Refs.GetVariable("SerialProtocol");

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

    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
