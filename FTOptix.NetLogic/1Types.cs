// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.ObjectTypes
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using UAManagedCore;

//#nullable disable
namespace FTOptix.NetLogic
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:NetLogic");
    public static readonly NodeId NetLogic = new NodeId(ObjectTypes.namespaceIndex, 1U);
  }
}
