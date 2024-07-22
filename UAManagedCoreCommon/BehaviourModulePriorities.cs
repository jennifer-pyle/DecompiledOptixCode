// Decompiled with JetBrains decompiler
// Type: UAManagedCore.BehaviourModulePriorities
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public enum BehaviourModulePriorities : byte
  {
    Unspecified = 0,
    Default = 1,
    RuntimeMin = 1,
    Project = 3,
    NetLogic = 4,
    UICommands = 5,
    UIObjects = 6,
    UISession = 7,
    UIPresentationEngine = 8,
    System = 9,
    EventGenerator = 10, // 0x0A
    Alarms = 15, // 0x0F
    NetScript = 20, // 0x14
    OPCUAServer = 30, // 0x1E
    Report = 32, // 0x20
    EventLogger = 35, // 0x23
    DataLogger = 40, // 0x28
    Recipe = 45, // 0x2D
    Table = 50, // 0x32
    Store = 51, // 0x33
    RetainedAlarms = 71, // 0x47
    AllAlarms = 72, // 0x48
    OPCUAClient = 75, // 0x4B
    OPCUAClientController = 78, // 0x4E
    ConcreteDrivers = 80, // 0x50
    CommunicationDrivers = 90, // 0x5A
    CommController = 95, // 0x5F
    StateMachine = 100, // 0x64
    Retentivity = 110, // 0x6E
    EventHandler = 113, // 0x71
    EUInformation = 120, // 0x78
    Range = 121, // 0x79
    Converter = 125, // 0x7D
    DataBind = 125, // 0x7D
    Commands = 170, // 0xAA
    VariableCommands = 170, // 0xAA
    CoreContext = 171, // 0xAB
    RuntimeMax = 179, // 0xB3
    DesignTimeMin = 180, // 0xB4
    DesignTimeMax = 255, // 0xFF
  }
}
