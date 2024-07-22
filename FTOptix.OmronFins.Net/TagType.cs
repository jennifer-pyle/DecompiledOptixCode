// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronFins.TagType
// Assembly: FTOptix.OmronFins.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 4638714C-7F4C-46B4-B420-EAFE85857675
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronFins.Net\1.0.8.38\Any\FTOptix.OmronFins.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OmronFins
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronFins", Number = 9)]
  public class TagType : FTOptix.CommunicationDriver.TagType
  {
    public MemoryArea MemoryArea
    {
      get => (MemoryArea) (int) this.GetOptionalVariableValue(nameof (MemoryArea));
      set => this.SetOptionalVariableValue(nameof (MemoryArea), new UAValue((int) value));
    }

    public IUAVariable MemoryAreaVariable => this.GetOrCreateVariable("MemoryArea");

    public DataConversion DataConversion
    {
      get => (DataConversion) (int) this.GetOptionalVariableValue(nameof (DataConversion));
      set => this.SetOptionalVariableValue(nameof (DataConversion), new UAValue((int) value));
    }

    public IUAVariable DataConversionVariable => this.GetOrCreateVariable("DataConversion");

    public BCDFormat BCDFormat
    {
      get => (BCDFormat) (int) this.GetOptionalVariableValue(nameof (BCDFormat));
      set => this.SetOptionalVariableValue(nameof (BCDFormat), new UAValue((int) value));
    }

    public IUAVariable BCDFormatVariable => this.GetOrCreateVariable("BCDFormat");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public uint NumWord
    {
      get => (uint) this.GetOptionalVariableValue(nameof (NumWord));
      set => this.SetOptionalVariableValue(nameof (NumWord), new UAValue(value));
    }

    public IUAVariable NumWordVariable => this.GetOrCreateVariable("NumWord");

    public uint BitOffset
    {
      get => (uint) this.GetOptionalVariableValue(nameof (BitOffset));
      set => this.SetOptionalVariableValue(nameof (BitOffset), new UAValue(value));
    }

    public IUAVariable BitOffsetVariable => this.GetOrCreateVariable("BitOffset");

    public uint NumFlag
    {
      get => (uint) this.GetOptionalVariableValue(nameof (NumFlag));
      set => this.SetOptionalVariableValue(nameof (NumFlag), new UAValue(value));
    }

    public IUAVariable NumFlagVariable => this.GetOrCreateVariable("NumFlag");

    public uint BankNumber
    {
      get => (uint) this.GetOptionalVariableValue(nameof (BankNumber));
      set => this.SetOptionalVariableValue(nameof (BankNumber), new UAValue(value));
    }

    public IUAVariable BankNumberVariable => this.GetOrCreateVariable("BankNumber");

    public InstanceNodeCollection<Tag> Instances => new InstanceNodeCollection<Tag>((IUANode) this);
  }
}
