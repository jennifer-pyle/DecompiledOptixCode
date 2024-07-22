// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.DataTypes
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public static class DataTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase");
    public static readonly NodeId DynamicLinkMode = new NodeId(DataTypes.namespaceIndex, 14U);
    public static readonly NodeId DynamicLinkEUMode = new NodeId(DataTypes.namespaceIndex, 91U);
    public static readonly NodeId ValueMapPairDataType = new NodeId(DataTypes.namespaceIndex, 75U);
    public static readonly NodeId VariableTransition = new NodeId(DataTypes.namespaceIndex, 112U);
    public static readonly NodeId VariableRangeTransition = new NodeId(DataTypes.namespaceIndex, 118U);
  }
}
