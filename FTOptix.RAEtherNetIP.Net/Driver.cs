﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.RAEtherNetIP.Driver
// Assembly: FTOptix.RAEtherNetIP.Net, Version=2.2.0.11, Culture=neutral, PublicKeyToken=null
// MVID: 626313C4-D37E-4FD2-9B56-0300FEB2B54A
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.RAEtherNetIP.Net\2.2.0.11\Any\FTOptix.RAEtherNetIP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.RAEtherNetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:RAEtherNetIP", Number = 4)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
