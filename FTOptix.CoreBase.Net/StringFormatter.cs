// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.StringFormatter
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 55)]
  public class StringFormatter : Converter
  {
    public string Format
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (Format)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (Format), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText LocalizedFormat
    {
      get => (LocalizedText) this.GetOptionalVariableValue("Format");
      set => this.SetOptionalVariableValue("Format", new UAValue(value));
    }

    public IUAVariable FormatVariable => this.GetOrCreateVariable("Format");
  }
}
