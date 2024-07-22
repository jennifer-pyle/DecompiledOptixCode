// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TransactionResource
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class TransactionResource : ITransactionResource, IDisposable
  {
    internal TransactionResourceSafeHandle handle;
    private bool disposed;

    public void AbortTransaction()
    {
      TransactionResource.Interop.TransactionResourceAbortTransaction((IntPtr) this.handle).CheckOutcome();
    }

    public void AddMethod(IUAObject obj, string method)
    {
      if (obj == null)
        throw new ArgumentNullException(nameof (obj));
      if (method == null)
        throw new ArgumentNullException(nameof (method));
      TransactionResource.Interop.TransactionResourceAddMethod((IntPtr) this.handle, (IntPtr) ((UANode) obj).nodeHandle, method).CheckOutcome();
    }

    public void AddVariable(IUAVariable variable, ValueOperationType operation)
    {
      if (variable == null)
        throw new ArgumentNullException(nameof (variable));
      TransactionResource.Interop.TransactionResourceAddVariable((IntPtr) this.handle, (IntPtr) ((UANode) variable).nodeHandle, (int) operation).CheckOutcome();
    }

    public void BeginTransaction()
    {
      TransactionResource.Interop.TransactionResourceBeginTransaction((IntPtr) this.handle).CheckOutcome();
    }

    public bool EndTransaction()
    {
      InteropCallResult interopCallResult = TransactionResource.Interop.TransactionResourceEndTransaction((IntPtr) this.handle);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        this.handle?.Dispose();
        this.handle = (TransactionResourceSafeHandle) null;
      }
      this.disposed = true;
    }

    internal TransactionResource(TransactionResourceSafeHandle handle) => this.handle = handle;

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult TransactionResourceAbortTransaction(IntPtr handle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult TransactionResourceAddMethod(
        IntPtr handle,
        IntPtr objectPtr,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string method);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult TransactionResourceAddVariable(
        IntPtr handle,
        IntPtr variablePtr,
        int operation);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult TransactionResourceBeginTransaction(IntPtr handle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult TransactionResourceEndTransaction(IntPtr handle);
    }
  }
}
