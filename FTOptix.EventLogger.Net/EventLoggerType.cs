// Decompiled with JetBrains decompiler
// Type: FTOptix.EventLogger.EventLoggerType
// Assembly: FTOptix.EventLogger.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: 528CE43C-3AF7-4AC6-BE57-ADCA4F1AF343
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.EventLogger.Net\1.0.8.39\Any\FTOptix.EventLogger.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.EventLogger
{
  [MapType(NamespaceUri = "urn:FTOptix:EventLogger", Number = 1)]
  public class EventLoggerType : UAObjectType
  {
    public bool Enabled
    {
      get => (bool) this.Refs.GetVariable(nameof (Enabled)).Value.Value;
      set => this.Refs.GetVariable(nameof (Enabled)).SetValue((object) value);
    }

    public IUAVariable EnabledVariable => this.Refs.GetVariable("Enabled");

    public string[] Locales
    {
      get => (string[]) this.Refs.GetVariable(nameof (Locales))?.GetValue();
      set
      {
        if (value != null)
          (this.Refs.GetVariable(nameof (Locales)) ?? this.GetOrCreateVariable(nameof (Locales))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (Locales))?.Delete();
      }
    }

    public IUAVariable LocalesVariable => this.GetOrCreateVariable("Locales");

    public NodeId Store
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Store)).Value.Value;
      set => this.Refs.GetVariable(nameof (Store)).SetValue((object) value);
    }

    public NodePointer StoreVariable => (NodePointer) this.Refs.GetVariable("Store");

    public PlaceholderChildNodeCollection<EventConfiguration> EventConfigurations
    {
      get
      {
        return new PlaceholderChildNodeCollection<EventConfiguration>((IUANode) this, nameof (EventConfigurations));
      }
    }

    public PlaceholderChildNodeCollection<EventFieldPath> EventFieldPaths
    {
      get
      {
        return new PlaceholderChildNodeCollection<EventFieldPath>((IUANode) this, nameof (EventFieldPaths));
      }
    }

    public PlaceholderChildNodeCollection<EventFieldToLog> EventFieldsToLog
    {
      get
      {
        return new PlaceholderChildNodeCollection<EventFieldToLog>((IUANode) this, nameof (EventFieldsToLog));
      }
    }

    public InstanceNodeCollection<FTOptix.EventLogger.EventLogger> Instances
    {
      get => new InstanceNodeCollection<FTOptix.EventLogger.EventLogger>((IUANode) this);
    }
  }
}
