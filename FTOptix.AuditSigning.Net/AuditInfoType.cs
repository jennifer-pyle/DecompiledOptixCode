// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.AuditInfoType
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [MapType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 5)]
  public class AuditInfoType : UAObjectType
  {
    public NodeId SigningController
    {
      get => (NodeId) this.Refs.GetVariable(nameof (SigningController)).Value.Value;
      set => this.Refs.GetVariable(nameof (SigningController)).SetValue((object) value);
    }

    public NodePointer SigningControllerVariable
    {
      get => (NodePointer) this.Refs.GetVariable("SigningController");
    }

    public WorkflowType WorkflowType
    {
      get => (WorkflowType) (int) this.GetOptionalVariableValue(nameof (WorkflowType));
      set => this.SetOptionalVariableValue(nameof (WorkflowType), (UAValue) (int) value);
    }

    public IUAVariable WorkflowTypeVariable => this.GetOrCreateVariable("WorkflowType");

    public PlaceholderChildNodeCollection<NodePointer> Users
    {
      get => new PlaceholderChildNodeCollection<NodePointer>((IUANode) this, nameof (Users));
    }

    public PlaceholderChildNodeCollection<NodePointer> Groups
    {
      get => new PlaceholderChildNodeCollection<NodePointer>((IUANode) this, nameof (Groups));
    }

    public InstanceNodeCollection<AuditInfo> Instances
    {
      get => new InstanceNodeCollection<AuditInfo>((IUANode) this);
    }
  }
}
