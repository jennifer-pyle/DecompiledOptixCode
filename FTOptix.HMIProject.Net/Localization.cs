// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.Localization
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public class Localization
  {
    private PropertyGroup localizationObject;

    public Localization(PropertyGroup localizationObject)
    {
      this.localizationObject = localizationObject;
    }

    public PropertyGroup Object => this.localizationObject;

    public string[] Locales
    {
      get => (string[]) this.localizationObject.GetOptionalVariableValue(nameof (Locales)).Value;
      set
      {
        if (value != null)
          this.localizationObject.SetOptionalVariableValue(nameof (Locales), new UAValue(value));
        else
          this.localizationObject.SetOptionalVariableValue(nameof (Locales), new UAValue(Array.Empty<string>()));
      }
    }

    public IUAVariable LocalesVariable => this.localizationObject.GetOrCreateVariable("Locales");

    public string[] LocaleFallbackList
    {
      get
      {
        return (string[]) this.localizationObject.GetOptionalVariableValue(nameof (LocaleFallbackList)).Value;
      }
      set
      {
        if (value != null)
          this.localizationObject.SetOptionalVariableValue(nameof (LocaleFallbackList), new UAValue(value));
        else
          this.localizationObject.SetOptionalVariableValue(nameof (LocaleFallbackList), new UAValue(Array.Empty<string>()));
      }
    }

    public IUAVariable LocaleFallbackListVariable
    {
      get => this.localizationObject.GetOrCreateVariable("LocaleFallbackList");
    }

    public MeasurementSystemMapItem[] MeasurementSystemMap
    {
      get
      {
        return (MeasurementSystemMapItem[]) this.localizationObject.GetOptionalVariableValue(nameof (MeasurementSystemMap)).Value;
      }
      set
      {
        if (value != null)
          this.localizationObject.SetOptionalVariableValue(nameof (MeasurementSystemMap), new UAValue((Struct[]) value));
        else
          this.localizationObject.SetOptionalVariableValue(nameof (MeasurementSystemMap), new UAValue((Struct[]) Array.Empty<MeasurementSystemMapItem>()));
      }
    }

    public IUAVariable MeasurementSystemMapVariable
    {
      get => this.localizationObject.GetOrCreateVariable("MeasurementSystemMap");
    }
  }
}
