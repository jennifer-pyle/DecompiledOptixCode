// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.UserType
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 14)]
  public class UserType : UAObjectType
  {
    public string Password
    {
      [Obsolete("This property is no longer available.", true)] get => string.Empty;
      [Obsolete("This property is no longer available. Use the FTOptix.Core.Session.ChangePassword method insted. If you get this error from the UserEditor widget, please re-import it from the template library.", true)] set
      {
      }
    }

    public IUAVariable PasswordVariable => this.GetOrCreateVariable("Password");

    public string LocaleId
    {
      get => (string) this.GetOptionalVariableValue(nameof (LocaleId)).Value;
      set => this.SetOptionalVariableValue(nameof (LocaleId), new UAValue(value));
    }

    public IUAVariable LocaleIdVariable => this.GetOrCreateVariable("LocaleId");

    public string Language
    {
      get => (string) this.GetOptionalVariableValue(nameof (Language)).Value;
      set => this.SetOptionalVariableValue(nameof (Language), new UAValue(value));
    }

    public IUAVariable LanguageVariable => this.GetOrCreateVariable("Language");

    public MeasurementSystem MeasurementSystem
    {
      get => (MeasurementSystem) (int) this.GetOptionalVariableValue(nameof (MeasurementSystem));
      set => this.SetOptionalVariableValue(nameof (MeasurementSystem), new UAValue((int) value));
    }

    public IUAVariable MeasurementSystemVariable => this.GetOrCreateVariable("MeasurementSystem");

    public string Domain
    {
      get => (string) this.GetOptionalVariableValue(nameof (Domain)).Value;
      set => this.SetOptionalVariableValue(nameof (Domain), new UAValue(value));
    }

    public IUAVariable DomainVariable => this.GetOrCreateVariable("Domain");

    public InstanceNodeCollection<User> Instances
    {
      get => new InstanceNodeCollection<User>((IUANode) this);
    }
  }
}
