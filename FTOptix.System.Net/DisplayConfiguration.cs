// Decompiled with JetBrains decompiler
// Type: FTOptix.System.Display
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  public class Display
  {
    private PropertyGroup displayObject;

    public Display(PropertyGroup displayObject) => this.displayObject = displayObject;

    public PropertyGroup Object => this.displayObject;

    public uint Brightness
    {
      get => (uint) this.BrightnessVariable.Value;
      set => this.BrightnessVariable.SetValue((object) value);
    }

    public IUAVariable BrightnessVariable => this.displayObject.GetVariable("Brightness");

    public uint VerticalResolution => (uint) this.VerticalResolutionVariable.Value;

    public IUAVariable VerticalResolutionVariable
    {
      get => this.displayObject.GetVariable("VerticalResolution");
    }

    public uint HorizontalResolution => (uint) this.HorizontalResolutionVariable.Value;

    public IUAVariable HorizontalResolutionVariable
    {
      get => this.displayObject.GetVariable("HorizontalResolution");
    }

    public uint Scale
    {
      get => (uint) this.ScaleVariable.Value;
      set => this.ScaleVariable.SetValue((object) value);
    }

    public IUAVariable ScaleVariable => this.displayObject.GetVariable("Scale");

    public DisplayOrientation Orientation
    {
      get => (DisplayOrientation) (int) this.OrientationVariable.Value;
      set => this.OrientationVariable.SetValue((object) (int) value);
    }

    public IUAVariable OrientationVariable => this.displayObject.GetVariable("Orientation");
  }
}
