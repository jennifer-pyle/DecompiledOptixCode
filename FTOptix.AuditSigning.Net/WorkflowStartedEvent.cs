// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.WorkflowStartedEvent
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [CustomEventType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 18)]
  public class WorkflowStartedEvent
  {
    public NodeId NodeId { get; set; }

    public WorkflowType WorkflowType { get; set; }

    public NodeId SessionId { get; set; }
  }
}
