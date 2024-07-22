// Decompiled with JetBrains decompiler
// Type: FTOptix.System.SystemType
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [MapType(NamespaceUri = "urn:FTOptix:System", Number = 1)]
  public class SystemType : UAObjectType
  {
    public PlaceholderChildNodeCollection<NetworkInterface> NetworkInterfaces
    {
      get
      {
        return new PlaceholderChildNodeCollection<NetworkInterface>((IUANode) this, nameof (NetworkInterfaces));
      }
    }

    public DateAndTime DateAndTime => (DateAndTime) this.Refs.GetObject(nameof (DateAndTime));

    public Application Application => (Application) this.Refs.GetObject(nameof (Application));

    public Display Display => (Display) this.Refs.GetObject(nameof (Display));

    public void Reboot() => this.ExecuteMethod(nameof (Reboot), new object[0]);

    public IUAMethod RebootMethod => this.Refs.GetMethod("Reboot");

    public bool RebootRequired => (bool) this.RebootRequiredVariable.Value;

    public IUAVariable RebootRequiredVariable => this.Refs.GetVariable("RebootRequired");

    public bool LoadApplication(string filePath, string password, bool deleteApplicationFiles)
    {
      object[] outputArgs;
      this.LoadApplicationMethod.Execute((IUANode) this, new object[3]
      {
        (object) filePath,
        (object) password,
        (object) deleteApplicationFiles
      }, out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod LoadApplicationMethod => this.Refs.GetMethod("LoadApplication");

    public InstanceNodeCollection<FTOptix.System.System> Instances
    {
      get => new InstanceNodeCollection<FTOptix.System.System>((IUANode) this);
    }
  }
}
