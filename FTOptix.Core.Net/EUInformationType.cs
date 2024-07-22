// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.EUInformationType
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 4)]
  public class EUInformationType : UAVariableType
  {
    public int UnitId
    {
      get => (int) this.Refs.GetVariable(nameof (UnitId)).Value.Value;
      set => this.Refs.GetVariable(nameof (UnitId)).SetValue((object) value);
    }

    public IUAVariable UnitIdVariable => this.Refs.GetVariable("UnitId");

    public new LocalizedText DisplayName
    {
      get => (LocalizedText) this.Refs.GetVariable(nameof (DisplayName)).Value.Value;
      set => this.Refs.GetVariable(nameof (DisplayName)).SetValue((object) value);
    }

    public IUAVariable DisplayNameVariable => this.Refs.GetVariable("DisplayName");

    public new LocalizedText Description
    {
      get => (LocalizedText) this.Refs.GetVariable(nameof (Description)).Value.Value;
      set => this.Refs.GetVariable(nameof (Description)).SetValue((object) value);
    }

    public IUAVariable DescriptionVariable => this.Refs.GetVariable("Description");

    public InstanceNodeCollection<EUInformation> Instances
    {
      get => new InstanceNodeCollection<EUInformation>((IUANode) this);
    }
  }
}
