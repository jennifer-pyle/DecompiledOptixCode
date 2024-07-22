// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.EventHandler
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 1)]
  public class EventHandler : UAObject
  {
    public NodeId ListenEventType
    {
      get => (NodeId) this.Refs.GetVariable(nameof (ListenEventType)).Value.Value;
      set => this.Refs.GetVariable(nameof (ListenEventType)).SetValue((object) value);
    }

    public IUAVariable ListenEventTypeVariable => this.Refs.GetVariable("ListenEventType");

    public NodeId ListenObject
    {
      get => (NodeId) this.Refs.GetVariable(nameof (ListenObject))?.GetValue();
      set
      {
        if (value != (NodeId) null)
          (this.Refs.GetVariable(nameof (ListenObject)) ?? this.GetOrCreateVariable(nameof (ListenObject))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (ListenObject))?.Delete();
      }
    }

    public IUAVariable ListenObjectVariable
    {
      get
      {
        IUAVariable variable = this.GetOrCreateVariable("ListenObject");
        if (this.ModellingRule == NamingRuleType.Mandatory)
          variable.ModellingRule = NamingRuleType.Mandatory;
        return variable;
      }
    }

    public PlaceholderChildNodeCollection<IUAObject> MethodsToCall
    {
      get => new PlaceholderChildNodeCollection<IUAObject>((IUANode) this, nameof (MethodsToCall));
    }
  }
}
