// Decompiled with JetBrains decompiler
// Type: Fadis.Mod10.StationType
// Assembly: Fadis.Mod10.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 1099F770-190D-4133-B8B5-E01D40B2BFEB
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\Fadis.Mod10.Net\1.0.8.38\Any\Fadis.Mod10.Net.dll

using FTOptix.CommunicationDriver;
using UAManagedCore;

#nullable disable
namespace Fadis.Mod10
{
  [MapType(NamespaceUri = "urn:Fadis:Mod10", Number = 12)]
  public class StationType : CommunicationStationType
  {
    public uint MaximumJobSizeInBytes
    {
      get => (uint) this.Refs.GetVariable(nameof (MaximumJobSizeInBytes)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaximumJobSizeInBytes)).SetValue((object) value);
    }

    public IUAVariable MaximumJobSizeInBytesVariable
    {
      get => this.Refs.GetVariable("MaximumJobSizeInBytes");
    }

    public string ExecuteCommand(string commandArgument)
    {
      string str = "";
      object[] objArray1 = new object[1]
      {
        (object) commandArgument
      };
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (ExecuteCommand), new object[2]
      {
        (object) str,
        (object) objArray1
      }, out outputArgs);
      object[] objArray2 = (object[]) outputArgs[0];
      return objArray2.Length == 0 ? (string) null : (string) objArray2[0];
    }

    public IUAMethod ExecuteCommandMethod => this.Refs.GetMethod("ExecuteCommand");

    public PlaceholderChildNodeCollection<Tag> Tags
    {
      get => new PlaceholderChildNodeCollection<Tag>((IUANode) this, nameof (Tags));
    }

    public InstanceNodeCollection<Station> Instances
    {
      get => new InstanceNodeCollection<Station>((IUANode) this);
    }
  }
}
