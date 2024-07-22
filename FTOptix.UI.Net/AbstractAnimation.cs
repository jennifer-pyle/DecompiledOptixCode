// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AbstractAnimation
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 420)]
  public class AbstractAnimation : UAObject
  {
    public bool Running
    {
      get => (bool) this.Refs.GetVariable(nameof (Running)).Value.Value;
      set => this.Refs.GetVariable(nameof (Running)).SetValue((object) value);
    }

    public IUAVariable RunningVariable => this.Refs.GetVariable("Running");

    public int Loops
    {
      get => (int) this.GetOptionalVariableValue(nameof (Loops));
      set => this.SetOptionalVariableValue(nameof (Loops), new UAValue(value));
    }

    public IUAVariable LoopsVariable => this.GetOrCreateVariable("Loops");
  }
}
