// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.ObjectTypes
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Alarm");
    public static readonly NodeId AlarmController = new NodeId(ObjectTypes.namespaceIndex, 67U);
    public static readonly NodeId OffNormalAlarmController = new NodeId(ObjectTypes.namespaceIndex, 84U);
    public static readonly NodeId LimitAlarmController = new NodeId(ObjectTypes.namespaceIndex, 86U);
    public static readonly NodeId NonExclusiveLevelAlarmController = new NodeId(ObjectTypes.namespaceIndex, 88U);
    public static readonly NodeId NonExclusiveRateOfChangeAlarmController = new NodeId(ObjectTypes.namespaceIndex, 89U);
    public static readonly NodeId ExclusiveLimitAlarmController = new NodeId(ObjectTypes.namespaceIndex, 101U);
    public static readonly NodeId ExclusiveLevelAlarmController = new NodeId(ObjectTypes.namespaceIndex, 103U);
    public static readonly NodeId NonExclusiveLimitAlarmController = new NodeId(ObjectTypes.namespaceIndex, 104U);
    public static readonly NodeId ExclusiveDeviationAlarmController = new NodeId(ObjectTypes.namespaceIndex, 106U);
    public static readonly NodeId NonExclusiveDeviationAlarmController = new NodeId(ObjectTypes.namespaceIndex, 108U);
    public static readonly NodeId ExclusiveRateOfChangeAlarmController = new NodeId(ObjectTypes.namespaceIndex, 110U);
  }
}
