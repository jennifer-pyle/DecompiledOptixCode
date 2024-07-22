// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TiaProfinet.Driver
// Assembly: FTOptix.S7TiaProfinet.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 04D0A327-9B8D-4FD1-B415-024D37158081
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TiaProfinet.Net\1.1.2.38\Any\FTOptix.S7TiaProfinet.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.S7TiaProfinet
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TiaProfinet", Number = 7)]
  public class Driver : FTOptix.CommunicationDriver.CommunicationDriver
  {
    public bool AllowRuntimeTagImport
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AllowRuntimeTagImport));
      set => this.SetOptionalVariableValue(nameof (AllowRuntimeTagImport), new UAValue(value));
    }

    public IUAVariable AllowRuntimeTagImportVariable
    {
      get => this.GetOrCreateVariable("AllowRuntimeTagImport");
    }

    public TypedChildNodeCollection<Station> Stations
    {
      get => new TypedChildNodeCollection<Station>((IUANode) this);
    }
  }
}
