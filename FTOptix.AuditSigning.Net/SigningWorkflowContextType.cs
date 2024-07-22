// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.SigningControllerContextType
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [MapType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 51)]
  public class SigningControllerContextType : UAObjectType
  {
    public NodeId Id
    {
      get => (NodeId) this.Refs.GetVariable("NodeId").Value.Value;
      set => this.Refs.GetVariable("NodeId").SetValue((object) value);
    }

    public NodePointer NodeIdVariable => (NodePointer) this.Refs.GetVariable("NodeId");

    public WorkflowType WorkflowType
    {
      get => (WorkflowType) (int) this.Refs.GetVariable(nameof (WorkflowType)).Value;
      set => this.Refs.GetVariable(nameof (WorkflowType)).SetValue((object) (int) value);
    }

    public IUAVariable WorkflowTypeVariable => this.Refs.GetVariable("WorkflowType");

    public object NewValue
    {
      get => this.Refs.GetVariable(nameof (NewValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (NewValue)).SetValue(value);
    }

    public IUAVariable NewValueVariable => this.Refs.GetVariable("NewValue");

    public object OldValue
    {
      get => this.Refs.GetVariable(nameof (OldValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (OldValue)).SetValue(value);
    }

    public IUAVariable OldValueVariable => this.Refs.GetVariable("OldValue");

    public bool WorkflowInProgress
    {
      get => (bool) this.Refs.GetVariable(nameof (WorkflowInProgress)).Value.Value;
      set => this.Refs.GetVariable(nameof (WorkflowInProgress)).SetValue((object) value);
    }

    public IUAVariable WorkflowInProgressVariable => this.Refs.GetVariable("WorkflowInProgress");

    public InstanceNodeCollection<SigningControllerContext> Instances
    {
      get => new InstanceNodeCollection<SigningControllerContext>((IUANode) this);
    }
  }
}
