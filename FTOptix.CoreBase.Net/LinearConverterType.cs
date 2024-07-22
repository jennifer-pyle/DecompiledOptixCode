// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.LinearConverterType
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 104)]
  public class LinearConverterType : ConverterType
  {
    public double Slope
    {
      get => (double) this.GetOptionalVariableValue(nameof (Slope));
      set => this.SetOptionalVariableValue(nameof (Slope), new UAValue(value));
    }

    public IUAVariable SlopeVariable => this.GetOrCreateVariable("Slope");

    public double Intercept
    {
      get => (double) this.GetOptionalVariableValue(nameof (Intercept));
      set => this.SetOptionalVariableValue(nameof (Intercept), new UAValue(value));
    }

    public IUAVariable InterceptVariable => this.GetOrCreateVariable("Intercept");

    public IUAVariable SourceVariable => this.Refs.GetVariable("Source");

    public InstanceNodeCollection<LinearConverter> Instances
    {
      get => new InstanceNodeCollection<LinearConverter>((IUANode) this);
    }
  }
}
