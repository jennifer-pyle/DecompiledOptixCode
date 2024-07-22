// Decompiled with JetBrains decompiler
// Type: FTOptix.EventLogger.EventConfigurationType
// Assembly: FTOptix.EventLogger.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: 528CE43C-3AF7-4AC6-BE57-ADCA4F1AF343
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.EventLogger.Net\1.0.8.39\Any\FTOptix.EventLogger.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.EventLogger
{
  [MapType(NamespaceUri = "urn:FTOptix:EventLogger", Number = 14)]
  public class EventConfigurationType : UAObjectType
  {
    public NodeId EventSource
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (EventSource));
      set => this.SetOptionalVariableValue(nameof (EventSource), new UAValue(value));
    }

    public NodePointer EventSourceVariable => (NodePointer) this.GetOrCreateVariable("EventSource");

    public bool MonitorSubtree
    {
      get => (bool) this.GetOptionalVariableValue(nameof (MonitorSubtree));
      set => this.SetOptionalVariableValue(nameof (MonitorSubtree), new UAValue(value));
    }

    public IUAVariable MonitorSubtreeVariable => this.GetOrCreateVariable("MonitorSubtree");

    public NodeId EventType
    {
      get => (NodeId) this.Refs.GetVariable(nameof (EventType)).Value.Value;
      set => this.Refs.GetVariable(nameof (EventType)).SetValue((object) value);
    }

    public NodePointer EventTypeVariable => (NodePointer) this.Refs.GetVariable("EventType");

    public bool ExcludeNonInteractiveSessions
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ExcludeNonInteractiveSessions));
      set
      {
        this.SetOptionalVariableValue(nameof (ExcludeNonInteractiveSessions), new UAValue(value));
      }
    }

    public IUAVariable ExcludeNonInteractiveSessionsVariable
    {
      get => this.GetOrCreateVariable("ExcludeNonInteractiveSessions");
    }

    public InstanceNodeCollection<EventConfiguration> Instances
    {
      get => new InstanceNodeCollection<EventConfiguration>((IUANode) this);
    }
  }
}
