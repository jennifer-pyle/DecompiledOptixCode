// Decompiled with JetBrains decompiler
// Type: Fadis.Mod10.ObjectTypes
// Assembly: Fadis.Mod10.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 1099F770-190D-4133-B8B5-E01D40B2BFEB
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\Fadis.Mod10.Net\1.0.8.38\Any\Fadis.Mod10.Net.dll

using UAManagedCore;

#nullable disable
namespace Fadis.Mod10
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:Fadis:Mod10");
    public static readonly NodeId Driver = new NodeId(ObjectTypes.namespaceIndex, 5U);
    public static readonly NodeId Station = new NodeId(ObjectTypes.namespaceIndex, 12U);
  }
}
