// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TCP.TagType
// Assembly: FTOptix.S7TCP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: CE29D4F9-3A52-4C85-9774-D6DA74ACB2D2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TCP.Net\1.0.8.38\Any\FTOptix.S7TCP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.S7TCP
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TCP", Number = 5)]
  public class TagType : FTOptix.CommunicationDriver.TagType
  {
    public MemoryArea MemoryArea
    {
      get => (MemoryArea) (int) this.GetOptionalVariableValue(nameof (MemoryArea));
      set => this.SetOptionalVariableValue(nameof (MemoryArea), new UAValue((int) value));
    }

    public IUAVariable MemoryAreaVariable => this.GetOrCreateVariable("MemoryArea");

    public Encoding Encoding
    {
      get => (Encoding) (int) this.GetOptionalVariableValue(nameof (Encoding));
      set => this.SetOptionalVariableValue(nameof (Encoding), new UAValue((int) value));
    }

    public IUAVariable EncodingVariable => this.GetOrCreateVariable("Encoding");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public uint BlockNumber
    {
      get => (uint) this.GetOptionalVariableValue(nameof (BlockNumber));
      set => this.SetOptionalVariableValue(nameof (BlockNumber), new UAValue(value));
    }

    public IUAVariable BlockNumberVariable => this.GetOrCreateVariable("BlockNumber");

    public uint CounterNumber
    {
      get => (uint) this.GetOptionalVariableValue(nameof (CounterNumber));
      set => this.SetOptionalVariableValue(nameof (CounterNumber), new UAValue(value));
    }

    public IUAVariable CounterNumberVariable => this.GetOrCreateVariable("CounterNumber");

    public uint TimerNumber
    {
      get => (uint) this.GetOptionalVariableValue(nameof (TimerNumber));
      set => this.SetOptionalVariableValue(nameof (TimerNumber), new UAValue(value));
    }

    public IUAVariable TimerNumberVariable => this.GetOrCreateVariable("TimerNumber");

    public uint Position
    {
      get => (uint) this.GetOptionalVariableValue(nameof (Position));
      set => this.SetOptionalVariableValue(nameof (Position), new UAValue(value));
    }

    public IUAVariable PositionVariable => this.GetOrCreateVariable("Position");

    public uint Bit
    {
      get => (uint) this.GetOptionalVariableValue(nameof (Bit));
      set => this.SetOptionalVariableValue(nameof (Bit), new UAValue(value));
    }

    public IUAVariable BitVariable => this.GetOrCreateVariable("Bit");

    public uint[] StartArrayIndex
    {
      get => (uint[]) this.GetOptionalVariableValue(nameof (StartArrayIndex));
      set => this.SetOptionalVariableValue(nameof (StartArrayIndex), new UAValue(value));
    }

    public IUAVariable StartArrayIndexVariable => this.GetOrCreateVariable("StartArrayIndex");

    public InstanceNodeCollection<Tag> Instances => new InstanceNodeCollection<Tag>((IUANode) this);
  }
}
