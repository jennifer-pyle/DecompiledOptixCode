// Decompiled with JetBrains decompiler
// Type: FTOptix.EventLogger.EventFieldToLogType
// Assembly: FTOptix.EventLogger.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: 528CE43C-3AF7-4AC6-BE57-ADCA4F1AF343
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.EventLogger.Net\1.0.8.39\Any\FTOptix.EventLogger.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.EventLogger
{
  [MapType(NamespaceUri = "urn:FTOptix:EventLogger", Number = 18)]
  public class EventFieldToLogType : UAVariableType
  {
    public InstanceNodeCollection<EventFieldToLog> Instances
    {
      get => new InstanceNodeCollection<EventFieldToLog>((IUANode) this);
    }
  }
}
