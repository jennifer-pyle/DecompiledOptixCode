// Decompiled with JetBrains decompiler
// Type: FTOptix.MicroController.ObjectTypes
// Assembly: FTOptix.MicroController.Net, Version=3.1.0.28, Culture=neutral, PublicKeyToken=null
// MVID: 3C2374A2-E7A9-4608-96D0-153AE54FA082
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MicroController.Net\3.1.0.28\Any\FTOptix.MicroController.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MicroController
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:MicroController");
    public static readonly NodeId MicroControllerDriver = new NodeId(ObjectTypes.namespaceIndex, 4U);
    public static readonly NodeId MicroControllerStation = new NodeId(ObjectTypes.namespaceIndex, 5U);
  }
}
