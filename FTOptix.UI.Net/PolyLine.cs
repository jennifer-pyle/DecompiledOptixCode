// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.PolyLine
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1124)]
  public class PolyLine : Container
  {
    public Color LineColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (LineColor)));
      set => this.SetOptionalVariableValue(nameof (LineColor), new UAValue(value.ARGB));
    }

    public IUAVariable LineColorVariable => this.GetOrCreateVariable("LineColor");

    public Color FillColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FillColor)));
      set => this.SetOptionalVariableValue(nameof (FillColor), new UAValue(value.ARGB));
    }

    public IUAVariable FillColorVariable => this.GetOrCreateVariable("FillColor");

    public float LineThickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (LineThickness));
      set => this.SetOptionalVariableValue(nameof (LineThickness), new UAValue(value));
    }

    public IUAVariable LineThicknessVariable => this.GetOrCreateVariable("LineThickness");

    public string Path
    {
      get => (string) this.GetOptionalVariableValue(nameof (Path));
      set => this.SetOptionalVariableValue(nameof (Path), new UAValue(value));
    }

    public IUAVariable PathVariable => this.GetOrCreateVariable("Path");

    public bool HitTestVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible));
      set => this.SetOptionalVariableValue(nameof (HitTestVisible), new UAValue(value));
    }

    public IUAVariable HitTestVisibleVariable => this.GetOrCreateVariable("HitTestVisible");

    public bool Blink
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Blink));
      set => this.SetOptionalVariableValue(nameof (Blink), new UAValue(value));
    }

    public IUAVariable BlinkVariable => this.GetOrCreateVariable("Blink");

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
