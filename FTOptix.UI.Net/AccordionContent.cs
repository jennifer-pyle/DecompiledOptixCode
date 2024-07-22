// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AccordionContent
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 1012)]
  public class AccordionContent : Container
  {
    public new bool Visible => (bool) this.GetOptionalVariableValue(nameof (Visible));

    public new bool Enabled => (bool) this.GetOptionalVariableValue(nameof (Enabled));

    public new float Opacity => (float) this.GetOptionalVariableValue(nameof (Opacity));

    public new float LeftMargin => (float) this.GetOptionalVariableValue(nameof (LeftMargin));

    public new float TopMargin => (float) this.GetOptionalVariableValue(nameof (TopMargin));

    public new float RightMargin => (float) this.GetOptionalVariableValue(nameof (RightMargin));

    public new float BottomMargin => (float) this.GetOptionalVariableValue(nameof (BottomMargin));

    public new float Width => (float) this.GetOptionalVariableValue(nameof (Width));

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

    public new float Rotation => (float) this.GetOptionalVariableValue(nameof (Rotation));
  }
}
