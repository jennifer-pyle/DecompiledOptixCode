// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.ReferenceTypes
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public static class ReferenceTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase");
    public static readonly NodeId HasDynamicLink = new NodeId(ReferenceTypes.namespaceIndex, 19U);
    public static readonly NodeId HasSource = new NodeId(ReferenceTypes.namespaceIndex, 20U);
    public static readonly NodeId HasConverter = new NodeId(ReferenceTypes.namespaceIndex, 21U);
    public static readonly NodeId HasParameter = new NodeId(ReferenceTypes.namespaceIndex, 50U);
  }
}
