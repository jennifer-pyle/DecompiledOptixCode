// Decompiled with JetBrains decompiler
// Type: FTOptix.System.Device
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  public class Device
  {
    private PropertyGroup deviceObject;

    public Device(PropertyGroup deviceObject) => this.deviceObject = deviceObject;

    public PropertyGroup Object => this.deviceObject;

    public string CatalogNumber => (string) this.CatalogNumberVariable.Value;

    public IUAVariable CatalogNumberVariable => this.deviceObject.GetVariable("CatalogNumber");

    public uint CPUFrequency => (uint) this.CPUFrequencyVariable.Value;

    public IUAVariable CPUFrequencyVariable => this.deviceObject.GetVariable("CPUFrequency");

    public int CPUTemperature => (int) this.CPUTemperatureVariable.Value;

    public IUAVariable CPUTemperatureVariable => this.deviceObject.GetVariable("CPUTemperature");

    public uint CPUUtilization => (uint) this.CPUUtilizationVariable.Value;

    public IUAVariable CPUUtilizationVariable => this.deviceObject.GetVariable("CPUUtilization");

    public uint EthernetNetworkCount => (uint) this.EthernetNetworkCountVariable.Value;

    public IUAVariable EthernetNetworkCountVariable
    {
      get => this.deviceObject.GetVariable("EthernetNetworkCount");
    }

    public uint EthernetPortCount => (uint) this.EthernetPortCountVariable.Value;

    public IUAVariable EthernetPortCountVariable
    {
      get => this.deviceObject.GetVariable("EthernetPortCount");
    }

    public DateTime FirmwareDate => (DateTime) this.FirmwareDateVariable.Value;

    public IUAVariable FirmwareDateVariable => this.deviceObject.GetVariable("FirmwareDate");

    public string FirmwareVersion => (string) this.FirmwareVersionVariable.Value;

    public IUAVariable FirmwareVersionVariable => this.deviceObject.GetVariable("FirmwareVersion");

    public uint HardwareProductCode => (uint) this.HardwareProductCodeVariable.Value;

    public IUAVariable HardwareProductCodeVariable
    {
      get => this.deviceObject.GetVariable("HardwareProductCode");
    }

    public uint HardwareProductType => (uint) this.HardwareProductTypeVariable.Value;

    public IUAVariable HardwareProductTypeVariable
    {
      get => this.deviceObject.GetVariable("HardwareProductType");
    }

    public string HardwareVersion => (string) this.HardwareVersionVariable.Value;

    public IUAVariable HardwareVersionVariable => this.deviceObject.GetVariable("HardwareVersion");

    public string HardwareSeries => (string) this.HardwareSeriesVariable.Value;

    public IUAVariable HardwareSeriesVariable => this.deviceObject.GetVariable("HardwareSeries");

    public string Hostname
    {
      get => (string) this.HostnameVariable.Value;
      set => this.HostnameVariable.SetValue((object) value);
    }

    public IUAVariable HostnameVariable => this.deviceObject.GetVariable("Hostname");

    public DateTime LastBootupTime => (DateTime) this.LastBootupTimeVariable.Value;

    public IUAVariable LastBootupTimeVariable => this.deviceObject.GetVariable("LastBootupTime");

    public DateTime LastApplicationUpdateTime
    {
      get => (DateTime) this.LastApplicationUpdateTimeVariable.Value;
    }

    public IUAVariable LastApplicationUpdateTimeVariable
    {
      get => this.deviceObject.GetVariable("LastApplicationUpdateTime");
    }

    public string OSVersion => (string) this.OSVersionVariable.Value;

    public IUAVariable OSVersionVariable => this.deviceObject.GetVariable("OSVersion");

    public string ProductName => (string) this.ProductNameVariable.Value;

    public IUAVariable ProductNameVariable => this.deviceObject.GetVariable("ProductName");

    public bool ProtectionModeEnabled
    {
      get => (bool) this.ProtectionModeEnabledVariable.Value;
      set => this.ProtectionModeEnabledVariable.SetValue((object) value);
    }

    public IUAVariable ProtectionModeEnabledVariable
    {
      get => this.deviceObject.GetVariable("ProtectionModeEnabled");
    }

    public string SystemManagerVersion => (string) this.SystemManagerVersionVariable.Value;

    public IUAVariable SystemManagerVersionVariable
    {
      get => this.deviceObject.GetVariable("SystemManagerVersion");
    }

    public uint TotalOnTime => (uint) this.TotalOnTimeVariable.Value;

    public IUAVariable TotalOnTimeVariable => this.deviceObject.GetVariable("TotalOnTime");

    public uint FreeMemory => (uint) this.FreeMemoryVariable.Value;

    public IUAVariable FreeMemoryVariable => this.deviceObject.GetVariable("FreeMemory");

    public uint TotalMemory => (uint) this.TotalMemoryVariable.Value;

    public IUAVariable TotalMemoryVariable => this.deviceObject.GetVariable("TotalMemory");

    public uint UsedMemory => (uint) this.UsedMemoryVariable.Value;

    public IUAVariable UsedMemoryVariable => this.deviceObject.GetVariable("UsedMemory");

    public uint FreeStorage => (uint) this.FreeStorageVariable.Value;

    public IUAVariable FreeStorageVariable => this.deviceObject.GetVariable("FreeStorage");

    public uint TotalStorage => (uint) this.TotalStorageVariable.Value;

    public IUAVariable TotalStorageVariable => this.deviceObject.GetVariable("TotalStorage");

    public uint UsedStorage => (uint) this.UsedStorageVariable.Value;

    public IUAVariable UsedStorageVariable => this.deviceObject.GetVariable("UsedStorage");
  }
}
