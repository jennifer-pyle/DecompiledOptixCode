// Decompiled with JetBrains decompiler
// Type: FTOptix.Retentivity.RetentivityStorageType
// Assembly: FTOptix.Retentivity.Net, Version=1.0.8.46, Culture=neutral, PublicKeyToken=null
// MVID: 27AC4578-28B3-4DBE-BFC1-C6B2253C6E5D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Retentivity.Net\1.0.8.46\Any\FTOptix.Retentivity.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Retentivity
{
  [MapType(NamespaceUri = "urn:FTOptix:Retentivity", Number = 1)]
  public class RetentivityStorageType : UAObjectType
  {
    public PlaceholderChildNodeCollection<IUAVariable> Nodes
    {
      get => new PlaceholderChildNodeCollection<IUAVariable>((IUANode) this, nameof (Nodes));
    }

    public double WriteDelay
    {
      get => (double) this.Refs.GetVariable(nameof (WriteDelay)).Value.Value;
      set => this.Refs.GetVariable(nameof (WriteDelay)).SetValue((object) value);
    }

    public IUAVariable WriteDelayVariable => this.Refs.GetVariable("WriteDelay");

    public bool DeltaObserverEnabled
    {
      get => (bool) this.Refs.GetVariable(nameof (DeltaObserverEnabled)).Value.Value;
      set => this.Refs.GetVariable(nameof (DeltaObserverEnabled)).SetValue((object) value);
    }

    public IUAVariable DeltaObserverEnabledVariable
    {
      get => this.Refs.GetVariable("DeltaObserverEnabled");
    }

    public InstanceNodeCollection<RetentivityStorage> Instances
    {
      get => new InstanceNodeCollection<RetentivityStorage>((IUANode) this);
    }
  }
}
