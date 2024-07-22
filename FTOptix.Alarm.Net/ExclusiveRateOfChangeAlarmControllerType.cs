﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.ExclusiveRateOfChangeAlarmControllerType
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  [MapType(NamespaceUri = "urn:FTOptix:Alarm", Number = 110)]
  public class ExclusiveRateOfChangeAlarmControllerType : ExclusiveLimitAlarmControllerType
  {
    public double PollingTime
    {
      get => (double) this.Refs.GetVariable(nameof (PollingTime)).Value.Value;
      set => this.Refs.GetVariable(nameof (PollingTime)).SetValue((object) value);
    }

    public IUAVariable PollingTimeVariable => this.Refs.GetVariable("PollingTime");

    public InstanceNodeCollection<ExclusiveRateOfChangeAlarmController> Instances
    {
      get => new InstanceNodeCollection<ExclusiveRateOfChangeAlarmController>((IUANode) this);
    }
  }
}
