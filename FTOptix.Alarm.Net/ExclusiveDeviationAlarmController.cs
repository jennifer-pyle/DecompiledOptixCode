// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.ExclusiveDeviationAlarmController
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  [MapType(NamespaceUri = "urn:FTOptix:Alarm", Number = 106)]
  public class ExclusiveDeviationAlarmController : ExclusiveLimitAlarmController
  {
    public double Setpoint
    {
      get => (double) this.Refs.GetVariable(nameof (Setpoint)).Value.Value;
      set => this.Refs.GetVariable(nameof (Setpoint)).SetValue((object) value);
    }

    public IUAVariable SetpointVariable => this.Refs.GetVariable("Setpoint");
  }
}
