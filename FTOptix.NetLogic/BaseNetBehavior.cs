// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.BaseNetBehavior
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;
using UAManagedCore;

//#nullable disable
namespace FTOptix.NetLogic
{
  public class BaseNetBehavior : IDisposable
  {
    private bool disposedValue;

    public void Initialize(IUANode node) => this.Node = node;

    public virtual void Start()
    {
    }

    public virtual void Stop()
    {
    }

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposedValue)
        return;
      if (disposing)
        DisposableFieldDisposing.DisposeFields(this.GetType(), (object) this);
      this.disposedValue = true;
    }

    protected IUANode Node { get; private set; }
  }
}
