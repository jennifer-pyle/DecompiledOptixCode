// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecQ.Driver
// Assembly: FTOptix.MelsecQ.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 82AF5AD0-6CA3-446B-98F5-2FEAD20A318F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecQ.Net\1.0.8.38\Any\FTOptix.MelsecQ.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecQ
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecQ", Number = 7)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
