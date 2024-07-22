// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.LimitAlarmController
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  [MapType(NamespaceUri = "urn:FTOptix:Alarm", Number = 86)]
  public class LimitAlarmController : AlarmController
  {
    public double? HighHighLimit
    {
      get => (double?) this.Refs.GetVariable(nameof (HighHighLimit))?.GetValue();
      set
      {
        if (value.HasValue)
          (this.Refs.GetVariable(nameof (HighHighLimit)) ?? this.GetOrCreateVariable(nameof (HighHighLimit))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (HighHighLimit))?.Delete();
      }
    }

    public double? HighLimit
    {
      get => (double?) this.Refs.GetVariable(nameof (HighLimit))?.GetValue();
      set
      {
        if (value.HasValue)
          (this.Refs.GetVariable(nameof (HighLimit)) ?? this.GetOrCreateVariable(nameof (HighLimit))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (HighLimit))?.Delete();
      }
    }

    public double? LowLimit
    {
      get => (double?) this.Refs.GetVariable(nameof (LowLimit))?.GetValue();
      set
      {
        if (value.HasValue)
          (this.Refs.GetVariable(nameof (LowLimit)) ?? this.GetOrCreateVariable(nameof (LowLimit))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (LowLimit))?.Delete();
      }
    }

    public double? LowLowLimit
    {
      get => (double?) this.Refs.GetVariable(nameof (LowLowLimit))?.GetValue();
      set
      {
        if (value.HasValue)
          (this.Refs.GetVariable(nameof (LowLowLimit)) ?? this.GetOrCreateVariable(nameof (LowLowLimit))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (LowLowLimit))?.Delete();
      }
    }

    public bool ActiveHighHighState
    {
      get => (bool) this.GetVariable("Active/ActiveHighHighState").GetValue();
    }

    public IUAVariable ActiveHighHighStateVariable
    {
      get => this.GetOrCreateVariable("Active/ActiveHighHighState");
    }

    public bool ActiveHighState => (bool) this.GetVariable("Active/ActiveHighState").GetValue();

    public IUAVariable ActiveHighStateVariable
    {
      get => this.GetOrCreateVariable("Active/ActiveHighState");
    }

    public bool ActiveLowState => (bool) this.GetVariable("Active/ActiveLowState").GetValue();

    public IUAVariable ActiveLowStateVariable => this.GetOrCreateVariable("Active/ActiveLowState");

    public bool ActiveLowLowState => (bool) this.GetVariable("Active/ActiveLowLowState").GetValue();

    public IUAVariable ActiveLowLowStateVariable
    {
      get => this.GetOrCreateVariable("Active/ActiveLowLowState");
    }

    public string MessageHighHighState
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable("Message").GetOrCreateVariable("HighHighStateMessage").Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        LocalizedText localizedText = new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId);
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("HighHighStateMessage", new UAValue(localizedText));
      }
    }

    public LocalizedText LocalizedMessageHighHighState
    {
      get
      {
        return (LocalizedText) this.GetOrCreateVariable("Message").GetOptionalVariableValue("HighHighStateMessage");
      }
      set
      {
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("HighHighStateMessage", new UAValue(value));
      }
    }

    public UAVariable MessageHighHighStateVariable
    {
      get
      {
        return (UAVariable) this.GetOrCreateVariable("Message").GetOrCreateVariable("HighHighStateMessage");
      }
    }

    public string MessageHighState
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable("Message").GetOrCreateVariable("HighStateMessage").Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        LocalizedText localizedText = new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId);
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("HighStateMessage", new UAValue(localizedText));
      }
    }

    public LocalizedText LocalizedMessageHighState
    {
      get
      {
        return (LocalizedText) this.GetOrCreateVariable("Message").GetOptionalVariableValue("HighStateMessage");
      }
      set
      {
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("HighStateMessage", new UAValue(value));
      }
    }

    public UAVariable MessageHighStateVariable
    {
      get
      {
        return (UAVariable) this.GetOrCreateVariable("Message").GetOrCreateVariable("HighStateMessage");
      }
    }

    public string MessageLowState
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable("Message").GetOrCreateVariable("LowStateMessage").Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        LocalizedText localizedText = new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId);
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("LowStateMessage", new UAValue(localizedText));
      }
    }

    public LocalizedText LocalizedMessageLowState
    {
      get
      {
        return (LocalizedText) this.GetOrCreateVariable("Message").GetOptionalVariableValue("LowStateMessage");
      }
      set
      {
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("LowStateMessage", new UAValue(value));
      }
    }

    public UAVariable MessageLowStateVariable
    {
      get
      {
        return (UAVariable) this.GetOrCreateVariable("Message").GetOrCreateVariable("LowStateMessage");
      }
    }

    public string MessageLowLowState
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable("Message").GetOrCreateVariable("LowLowStateMessage").Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        LocalizedText localizedText = new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId);
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("LowLowStateMessage", new UAValue(localizedText));
      }
    }

    public LocalizedText LocalizedMessageLowLowState
    {
      get
      {
        return (LocalizedText) this.GetOrCreateVariable("Message").GetOptionalVariableValue("LowLowStateMessage");
      }
      set
      {
        this.GetOrCreateVariable("Message").SetOptionalVariableValue("LowLowStateMessage", new UAValue(value));
      }
    }

    public UAVariable MessageLowLowStateVariable
    {
      get
      {
        return (UAVariable) this.GetOrCreateVariable("Message").GetOrCreateVariable("LowLowStateMessage");
      }
    }
  }
}
