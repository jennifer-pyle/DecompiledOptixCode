// Decompiled with JetBrains decompiler
// Type: FTOptix.System.Application
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  public class Application
  {
    private PropertyGroup applicationObject;

    public Application(PropertyGroup applicationObject)
    {
      this.applicationObject = applicationObject;
    }

    public PropertyGroup Object => this.applicationObject;

    public bool FastBlink => (bool) this.FastBlinkVariable.Value;

    public IUAVariable FastBlinkVariable => this.applicationObject.GetVariable("FastBlink");

    public bool MediumBlink => (bool) this.MediumBlinkVariable.Value;

    public IUAVariable MediumBlinkVariable => this.applicationObject.GetVariable("MediumBlink");

    public bool SlowBlink => (bool) this.SlowBlinkVariable.Value;

    public IUAVariable SlowBlinkVariable => this.applicationObject.GetVariable("SlowBlink");
  }
}
