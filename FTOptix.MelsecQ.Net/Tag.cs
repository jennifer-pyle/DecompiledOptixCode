// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecQ.Tag
// Assembly: FTOptix.MelsecQ.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 82AF5AD0-6CA3-446B-98F5-2FEAD20A318F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecQ.Net\1.0.8.38\Any\FTOptix.MelsecQ.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecQ
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecQ", Number = 3)]
  public class Tag : FTOptix.CommunicationDriver.Tag
  {
    public MemoryArea MemoryArea
    {
      get => (MemoryArea) (int) this.GetOptionalVariableValue(nameof (MemoryArea));
      set => this.SetOptionalVariableValue(nameof (MemoryArea), new UAValue((int) value));
    }

    public IUAVariable MemoryAreaVariable => this.GetOrCreateVariable("MemoryArea");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public uint NumDevice
    {
      get => (uint) this.GetOptionalVariableValue(nameof (NumDevice));
      set => this.SetOptionalVariableValue(nameof (NumDevice), new UAValue(value));
    }

    public IUAVariable NumDeviceVariable => this.GetOrCreateVariable("NumDevice");

    public uint BitOffset
    {
      get => (uint) this.GetOptionalVariableValue(nameof (BitOffset));
      set => this.SetOptionalVariableValue(nameof (BitOffset), new UAValue(value));
    }

    public IUAVariable BitOffsetVariable => this.GetOrCreateVariable("BitOffset");

    public Encoding Encoding
    {
      get => (Encoding) (int) this.GetOptionalVariableValue(nameof (Encoding));
      set => this.SetOptionalVariableValue(nameof (Encoding), new UAValue((int) value));
    }

    public IUAVariable EncodingVariable => this.GetOrCreateVariable("Encoding");
  }
}
