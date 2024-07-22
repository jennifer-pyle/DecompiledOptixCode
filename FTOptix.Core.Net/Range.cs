// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.Range
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 5)]
  public class Range : UAVariable
  {
    public double Low
    {
      get => (double) this.Refs.GetVariable(nameof (Low)).Value.Value;
      set => this.Refs.GetVariable(nameof (Low)).SetValue((object) value);
    }

    public IUAVariable LowVariable => this.Refs.GetVariable("Low");

    public double High
    {
      get => (double) this.Refs.GetVariable(nameof (High)).Value.Value;
      set => this.Refs.GetVariable(nameof (High)).SetValue((object) value);
    }

    public IUAVariable HighVariable => this.Refs.GetVariable("High");

    public bool Constrain
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Constrain)).Value;
      set => this.SetOptionalVariableValue(nameof (Constrain), new UAValue(value));
    }

    public IUAVariable ConstrainVariable => this.GetOrCreateVariable("Constrain");
  }
}
