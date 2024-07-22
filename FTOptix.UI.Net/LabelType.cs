// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.LabelType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 10)]
  public class LabelType : ItemType
  {
    public LocalizedText Text
    {
      get => (LocalizedText) this.GetOptionalVariableValue(nameof (Text));
      set => this.SetOptionalVariableValue(nameof (Text), new UAValue(value));
    }

    public IUAVariable TextVariable => this.GetOrCreateVariable("Text");

    public TextHorizontalAlignment TextHorizontalAlignment
    {
      get
      {
        return (TextHorizontalAlignment) (int) this.GetOptionalVariableValue(nameof (TextHorizontalAlignment));
      }
      set
      {
        this.SetOptionalVariableValue(nameof (TextHorizontalAlignment), new UAValue((int) value));
      }
    }

    public IUAVariable TextHorizontalAlignmentVariable
    {
      get => this.GetOrCreateVariable("TextHorizontalAlignment");
    }

    public TextVerticalAlignment TextVerticalAlignment
    {
      get
      {
        return (TextVerticalAlignment) (int) this.GetOptionalVariableValue(nameof (TextVerticalAlignment));
      }
      set
      {
        this.SetOptionalVariableValue(nameof (TextVerticalAlignment), new UAValue((int) value));
      }
    }

    public IUAVariable TextVerticalAlignmentVariable
    {
      get => this.GetOrCreateVariable("TextVerticalAlignment");
    }

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

    public bool FontUnderline
    {
      get => (bool) this.GetOptionalVariableValue(nameof (FontUnderline));
      set => this.SetOptionalVariableValue(nameof (FontUnderline), new UAValue(value));
    }

    public IUAVariable FontUnderlineVariable => this.GetOrCreateVariable("FontUnderline");

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

    public bool Blink
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Blink));
      set => this.SetOptionalVariableValue(nameof (Blink), new UAValue(value));
    }

    public IUAVariable BlinkVariable => this.GetOrCreateVariable("Blink");

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public InstanceNodeCollection<Label> Instances
    {
      get => new InstanceNodeCollection<Label>((IUANode) this);
    }
  }
}
