// Decompiled with JetBrains decompiler
// Type: UAManagedCore.WriteMask
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Flags]
  public enum WriteMask : uint
  {
    AccessLevel = 1,
    ArrayDimensions = 2,
    BrowseName = 4,
    ContainsNoLoop = 8,
    DataType = 16, // 0x00000010
    Description = 32, // 0x00000020
    DisplayName = 64, // 0x00000040
    EventNotifier = 128, // 0x00000080
    Executable = 256, // 0x00000100
    Historizing = 512, // 0x00000200
    InverseName = 1024, // 0x00000400
    IsAbstract = 2048, // 0x00000800
    MinimumSamplingInterval = 4096, // 0x00001000
    NodeClass = 8192, // 0x00002000
    NodeId = 16384, // 0x00004000
    Symmetric = 32768, // 0x00008000
    UserAccessLevel = 65536, // 0x00010000
    UserExecutable = 131072, // 0x00020000
    UserWriteMask = 262144, // 0x00040000
    ValueRank = 524288, // 0x00080000
    WriteMask = 1048576, // 0x00100000
    ValueForVariableType = 2097152, // 0x00200000
    FirstReserved = 4194304, // 0x00400000
    LastReserved = 2147483648, // 0x80000000
  }
}
