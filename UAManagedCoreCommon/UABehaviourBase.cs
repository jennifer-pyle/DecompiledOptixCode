// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UABehaviourBase`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class UABehaviourBase<T> : IBehaviour where T : IUANode
  {
    protected UABehaviourBase(T obj) => this.MyObject = obj;

    protected T MyObject { get; }

    protected IContext Context => this.MyObject.Context;

    void IBehaviour.Start() => this.OnStart();

    void IBehaviour.Stop() => this.OnStop();

    protected virtual void OnStart()
    {
    }

    protected virtual void OnStop()
    {
    }
  }
}
