// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TCP.VariableTypes
// Assembly: FTOptix.S7TCP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: CE29D4F9-3A52-4C85-9774-D6DA74ACB2D2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TCP.Net\1.0.8.38\Any\FTOptix.S7TCP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.S7TCP
{
  public static class VariableTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:S7TCP");
    public static readonly NodeId Tag = new NodeId(VariableTypes.namespaceIndex, 5U);
  }
}
