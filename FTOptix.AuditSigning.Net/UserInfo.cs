// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.UserInfo
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [MapType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 22)]
  public class UserInfo : UAObject
  {
    public NodeId User
    {
      get => (NodeId) this.Refs.GetVariable(nameof (User)).Value.Value;
      set => this.Refs.GetVariable(nameof (User)).SetValue((object) value);
    }

    public NodePointer UserVariable => (NodePointer) this.Refs.GetVariable("User");
  }
}
