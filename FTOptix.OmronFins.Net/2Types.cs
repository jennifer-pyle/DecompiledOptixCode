// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronFins.VariableTypes
// Assembly: FTOptix.OmronFins.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 4638714C-7F4C-46B4-B420-EAFE85857675
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronFins.Net\1.0.8.38\Any\FTOptix.OmronFins.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OmronFins
{
  public static class VariableTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:OmronFins");
    public static readonly NodeId Tag = new NodeId(VariableTypes.namespaceIndex, 9U);
  }
}
