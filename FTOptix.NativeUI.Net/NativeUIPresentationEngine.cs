// Decompiled with JetBrains decompiler
// Type: FTOptix.NativeUI.NativeUIPresentationEngine
// Assembly: FTOptix.NativeUI.Net, Version=1.0.8.51, Culture=neutral, PublicKeyToken=null
// MVID: 85F942F5-DB06-44CC-BDA7-FE76B2433DC4
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NativeUI.Net\1.0.8.51\Any\FTOptix.NativeUI.Net.dll

using FTOptix.UI;
using UAManagedCore;

#nullable disable
namespace FTOptix.NativeUI
{
  [MapType(NamespaceUri = "urn:FTOptix:NativeUI", Number = 1)]
  public class NativeUIPresentationEngine : PresentationEngine
  {
    public double DynamicVariablesPollingTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (DynamicVariablesPollingTime));
      set
      {
        this.SetOptionalVariableValue(nameof (DynamicVariablesPollingTime), new UAValue(value));
      }
    }

    public IUAVariable DynamicVariablesPollingTimeVariable
    {
      get => this.GetOrCreateVariable("DynamicVariablesPollingTime");
    }

    public TextRenderType TextRenderType
    {
      get => (TextRenderType) (int) this.GetOptionalVariableValue(nameof (TextRenderType));
      set => this.SetOptionalVariableValue(nameof (TextRenderType), new UAValue((int) value));
    }

    public IUAVariable TextRenderTypeVariable => this.GetOrCreateVariable("TextRenderType");

    public bool EnableVirtualKeyboard
    {
      get => (bool) this.Refs.GetVariable(nameof (EnableVirtualKeyboard)).Value.Value;
      set => this.Refs.GetVariable(nameof (EnableVirtualKeyboard)).SetValue((object) value);
    }

    public IUAVariable EnableVirtualKeyboardVariable
    {
      get => this.Refs.GetVariable("EnableVirtualKeyboard");
    }
  }
}
