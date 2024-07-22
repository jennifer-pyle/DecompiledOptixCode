// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DelayedButton
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 105)]
  public class DelayedButton : Button
  {
    public double Delay
    {
      get => (double) this.GetOptionalVariableValue(nameof (Delay));
      set => this.SetOptionalVariableValue(nameof (Delay), new UAValue(value));
    }

    public IUAVariable DelayVariable => this.GetOrCreateVariable("Delay");

    public event EventHandler<MouseLongPressEvent> OnMouseLongPress
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 401U), typeof (EventHandler<MouseLongPressEvent>), typeof (MouseLongPressEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 401U), typeof (EventHandler<MouseLongPressEvent>), typeof (MouseLongPressEvent)).Remove((Delegate) value);
      }
    }
  }
}
