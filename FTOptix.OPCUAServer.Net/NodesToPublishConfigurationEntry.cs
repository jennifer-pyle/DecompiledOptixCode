// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAServer.NodesToPublishConfigurationEntry
// Assembly: FTOptix.OPCUAServer.Net, Version=1.1.4.39, Culture=neutral, PublicKeyToken=null
// MVID: 8FF3501A-13A0-4017-8C9B-45AF38532B2C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAServer.Net\1.1.4.39\Any\FTOptix.OPCUAServer.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.OPCUAServer
{
  [MapType(NamespaceUri = "urn:FTOptix:OPCUAServer", Number = 6)]
  public class NodesToPublishConfigurationEntry : UAObject
  {
    public PlaceholderChildNodeCollection<NodePointer> Nodes
    {
      get => new PlaceholderChildNodeCollection<NodePointer>((IUANode) this, nameof (Nodes));
    }

    public PlaceholderChildNodeCollection<NodePointer> Users
    {
      get => new PlaceholderChildNodeCollection<NodePointer>((IUANode) this, nameof (Users));
    }
  }
}
