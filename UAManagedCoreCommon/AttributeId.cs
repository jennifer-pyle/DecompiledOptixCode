// Decompiled with JetBrains decompiler
// Type: UAManagedCore.AttributeId
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public enum AttributeId : uint
  {
    NodeId = 1,
    NodeClass = 2,
    BrowseName = 3,
    DisplayName = 4,
    Description = 5,
    WriteMask = 6,
    UserWriteMask = 7,
    IsAbstract = 8,
    Symmetric = 9,
    InverseName = 10, // 0x0000000A
    ContainsNoLoops = 11, // 0x0000000B
    EventNotifier = 12, // 0x0000000C
    Value = 13, // 0x0000000D
    DataType = 14, // 0x0000000E
    ValueRank = 15, // 0x0000000F
    ArrayDimensions = 16, // 0x00000010
    AccessLevel = 17, // 0x00000011
    UserAccessLevel = 18, // 0x00000012
    MinimumSamplingInterval = 19, // 0x00000013
    Historizing = 20, // 0x00000014
    Executable = 21, // 0x00000015
    UserExecutable = 22, // 0x00000016
    ActualDataType = 23, // 0x00000017
    ActualArrayDimensions = 24, // 0x00000018
    BrowsePath = 64, // 0x00000040
    Quality = 65, // 0x00000041
    StatusCode = 66, // 0x00000042
    SourceTimestamp = 67, // 0x00000043
    ServerTimestamp = 68, // 0x00000044
  }
}
