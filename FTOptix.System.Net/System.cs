// Decompiled with JetBrains decompiler
// Type: FTOptix.System.System
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [MapType(NamespaceUri = "urn:FTOptix:System", Number = 1)]
  public class System : UAObject
  {
    public PlaceholderChildNodeCollection<NetworkInterface> NetworkInterfaces
    {
      get
      {
        return new PlaceholderChildNodeCollection<NetworkInterface>((IUANode) this, nameof (NetworkInterfaces));
      }
    }

    public DateAndTime DateAndTime
    {
      get => new DateAndTime((PropertyGroup) this.Refs.GetObject(nameof (DateAndTime)));
    }

    public Application Application
    {
      get => new Application((PropertyGroup) this.Refs.GetObject(nameof (Application)));
    }

    public Device Device => new Device((PropertyGroup) this.Refs.GetObject(nameof (Device)));

    public Display Display => new Display((PropertyGroup) this.Refs.GetObject(nameof (Display)));

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

    public event EventHandler<LoadApplicationStatusEvent> OnLoadApplicationStatusEvent
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:System"), 104U), typeof (EventHandler<LoadApplicationStatusEvent>), typeof (LoadApplicationStatusEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:System"), 104U), typeof (EventHandler<LoadApplicationStatusEvent>), typeof (LoadApplicationStatusEvent)).Remove((Delegate) value);
      }
    }
  }
}
