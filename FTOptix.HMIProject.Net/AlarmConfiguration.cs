// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.AlarmConfiguration
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public class AlarmConfiguration
  {
    private PropertyGroup alarmConfigurationObject;

    public AlarmConfiguration(PropertyGroup alarmConfigurationObject)
    {
      this.alarmConfigurationObject = alarmConfigurationObject;
    }

    public PropertyGroup Object => this.alarmConfigurationObject;

    public bool BranchingEnabled
    {
      get
      {
        return (bool) this.alarmConfigurationObject.GetOptionalVariableValue(nameof (BranchingEnabled)).Value;
      }
      set
      {
        this.alarmConfigurationObject.SetOptionalVariableValue(nameof (BranchingEnabled), new UAValue(value));
      }
    }

    public IUAVariable BranchingEnabledVariable
    {
      get => this.alarmConfigurationObject.GetOrCreateVariable("BranchingEnabled");
    }

    public double DynamicVariablesPollingTime
    {
      get
      {
        return (double) this.alarmConfigurationObject.GetOptionalVariableValue(nameof (DynamicVariablesPollingTime)).Value;
      }
      set
      {
        this.alarmConfigurationObject.SetOptionalVariableValue(nameof (DynamicVariablesPollingTime), new UAValue(value));
      }
    }

    public IUAVariable DynamicVariablesPollingTimeVariable
    {
      get => this.alarmConfigurationObject.GetOrCreateVariable("DynamicVariablesPollingTime");
    }
  }
}
