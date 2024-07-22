// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Led
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 139)]
  public class Led : Item
  {
    public string Text
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (Text)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (Text), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText LocalizedText
    {
      get => (LocalizedText) this.GetOptionalVariableValue("Text");
      set => this.SetOptionalVariableValue("Text", new UAValue(value));
    }

    public UAVariable TextVariable => (UAVariable) this.GetOrCreateVariable("Text");

    public string Appearance
    {
      get => (string) this.GetOptionalVariableValue(nameof (Appearance));
      set => this.SetOptionalVariableValue(nameof (Appearance), new UAValue(value));
    }

    public IUAVariable AppearanceVariable => this.GetOrCreateVariable("Appearance");

    public Color Color
    {
      get => new Color(this.GetOptionalVariableValue(nameof (Color)));
      set => this.SetOptionalVariableValue(nameof (Color), new UAValue(value.ARGB));
    }

    public IUAVariable ColorVariable => this.GetOrCreateVariable("Color");

    public bool Active
    {
      get => (bool) this.Refs.GetVariable(nameof (Active)).Value.Value;
      set => this.Refs.GetVariable(nameof (Active)).SetValue((object) value);
    }

    public IUAVariable ActiveVariable => this.Refs.GetVariable("Active");

    public bool BlinkWhenActive
    {
      get => (bool) this.GetOptionalVariableValue(nameof (BlinkWhenActive));
      set => this.SetOptionalVariableValue(nameof (BlinkWhenActive), new UAValue(value));
    }

    public IUAVariable BlinkWhenActiveVariable => this.GetOrCreateVariable("BlinkWhenActive");

    public ResourceUri ImagePath
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ImagePath)));
      set => this.SetOptionalVariableValue(nameof (ImagePath), new UAValue((string) value));
    }

    public IUAVariable ImagePathVariable => this.GetOrCreateVariable("ImagePath");

    public Position ImagePosition
    {
      get => (Position) (int) this.GetOptionalVariableValue(nameof (ImagePosition));
      set => this.SetOptionalVariableValue(nameof (ImagePosition), new UAValue((int) value));
    }

    public IUAVariable ImagePositionVariable => this.GetOrCreateVariable("ImagePosition");

    public Position TextPosition
    {
      get => (Position) (int) this.GetOptionalVariableValue(nameof (TextPosition));
      set => this.SetOptionalVariableValue(nameof (TextPosition), new UAValue((int) value));
    }

    public IUAVariable TextPositionVariable => this.GetOrCreateVariable("TextPosition");

    public float ImageWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageWidth));
      set => this.SetOptionalVariableValue(nameof (ImageWidth), new UAValue(value));
    }

    public IUAVariable ImageWidthVariable => this.GetOrCreateVariable("ImageWidth");

    public float ImageHeight
    {
      get => (float) this.GetOptionalVariableValue(nameof (ImageHeight));
      set => this.SetOptionalVariableValue(nameof (ImageHeight), new UAValue(value));
    }

    public IUAVariable ImageHeightVariable => this.GetOrCreateVariable("ImageHeight");

    public bool WordWrap
    {
      get => (bool) this.GetOptionalVariableValue(nameof (WordWrap));
      set => this.SetOptionalVariableValue(nameof (WordWrap), new UAValue(value));
    }

    public IUAVariable WordWrapVariable => this.GetOrCreateVariable("WordWrap");

    public Elide Elide
    {
      get => (Elide) (int) this.GetOptionalVariableValue(nameof (Elide));
      set => this.SetOptionalVariableValue(nameof (Elide), new UAValue((int) value));
    }

    public IUAVariable ElideVariable => this.GetOrCreateVariable("Elide");

    public string FontFamily
    {
      get => (string) this.GetOptionalVariableValue(nameof (FontFamily));
      set => this.SetOptionalVariableValue(nameof (FontFamily), new UAValue(value));
    }

    public IUAVariable FontFamilyVariable => this.GetOrCreateVariable("FontFamily");

    public FontWeight FontWeight
    {
      get => (FontWeight) (int) this.GetOptionalVariableValue(nameof (FontWeight));
      set => this.SetOptionalVariableValue(nameof (FontWeight), new UAValue((int) value));
    }

    public IUAVariable FontWeightVariable => this.GetOrCreateVariable("FontWeight");

    public bool FontItalic
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FontItalic));
      set => this.SetOptionalVariableValue(nameof (FontItalic), new UAValue(value));
    }

    public IUAVariable FontItalicVariable => this.GetOrCreateVariable("FontItalic");

    public float FontSize
    {
      get => (float) this.GetOptionalVariableValue(nameof (FontSize));
      set => this.SetOptionalVariableValue(nameof (FontSize), new UAValue(value));
    }

    public IUAVariable FontSizeVariable => this.GetOrCreateVariable("FontSize");

    public Color TextColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (TextColor)));
      set => this.SetOptionalVariableValue(nameof (TextColor), new UAValue(value.ARGB));
    }

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");
  }
}
