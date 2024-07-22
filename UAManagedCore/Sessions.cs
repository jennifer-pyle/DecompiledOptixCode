// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Sessions
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class Sessions : ISessions
  {
    internal IntPtr contextPtr;

    public SessionInfo CurrentSessionInfo
    {
      get
      {
        InteropCallResult currentSessionInfo = Sessions.Interop.SessionsGetCurrentSessionInfo(this.contextPtr);
        currentSessionInfo.CheckOutcome();
        return (SessionInfo) currentSessionInfo.GetStruct<Sessions.SessionInfoInterop>();
      }
    }

    public ISessionHandler CurrentSessionHandler
    {
      get
      {
        InteropCallResult currentSessionHandler = Sessions.Interop.SessionsGetCurrentSessionHandler(this.contextPtr);
        currentSessionHandler.CheckOutcome();
        return (ISessionHandler) currentSessionHandler.Get<SessionHandler>();
      }
    }

    public IWeakSessionHandler CurrentWeakSessionHandler => throw new NotImplementedException();

    public ISessionHandler CreateSession(QualifiedName userName, string password)
    {
      if (userName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (userName));
      if (password == null)
        throw new ArgumentNullException(nameof (password));
      InteropCallResult session = Sessions.Interop.SessionsCreateSession(this.contextPtr, ObjectMarshal.ToIntPtr((object) userName), password);
      session.CheckOutcome();
      return (ISessionHandler) session.Get<SessionHandler>();
    }

    public ISessionHandler CreateSession(QualifiedName userName, string password, string localeId)
    {
      if (userName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (userName));
      if (password == null)
        throw new ArgumentNullException(nameof (password));
      if (localeId == null)
        throw new ArgumentNullException(nameof (localeId));
      InteropCallResult sessionWithLocaleId = Sessions.Interop.SessionsCreateSessionWithLocaleId(this.contextPtr, ObjectMarshal.ToIntPtr((object) userName), password, localeId);
      sessionWithLocaleId.CheckOutcome();
      return (ISessionHandler) sessionWithLocaleId.Get<SessionHandler>();
    }

    public IDisposable ImpersonateRootTemporary()
    {
      InteropCallResult interopCallResult = Sessions.Interop.SessionsImpersonateRootTemporary(this.contextPtr);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public void ImpersonateSession(ISessionHandler session)
    {
      Sessions.Interop.SessionsImpersonateSession(this.contextPtr, (IntPtr) ((SessionHandler) session).handle).CheckOutcome();
    }

    public IDisposable ImpersonateSessionTemporary(ISessionHandler session)
    {
      InteropCallResult interopCallResult = Sessions.Interop.SessionsImpersonateSessionTemporary(this.contextPtr, (IntPtr) ((SessionHandler) session).handle);
      interopCallResult.CheckOutcome();
      return (IDisposable) new OnScopeExit(interopCallResult.Get<OnScopeExitSafeHandle>());
    }

    public ISessionHandler InternalCreateSession(QualifiedName userName, NodeId nodeId)
    {
      if (userName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (userName));
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      InteropCallResult session = Sessions.Interop.SessionsInternalCreateSession(this.contextPtr, ObjectMarshal.ToIntPtr((object) userName), ObjectMarshal.ToIntPtr((object) nodeId));
      session.CheckOutcome();
      return (ISessionHandler) session.Get<SessionHandler>();
    }

    public ISessionHandler InternalCreateSession(
      QualifiedName userName,
      NodeId nodeId,
      string localeId)
    {
      if (userName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (userName));
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (localeId == null)
        throw new ArgumentNullException(nameof (localeId));
      InteropCallResult sessionWithLocaleId = Sessions.Interop.SessionsInternalCreateSessionWithLocaleId(this.contextPtr, ObjectMarshal.ToIntPtr((object) userName), ObjectMarshal.ToIntPtr((object) nodeId), localeId);
      sessionWithLocaleId.CheckOutcome();
      return (ISessionHandler) sessionWithLocaleId.Get<SessionHandler>();
    }

    public ISessionHandler InternalCreateSession(IUAObject user, NodeId nodeId)
    {
      if (user == null)
        throw new ArgumentNullException(nameof (user));
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      InteropCallResult sessionWithUser = Sessions.Interop.SessionsInternalCreateSessionWithUser(this.contextPtr, (IntPtr) ((UANode) user).nodeHandle, ObjectMarshal.ToIntPtr((object) nodeId));
      sessionWithUser.CheckOutcome();
      return (ISessionHandler) sessionWithUser.Get<SessionHandler>();
    }

    internal Sessions(IntPtr contextPtr) => this.contextPtr = contextPtr;

    internal struct SessionInfoInterop
    {
      public IntPtr SessionObject;
      public IntPtr User;
      public int IsRootUser;
      public IntPtr LocaleId;

      public static implicit operator SessionInfo(Sessions.SessionInfoInterop v)
      {
        SessionInfo sessionInfo = new SessionInfo((IUAObject) ObjectMarshal.FromIntPtr<UAObject>(v.SessionObject), (IUAObject) ObjectMarshal.FromIntPtr<UAObject>(v.User), v.IsRootUser != 0, Marshal.PtrToStringUTF8(v.LocaleId));
        NativeMemory.Free(v.LocaleId);
        return sessionInfo;
      }
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsGetCurrentSessionInfo(IntPtr context);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsGetCurrentSessionHandler(IntPtr context);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsCreateSession(
        IntPtr context,
        IntPtr qualifiedUserName,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string password);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsCreateSessionWithLocaleId(
        IntPtr context,
        IntPtr qualifiedUserName,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string password,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string localeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsImpersonateRootTemporary(IntPtr context);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsImpersonateSession(
        IntPtr context,
        IntPtr safeHandlePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsImpersonateSessionTemporary(
        IntPtr context,
        IntPtr safeHandlePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsInternalCreateSession(
        IntPtr context,
        IntPtr qualifiedUserName,
        IntPtr nodeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsInternalCreateSessionWithLocaleId(
        IntPtr context,
        IntPtr qualifiedUserName,
        IntPtr nodeId,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string localeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionsInternalCreateSessionWithUser(
        IntPtr context,
        IntPtr userNodeHandle,
        IntPtr nodeId);
    }
  }
}
