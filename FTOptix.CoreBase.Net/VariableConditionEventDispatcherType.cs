// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.VariableConditionEventDispatcherType
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 43)]
  public class VariableConditionEventDispatcherType : UAObjectType
  {
    public string VariableNodePath
    {
      get => (string) this.Refs.GetVariable(nameof (VariableNodePath)).Value;
      set => this.Refs.GetVariable(nameof (VariableNodePath)).SetValue((object) value);
    }

    public IUAVariable VariableNodePathVariable => this.Refs.GetVariable("VariableNodePath");

    public InstanceNodeCollection<VariableConditionEventDispatcher> Instances
    {
      get => new InstanceNodeCollection<VariableConditionEventDispatcher>((IUANode) this);
    }
  }
}
