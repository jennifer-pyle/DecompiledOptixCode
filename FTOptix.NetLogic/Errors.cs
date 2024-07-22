// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.Error
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

//#nullable disable
namespace FTOptix.NetLogic
{
  internal enum Error : ushort
  {
    LoadingLogicFromNetAssemblyFailed = 1,
    InvokingLogicMethodInNetAssemblyFailed = 2,
    NetLogicStartMethodFailed = 3,
    NetLogicStopMethodFailed = 4,
    NetAssemblyNotFound = 5,
    DisposingNetLogicFailed = 6,
    NetLogicStartTakesTooLongToExecute = 7,
    NetLogicMethodTakesTooLongToExecute = 8,
    MissingLogicTypeInNetAssembly = 9,
  }
}
