// Decompiled with JetBrains decompiler
// Type: FTOptix.RAEtherNetIP.StationStatusVariables
// Assembly: FTOptix.RAEtherNetIP.Net, Version=2.2.0.11, Culture=neutral, PublicKeyToken=null
// MVID: 626313C4-D37E-4FD2-9B56-0300FEB2B54A
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.RAEtherNetIP.Net\2.2.0.11\Any\FTOptix.RAEtherNetIP.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.RAEtherNetIP
{
  public class StationStatusVariables
  {
    private PropertyGroup stationStatusVariablesObject;

    public StationStatusVariables(PropertyGroup stationStatusVariablesObject)
    {
      this.stationStatusVariablesObject = stationStatusVariablesObject;
    }

    public PropertyGroup Object => this.stationStatusVariablesObject;

    public uint ActiveDataItems
    {
      get
      {
        return (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (ActiveDataItems)).Value;
      }
    }

    public IUAVariable ActiveDataItemsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("ActiveDataItems");
    }

    public uint ActivityCounter
    {
      get
      {
        return (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (ActivityCounter)).Value;
      }
    }

    public IUAVariable ActivityCounterVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("ActivityCounter");
    }

    public string CatalogNumber
    {
      get
      {
        return (string) this.stationStatusVariablesObject.Refs.GetVariable(nameof (CatalogNumber)).Value;
      }
    }

    public IUAVariable CatalogNumberVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("CatalogNumber");
    }

    public string ControllerName
    {
      get
      {
        return (string) this.stationStatusVariablesObject.Refs.GetVariable(nameof (ControllerName)).Value;
      }
    }

    public IUAVariable ControllerNameVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("ControllerName");
    }

    public uint FailedDataItems
    {
      get
      {
        return (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (FailedDataItems)).Value;
      }
    }

    public IUAVariable FailedDataItemsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("FailedDataItems");
    }

    public uint MajorRev
    {
      get => (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (MajorRev)).Value;
    }

    public IUAVariable MajorRevVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("MajorRev");
    }

    public uint MinorRev
    {
      get => (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (MinorRev)).Value;
    }

    public IUAVariable MinorRevVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("MinorRev");
    }

    public string Mode
    {
      get => (string) this.stationStatusVariablesObject.Refs.GetVariable(nameof (Mode)).Value;
    }

    public IUAVariable ModeVariable => this.stationStatusVariablesObject.Refs.GetVariable("Mode");

    public uint OptimizedBlocks
    {
      get
      {
        return (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (OptimizedBlocks)).Value;
      }
    }

    public IUAVariable OptimizedBlocksVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("OptimizedBlocks");
    }

    public string Path
    {
      get => (string) this.stationStatusVariablesObject.Refs.GetVariable(nameof (Path)).Value;
    }

    public IUAVariable PathVariable => this.stationStatusVariablesObject.Refs.GetVariable("Path");

    public bool Present
    {
      get => (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (Present)).Value;
    }

    public IUAVariable PresentVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("Present");
    }

    public uint ProductCode
    {
      get => (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (ProductCode)).Value;
    }

    public IUAVariable ProductCodeVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("ProductCode");
    }

    public uint ProductType
    {
      get => (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (ProductType)).Value;
    }

    public IUAVariable ProductTypeVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("ProductType");
    }

    public bool RecoverableMajorFaults
    {
      get
      {
        return (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (RecoverableMajorFaults)).Value;
      }
    }

    public IUAVariable RecoverableMajorFaultsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("RecoverableMajorFaults");
    }

    public bool RecoverableMinorFaults
    {
      get
      {
        return (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (RecoverableMinorFaults)).Value;
      }
    }

    public IUAVariable RecoverableMinorFaultsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("RecoverableMinorFaults");
    }

    public bool RunMode
    {
      get => (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (RunMode)).Value;
    }

    public IUAVariable RunModeVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("RunMode");
    }

    public bool Synchronized
    {
      get => (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (Synchronized)).Value;
    }

    public IUAVariable SynchronizedVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("Synchronized");
    }

    public string SyncState
    {
      get => (string) this.stationStatusVariablesObject.Refs.GetVariable(nameof (SyncState)).Value;
    }

    public IUAVariable SyncStateVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("SyncState");
    }

    public bool UnrecoverableMajorFaults
    {
      get
      {
        return (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (UnrecoverableMajorFaults)).Value;
      }
    }

    public IUAVariable UnrecoverableMajorFaultsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("UnrecoverableMajorFaults");
    }

    public bool UnrecoverableMinorFaults
    {
      get
      {
        return (bool) this.stationStatusVariablesObject.Refs.GetVariable(nameof (UnrecoverableMinorFaults)).Value;
      }
    }

    public IUAVariable UnrecoverableMinorFaultsVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("UnrecoverableMinorFaults");
    }

    public uint Vendor
    {
      get => (uint) this.stationStatusVariablesObject.Refs.GetVariable(nameof (Vendor)).Value;
    }

    public IUAVariable VendorVariable
    {
      get => this.stationStatusVariablesObject.Refs.GetVariable("Vendor");
    }
  }
}
