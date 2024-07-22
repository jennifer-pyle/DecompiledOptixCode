// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.ValueMapConverterType
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 46)]
  public class ValueMapConverterType : ConverterType
  {
    public ValueMapConverterDataCollection Data
    {
      get => new ValueMapConverterDataCollection((IUANode) this);
    }

    public IUAVariable SourceVariable => this.Refs.GetVariable("Source");

    public InstanceNodeCollection<ValueMapConverter> Instances
    {
      get => new InstanceNodeCollection<ValueMapConverter>((IUANode) this);
    }
  }
}
