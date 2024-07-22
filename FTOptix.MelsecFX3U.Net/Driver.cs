// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecFX3U.Driver
// Assembly: FTOptix.MelsecFX3U.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 6BE706AB-E05A-4E2F-AFFF-E26ED6578923
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecFX3U.Net\1.0.8.38\Any\FTOptix.MelsecFX3U.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecFX3U
{
  [MapType(NamespaceUri = "urn:FTOptix:MelsecFX3U", Number = 7)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
