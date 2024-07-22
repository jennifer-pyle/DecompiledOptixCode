// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronEthernetIP.Driver
// Assembly: FTOptix.OmronEthernetIP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 41B722E7-479B-45E5-98C5-B6231316318E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronEthernetIP.Net\1.0.8.38\Any\FTOptix.OmronEthernetIP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OmronEthernetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronEthernetIP", Number = 4)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
