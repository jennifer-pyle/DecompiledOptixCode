﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.CODESYS.Driver
// Assembly: FTOptix.CODESYS.Net, Version=2.0.4.38, Culture=neutral, PublicKeyToken=null
// MVID: 8A6E538D-4FC1-46A5-B5C8-EC5F861CEF6D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CODESYS.Net\2.0.4.38\Any\FTOptix.CODESYS.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CODESYS
{
  [MapType(NamespaceUri = "urn:FTOptix:CODESYS", Number = 3)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
