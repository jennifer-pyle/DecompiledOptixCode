// Decompiled with JetBrains decompiler
// Type: FTOptix.AuditSigning.SigningController
// Assembly: FTOptix.AuditSigning.Net, Version=1.1.2.43, Culture=neutral, PublicKeyToken=null
// MVID: 41E183E2-61F4-4666-B6EE-6A53F78D8197
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.AuditSigning.Net\1.1.2.43\Any\FTOptix.AuditSigning.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.AuditSigning
{
  [MapType(NamespaceUri = "urn:FTOptix:AuditSigning", Number = 30)]
  public class SigningController : UAObject
  {
    public PlaceholderChildNodeCollection<UserInfo> UsersAllowedToSign
    {
      get
      {
        return new PlaceholderChildNodeCollection<UserInfo>((IUANode) this, nameof (UsersAllowedToSign));
      }
    }

    public PlaceholderChildNodeCollection<GroupInfo> GroupsAllowedToSign
    {
      get
      {
        return new PlaceholderChildNodeCollection<GroupInfo>((IUANode) this, nameof (GroupsAllowedToSign));
      }
    }

    public PlaceholderChildNodeCollection<UserInfo> UsersAllowedToDoubleSign
    {
      get
      {
        return new PlaceholderChildNodeCollection<UserInfo>((IUANode) this, nameof (UsersAllowedToDoubleSign));
      }
    }

    public PlaceholderChildNodeCollection<GroupInfo> GroupsAllowedToDoubleSign
    {
      get
      {
        return new PlaceholderChildNodeCollection<GroupInfo>((IUANode) this, nameof (GroupsAllowedToDoubleSign));
      }
    }

    public SignResult Confirm(string note)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Confirm), new object[1]
      {
        (object) note
      }, out outputArgs);
      return (SignResult) outputArgs[0];
    }

    public IUAMethod ConfirmMethod => this.Refs.GetMethod("Confirm");

    public SignResult Sign(string username, string password, string note)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Sign), new object[3]
      {
        (object) username,
        (object) password,
        (object) note
      }, out outputArgs);
      return (SignResult) outputArgs[0];
    }

    public IUAMethod SignMethod => this.Refs.GetMethod("Sign");

    public SignResult DoubleSign(
      string firstUsername,
      string firstUserPassword,
      string firstUserNote,
      string secondUser,
      string secondUserPassword,
      string secondUserNote)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (DoubleSign), new object[6]
      {
        (object) firstUsername,
        (object) firstUserPassword,
        (object) firstUserNote,
        (object) secondUser,
        (object) secondUserPassword,
        (object) secondUserNote
      }, out outputArgs);
      return (SignResult) outputArgs[0];
    }

    public IUAMethod DoubleSignMethod => this.Refs.GetMethod("DoubleSign");

    public void Cancel() => this.ExecuteMethod(nameof (Cancel), new object[0]);

    public IUAMethod CancelMethod => this.Refs.GetMethod("Cancel");

    public event EventHandler<WorkflowStartedEvent> OnWorkflowStarted
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:AuditSigning"), 18U), typeof (EventHandler<WorkflowStartedEvent>), typeof (WorkflowStartedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:AuditSigning"), 18U), typeof (EventHandler<WorkflowStartedEvent>), typeof (WorkflowStartedEvent)).Remove((Delegate) value);
      }
    }
  }
}
