// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.ObjectTypes
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:AuditSigning");
    public static readonly NodeId AuditInfo = new NodeId(ObjectTypes.namespaceIndex, 5U);
    public static readonly NodeId WorkflowStartedEvent = new NodeId(ObjectTypes.namespaceIndex, 18U);
    public static readonly NodeId UserInfo = new NodeId(ObjectTypes.namespaceIndex, 22U);
    public static readonly NodeId GroupInfo = new NodeId(ObjectTypes.namespaceIndex, 26U);
    public static readonly NodeId SigningController = new NodeId(ObjectTypes.namespaceIndex, 30U);
    public static readonly NodeId SigningControllerContext = new NodeId(ObjectTypes.namespaceIndex, 51U);
    public static readonly NodeId AuditSigningWorkflowEvent = new NodeId(ObjectTypes.namespaceIndex, 59U);
    public static readonly NodeId AuditSigningWorkflowStartedEvent = new NodeId(ObjectTypes.namespaceIndex, 65U);
    public static readonly NodeId AuditSigningWorkflowCompletedEvent = new NodeId(ObjectTypes.namespaceIndex, 66U);
  }
}
