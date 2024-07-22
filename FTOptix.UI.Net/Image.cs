// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Image
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 9)]
  public class Image : Container
  {
    public ResourceUri Path
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (Path)).Value);
      set => this.Refs.GetVariable(nameof (Path)).SetValue((object) (string) value);
    }

    public IUAVariable PathVariable => this.Refs.GetVariable("Path");

    public Color DynamicColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (DynamicColor)));
      set => this.SetOptionalVariableValue(nameof (DynamicColor), new UAValue(value.ARGB));
    }

    public IUAVariable DynamicColorVariable => this.GetOrCreateVariable("DynamicColor");

    public ColorizationMode ColorizationMode
    {
      get => (ColorizationMode) (int) this.GetOptionalVariableValue(nameof (ColorizationMode));
      set => this.SetOptionalVariableValue(nameof (ColorizationMode), new UAValue((int) value));
    }

    public IUAVariable ColorizationModeVariable => this.GetOrCreateVariable("ColorizationMode");

    public FillMode FillMode
    {
      get => (FillMode) (int) this.GetOptionalVariableValue(nameof (FillMode));
      set => this.SetOptionalVariableValue(nameof (FillMode), new UAValue((int) value));
    }

    public IUAVariable FillModeVariable => this.GetOrCreateVariable("FillMode");

    public bool HitTestVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible));
      set => this.SetOptionalVariableValue(nameof (HitTestVisible), new UAValue(value));
    }

    public IUAVariable HitTestVisibleVariable => this.GetOrCreateVariable("HitTestVisible");

    public float ImageLeftMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageLeftMargin));
      set => this.SetOptionalVariableValue(nameof (ImageLeftMargin), new UAValue(value));
    }

    public IUAVariable ImageLeftMarginVariable => this.GetOrCreateVariable("ImageLeftMargin");

    public float ImageTopMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageTopMargin));
      set => this.SetOptionalVariableValue(nameof (ImageTopMargin), new UAValue(value));
    }

    public IUAVariable ImageTopMarginVariable => this.GetOrCreateVariable("ImageTopMargin");

    public float ImageRightMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageRightMargin));
      set => this.SetOptionalVariableValue(nameof (ImageRightMargin), new UAValue(value));
    }

    public IUAVariable ImageRightMarginVariable => this.GetOrCreateVariable("ImageRightMargin");

    public float ImageBottomMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageBottomMargin));
      set => this.SetOptionalVariableValue(nameof (ImageBottomMargin), new UAValue(value));
    }

    public IUAVariable ImageBottomMarginVariable => this.GetOrCreateVariable("ImageBottomMargin");

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
