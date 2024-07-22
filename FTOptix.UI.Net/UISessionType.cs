// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.UISessionType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 665)]
  public class UISessionType : SessionType
  {
    public TimeSpan IdleTimeoutDuration
    {
      get
      {
        return TimeSpan.FromMilliseconds((double) this.GetOptionalVariableValue(nameof (IdleTimeoutDuration)));
      }
      set
      {
        this.SetOptionalVariableValue(nameof (IdleTimeoutDuration), new UAValue(value.TotalMilliseconds));
      }
    }

    public IUAVariable IdleTimeoutDurationVariable
    {
      get => this.GetOrCreateVariable("IdleTimeoutDuration");
    }

    public bool IdleTimeoutEnabled
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IdleTimeoutEnabled));
      set => this.SetOptionalVariableValue(nameof (IdleTimeoutEnabled), new UAValue(value));
    }

    public IUAVariable IdleTimeoutEnabledVariable => this.GetOrCreateVariable("IdleTimeoutEnabled");

    public new bool IsInteractive
    {
      get => (bool) this.Refs.GetVariable(nameof (IsInteractive)).Value.Value;
    }

    public new IUAVariable IsInteractiveVariable => this.Refs.GetVariable("IsInteractive");

    public bool IsNative => (bool) this.Refs.GetVariable(nameof (IsNative)).Value;

    public IUAVariable IsNativeVariable => this.Refs.GetVariable("IsNative");

    public bool IsWeb => (bool) this.Refs.GetVariable(nameof (IsWeb)).Value;

    public IUAVariable IsWebVariable => this.Refs.GetVariable("IsWeb");

    public string IpAddress => (string) this.Refs.GetVariable(nameof (IpAddress)).Value;

    public IUAVariable IpAddressVariable => this.Refs.GetVariable("IpAddress");

    public InstanceNodeCollection<UISession> Instances
    {
      get => new InstanceNodeCollection<UISession>((IUANode) this);
    }
  }
}
