// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.CommunicationStation
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  [MapType(NamespaceUri = "urn:FTOptix:CommunicationDriver", Number = 7)]
  public class CommunicationStation : UAObject
  {
    public CommunicationOperationCode OperationCode
    {
      get => (CommunicationOperationCode) (int) this.Refs.GetVariable(nameof (OperationCode)).Value;
      set => this.Refs.GetVariable(nameof (OperationCode)).SetValue((object) (int) value);
    }

    public IUAVariable OperationCodeVariable => this.Refs.GetVariable("OperationCode");

    public void Browse(out Struct[] plcItems, out Struct[] prototypeItems)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Browse), new object[0], out outputArgs);
      plcItems = (Struct[]) outputArgs[0];
      prototypeItems = (Struct[]) outputArgs[1];
    }

    public IUAMethod BrowseMethod => this.Refs.GetMethod("Browse");

    public void Import(Struct[] plcItems, Struct[] prototypeItems)
    {
      this.ExecuteMethod(nameof (Import), new object[2]
      {
        (object) plcItems,
        (object) prototypeItems
      });
    }

    public IUAMethod ImportMethod => this.Refs.GetMethod("Import");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }

    private PlaceholderChildNodeCollection<TagStructure> TagStructures
    {
      get => new PlaceholderChildNodeCollection<TagStructure>((IUANode) this, "Tags");
    }
  }
}
