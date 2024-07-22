// Decompiled with JetBrains decompiler
// Type: FTOptix.InfluxDBStore.InfluxDBStoreTableType
// Assembly: FTOptix.InfluxDBStore.Net, Version=1.0.1.44, Culture=neutral, PublicKeyToken=null
// MVID: D250D165-EF05-42CD-BF7B-B79EF31B07C8
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.InfluxDBStore.Net\1.0.1.44\Any\FTOptix.InfluxDBStore.Net.dll

using FTOptix.Store;
using UAManagedCore;

#nullable disable
namespace FTOptix.InfluxDBStore
{
  [MapType(NamespaceUri = "urn:FTOptix:InfluxDBStore", Number = 3)]
  public class InfluxDBStoreTableType : TableType
  {
    public PlaceholderChildNodeCollection<InfluxDBTag> Tags
    {
      get => new PlaceholderChildNodeCollection<InfluxDBTag>((IUANode) this, nameof (Tags));
    }

    public InstanceNodeCollection<InfluxDBStoreTable> Instances
    {
      get => new InstanceNodeCollection<InfluxDBStoreTable>((IUANode) this);
    }
  }
}
