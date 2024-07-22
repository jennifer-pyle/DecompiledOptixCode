// Decompiled with JetBrains decompiler
// Type: FTOptix.WebUI.ObjectTypes
// Assembly: FTOptix.WebUI.Net, Version=1.2.0.52, Culture=neutral, PublicKeyToken=null
// MVID: 2B83AA5D-FBF5-48D5-A192-6929F90320F9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.WebUI.Net\1.2.0.52\Any\FTOptix.WebUI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.WebUI
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:WebUI");
    public static readonly NodeId WebUIPresentationEngine = new NodeId(ObjectTypes.namespaceIndex, 1U);
  }
}
