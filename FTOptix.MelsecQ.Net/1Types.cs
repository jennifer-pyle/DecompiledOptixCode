// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecQ.ObjectTypes
// Assembly: FTOptix.MelsecQ.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 82AF5AD0-6CA3-446B-98F5-2FEAD20A318F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecQ.Net\1.0.8.38\Any\FTOptix.MelsecQ.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.MelsecQ
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:MelsecQ");
    public static readonly NodeId Driver = new NodeId(ObjectTypes.namespaceIndex, 7U);
    public static readonly NodeId Station = new NodeId(ObjectTypes.namespaceIndex, 8U);
  }
}
