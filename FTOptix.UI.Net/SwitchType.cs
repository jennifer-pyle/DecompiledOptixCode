// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.SwitchType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 75)]
  public class SwitchType : ItemType
  {
    public bool Checked
    {
      get => (bool) this.Refs.GetVariable(nameof (Checked)).Value.Value;
      set => this.Refs.GetVariable(nameof (Checked)).SetValue((object) value);
    }

    public IUAVariable CheckedVariable => this.Refs.GetVariable("Checked");

    public LocalizedText CheckedText
    {
      get => (LocalizedText) this.GetOptionalVariableValue(nameof (CheckedText));
      set => this.SetOptionalVariableValue(nameof (CheckedText), new UAValue(value));
    }

    public IUAVariable CheckedTextVariable => this.GetOrCreateVariable("CheckedText");

    public LocalizedText UncheckedText
    {
      get => (LocalizedText) this.GetOptionalVariableValue(nameof (UncheckedText));
      set => this.SetOptionalVariableValue(nameof (UncheckedText), new UAValue(value));
    }

    public IUAVariable UncheckedTextVariable => this.GetOrCreateVariable("UncheckedText");

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

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public IUAVariable TextColorVariable => this.GetOrCreateVariable("TextColor");

    public InstanceNodeCollection<Switch> Instances
    {
      get => new InstanceNodeCollection<Switch>((IUANode) this);
    }
  }
}
