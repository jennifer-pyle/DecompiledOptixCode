// Decompiled with JetBrains decompiler
// Type: FTOptix.Modbus.Tag
// Assembly: FTOptix.Modbus.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: C70D0038-6EC8-4D48-89C2-4A031CE99C4E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Modbus.Net\1.0.8.38\Any\FTOptix.Modbus.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Modbus
{
  [MapType(NamespaceUri = "urn:FTOptix:Modbus", Number = 3)]
  public class Tag : FTOptix.CommunicationDriver.Tag
  {
    public ModbusMemoryArea MemoryArea
    {
      get => (ModbusMemoryArea) (int) this.GetOptionalVariableValue(nameof (MemoryArea));
      set => this.SetOptionalVariableValue(nameof (MemoryArea), new UAValue((int) value));
    }

    public IUAVariable MemoryAreaVariable => this.GetOrCreateVariable("MemoryArea");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public ushort NumRegister
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (NumRegister));
      set => this.SetOptionalVariableValue(nameof (NumRegister), new UAValue(value));
    }

    public IUAVariable NumRegisterVariable => this.GetOrCreateVariable("NumRegister");

    public ushort NumCoil
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (NumCoil));
      set => this.SetOptionalVariableValue(nameof (NumCoil), new UAValue(value));
    }

    public IUAVariable NumCoilVariable => this.GetOrCreateVariable("NumCoil");

    public ushort NumDiscreteInput
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (NumDiscreteInput));
      set => this.SetOptionalVariableValue(nameof (NumDiscreteInput), new UAValue(value));
    }

    public IUAVariable NumDiscreteInputVariable => this.GetOrCreateVariable("NumDiscreteInput");

    public uint BitOffset
    {
      get => (uint) this.GetOptionalVariableValue(nameof (BitOffset));
      set => this.SetOptionalVariableValue(nameof (BitOffset), new UAValue(value));
    }

    public IUAVariable BitOffsetVariable => this.GetOrCreateVariable("BitOffset");
  }
}
