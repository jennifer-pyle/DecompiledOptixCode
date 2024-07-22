// Decompiled with JetBrains decompiler
// Type: FTOptix.Alarm.AlarmControllerType
// Assembly: FTOptix.Alarm.Net, Version=1.2.1.48, Culture=neutral, PublicKeyToken=null
// MVID: A8E60840-4560-4350-AD78-0013E94B5C5E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Alarm.Net\1.2.1.48\Any\FTOptix.Alarm.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Alarm
{
  [MapType(NamespaceUri = "urn:FTOptix:Alarm", Number = 67)]
  public class AlarmControllerType : UAObjectType
  {
    public bool Enabled
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Enabled));
      set => this.SetOptionalVariableValue(nameof (Enabled), new UAValue(value));
    }

    public IUAVariable EnabledVariable => this.GetOrCreateVariable("Enabled");

    public bool Active => (bool) this.GetOptionalVariableValue(nameof (Active));

    public IUAVariable ActiveVariable => this.GetOrCreateVariable("Active");

    public bool AutoAcknowledge
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AutoAcknowledge));
      set => this.SetOptionalVariableValue(nameof (AutoAcknowledge), new UAValue(value));
    }

    public IUAVariable AutoAcknowledgeVariable => this.GetOrCreateVariable("AutoAcknowledge");

    public bool AutoConfirm
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AutoConfirm));
      set => this.SetOptionalVariableValue(nameof (AutoConfirm), new UAValue(value));
    }

    public IUAVariable AutoConfirmVariable => this.GetOrCreateVariable("AutoConfirm");

    public double InputValue
    {
      get => (double) this.Refs.GetVariable(nameof (InputValue)).Value.Value;
      set => this.Refs.GetVariable(nameof (InputValue)).SetValue((object) value);
    }

    public IUAVariable InputValueVariable => this.Refs.GetVariable("InputValue");

    public string Message
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (Message)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (Message), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText LocalizedMessage
    {
      get => (LocalizedText) this.GetOptionalVariableValue("Message");
      set => this.SetOptionalVariableValue("Message", new UAValue(value));
    }

    public UAVariable MessageVariable => (UAVariable) this.GetOrCreateVariable("Message");

    public ushort Severity
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (Severity));
      set => this.SetOptionalVariableValue(nameof (Severity), new UAValue(value));
    }

    public IUAVariable SeverityVariable => this.GetOrCreateVariable("Severity");

    public double MaxTimeShelved
    {
      get => (double) this.GetOptionalVariableValue(nameof (MaxTimeShelved));
      set => this.SetOptionalVariableValue(nameof (MaxTimeShelved), new UAValue(value));
    }

    public IUAVariable MaxTimeShelvedVariable => this.GetOrCreateVariable("MaxTimeShelved");

    public double PresetTimeShelved
    {
      get => (double) this.GetOptionalVariableValue(nameof (PresetTimeShelved));
      set => this.SetOptionalVariableValue(nameof (PresetTimeShelved), new UAValue(value));
    }

    public IUAVariable PresetTimeShelvedVariable => this.GetOrCreateVariable("PresetTimeShelved");

    public object[] LastEvent
    {
      get => (object[]) this.Refs.GetVariable(nameof (LastEvent)).Value.Value;
      set => this.Refs.GetVariable(nameof (LastEvent)).SetValue((object) value);
    }

    public IUAVariable LastEventVariable => this.Refs.GetVariable("LastEvent");

    public void Acknowledge(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Acknowledge), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod AcknowledgeMethod => this.Refs.GetMethod("Acknowledge");

    public void Confirm(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Confirm), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod ConfirmMethod => this.Refs.GetMethod("Confirm");

    public void AddComment(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (AddComment), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod AddCommentMethod => this.Refs.GetMethod("AddComment");

    public void Reset(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Reset), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod ResetMethod => this.Refs.GetMethod("Reset");

    public bool Latched => (bool) this.GetOptionalVariableValue(nameof (Latched));

    public IUAVariable LatchedVariable => this.GetOrCreateVariable("Latched");

    public void Suppress(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Suppress), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod SuppressMethod => this.Refs.GetMethod("Suppress");

    public void Unsuppress(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Unsuppress), new object[2]
      {
        (object) new ByteString(),
        (object) comment
      });
    }

    public IUAMethod UnsuppressMethod => this.Refs.GetMethod("Unsuppress");

    public bool Suppressed => (bool) this.GetOptionalVariableValue(nameof (Suppressed));

    public IUAVariable SuppressedVariable => this.GetOrCreateVariable("Suppressed");

    public bool Shelved => (bool) this.GetOptionalVariableValue(nameof (Shelved));

    public IUAVariable ShelvedVariable => this.GetOrCreateVariable("Shelved");

    public void OneShotShelve(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (OneShotShelve), new object[1]
      {
        (object) comment
      });
    }

    public void OneShotShelve()
    {
      this.ExecuteMethod(nameof (OneShotShelve), new object[1]
      {
        (object) LocalizedText.Empty
      });
    }

    public IUAMethod OneShotShelveMethod => this.Refs.GetMethod("OneShotShelve");

    public void TimedShelve(double shelvingTime, LocalizedText comment)
    {
      this.ExecuteMethod(nameof (TimedShelve), new object[2]
      {
        (object) shelvingTime,
        (object) comment
      });
    }

    public void TimedShelve(double shelvingTime)
    {
      this.ExecuteMethod(nameof (TimedShelve), new object[2]
      {
        (object) shelvingTime,
        (object) LocalizedText.Empty
      });
    }

    public IUAMethod TimedShelveMethod => this.Refs.GetMethod("TimedShelve");

    public void Unshelve(LocalizedText comment)
    {
      this.ExecuteMethod(nameof (Unshelve), new object[1]
      {
        (object) comment
      });
    }

    public void Unshelve()
    {
      this.ExecuteMethod(nameof (Unshelve), new object[1]
      {
        (object) LocalizedText.Empty
      });
    }

    public IUAMethod UnshelveMethod => this.Refs.GetMethod("Unshelve");

    public InstanceNodeCollection<AlarmController> Instances
    {
      get => new InstanceNodeCollection<AlarmController>((IUANode) this);
    }
  }
}
