// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.DynamicLinkType
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using System.Collections.Generic;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 9)]
  public class DynamicLinkType : UAVariableType
  {
    public uint[] ParentArrayIndex
    {
      get
      {
        object parentArrayIndex = this.GetOptionalVariableValue(nameof (ParentArrayIndex)).Value;
        if (parentArrayIndex == null || parentArrayIndex.GetType().IsArray)
          return (uint[]) parentArrayIndex;
        return new uint[1]{ (uint) parentArrayIndex };
      }
      set => this.SetOptionalVariableValue(nameof (ParentArrayIndex), new UAValue(value));
    }

    public uint ParentScalarIndex
    {
      set
      {
        this.SetOptionalVariableValue("ParentArrayIndex", new UAValue(new uint[1]
        {
          value
        }));
      }
    }

    public IUAVariable ParentArrayIndexVariable => this.GetOrCreateVariable("ParentArrayIndex");

    public DynamicLinkMode Mode
    {
      get => (DynamicLinkMode) (int) this.GetOptionalVariableValue(nameof (Mode));
      set => this.SetOptionalVariableValue(nameof (Mode), new UAValue((int) value));
    }

    public IUAVariable ModeVariable => this.GetOrCreateVariable("Mode");

    public bool IsPull
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IsPull));
      set => this.SetOptionalVariableValue(nameof (IsPull), new UAValue(value));
    }

    public IUAVariable IsPullVariable => this.GetOrCreateVariable("IsPull");

    public DynamicLinkEUMode EUMode
    {
      get => (DynamicLinkEUMode) (int) this.GetOptionalVariableValue(nameof (EUMode));
      set => this.SetOptionalVariableValue(nameof (EUMode), new UAValue((int) value));
    }

    public IUAVariable EUModeVariable => this.GetOrCreateVariable("EUMode");

    public override void SetModellingRuleRecursive()
    {
      IUANode owner = this.Owner;
      if (owner == null || owner.ModellingRule == NamingRuleType.None)
        return;
      if (owner.ModellingRule == NamingRuleType.Optional)
        owner.ModellingRule = NamingRuleType.Mandatory;
      this.ModellingRule = owner.ModellingRule;
      foreach (IUAVariable variable in (IEnumerable<IUAVariable>) this.Refs.GetVariables(UAManagedCore.OpcUa.ReferenceTypes.Aggregates))
      {
        variable.ModellingRule = NamingRuleType.Mandatory;
        variable.SetModellingRuleRecursive();
      }
    }

    public InstanceNodeCollection<DynamicLink> Instances
    {
      get => new InstanceNodeCollection<DynamicLink>((IUANode) this);
    }
  }
}
