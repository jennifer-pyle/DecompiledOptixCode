// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.PdfViewer
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 385)]
  public class PdfViewer : Item
  {
    public ResourceUri Path
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (Path)).Value);
      set => this.Refs.GetVariable(nameof (Path)).SetValue((object) (string) value);
    }

    public IUAVariable PathVariable => this.Refs.GetVariable("Path");

    public int CurrentPage
    {
      get => (int) this.Refs.GetVariable(nameof (CurrentPage)).Value.Value;
      set => this.Refs.GetVariable(nameof (CurrentPage)).SetValue((object) value);
    }

    public IUAVariable CurrentPageVariable => this.Refs.GetVariable("CurrentPage");

    public PdfViewerZoomMode ZoomMode
    {
      get => (PdfViewerZoomMode) (int) this.GetOptionalVariableValue(nameof (ZoomMode));
      set => this.SetOptionalVariableValue(nameof (ZoomMode), new UAValue((int) value));
    }

    public IUAVariable ZoomModeVariable => this.GetOrCreateVariable("ZoomMode");

    public uint ZoomLevel
    {
      get => (uint) this.GetOptionalVariableValue(nameof (ZoomLevel));
      set => this.SetOptionalVariableValue(nameof (ZoomLevel), new UAValue(value));
    }

    public IUAVariable ZoomLevelVariable => this.GetOrCreateVariable("ZoomLevel");

    public string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
      set => this.SetOptionalVariableValue(nameof (ScrollBarStyle), new UAValue(value));
    }

    public IUAVariable ScrollBarStyleVariable => this.GetOrCreateVariable("ScrollBarStyle");
  }
}
