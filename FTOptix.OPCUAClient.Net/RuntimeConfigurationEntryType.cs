// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAClient.RuntimeConfigurationEntryType
// Assembly: FTOptix.OPCUAClient.Net, Version=1.2.0.14, Culture=neutral, PublicKeyToken=null
// MVID: F06E52A2-2D8D-46E9-85AE-074DAF07FD19
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAClient.Net\1.2.0.14\Any\FTOptix.OPCUAClient.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OPCUAClient
{
  [MapType(NamespaceUri = "urn:FTOptix:OPCUAClient", Number = 102)]
  public class RuntimeConfigurationEntryType : UAObjectType
  {
    public NodeId LocalDestinationNode
    {
      get => (NodeId) this.Refs.GetVariable(nameof (LocalDestinationNode)).Value.Value;
      set => this.Refs.GetVariable(nameof (LocalDestinationNode)).SetValue((object) value);
    }

    public IUAVariable LocalDestinationNodeVariable
    {
      get => this.Refs.GetVariable("LocalDestinationNode");
    }

    public string RemoteSourceNode
    {
      get => (string) this.Refs.GetVariable(nameof (RemoteSourceNode)).Value.Value;
      set => this.Refs.GetVariable(nameof (RemoteSourceNode)).SetValue((object) value);
    }

    public IUAVariable RemoteSourceNodeVariable => this.Refs.GetVariable("RemoteSourceNode");

    public ContentSynchronizationMode ContentSynchronizationMode
    {
      get
      {
        return (ContentSynchronizationMode) (int) this.Refs.GetVariable(nameof (ContentSynchronizationMode)).Value;
      }
      set
      {
        this.Refs.GetVariable(nameof (ContentSynchronizationMode)).SetValue((object) (int) value);
      }
    }

    public IUAVariable ContentSynchronizationModeVariable
    {
      get => this.Refs.GetVariable("ContentSynchronizationMode");
    }

    public bool IncludeRemoteSourceNode
    {
      get => (bool) this.Refs.GetVariable(nameof (IncludeRemoteSourceNode)).Value.Value;
      set => this.Refs.GetVariable(nameof (IncludeRemoteSourceNode)).SetValue((object) value);
    }

    public IUAVariable IncludeRemoteSourceNodeVariable
    {
      get => this.Refs.GetVariable("IncludeRemoteSourceNode");
    }

    public bool EventSynchronization
    {
      get => (bool) this.Refs.GetVariable(nameof (EventSynchronization)).Value.Value;
      set => this.Refs.GetVariable(nameof (EventSynchronization)).SetValue((object) value);
    }

    public IUAVariable EventSynchronizationVariable
    {
      get => this.Refs.GetVariable("EventSynchronization");
    }

    public NodeId EventType
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (EventType));
      set => this.SetOptionalVariableValue(nameof (EventType), new UAValue(value));
    }

    public IUAVariable EventTypeVariable => this.GetOrCreateVariable("EventType");

    public InstanceNodeCollection<RuntimeConfigurationEntry> Instances
    {
      get => new InstanceNodeCollection<RuntimeConfigurationEntry>((IUANode) this);
    }
  }
}
