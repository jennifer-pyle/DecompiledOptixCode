﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.TextBox
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 11)]
  public class TextBox : Item
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

    public ValueChangeBehaviour ValueChangeBehaviour
    {
      get
      {
        return (ValueChangeBehaviour) (int) this.GetOptionalVariableValue(nameof (ValueChangeBehaviour));
      }
      set => this.SetOptionalVariableValue(nameof (ValueChangeBehaviour), new UAValue((int) value));
    }

    public IUAVariable ValueChangeBehaviourVariable
    {
      get => this.GetOrCreateVariable("ValueChangeBehaviour");
    }

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

    public Color BorderColor
    {
      get => new Color(this.GetOptionalVariableValue(nameof (BorderColor)));
      set => this.SetOptionalVariableValue(nameof (BorderColor), new UAValue(value.ARGB));
    }

    public IUAVariable BorderColorVariable => this.GetOrCreateVariable("BorderColor");

    public string PlaceholderText
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (PlaceholderText)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (PlaceholderText), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText PlaceholderLocalizedText
    {
      get => (LocalizedText) this.GetOptionalVariableValue("PlaceholderText");
      set => this.SetOptionalVariableValue("PlaceholderText", new UAValue(value));
    }

    public UAVariable PlaceholderTextVariable
    {
      get => (UAVariable) this.GetOrCreateVariable("PlaceholderText");
    }

    public bool ReadOnly
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ReadOnly));
      set => this.SetOptionalVariableValue(nameof (ReadOnly), new UAValue(value));
    }

    public IUAVariable ReadOnlyVariable => this.GetOrCreateVariable("ReadOnly");

    public InputType ContentType
    {
      get => (InputType) (int) this.GetOptionalVariableValue(nameof (ContentType));
      set => this.SetOptionalVariableValue(nameof (ContentType), new UAValue((int) value));
    }

    public IUAVariable ContentTypeVariable => this.GetOrCreateVariable("ContentType");

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

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
