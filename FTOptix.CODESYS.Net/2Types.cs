// Decompiled with JetBrains decompiler
// Type: FTOptix.CODESYS.VariableTypes
// Assembly: FTOptix.CODESYS.Net, Version=2.0.4.38, Culture=neutral, PublicKeyToken=null
// MVID: 8A6E538D-4FC1-46A5-B5C8-EC5F861CEF6D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CODESYS.Net\2.0.4.38\Any\FTOptix.CODESYS.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CODESYS
{
  public static class VariableTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CODESYS");
    public static readonly NodeId Tag = new NodeId(VariableTypes.namespaceIndex, 1U);
  }
}
