// Decompiled with JetBrains decompiler
// Type: FTOptix.Modbus.DriverType
// Assembly: FTOptix.Modbus.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: C70D0038-6EC8-4D48-89C2-4A031CE99C4E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Modbus.Net\1.0.8.38\Any\FTOptix.Modbus.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.Modbus
{
  [MapType(NamespaceUri = "urn:FTOptix:Modbus", Number = 7)]
  public class DriverType : CommunicationDriverType
  {
    public ModbusProtocol Protocol
    {
      get => (ModbusProtocol) (int) this.Refs.GetVariable(nameof (Protocol)).Value;
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

    public InstanceNodeCollection<Driver> Instances
    {
      get => new InstanceNodeCollection<Driver>((IUANode) this);
    }
  }
}
