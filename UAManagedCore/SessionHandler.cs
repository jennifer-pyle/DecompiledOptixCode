// Decompiled with JetBrains decompiler
// Type: UAManagedCore.SessionHandler
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  internal class SessionHandler : ISessionHandler, ISessionInfo, IDisposable
  {
    internal IntPtr contextPtr;
    internal SessionHandlerSafeHandle handle;
    private bool disposed;

    public string ActualLocaleId
    {
      get
      {
        InteropCallResult actualLocaleId = SessionHandler.Interop.SessionHandlerGetActualLocaleId(this.contextPtr, (IntPtr) this.handle);
        actualLocaleId.CheckOutcome();
        return actualLocaleId.GetString();
      }
      set
      {
        SessionHandler.Interop.SessionHandlerSetActualLocaleId(this.contextPtr, (IntPtr) this.handle, value).CheckOutcome();
      }
    }

    public bool IsDisposed => this.disposed;

    public IUAObject SessionObject
    {
      get
      {
        InteropCallResult sessionObject = SessionHandler.Interop.SessionHandlerGetSessionObject(this.contextPtr, (IntPtr) this.handle);
        sessionObject.CheckOutcome();
        return (IUAObject) sessionObject.Get<UAObject>();
      }
    }

    public IUAObject User
    {
      get
      {
        InteropCallResult user = SessionHandler.Interop.SessionHandlerGetUser(this.contextPtr, (IntPtr) this.handle);
        user.CheckOutcome();
        return (IUAObject) user.Get<UAObject>();
      }
    }

    public bool IsRootUser
    {
      get
      {
        InteropCallResult interopCallResult = SessionHandler.Interop.SessionHandlerIsRootUser(this.contextPtr, (IntPtr) this.handle);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public ISessionHandler Copy() => throw new NotImplementedException();

    public IWeakSessionHandler GetWeakSessionHandler() => throw new NotImplementedException();

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    internal SessionHandler(UACoreContext context, SessionHandlerSafeHandle safeHandle)
    {
      this.contextPtr = context.nativeContextPtr;
      this.handle = safeHandle;
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        this.handle.Dispose();
        this.handle = (SessionHandlerSafeHandle) null;
      }
      this.disposed = true;
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionHandlerGetActualLocaleId(
        IntPtr context,
        IntPtr sessionHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionHandlerSetActualLocaleId(
        IntPtr context,
        IntPtr sessionHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string localeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionHandlerGetSessionObject(
        IntPtr context,
        IntPtr sessionHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionHandlerGetUser(
        IntPtr context,
        IntPtr sessionHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult SessionHandlerIsRootUser(
        IntPtr context,
        IntPtr sessionHandle);
    }
  }
}
