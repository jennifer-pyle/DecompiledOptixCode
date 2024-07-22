// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.Objects
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  public static class Objects
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Alarm");
    public static readonly NodeId AlarmCommands = new NodeId(Objects.namespaceIndex, 64U);
    public static readonly NodeId AlarmConfiguration = new NodeId(Objects.namespaceIndex, 60U);
    public static readonly NodeId RetainedAlarms = new NodeId(Objects.namespaceIndex, 44U);
    public static readonly NodeId AllAlarms = new NodeId(Objects.namespaceIndex, 141U);
  }
}
