// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.ObjectTypes
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CommunicationDriver");
    public static readonly NodeId CommunicationDriver = new NodeId(ObjectTypes.namespaceIndex, 6U);
    public static readonly NodeId CommunicationStation = new NodeId(ObjectTypes.namespaceIndex, 7U);
  }
}
