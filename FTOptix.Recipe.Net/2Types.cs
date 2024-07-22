// Decompiled with JetBrains decompiler
// Type: FTOptix.Recipe.ReferenceTypes
// Assembly: FTOptix.Recipe.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: EFD0D777-9FCB-4D24-B9F7-D873EB52C7CF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Recipe.Net\1.0.8.39\Any\FTOptix.Recipe.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Recipe
{
  public static class ReferenceTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Recipe");
    public static readonly NodeId HasSchema = new NodeId(ReferenceTypes.namespaceIndex, 5U);
    public static readonly NodeId HasSubSchema = new NodeId(ReferenceTypes.namespaceIndex, 50U);
    public static readonly NodeId HasSubRecipe = new NodeId(ReferenceTypes.namespaceIndex, 51U);
  }
}
