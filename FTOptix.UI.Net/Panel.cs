// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Panel
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 78)]
  public class Panel : Container
  {
    public bool HitTestVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible));
      set => this.SetOptionalVariableValue(nameof (HitTestVisible), new UAValue(value));
    }

    public IUAVariable HitTestVisibleVariable => this.GetOrCreateVariable("HitTestVisible");

    public event EventHandler<MouseDownEvent> OnMouseDown
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 14U), typeof (EventHandler<MouseDownEvent>), typeof (MouseDownEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 14U), typeof (EventHandler<MouseDownEvent>), typeof (MouseDownEvent)).Remove((Delegate) value);
      }
    }

    public event EventHandler<MouseUpEvent> OnMouseUp
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 15U), typeof (EventHandler<MouseUpEvent>), typeof (MouseUpEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 15U), typeof (EventHandler<MouseUpEvent>), typeof (MouseUpEvent)).Remove((Delegate) value);
      }
    }

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
