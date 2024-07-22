﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AdvancedSVGImage
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1107)]
  public class AdvancedSVGImage : Container
  {
    public ResourceUri Path
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (Path)).Value);
      set => this.Refs.GetVariable(nameof (Path)).SetValue((object) (string) value);
    }

    public IUAVariable PathVariable => this.Refs.GetVariable("Path");

    public FillMode FillMode
    {
      get => (FillMode) this.GetOptionalVariableValue(nameof (FillMode)).Value;
      set => this.SetOptionalVariableValue(nameof (FillMode), new UAValue((int) value));
    }

    public IUAVariable FillModeVariable => this.GetOrCreateVariable("FillMode");

    public ColorizationMode ColorizationMode
    {
      get => (ColorizationMode) this.GetOptionalVariableValue(nameof (ColorizationMode)).Value;
      set => this.SetOptionalVariableValue(nameof (ColorizationMode), new UAValue((int) value));
    }

    public IUAVariable ColorizationModeVariable => this.GetOrCreateVariable("ColorizationMode");

    public bool HitTestVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (HitTestVisible)).Value;
      set => this.SetOptionalVariableValue(nameof (HitTestVisible), new UAValue(value));
    }

    public IUAVariable HitTestVisibleVariable => this.GetOrCreateVariable("HitTestVisible");

    public bool Blink
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Blink));
      set => this.SetOptionalVariableValue(nameof (Blink), new UAValue(value));
    }

    public IUAVariable BlinkVariable => this.GetOrCreateVariable("Blink");

    public PlaceholderChildNodeCollection<AdvancedSVGImageElementProperty> SVGElementProperties
    {
      get
      {
        return new PlaceholderChildNodeCollection<AdvancedSVGImageElementProperty>((IUANode) this, nameof (SVGElementProperties));
      }
    }

    public void SetImageContent(string xmlDataString)
    {
      this.ExecuteMethod(nameof (SetImageContent), new object[1]
      {
        (object) xmlDataString
      }, out object[] _);
    }

    public IUAMethod SetImageContentMethod => this.Refs.GetMethod("SetImageContent");

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
