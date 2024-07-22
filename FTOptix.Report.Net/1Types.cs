// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.ObjectTypes
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Report");
    public static readonly NodeId ReportColumnLayout = new NodeId(ObjectTypes.namespaceIndex, 1U);
    public static readonly NodeId Report = new NodeId(ObjectTypes.namespaceIndex, 6U);
    public static readonly NodeId PanelSection = new NodeId(ObjectTypes.namespaceIndex, 18U);
    public static readonly NodeId PageBreak = new NodeId(ObjectTypes.namespaceIndex, 27U);
    public static readonly NodeId ReportLabel = new NodeId(ObjectTypes.namespaceIndex, 30U);
    public static readonly NodeId ReportRectangle = new NodeId(ObjectTypes.namespaceIndex, 31U);
    public static readonly NodeId ReportDataGridColumn = new NodeId(ObjectTypes.namespaceIndex, 32U);
    public static readonly NodeId ReportDataGridLabelItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 34U);
    public static readonly NodeId ReportPanel = new NodeId(ObjectTypes.namespaceIndex, 35U);
    public static readonly NodeId DataGridSection = new NodeId(ObjectTypes.namespaceIndex, 38U);
    public static readonly NodeId ReportStyleSheet = new NodeId(ObjectTypes.namespaceIndex, 192U);
    public static readonly NodeId ReportImage = new NodeId(ObjectTypes.namespaceIndex, 327U);
    public static readonly NodeId GeneratePdfCompletedEvent = new NodeId(ObjectTypes.namespaceIndex, 378U);
    public static readonly NodeId ReportDataGridImageItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 386U);
    public static readonly NodeId ReportPieChart = new NodeId(ObjectTypes.namespaceIndex, 492U);
  }
}
