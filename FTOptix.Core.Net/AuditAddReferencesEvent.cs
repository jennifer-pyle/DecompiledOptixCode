﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.AuditAddReferencesEvent
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [CustomEventType(NamespaceUri = "http://opcfoundation.org/UA/", Number = 2095)]
  public class AuditAddReferencesEvent : AuditNodeManagementEvent
  {
    public AddReferencesItem[] ReferencesToAdd { get; set; }
  }
}
