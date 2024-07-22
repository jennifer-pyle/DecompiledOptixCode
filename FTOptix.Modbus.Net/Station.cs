// Decompiled with JetBrains decompiler
// Type: FTOptix.Modbus.Station
// Assembly: FTOptix.Modbus.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: C70D0038-6EC8-4D48-89C2-4A031CE99C4E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Modbus.Net\1.0.8.38\Any\FTOptix.Modbus.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace FTOptix.Modbus
{
  [MapType(NamespaceUri = "urn:FTOptix:Modbus", Number = 8)]
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

    public byte UnitIdentifier
    {
      get => (byte) this.Refs.GetVariable(nameof (UnitIdentifier)).Value.Value;
      set => this.Refs.GetVariable(nameof (UnitIdentifier)).SetValue((object) value);
    }

    public IUAVariable UnitIdentifierVariable => this.Refs.GetVariable("UnitIdentifier");

    public bool WriteMultipleCoils
    {
      get => (bool) this.Refs.GetVariable(nameof (WriteMultipleCoils)).Value.Value;
      set => this.Refs.GetVariable(nameof (WriteMultipleCoils)).SetValue((object) value);
    }

    public IUAVariable WriteMultipleCoilsVariable => this.Refs.GetVariable("WriteMultipleCoils");

    public bool WriteMultipleRegisters
    {
      get => (bool) this.Refs.GetVariable(nameof (WriteMultipleRegisters)).Value.Value;
      set => this.Refs.GetVariable(nameof (WriteMultipleRegisters)).SetValue((object) value);
    }

    public IUAVariable WriteMultipleRegistersVariable
    {
      get => this.Refs.GetVariable("WriteMultipleRegisters");
    }

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

    public bool TagOptimization
    {
      get => (bool) this.GetOptionalVariableValue(nameof (TagOptimization));
      set => this.SetOptionalVariableValue(nameof (TagOptimization), new UAValue(value));
    }

    public IUAVariable TagOptimizationVariable => this.GetOrCreateVariable("TagOptimization");

    public bool SwapBytes
    {
      get => (bool) this.GetOptionalVariableValue(nameof (SwapBytes));
      set => this.SetOptionalVariableValue(nameof (SwapBytes), new UAValue(value));
    }

    public IUAVariable SwapBytesVariable => this.GetOrCreateVariable("SwapBytes");

    public bool SwapWords
    {
      get => (bool) this.GetOptionalVariableValue(nameof (SwapWords));
      set => this.SetOptionalVariableValue(nameof (SwapWords), new UAValue(value));
    }

    public IUAVariable SwapWordsVariable => this.GetOrCreateVariable("SwapWords");

    public bool SwapDWords
    {
      get => (bool) this.GetOptionalVariableValue(nameof (SwapDWords));
      set => this.SetOptionalVariableValue(nameof (SwapDWords), new UAValue(value));
    }

    public IUAVariable SwapDWordsVariable => this.GetOrCreateVariable("SwapDWords");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }
  }
}
