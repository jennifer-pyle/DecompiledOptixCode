// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Rectangle
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 60)]
  public class Rectangle : Container
  {
    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public Color FillColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FillColor)));
      set => this.SetOptionalVariableValue(nameof (FillColor), new UAValue(value.ARGB));
    }

    public IUAVariable FillColorVariable => this.GetOrCreateVariable("FillColor");

    public float BorderThickness
    {
      get => (float) this.GetOptionalVariableValue(nameof (BorderThickness));
      set => this.SetOptionalVariableValue(nameof (BorderThickness), new UAValue(value));
    }

    public IUAVariable BorderThicknessVariable => this.GetOrCreateVariable("BorderThickness");

    public float CornerRadius
    {
      get => (float) this.GetOptionalVariableValue(nameof (CornerRadius));
      set => this.SetOptionalVariableValue(nameof (CornerRadius), new UAValue(value));
    }

    public IUAVariable CornerRadiusVariable => this.GetOrCreateVariable("CornerRadius");

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
