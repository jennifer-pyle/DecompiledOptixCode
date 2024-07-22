// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecFX3U.Tag
// Assembly: FTOptix.MelsecFX3U.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 6BE706AB-E05A-4E2F-AFFF-E26ED6578923
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecFX3U.Net\1.0.8.38\Any\FTOptix.MelsecFX3U.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecFX3U
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecFX3U", Number = 3)]
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
  }
}
