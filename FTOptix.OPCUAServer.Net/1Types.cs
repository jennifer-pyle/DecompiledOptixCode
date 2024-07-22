// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAServer.ObjectTypes
// Assembly: FTOptix.OPCUAServer.Net, Version=1.1.4.39, Culture=neutral, PublicKeyToken=null
// MVID: 8FF3501A-13A0-4017-8C9B-45AF38532B2C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAServer.Net\1.1.4.39\Any\FTOptix.OPCUAServer.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OPCUAServer
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:OPCUAServer");
    public static readonly NodeId OPCUAServer = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId NodesToPublishConfigurationEntry = new NodeId(ObjectTypes.namespaceIndex, 6U);
  }
}
