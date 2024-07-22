// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ObjectTypes
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI");
    public static readonly NodeId Item = new NodeId(ObjectTypes.namespaceIndex, 6U);
    public static readonly NodeId RowLayout = new NodeId(ObjectTypes.namespaceIndex, 7U);
    public static readonly NodeId ColumnLayout = new NodeId(ObjectTypes.namespaceIndex, 8U);
    public static readonly NodeId Image = new NodeId(ObjectTypes.namespaceIndex, 9U);
    public static readonly NodeId Label = new NodeId(ObjectTypes.namespaceIndex, 10U);
    public static readonly NodeId TextBox = new NodeId(ObjectTypes.namespaceIndex, 11U);
    public static readonly NodeId Window = new NodeId(ObjectTypes.namespaceIndex, 12U);
    public static readonly NodeId MouseEvent = new NodeId(ObjectTypes.namespaceIndex, 13U);
    public static readonly NodeId MouseDownEvent = new NodeId(ObjectTypes.namespaceIndex, 14U);
    public static readonly NodeId MouseUpEvent = new NodeId(ObjectTypes.namespaceIndex, 15U);
    public static readonly NodeId MouseClickEvent = new NodeId(ObjectTypes.namespaceIndex, 16U);
    public static readonly NodeId MouseDoubleClickEvent = new NodeId(ObjectTypes.namespaceIndex, 17U);
    public static readonly NodeId PresentationEngine = new NodeId(ObjectTypes.namespaceIndex, 46U);
    public static readonly NodeId BorderedImage = new NodeId(ObjectTypes.namespaceIndex, 52U);
    public static readonly NodeId Rectangle = new NodeId(ObjectTypes.namespaceIndex, 60U);
    public static readonly NodeId Button = new NodeId(ObjectTypes.namespaceIndex, 65U);
    public static readonly NodeId Container = new NodeId(ObjectTypes.namespaceIndex, 71U);
    public static readonly NodeId CheckBox = new NodeId(ObjectTypes.namespaceIndex, 72U);
    public static readonly NodeId Switch = new NodeId(ObjectTypes.namespaceIndex, 75U);
    public static readonly NodeId Panel = new NodeId(ObjectTypes.namespaceIndex, 78U);
    public static readonly NodeId SpinBox = new NodeId(ObjectTypes.namespaceIndex, 88U);
    public static readonly NodeId RangeSlider = new NodeId(ObjectTypes.namespaceIndex, 93U);
    public static readonly NodeId Dial = new NodeId(ObjectTypes.namespaceIndex, 100U);
    public static readonly NodeId MomentaryButton = new NodeId(ObjectTypes.namespaceIndex, 1211U);
    public static readonly NodeId ToggleButton = new NodeId(ObjectTypes.namespaceIndex, 103U);
    public static readonly NodeId DelayedButton = new NodeId(ObjectTypes.namespaceIndex, 105U);
    public static readonly NodeId EditableLabel = new NodeId(ObjectTypes.namespaceIndex, 107U);
    public static readonly NodeId RadioButton = new NodeId(ObjectTypes.namespaceIndex, 110U);
    public static readonly NodeId BaseUIObject = new NodeId(ObjectTypes.namespaceIndex, 112U);
    public static readonly NodeId Led = new NodeId(ObjectTypes.namespaceIndex, 139U);
    public static readonly NodeId ListBox = new NodeId(ObjectTypes.namespaceIndex, 181U);
    public static readonly NodeId PanelLoader = new NodeId(ObjectTypes.namespaceIndex, 183U);
    public static readonly NodeId DataGrid = new NodeId(ObjectTypes.namespaceIndex, 186U);
    public static readonly NodeId DataGridColumn = new NodeId(ObjectTypes.namespaceIndex, 190U);
    public static readonly NodeId DataGridItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 196U);
    public static readonly NodeId DataGridLabelItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 197U);
    public static readonly NodeId DataGridEditableLabelItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 544U);
    public static readonly NodeId DataGridImageItemTemplate = new NodeId(ObjectTypes.namespaceIndex, 200U);
    public static readonly NodeId ComboBox = new NodeId(ObjectTypes.namespaceIndex, 209U);
    public static readonly NodeId Trend = new NodeId(ObjectTypes.namespaceIndex, 223U);
    public static readonly NodeId CircularGauge = new NodeId(ObjectTypes.namespaceIndex, 292U);
    public static readonly NodeId WarningZone = new NodeId(ObjectTypes.namespaceIndex, 305U);
    public static readonly NodeId LinearGauge = new NodeId(ObjectTypes.namespaceIndex, 311U);
    public static readonly NodeId WebBrowser = new NodeId(ObjectTypes.namespaceIndex, 350U);
    public static readonly NodeId ScrollView = new NodeId(ObjectTypes.namespaceIndex, 362U);
    public static readonly NodeId DateTimeAxis = new NodeId(ObjectTypes.namespaceIndex, 365U);
    public static readonly NodeId ValueAxis = new NodeId(ObjectTypes.namespaceIndex, 366U);
    public static readonly NodeId Video = new NodeId(ObjectTypes.namespaceIndex, 372U);
    public static readonly NodeId PdfViewer = new NodeId(ObjectTypes.namespaceIndex, 385U);
    public static readonly NodeId BehaviourAnimation = new NodeId(ObjectTypes.namespaceIndex, 410U);
    public static readonly NodeId AbstractAnimation = new NodeId(ObjectTypes.namespaceIndex, 420U);
    public static readonly NodeId ParallelAnimation = new NodeId(ObjectTypes.namespaceIndex, 423U);
    public static readonly NodeId NumberAnimation = new NodeId(ObjectTypes.namespaceIndex, 424U);
    public static readonly NodeId SequentialAnimation = new NodeId(ObjectTypes.namespaceIndex, 430U);
    public static readonly NodeId StyleSheet = new NodeId(ObjectTypes.namespaceIndex, 447U);
    public static readonly NodeId Dialog = new NodeId(ObjectTypes.namespaceIndex, 515U);
    public static readonly NodeId DropDownButton = new NodeId(ObjectTypes.namespaceIndex, 526U);
    public static readonly NodeId NavigationPanel = new NodeId(ObjectTypes.namespaceIndex, 546U);
    public static readonly NodeId NavigationPanelItem = new NodeId(ObjectTypes.namespaceIndex, 547U);
    public static readonly NodeId XYChart = new NodeId(ObjectTypes.namespaceIndex, 558U);
    public static readonly NodeId XYChartPen = new NodeId(ObjectTypes.namespaceIndex, 561U);
    public static readonly NodeId XYChartScalarLinePen = new NodeId(ObjectTypes.namespaceIndex, 569U);
    public static readonly NodeId XYChartArrayLinePen = new NodeId(ObjectTypes.namespaceIndex, 574U);
    public static readonly NodeId XYChartLinePen = new NodeId(ObjectTypes.namespaceIndex, 583U);
    public static readonly NodeId XYChartPolygonPen = new NodeId(ObjectTypes.namespaceIndex, 615U);
    public static readonly NodeId Popup = new NodeId(ObjectTypes.namespaceIndex, 620U);
    public static readonly NodeId DateTimePicker = new NodeId(ObjectTypes.namespaceIndex, 631U);
    public static readonly NodeId DurationPicker = new NodeId(ObjectTypes.namespaceIndex, 642U);
    public static readonly NodeId UISession = new NodeId(ObjectTypes.namespaceIndex, 665U);
    public static readonly NodeId Ellipse = new NodeId(ObjectTypes.namespaceIndex, 1119U);
    public static readonly NodeId PolyLine = new NodeId(ObjectTypes.namespaceIndex, 1124U);
    public static readonly NodeId ScaleLayout = new NodeId(ObjectTypes.namespaceIndex, 1140U);
    public static readonly NodeId Screen = new NodeId(ObjectTypes.namespaceIndex, 1170U);
    public static readonly NodeId ControlStyle = new NodeId(ObjectTypes.namespaceIndex, 709U);
    public static readonly NodeId ButtonStyle = new NodeId(ObjectTypes.namespaceIndex, 710U);
    public static readonly NodeId InputBoxStyle = new NodeId(ObjectTypes.namespaceIndex, 749U);
    public static readonly NodeId SwitchStyle = new NodeId(ObjectTypes.namespaceIndex, 779U);
    public static readonly NodeId GaugeStyle = new NodeId(ObjectTypes.namespaceIndex, 813U);
    public static readonly NodeId NavigationPanelStyle = new NodeId(ObjectTypes.namespaceIndex, 847U);
    public static readonly NodeId ChartStyle = new NodeId(ObjectTypes.namespaceIndex, 869U);
    public static readonly NodeId DataListStyle = new NodeId(ObjectTypes.namespaceIndex, 887U);
    public static readonly NodeId ScrollBarStyle = new NodeId(ObjectTypes.namespaceIndex, 957U);
    public static readonly NodeId ToolTipStyle = new NodeId(ObjectTypes.namespaceIndex, 937U);
    public static readonly NodeId AccordionStyle = new NodeId(ObjectTypes.namespaceIndex, 985U);
    public static readonly NodeId PieChartStyle = new NodeId(ObjectTypes.namespaceIndex, 1059U);
    public static readonly NodeId HistogramChartStyle = new NodeId(ObjectTypes.namespaceIndex, 1085U);
    public static readonly NodeId LabelStyle = new NodeId(ObjectTypes.namespaceIndex, 1277U);
    public static readonly NodeId Sparkline = new NodeId(ObjectTypes.namespaceIndex, 1223U);
    public static readonly NodeId RadioButtonStyle = new NodeId(ObjectTypes.namespaceIndex, 1305U);
    public static readonly NodeId CheckBoxStyle = new NodeId(ObjectTypes.namespaceIndex, 1317U);
    public static readonly NodeId GridLayout = new NodeId(ObjectTypes.namespaceIndex, 1350U);
    public static readonly NodeId GridLayoutProperties = new NodeId(ObjectTypes.namespaceIndex, 1345U);
  }
}
