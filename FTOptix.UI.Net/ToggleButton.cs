// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ToggleButton
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 103)]
  public class ToggleButton : Button
  {
    public bool Active
    {
      get => (bool) this.Refs.GetVariable(nameof (Active)).Value;
      set => this.Refs.GetVariable(nameof (Active)).SetValue((object) value);
    }

    public IUAVariable ActiveVariable => this.Refs.GetVariable("Active");

    public event EventHandler<UserValueChangedEvent> OnUserValueChanged
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 690U), typeof (EventHandler<UserValueChangedEvent>), typeof (UserValueChangedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 690U), typeof (EventHandler<UserValueChangedEvent>), typeof (UserValueChangedEvent)).Remove((Delegate) value);
      }
    }
  }
}
