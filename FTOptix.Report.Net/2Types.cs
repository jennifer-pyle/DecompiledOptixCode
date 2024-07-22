// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.DataTypes
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  public static class DataTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Report");
    public static readonly NodeId PageSize = new NodeId(DataTypes.namespaceIndex, 205U);
    public static readonly NodeId GeneratePdfCompletedResult = new NodeId(DataTypes.namespaceIndex, 381U);
    public static readonly NodeId PageOrientation = new NodeId(DataTypes.namespaceIndex, 384U);
  }
}
