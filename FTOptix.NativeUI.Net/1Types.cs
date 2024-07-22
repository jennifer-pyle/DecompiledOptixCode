// Decompiled with JetBrains decompiler
// Type: FTOptix.NativeUI.ObjectTypes
// Assembly: FTOptix.NativeUI.Net, Version=1.0.8.51, Culture=neutral, PublicKeyToken=null
// MVID: 85F942F5-DB06-44CC-BDA7-FE76B2433DC4
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NativeUI.Net\1.0.8.51\Any\FTOptix.NativeUI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.NativeUI
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:NativeUI");
    public static readonly NodeId NativeUIPresentationEngine = new NodeId(ObjectTypes.namespaceIndex, 1U);
  }
}
