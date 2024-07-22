// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UACoreContextFactory
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UACoreContextFactory : IDisposable
  {
    private UACoreContext managedContext;
    private IntPtr coreContextPtr;
    private bool disposed;

    public UACoreContextFactory(string customModulesDirectory)
    {
      InteropCallResult interopCallResult = UACoreContextFactory.Interop.UACoreContextFactoryConstructor(customModulesDirectory, out this.coreContextPtr);
      interopCallResult.CheckOutcome();
      this.managedContext = ObjectMarshal.FromIntPtr<UACoreContext>(interopCallResult.ReturnValuePtr);
    }

    public IContext Get() => (IContext) this.managedContext;

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        UACoreContextFactory.Interop.UACoreContextFactoryDispose(this.coreContextPtr).CheckOutcome();
        this.managedContext = (UACoreContext) null;
        this.coreContextPtr = IntPtr.Zero;
      }
      this.disposed = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextFactoryConstructor(
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string customModulesDirectory,
        out IntPtr coreContextPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UACoreContextFactoryDispose(IntPtr coreContextPtr);
    }
  }
}
