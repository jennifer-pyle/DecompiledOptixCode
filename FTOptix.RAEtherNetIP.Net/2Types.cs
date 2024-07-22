// Decompiled with JetBrains decompiler
// Type: FTOptix.RAEtherNetIP.VariableTypes
// Assembly: FTOptix.RAEtherNetIP.Net, Version=2.2.0.11, Culture=neutral, PublicKeyToken=null
// MVID: 626313C4-D37E-4FD2-9B56-0300FEB2B54A
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.RAEtherNetIP.Net\2.2.0.11\Any\FTOptix.RAEtherNetIP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.RAEtherNetIP
{
  public static class VariableTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:RAEtherNetIP");
    public static readonly NodeId Tag = new NodeId(VariableTypes.namespaceIndex, 1U);
    public static readonly NodeId SmartObjectTag = new NodeId(VariableTypes.namespaceIndex, 90U);
    public static readonly NodeId SmartObjectWritableTag = new NodeId(VariableTypes.namespaceIndex, 91U);
  }
}
