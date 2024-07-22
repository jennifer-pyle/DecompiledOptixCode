// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.UserPassword
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 253)]
  public class UserPassword : UAVariable
  {
    public PasswordHash Hash => (PasswordHash) this.Refs.GetVariable(nameof (Hash)).Value.Value;

    public IUAVariable HashVariable => this.Refs.GetVariable("Hash");

    public DateTime ChangeTimestamp
    {
      get => (DateTime) this.Refs.GetVariable(nameof (ChangeTimestamp)).Value.Value;
    }

    public IUAVariable ChangeTimestampVariable => this.Refs.GetVariable("ChangeTimestamp");

    public PasswordHash[] History
    {
      get => (PasswordHash[]) this.Refs.GetVariable(nameof (History)).Value.Value;
    }

    public IUAVariable HistoryVariable => this.Refs.GetVariable("History");
  }
}
