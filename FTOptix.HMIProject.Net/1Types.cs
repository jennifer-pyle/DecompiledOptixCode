// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.ObjectTypes
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:HMIProject");
    public static readonly NodeId ProjectFolder = new NodeId(ObjectTypes.namespaceIndex, 6U);
    public static readonly NodeId ProjectLoadedEvent = new NodeId(ObjectTypes.namespaceIndex, 18U);
    public static readonly NodeId ObjectLibraryProjectFolder = new NodeId(ObjectTypes.namespaceIndex, 26U);
    public static readonly NodeId ObjectLibraryItem = new NodeId(ObjectTypes.namespaceIndex, 29U);
    public static readonly NodeId CategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 43U);
    public static readonly NodeId UICategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 44U);
    public static readonly NodeId ModelCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 45U);
    public static readonly NodeId ConvertersCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 46U);
    public static readonly NodeId AlarmsCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 47U);
    public static readonly NodeId RecipesCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 48U);
    public static readonly NodeId LoggersCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 49U);
    public static readonly NodeId DataStoresCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 50U);
    public static readonly NodeId ReportsCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 51U);
    public static readonly NodeId OPCUACategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 52U);
    public static readonly NodeId CommDriversCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 53U);
    public static readonly NodeId NetLogicCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 54U);
    public static readonly NodeId SecurityCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 55U);
    public static readonly NodeId TranslationsCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 56U);
    public static readonly NodeId RetentivityCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 57U);
    public static readonly NodeId ScreensCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 67U);
    public static readonly NodeId SystemCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 68U);
    public static readonly NodeId RolesCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 69U);
    public static readonly NodeId EdgeAppCategoryFolder = new NodeId(ObjectTypes.namespaceIndex, 70U);
  }
}
