﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ParallelAnimationType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 423)]
  public class ParallelAnimationType : AbstractAnimationType
  {
    public InstanceNodeCollection<ParallelAnimation> Instances
    {
      get => new InstanceNodeCollection<ParallelAnimation>((IUANode) this);
    }
  }
}
