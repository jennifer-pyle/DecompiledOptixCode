// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.SessionType
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 16)]
  public class SessionType : UAObjectType
  {
    public NodeId User
    {
      get => (NodeId) this.Refs.GetVariable(nameof (User)).Value.Value;
      set => this.Refs.GetVariable(nameof (User)).SetValue((object) value);
    }

    public IUAVariable UserVariable => this.Refs.GetVariable("User");

    public string[] LocaleIds
    {
      get => (string[]) this.GetOptionalVariableValue(nameof (LocaleIds)).Value;
      set => this.SetOptionalVariableValue(nameof (LocaleIds), new UAValue(value));
    }

    public IUAVariable LocaleIdsVariable => this.GetOrCreateVariable("LocaleIds");

    public string[] Languages
    {
      get => (string[]) this.GetOptionalVariableValue(nameof (Languages)).Value;
      set => this.SetOptionalVariableValue(nameof (Languages), new UAValue(value));
    }

    public IUAVariable LanguagesVariable => this.GetOrCreateVariable("Languages");

    public MeasurementSystem MeasurementSystem
    {
      get => (MeasurementSystem) (int) this.GetOptionalVariableValue(nameof (MeasurementSystem));
      set => this.SetOptionalVariableValue(nameof (MeasurementSystem), new UAValue((int) value));
    }

    public IUAVariable MeasurementSystemVariable => this.GetOrCreateVariable("MeasurementSystem");

    public string[] ActualLocaleIds
    {
      get => (string[]) this.Refs.GetVariable(nameof (ActualLocaleIds)).Value.Value;
      set => this.Refs.GetVariable(nameof (ActualLocaleIds)).SetValue((object) value);
    }

    public IUAVariable ActualLocaleIdsVariable => this.Refs.GetVariable("ActualLocaleIds");

    public string[] ActualLanguages
    {
      get => (string[]) this.Refs.GetVariable(nameof (ActualLanguages)).Value.Value;
      set => this.Refs.GetVariable(nameof (ActualLanguages)).SetValue((object) value);
    }

    public IUAVariable ActualLanguagesVariable => this.Refs.GetVariable("ActualLanguages");

    public bool IsInteractive
    {
      get => (bool) this.Refs.GetVariable(nameof (IsInteractive)).Value.Value;
      set => this.Refs.GetVariable(nameof (IsInteractive)).SetValue((object) value);
    }

    public IUAVariable IsInteractiveVariable => this.Refs.GetVariable("IsInteractive");

    public TimeZoneOffset TimeZoneOffset
    {
      get => (TimeZoneOffset) this.Refs.GetVariable(nameof (TimeZoneOffset)).Value;
    }

    public IUAVariable TimeZoneOffsetVariable => this.Refs.GetVariable("TimeZoneOffset");

    public InstanceNodeCollection<Session> Instances
    {
      get => new InstanceNodeCollection<Session>((IUANode) this);
    }
  }
}
