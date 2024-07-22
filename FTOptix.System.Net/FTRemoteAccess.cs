// Decompiled with JetBrains decompiler
// Type: FTOptix.System.FTRemoteAccess
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [MapType(NamespaceUri = "urn:FTOptix:System", Number = 62)]
  public class FTRemoteAccess : UAObject
  {
    public string RuntimeVersion => (string) this.RuntimeVersionVariable.Value;

    public IUAVariable RuntimeVersionVariable => this.Refs.GetVariable("RuntimeVersion");

    public ServerConnection ServerConnection
    {
      get => (ServerConnection) (int) this.ServerConnectionVariable.Value;
    }

    public IUAVariable ServerConnectionVariable => this.Refs.GetVariable("ServerConnection");

    public bool RegisteredToDomain => (bool) this.RegisteredToDomainVariable.Value;

    public IUAVariable RegisteredToDomainVariable => this.Refs.GetVariable("RegisteredToDomain");

    public AssistanceRequestMode AssistanceRequestMode
    {
      get => (AssistanceRequestMode) (int) this.AssistanceRequestModeVariable.Value;
    }

    public IUAVariable AssistanceRequestModeVariable
    {
      get => this.Refs.GetVariable("AssistanceRequestMode");
    }

    public bool AssistanceRequested => (bool) this.AssistanceRequestedVariable.Value;

    public IUAVariable AssistanceRequestedVariable => this.Refs.GetVariable("AssistanceRequested");

    public uint RemoteConnectionCount => (uint) this.RemoteConnectionCountVariable.Value;

    public IUAVariable RemoteConnectionCountVariable
    {
      get => this.Refs.GetVariable("RemoteConnectionCount");
    }

    public string AnonymousId => (string) this.AnonymousIdVariable.Value;

    public IUAVariable AnonymousIdVariable => this.Refs.GetVariable("AnonymousId");

    public string AnonymousPassword => (string) this.AnonymousPasswordVariable.Value;

    public IUAVariable AnonymousPasswordVariable => this.Refs.GetVariable("AnonymousPassword");

    public bool ConnectToServer()
    {
      object[] outputArgs;
      this.ConnectToServerMethod.Execute((IUANode) this, new object[0], out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod ConnectToServerMethod => this.Refs.GetMethod("ConnectToServer");

    public bool DisconnectFromServer()
    {
      object[] outputArgs;
      this.DisconnectFromServerMethod.Execute((IUANode) this, new object[0], out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod DisconnectFromServerMethod => this.Refs.GetMethod("DisconnectFromServer");

    public OpenAssistanceRequestResult OpenAssistanceRequest(
      string name,
      string contactInformation,
      string description)
    {
      object[] outputArgs;
      this.OpenAssistanceRequestMethod.Execute((IUANode) this, new object[3]
      {
        (object) name,
        (object) contactInformation,
        (object) description
      }, out outputArgs);
      return (OpenAssistanceRequestResult) outputArgs[0];
    }

    public IUAMethod OpenAssistanceRequestMethod => this.Refs.GetMethod("OpenAssistanceRequest");

    public CloseAssistanceRequestResult CloseAssistanceRequest()
    {
      object[] outputArgs;
      this.CloseAssistanceRequestMethod.Execute((IUANode) this, new object[0], out outputArgs);
      return (CloseAssistanceRequestResult) outputArgs[0];
    }

    public IUAMethod CloseAssistanceRequestMethod => this.Refs.GetMethod("CloseAssistanceRequest");

    public IncomingRemoteConnectionApprovalResult ApproveIncomingRemoteConnection(
      ByteString supervisorId)
    {
      object[] outputArgs;
      this.ApproveIncomingRemoteConnectionMethod.Execute((IUANode) this, new object[1]
      {
        (object) supervisorId
      }, out outputArgs);
      return (IncomingRemoteConnectionApprovalResult) outputArgs[0];
    }

    public IUAMethod ApproveIncomingRemoteConnectionMethod
    {
      get => this.Refs.GetMethod("ApproveIncomingRemoteConnection");
    }

    public IncomingRemoteConnectionApprovalResult DenyIncomingRemoteConnection(
      ByteString supervisorId)
    {
      object[] outputArgs;
      this.DenyIncomingRemoteConnectionMethod.Execute((IUANode) this, new object[1]
      {
        (object) supervisorId
      }, out outputArgs);
      return (IncomingRemoteConnectionApprovalResult) outputArgs[0];
    }

    public IUAMethod DenyIncomingRemoteConnectionMethod
    {
      get => this.Refs.GetMethod("DenyIncomingRemoteConnection");
    }

    public event EventHandler<RemoteConnectionRequestEvent> OnConnectionRequestEvent
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:System"), 14U), typeof (EventHandler<RemoteConnectionRequestEvent>), typeof (RemoteConnectionRequestEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:System"), 14U), typeof (EventHandler<RemoteConnectionRequestEvent>), typeof (RemoteConnectionRequestEvent)).Remove((Delegate) value);
      }
    }
  }
}
