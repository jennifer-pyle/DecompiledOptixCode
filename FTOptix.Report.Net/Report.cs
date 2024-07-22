// Decompiled with JetBrains decompiler
// Type: FTOptix.Report.Report
// Assembly: FTOptix.Report.Net, Version=2.2.0.9, Culture=neutral, PublicKeyToken=null
// MVID: 4B1156BC-913E-45B1-80D4-9F32FAAD1A03
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Report.Net\2.2.0.9\Any\FTOptix.Report.Net.dll

using FTOptix.Core;
using FTOptix.UI;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Report
{
  [MapType(NamespaceUri = "urn:FTOptix:Report", Number = 6)]
  public class Report : ColumnLayout
  {
    public PageSize PageSize
    {
      get => (PageSize) (int) this.Refs.GetVariable(nameof (PageSize)).Value;
      set => this.Refs.GetVariable(nameof (PageSize)).SetValue((object) (int) value);
    }

    public IUAVariable PageSizeVariable => this.Refs.GetVariable("PageSize");

    public PageOrientation PageOrientation
    {
      get => (PageOrientation) (int) this.GetOptionalVariableValue(nameof (PageOrientation));
      set => this.SetOptionalVariableValue(nameof (PageOrientation), new UAValue((int) value));
    }

    public IUAVariable PageOrientationVariable => this.GetOrCreateVariable("PageOrientation");

    public float PageWidth
    {
      get => (float) this.Refs.GetVariable(nameof (PageWidth)).Value.Value;
      set => this.Refs.GetVariable(nameof (PageWidth)).SetValue((object) value);
    }

    public IUAVariable PageWidthVariable => this.Refs.GetVariable("PageWidth");

    public float PageHeight
    {
      get => (float) this.Refs.GetVariable(nameof (PageHeight)).Value.Value;
      set => this.Refs.GetVariable(nameof (PageHeight)).SetValue((object) value);
    }

    public IUAVariable PageHeightVariable => this.Refs.GetVariable("PageHeight");

    public new float Width => (float) this.GetOptionalVariableValue(nameof (Width));

    public new float Height => (float) this.GetOptionalVariableValue(nameof (Height));

    public new float LeftMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (LeftMargin));
      set => this.SetOptionalVariableValue(nameof (LeftMargin), new UAValue(value));
    }

    public new float RightMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (RightMargin));
      set => this.SetOptionalVariableValue(nameof (RightMargin), new UAValue(value));
    }

    public new float TopMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (TopMargin));
      set => this.SetOptionalVariableValue(nameof (TopMargin), new UAValue(value));
    }

    public new float BottomMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (BottomMargin));
      set => this.SetOptionalVariableValue(nameof (BottomMargin), new UAValue(value));
    }

    public new bool Visible => (bool) this.GetOptionalVariableValue(nameof (Visible));

    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));

    public NodeId StyleSheet
    {
      get => (NodeId) this.Refs.GetVariable(nameof (StyleSheet)).Value.Value;
      set => this.Refs.GetVariable(nameof (StyleSheet)).SetValue((object) value);
    }

    public NodePointer StyleSheetVariable => (NodePointer) this.Refs.GetVariable("StyleSheet");

    public new ContentVerticalAlignment ContentAlignment
    {
      get
      {
        return (ContentVerticalAlignment) (int) this.GetOptionalVariableValue(nameof (ContentAlignment));
      }
    }

    public new HorizontalAlignment HorizontalAlignment
    {
      get
      {
        return (HorizontalAlignment) (int) this.GetOptionalVariableValue(nameof (HorizontalAlignment));
      }
    }

    public new VerticalAlignment VerticalAlignment
    {
      get => (VerticalAlignment) (int) this.GetOptionalVariableValue(nameof (VerticalAlignment));
    }

    public string PageCount => (string) this.Refs.GetVariable(nameof (PageCount)).Value.Value;

    public IUAVariable PageCountVariable => this.Refs.GetVariable("PageCount");

    public string PageNumber => (string) this.Refs.GetVariable(nameof (PageNumber)).Value.Value;

    public IUAVariable PageNumberVariable => this.Refs.GetVariable("PageNumber");

    public DateTime PrintDateTime
    {
      get => (DateTime) this.Refs.GetVariable(nameof (PrintDateTime)).Value.Value;
    }

    public IUAVariable PrintDateTimeVariable => this.Refs.GetVariable("PrintDateTime");

    public Panel Header => (Panel) this.Refs.GetObject(nameof (Header));

    public PlaceholderChildNodeCollection<Item> Sections
    {
      get => new PlaceholderChildNodeCollection<Item>((IUANode) this, nameof (Sections));
    }

    public Panel Footer => (Panel) this.Refs.GetObject(nameof (Footer));

    public void GeneratePdf(ResourceUri outputPath, string localeId, out Guid operationId)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (GeneratePdf), new object[2]
      {
        (object) (string) outputPath,
        (object) localeId
      }, out outputArgs);
      operationId = (Guid) outputArgs[0];
    }

    public IUAMethod GeneratePdfMethod => this.Refs.GetMethod("GeneratePdf");

    public event EventHandler<GeneratePdfCompletedEvent> OnGeneratePdfCompleted
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Report"), 378U), typeof (EventHandler<GeneratePdfCompletedEvent>), typeof (GeneratePdfCompletedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Report"), 378U), typeof (EventHandler<GeneratePdfCompletedEvent>), typeof (GeneratePdfCompletedEvent)).Remove((Delegate) value);
      }
    }
  }
}
