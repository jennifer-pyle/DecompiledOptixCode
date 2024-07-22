// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.GroupInfoType
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [MapType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 26)]
  public class GroupInfoType : UAObjectType
  {
    public NodeId Group
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Group)).Value.Value;
      set => this.Refs.GetVariable(nameof (Group)).SetValue((object) value);
    }

    public NodePointer GroupVariable => (NodePointer) this.Refs.GetVariable("Group");

    public InstanceNodeCollection<GroupInfo> Instances
    {
      get => new InstanceNodeCollection<GroupInfo>((IUANode) this);
    }
  }
}
