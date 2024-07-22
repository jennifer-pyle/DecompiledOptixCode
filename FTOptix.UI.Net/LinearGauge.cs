// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.LinearGauge
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 311)]
  public class LinearGauge : Item
  {
    public float Value
    {
      get => (float) this.Refs.GetVariable(nameof (Value)).Value.Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue((object) value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");

    public float MinValue
    {
      get => (float) this.Refs.GetVariable(nameof (MinValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (MinValue)).SetValue((object) value);
    }

    public IUAVariable MinValueVariable => this.Refs.GetVariable("MinValue");

    public float MaxValue
    {
      get => (float) this.Refs.GetVariable(nameof (MaxValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaxValue)).SetValue((object) value);
    }

    public IUAVariable MaxValueVariable => this.Refs.GetVariable("MaxValue");

    public float MajorTickCount
    {
      get => (float) this.GetOptionalVariableValue(nameof (MajorTickCount));
      set => this.SetOptionalVariableValue(nameof (MajorTickCount), new UAValue(value));
    }

    public IUAVariable MajorTickCountVariable => this.GetOrCreateVariable("MajorTickCount");

    public float MinorTickCount
    {
      get => (float) this.GetOptionalVariableValue(nameof (MinorTickCount));
      set => this.SetOptionalVariableValue(nameof (MinorTickCount), new UAValue(value));
    }

    public IUAVariable MinorTickCountVariable => this.GetOrCreateVariable("MinorTickCount");

    public bool LabelVisible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (LabelVisible));
      set => this.SetOptionalVariableValue(nameof (LabelVisible), new UAValue(value));
    }

    public IUAVariable LabelVisibleVariable => this.GetOrCreateVariable("LabelVisible");

    public bool Editable
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Editable));
      set => this.SetOptionalVariableValue(nameof (Editable), new UAValue(value));
    }

    public IUAVariable EditableVariable => this.GetOrCreateVariable("Editable");

    public float ScalePadding
    {
      get => (float) this.GetOptionalVariableValue(nameof (ScalePadding));
      set => this.SetOptionalVariableValue(nameof (ScalePadding), new UAValue(value));
    }

    public IUAVariable ScalePaddingVariable => this.GetOrCreateVariable("ScalePadding");

    public ResourceUri ImagePath
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ImagePath)));
      set => this.SetOptionalVariableValue(nameof (ImagePath), new UAValue((string) value));
    }

    public IUAVariable ImagePathVariable => this.GetOrCreateVariable("ImagePath");

    public Color FillColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (FillColor)));
      set => this.SetOptionalVariableValue(nameof (FillColor), new UAValue(value.ARGB));
    }

    public IUAVariable FillColorVariable => this.GetOrCreateVariable("FillColor");

    public ColorizationMode ColorizationMode
    {
      get => (ColorizationMode) (int) this.GetOptionalVariableValue(nameof (ColorizationMode));
      set => this.SetOptionalVariableValue(nameof (ColorizationMode), new UAValue((int) value));
    }

    public IUAVariable ColorizationModeVariable => this.GetOrCreateVariable("ColorizationMode");

    public PlaceholderChildNodeCollection<WarningZone> WarningZones
    {
      get => new PlaceholderChildNodeCollection<WarningZone>((IUANode) this, nameof (WarningZones));
    }

    public ValueChangeBehaviour ValueChangeBehaviour
    {
      get
      {
        return (ValueChangeBehaviour) (int) this.GetOptionalVariableValue(nameof (ValueChangeBehaviour));
      }
      set => this.SetOptionalVariableValue(nameof (ValueChangeBehaviour), new UAValue((int) value));
    }

    public IUAVariable ValueChangeBehaviourVariable
    {
      get => this.GetOrCreateVariable("ValueChangeBehaviour");
    }

    public Position ScalePosition
    {
      get => (Position) (int) this.GetOptionalVariableValue(nameof (ScalePosition));
      set => this.SetOptionalVariableValue(nameof (ScalePosition), new UAValue((int) value));
    }

    public IUAVariable ScalePositionVariable => this.GetOrCreateVariable("ScalePosition");

    public Orientation Orientation
    {
      get => (Orientation) (int) this.GetOptionalVariableValue(nameof (Orientation));
      set => this.SetOptionalVariableValue(nameof (Orientation), new UAValue((int) value));
    }

    public IUAVariable OrientationVariable => this.GetOrCreateVariable("Orientation");

    public bool Tooltip
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Tooltip));
      set => this.SetOptionalVariableValue(nameof (Tooltip), new UAValue(value));
    }

    public IUAVariable TooltipVariable => this.GetOrCreateVariable("Tooltip");

    public string GaugeStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (GaugeStyle));
      set => this.SetOptionalVariableValue(nameof (GaugeStyle), new UAValue(value));
    }

    public IUAVariable GaugeStyleVariable => this.GetOrCreateVariable("GaugeStyle");

    public string ToolTipStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ToolTipStyle));
      set => this.SetOptionalVariableValue(nameof (ToolTipStyle), new UAValue(value));
    }

    public IUAVariable ToolTipStyleVariable => this.GetOrCreateVariable("ToolTipStyle");

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
