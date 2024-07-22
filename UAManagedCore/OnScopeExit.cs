// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OnScopeExit
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  public class OnScopeExit : IDisposable
  {
    internal OnScopeExitSafeHandle handle;
    private bool disposed;

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        this.handle?.Dispose();
        this.handle = (OnScopeExitSafeHandle) null;
      }
      this.disposed = true;
    }

    internal OnScopeExit(OnScopeExitSafeHandle handle) => this.handle = handle;
  }
}
