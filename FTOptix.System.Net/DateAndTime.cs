// Decompiled with JetBrains decompiler
// Type: FTOptix.System.DateAndTime
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  public class DateAndTime
  {
    private PropertyGroup dateAndTimeObject;

    public DateAndTime(PropertyGroup dateAndTimeObject)
    {
      this.dateAndTimeObject = dateAndTimeObject;
    }

    public PropertyGroup Object => this.dateAndTimeObject;

    public TimeSynchronizationMode[] AvailableSynchronizationModes
    {
      get
      {
        int[] numArray = (int[]) this.AvailableSynchronizationModesVariable.Value;
        TimeSynchronizationMode[] synchronizationModes = new TimeSynchronizationMode[numArray.Length];
        for (int index = 0; index < numArray.Length; ++index)
          synchronizationModes[index] = (TimeSynchronizationMode) numArray[index];
        return synchronizationModes;
      }
    }

    public IUAVariable AvailableSynchronizationModesVariable
    {
      get => this.dateAndTimeObject.GetVariable("AvailableSynchronizationModes");
    }

    public TimeSynchronizationMode SynchronizationMode
    {
      get => (TimeSynchronizationMode) (int) this.SynchronizationModeVariable.Value;
      set => this.SynchronizationModeVariable.SetValue((object) (int) value);
    }

    public IUAVariable SynchronizationModeVariable
    {
      get => this.dateAndTimeObject.GetVariable("SynchronizationMode");
    }

    public string RemoteNTPServer
    {
      get => (string) this.RemoteNTPServerVariable.Value;
      set => this.RemoteNTPServerVariable.SetValue((object) value);
    }

    public IUAVariable RemoteNTPServerVariable
    {
      get => this.dateAndTimeObject.GetVariable("RemoteNTPServer");
    }

    public string PLCAddress
    {
      get => (string) this.PLCAddressVariable.Value;
      set => this.PLCAddressVariable.SetValue((object) value);
    }

    public IUAVariable PLCAddressVariable => this.dateAndTimeObject.GetVariable("PLCAddress");

    public DateTime DateTime
    {
      get => (DateTime) this.DateTimeVariable.Value;
      set => this.DateTimeVariable.SetValue((object) value);
    }

    public IUAVariable DateTimeVariable => this.dateAndTimeObject.GetVariable("DateTime");

    public string TimeZone
    {
      get => (string) this.TimeZoneVariable.Value;
      set => this.TimeZoneVariable.SetValue((object) value);
    }

    public IUAVariable TimeZoneVariable => this.dateAndTimeObject.GetVariable("TimeZone");

    public string[] LocalNTPServerInterfaces
    {
      get => (string[]) this.LocalNTPServerInterfacesVariable.Value;
      set => this.LocalNTPServerInterfacesVariable.SetValue((object) value);
    }

    public IUAVariable LocalNTPServerInterfacesVariable
    {
      get => this.dateAndTimeObject.GetVariable("LocalNTPServerInterfaces");
    }
  }
}
