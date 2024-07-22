// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ValueAxisType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 366)]
  public class ValueAxisType : UAObjectType
  {
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

    public bool AutoScale
    {
      get => (bool) this.Refs.GetVariable(nameof (AutoScale)).Value.Value;
      set => this.Refs.GetVariable(nameof (AutoScale)).SetValue((object) value);
    }

    public IUAVariable AutoScaleVariable => this.Refs.GetVariable("AutoScale");

    public bool Interactive
    {
      get => (bool) this.Refs.GetVariable(nameof (Interactive)).Value.Value;
      set => this.Refs.GetVariable(nameof (Interactive)).SetValue((object) value);
    }

    public IUAVariable InteractiveVariable => this.Refs.GetVariable("Interactive");

    public HorizontalPosition Position
    {
      get => (HorizontalPosition) this.Refs.GetVariable(nameof (Position)).Value.Value;
      set => this.Refs.GetVariable(nameof (Position)).SetValue((object) (int) value);
    }

    public IUAVariable PositionVariable => this.GetVariable("Position");

    public InstanceNodeCollection<ValueAxis> Instances
    {
      get => new InstanceNodeCollection<ValueAxis>((IUANode) this);
    }
  }
}
