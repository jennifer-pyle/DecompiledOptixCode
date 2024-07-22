// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DateTimeAxis
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 365)]
  public class DateTimeAxis : UAObject
  {
    public bool Follow
    {
      get => (bool) this.Refs.GetVariable(nameof (Follow)).Value.Value;
      set => this.Refs.GetVariable(nameof (Follow)).SetValue((object) value);
    }

    public IUAVariable FollowVariable => this.Refs.GetVariable("Follow");

    public uint Window
    {
      get
      {
        return (uint) Math.Round(Math.Max(0.0, (double) this.Refs.GetVariable(nameof (Window)).Value));
      }
      set => this.Refs.GetVariable(nameof (Window)).SetValue((object) (double) value);
    }

    public IUAVariable WindowVariable => this.Refs.GetVariable("Window");

    public bool Interactive
    {
      get => (bool) this.Refs.GetVariable(nameof (Interactive)).Value.Value;
      set => this.Refs.GetVariable(nameof (Interactive)).SetValue((object) value);
    }

    public IUAVariable InteractiveVariable => this.Refs.GetVariable("Interactive");

    public DateTime Time
    {
      get => (DateTime) this.Refs.GetVariable(nameof (Time)).Value.Value;
      set => this.Refs.GetVariable(nameof (Time)).SetValue((object) value);
    }

    public IUAVariable TimeVariable => this.Refs.GetVariable("Time");

    public SnapPosition SnapPosition
    {
      get => (SnapPosition) (int) this.GetOptionalVariableValue(nameof (SnapPosition));
      set => this.SetOptionalVariableValue(nameof (SnapPosition), new UAValue((int) value));
    }

    public IUAVariable SnapPositionVariable => this.GetOrCreateVariable("SnapPosition");
  }
}
