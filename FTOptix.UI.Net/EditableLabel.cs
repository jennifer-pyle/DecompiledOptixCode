// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.EditableLabel
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 107)]
  public class EditableLabel : Item
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

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public string LabelStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (LabelStyle));
      set => this.SetOptionalVariableValue(nameof (LabelStyle), new UAValue(value));
    }

    public IUAVariable LabelStyleVariable => this.GetOrCreateVariable("LabelStyle");

    public string InputBoxStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (InputBoxStyle));
      set => this.SetOptionalVariableValue(nameof (InputBoxStyle), new UAValue(value));
    }

    public IUAVariable InputBoxStyleVariable => this.GetOrCreateVariable("InputBoxStyle");

    public bool Editable
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Editable));
      set => this.SetOptionalVariableValue(nameof (Editable), new UAValue(value));
    }

    public IUAVariable EditableVariable => this.GetOrCreateVariable("Editable");

    public event EventHandler<UserTextChangedEvent> OnUserTextChanged
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 688U), typeof (EventHandler<UserTextChangedEvent>), typeof (UserTextChangedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 688U), typeof (EventHandler<UserTextChangedEvent>), typeof (UserTextChangedEvent)).Remove((Delegate) value);
      }
    }
  }
}
