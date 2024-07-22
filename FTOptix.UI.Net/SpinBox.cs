// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.SpinBox
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using System.ComponentModel;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 88)]
  public class SpinBox : Item
  {
    public double Value
    {
      get => (double) this.Refs.GetVariable(nameof (Value)).Value.Value;
      set => this.Refs.GetVariable(nameof (Value)).SetValue((object) value);
    }

    public IUAVariable ValueVariable => this.Refs.GetVariable("Value");

    public double MinValue
    {
      get => (double) this.GetOptionalVariableValue(nameof (MinValue));
      set => this.SetOptionalVariableValue(nameof (MinValue), new UAValue(value));
    }

    public IUAVariable MinValueVariable => this.GetOrCreateVariable("MinValue");

    public double MaxValue
    {
      get => (double) this.GetOptionalVariableValue(nameof (MaxValue));
      set => this.SetOptionalVariableValue(nameof (MaxValue), new UAValue(value));
    }

    public IUAVariable MaxValueVariable => this.GetOrCreateVariable("MaxValue");

    public string Format
    {
      get => (string) this.GetOptionalVariableValue(nameof (Format));
      set => this.SetOptionalVariableValue(nameof (Format), new UAValue(value));
    }

    public IUAVariable FormatVariable => this.GetOrCreateVariable("Format");

    public double Increment
    {
      get => (double) this.GetOptionalVariableValue(nameof (Increment));
      set => this.SetOptionalVariableValue(nameof (Increment), new UAValue(value));
    }

    public IUAVariable IncrementVariable => this.GetOrCreateVariable("Increment");

    public bool Editable
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Editable));
      set => this.SetOptionalVariableValue(nameof (Editable), new UAValue(value));
    }

    public IUAVariable EditableVariable => this.GetOrCreateVariable("Editable");

    public bool ShowButtons
    {
      get => (bool) this.GetOptionalVariableValue(nameof (ShowButtons));
      set => this.SetOptionalVariableValue(nameof (ShowButtons), new UAValue(value));
    }

    public IUAVariable ShowButtonsVariable => this.GetOrCreateVariable("ShowButtons");

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

    public string InputBoxStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (InputBoxStyle));
      set => this.SetOptionalVariableValue(nameof (InputBoxStyle), new UAValue(value));
    }

    public IUAVariable InputBoxStyleVariable => this.GetOrCreateVariable("InputBoxStyle");

    public string ButtonStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ButtonStyle));
      set => this.SetOptionalVariableValue(nameof (ButtonStyle), new UAValue(value));
    }

    public IUAVariable ButtonStyleVariable => this.GetOrCreateVariable("ButtonStyle");

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is obsolete and it'll be removed in future releases. This function will always return ValueChangeBehaviour.ValueChangeOnEditingFinished")]
    public ValueChangeBehaviour ValueChangeBehaviour
    {
      get => ValueChangeBehaviour.ValueChangeOnEditingFinished;
      set
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. SpinBox behaviour is now stuck to ValueChangeBehaviour.ValueChangeOnEditingFinished", true)]
    public IUAVariable ValueChangeBehaviourVariable => (IUAVariable) null;

    public event EventHandler<UserValueChangedEvent> OnUserValueChanged
    {
      add
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 690U), typeof (EventHandler<UserValueChangedEvent>), typeof (UserValueChangedEvent)).Add((Delegate) value);
      }
      remove
      {
        this.GetOrCreateCustomEventHandler(new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 690U), typeof (EventHandler<UserValueChangedEvent>), typeof (UserValueChangedEvent)).Remove((Delegate) value);
      }
    }
  }
}
