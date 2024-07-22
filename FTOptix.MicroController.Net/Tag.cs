// Decompiled with JetBrains decompiler
// Type: FTOptix.MicroController.Tag
// Assembly: FTOptix.MicroController.Net, Version=3.1.0.28, Culture=neutral, PublicKeyToken=null
// MVID: 3C2374A2-E7A9-4608-96D0-153AE54FA082
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MicroController.Net\3.1.0.28\Any\FTOptix.MicroController.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MicroController
{
  [MapType(NamespaceUri = "urn:FTOptix:MicroController", Number = 1)]
  public class Tag : FTOptix.CommunicationDriver.Tag
  {
    public string SymbolName
    {
      get => (string) this.Refs.GetVariable(nameof (SymbolName)).Value.Value;
      set => this.Refs.GetVariable(nameof (SymbolName)).SetValue((object) value);
    }

    public IUAVariable SymbolNameVariable => this.Refs.GetVariable("SymbolName");
  }
}
