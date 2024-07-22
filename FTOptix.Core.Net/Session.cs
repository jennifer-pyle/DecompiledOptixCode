// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.Session
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 16)]
  public class Session : UAObject
  {
    private bool variableChangeRegistered;
    private bool disposedValue;
    private object lockedObject = new object();

    public User User
    {
      get
      {
        return this.Context.GetNode((NodeId) this.Refs.GetVariable(nameof (User)).Value.Value) as User;
      }
    }

    public IUAVariable UserVariable => this.Refs.GetVariable("User");

    public string LocaleId
    {
      get => (string) this.GetOptionalVariableValue(nameof (LocaleId)).Value;
      set => this.SetOptionalVariableValue("LocaleIds", new UAValue(value));
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

    public string ActualLocaleId
    {
      get => (string) this.Refs.GetVariable(nameof (ActualLocaleId)).Value.Value;
      set => this.Refs.GetVariable(nameof (ActualLocaleId)).SetValue((object) value);
    }

    public IUAVariable ActualLocaleIdVariable => this.Refs.GetVariable("ActualLocaleId");

    public string ActualLanguage
    {
      get => (string) this.Refs.GetVariable(nameof (ActualLanguage)).Value.Value;
      set => this.Refs.GetVariable(nameof (ActualLanguage)).SetValue((object) value);
    }

    public IUAVariable ActualLanguageVariable => this.Refs.GetVariable("ActualLanguage");

    public MeasurementSystem ActualMeasurementSystem
    {
      get
      {
        return (MeasurementSystem) this.Refs.GetVariable(nameof (ActualMeasurementSystem)).Value.Value;
      }
      set => this.Refs.GetVariable(nameof (ActualMeasurementSystem)).SetValue((object) value);
    }

    public IUAVariable ActualMeasurementSystemVariable
    {
      get => this.GetOrCreateVariable("ActualMeasurementSystem");
    }

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

    public ChangeUserResult ChangeUser(string username, string password)
    {
      object[] outputArgs;
      this.ExecuteMethod(nameof (ChangeUser), new object[2]
      {
        (object) username,
        (object) password
      }, out outputArgs);
      return new ChangeUserResult((ChangeUserResultCode) outputArgs[1]);
    }

    public ChangePasswordResult ChangePassword(
      string username,
      string newPassword,
      string oldPassword)
    {
      object[] outputArgs;
      this.ExecuteMethod(nameof (ChangePassword), new object[3]
      {
        (object) username,
        (object) newPassword,
        (object) oldPassword
      }, out outputArgs);
      return new ChangePasswordResult((ChangePasswordResultCode) outputArgs[1]);
    }

    public ChangePasswordResult ChangePasswordInternal(string username, string newPassword)
    {
      object[] outputArgs;
      this.ExecuteMethod(nameof (ChangePasswordInternal), new object[2]
      {
        (object) username,
        (object) newPassword
      }, out outputArgs);
      return new ChangePasswordResult((ChangePasswordResultCode) outputArgs[1]);
    }

    public ChangeUserResult Login(string username, string password)
    {
      object[] outputArgs;
      this.ExecuteMethod(nameof (Login), new object[2]
      {
        (object) username,
        (object) password
      }, out outputArgs);
      return new ChangeUserResult((ChangeUserResultCode) outputArgs[1]);
    }

    public void Logout() => this.ExecuteMethod(nameof (Logout));

    public event EventHandler<UserChangeEventArgs> UserChange
    {
      add
      {
        lock (this.lockedObject)
        {
          this.userChange += value;
          if (this.userChange.GetInvocationList().Length != 1)
            return;
          this.variableChangeRegistered = true;
          this.UserVariable.VariableChange += new EventHandler<VariableChangeEventArgs>(this.UserVariableChange);
        }
      }
      remove
      {
        lock (this.lockedObject)
        {
          if (this.userChange == null)
            return;
          this.userChange -= value;
          if (this.userChange != null && this.userChange.GetInvocationList().Length != 0 || !this.variableChangeRegistered)
            return;
          this.variableChangeRegistered = false;
          this.UserVariable.VariableChange -= new EventHandler<VariableChangeEventArgs>(this.UserVariableChange);
        }
      }
    }

    private void UserVariableChange(object sender, VariableChangeEventArgs e)
    {
      UserChangeEventArgs e1 = new UserChangeEventArgs((User) this.Context.GetObject((NodeId) e.NewValue), (User) this.Context.GetObject((NodeId) e.OldValue));
      EventHandler<UserChangeEventArgs> userChange = this.userChange;
      if (userChange == null)
        return;
      userChange((object) this.Context.Sessions.CurrentSessionInfo.SessionObject, e1);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.disposedValue)
        return;
      if (disposing)
        this.UnregisterUserChanged();
      this.disposedValue = true;
      base.Dispose(disposing);
    }

    private void UnregisterUserChanged()
    {
      lock (this.lockedObject)
      {
        this.userChange = (EventHandler<UserChangeEventArgs>) null;
        if (!this.variableChangeRegistered)
          return;
        try
        {
          this.UserVariable.VariableChange -= new EventHandler<VariableChangeEventArgs>(this.UserVariableChange);
        }
        catch
        {
        }
        this.variableChangeRegistered = false;
      }
    }

    private event EventHandler<UserChangeEventArgs> userChange;
  }
}
