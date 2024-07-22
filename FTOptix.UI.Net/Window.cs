// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Window
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 12)]
  public class Window : BaseUIObject
  {
    public float X
    {
      get => (float) this.GetOptionalVariableValue(nameof (X));
      set => this.SetOptionalVariableValue(nameof (X), new UAValue(value));
    }

    public IUAVariable XVariable => this.GetOrCreateVariable("X");

    public float Y
    {
      get => (float) this.GetOptionalVariableValue(nameof (Y));
      set => this.SetOptionalVariableValue(nameof (Y), new UAValue(value));
    }

    public IUAVariable YVariable => this.GetOrCreateVariable("Y");

    public float Width
    {
      get => (float) this.GetOptionalVariableValue(nameof (Width));
      set => this.SetOptionalVariableValue(nameof (Width), new UAValue(value));
    }

    public IUAVariable WidthVariable => this.GetOrCreateVariable("Width");

    public float Height
    {
      get => (float) this.GetOptionalVariableValue(nameof (Height));
      set => this.SetOptionalVariableValue(nameof (Height), new UAValue(value));
    }

    public IUAVariable HeightVariable => this.GetOrCreateVariable("Height");

    public bool FullScreen
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FullScreen));
      set => this.SetOptionalVariableValue(nameof (FullScreen), new UAValue(value));
    }

    public IUAVariable FullScreenVariable => this.GetOrCreateVariable("FullScreen");

    public bool AlwaysOnTop
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AlwaysOnTop));
      set => this.SetOptionalVariableValue(nameof (AlwaysOnTop), new UAValue(value));
    }

    public IUAVariable AlwaysOnTopVariable => this.GetOrCreateVariable("AlwaysOnTop");

    public string Caption
    {
      get => (string) this.GetOptionalVariableValue(nameof (Caption));
      set => this.SetOptionalVariableValue(nameof (Caption), new UAValue(value));
    }

    public IUAVariable CaptionVariable => this.GetOrCreateVariable("Caption");
  }
}
