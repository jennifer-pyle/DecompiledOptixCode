// Decompiled with JetBrains decompiler
// Type: FTOptix.MelsecQ.MemoryArea
// Assembly: FTOptix.MelsecQ.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 82AF5AD0-6CA3-446B-98F5-2FEAD20A318F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.MelsecQ.Net\1.0.8.38\Any\FTOptix.MelsecQ.Net.dll

#nullable disable
namespace FTOptix.MelsecQ
{
  public enum MemoryArea
  {
    InputRelay = 0,
    OutputRelay = 1,
    InternalRelay = 2,
    LatchRelay = 3,
    Annunciator = 4,
    EdgeRelay = 5,
    LinkRelay = 6,
    DataRegister = 7,
    LinkRegister = 8,
    TimerContact = 9,
    TimerCoil = 10, // 0x0000000A
    TimerCurrentValue = 11, // 0x0000000B
    CounterContact = 12, // 0x0000000C
    CounterCoil = 13, // 0x0000000D
    CounterCurrentValue = 14, // 0x0000000E
    SpecialLinkRelay = 15, // 0x0000000F
    SpecialLinkRegister = 16, // 0x00000010
    StepRelay = 17, // 0x00000011
    IndexRegister = 20, // 0x00000014
    FileRegisterR = 21, // 0x00000015
    FileRegisterZR = 22, // 0x00000016
    SpecialRelay = 23, // 0x00000017
    SpecialRegister = 24, // 0x00000018
    RetentiveTimerContact = 25, // 0x00000019
    RetentiveTimerCoil = 26, // 0x0000001A
    RetentiveTimerCurrentValue = 27, // 0x0000001B
  }
}
