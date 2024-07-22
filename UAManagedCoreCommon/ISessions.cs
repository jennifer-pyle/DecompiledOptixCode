// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ISessions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface ISessions
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void ImpersonateSession(ISessionHandler session);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler CreateSession(QualifiedName userName, string password);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler CreateSession(QualifiedName userName, string password, string localeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    SessionInfo CurrentSessionInfo { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler CurrentSessionHandler { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IWeakSessionHandler CurrentWeakSessionHandler { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler InternalCreateSession(QualifiedName userName, NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler InternalCreateSession(QualifiedName userName, NodeId nodeId, string localeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ISessionHandler InternalCreateSession(IUAObject user, NodeId nodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable ImpersonateSessionTemporary(ISessionHandler session);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IDisposable ImpersonateRootTemporary();
  }
}
