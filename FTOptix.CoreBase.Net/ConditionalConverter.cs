// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.ConditionalConverter
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 87)]
  public class ConditionalConverter : Converter
  {
    public object TrueValue
    {
      get => this.GetOptionalVariableValue(nameof (TrueValue)).Value;
      set => this.SetOptionalVariableValue(nameof (TrueValue), new UAValue(value));
    }

    public IUAVariable TrueValueVariable => this.GetOrCreateVariable("TrueValue");

    public object FalseValue
    {
      get => this.GetOptionalVariableValue(nameof (FalseValue)).Value;
      set => this.SetOptionalVariableValue(nameof (FalseValue), new UAValue(value));
    }

    public IUAVariable FalseValueVariable => this.GetOrCreateVariable("FalseValue");

    public IUAVariable ConditionVariable => this.Refs.GetVariable("Condition");
  }
}
