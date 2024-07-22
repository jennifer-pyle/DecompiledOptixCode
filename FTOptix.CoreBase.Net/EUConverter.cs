// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.EUConverter
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 3)]
  public class EUConverter : Converter
  {
    public double ScaledMax
    {
      get => (double) this.GetOptionalVariableValue(nameof (ScaledMax));
      set => this.SetOptionalVariableValue(nameof (ScaledMax), new UAValue(value));
    }

    public IUAVariable ScaledMaxVariable => this.GetOrCreateVariable("ScaledMax");

    public double ScaledMin
    {
      get => (double) this.GetOptionalVariableValue(nameof (ScaledMin));
      set => this.SetOptionalVariableValue(nameof (ScaledMin), new UAValue(value));
    }

    public IUAVariable ScaledMinVariable => this.GetOrCreateVariable("ScaledMin");

    public double RawMax
    {
      get => (double) this.GetOptionalVariableValue(nameof (RawMax));
      set => this.SetOptionalVariableValue(nameof (RawMax), new UAValue(value));
    }

    public IUAVariable RawMaxVariable => this.GetOrCreateVariable("RawMax");

    public double RawMin
    {
      get => (double) this.GetOptionalVariableValue(nameof (RawMin));
      set => this.SetOptionalVariableValue(nameof (RawMin), new UAValue(value));
    }

    public IUAVariable RawMinVariable => this.GetOrCreateVariable("RawMin");

    public IUAVariable SourceVariable => this.Refs.GetVariable("Source");
  }
}
