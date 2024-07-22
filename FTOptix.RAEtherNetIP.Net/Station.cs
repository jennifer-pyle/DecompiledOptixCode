// Decompiled with JetBrains decompiler
// Type: FTOptix.RAEtherNetIP.Station
// Assembly: FTOptix.RAEtherNetIP.Net, Version=2.2.0.11, Culture=neutral, PublicKeyToken=null
// MVID: 626313C4-D37E-4FD2-9B56-0300FEB2B54A
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.RAEtherNetIP.Net\2.2.0.11\Any\FTOptix.RAEtherNetIP.Net.dll

using FTOptix.CommunicationDriver;
using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.RAEtherNetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:RAEtherNetIP", Number = 5)]
  public class Station : CommunicationStation
  {
    public string Route
    {
      get => (string) this.Refs.GetVariable(nameof (Route)).Value.Value;
      set => this.Refs.GetVariable(nameof (Route)).SetValue((object) value);
    }

    public IUAVariable RouteVariable => this.Refs.GetVariable("Route");

    public bool EnableExtendedProperties
    {
      get => (bool) this.GetOptionalVariableValue(nameof (EnableExtendedProperties));
      set => this.SetOptionalVariableValue(nameof (EnableExtendedProperties), new UAValue(value));
    }

    public IUAVariable EnableExtendedPropertiesVariable
    {
      get => this.GetOrCreateVariable("EnableExtendedProperties");
    }

    public double Timeout
    {
      get => (double) this.GetOptionalVariableValue(nameof (Timeout));
      set => this.SetOptionalVariableValue(nameof (Timeout), new UAValue(value));
    }

    public IUAVariable TimeoutVariable => this.GetOrCreateVariable("Timeout");

    public StationStatusVariables StationStatusVariables
    {
      get
      {
        return new StationStatusVariables((PropertyGroup) this.Refs.GetObject(nameof (StationStatusVariables)));
      }
    }

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }
  }
}
