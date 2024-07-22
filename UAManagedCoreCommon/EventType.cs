// Decompiled with JetBrains decompiler
// Type: UAManagedCore.EventType
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  [Flags]
  public enum EventType : ulong
  {
    FirstEvent = 1,
    AccessLevelChanged = FirstEvent, // 0x0000000000000001
    ArrayDimensionsChanged = 2,
    BrowseNameChanged = 4,
    ContainsNoLoopsChanged = 8,
    DataTypeChanged = 16, // 0x0000000000000010
    DescriptionChanged = 32, // 0x0000000000000020
    DisplayNameChanged = 64, // 0x0000000000000040
    EventNotifierChanged = 128, // 0x0000000000000080
    ExecutableChanged = 256, // 0x0000000000000100
    HistorizingChanged = 512, // 0x0000000000000200
    InverseNameChanged = 1024, // 0x0000000000000400
    IsAbstractChanged = 2048, // 0x0000000000000800
    MinimumSamplingIntervalChanged = 4096, // 0x0000000000001000
    NodeClassChanged = 8192, // 0x0000000000002000
    NodeIdChanged = 16384, // 0x0000000000004000
    SymmetricChanged = 32768, // 0x0000000000008000
    UserAccessLevelChanged = 65536, // 0x0000000000010000
    UserExecutableChanged = 131072, // 0x0000000000020000
    UserWriteMaskChanged = 262144, // 0x0000000000040000
    ValueRankChanged = 524288, // 0x0000000000080000
    WriteMaskChanged = 1048576, // 0x0000000000100000
    ValueForVariableTypeChanged = 2097152, // 0x0000000000200000
    ActualDataTypeChanged = 4194304, // 0x0000000000400000
    ActualArrayDimensionsChanged = 8388608, // 0x0000000000800000
    FirstReserved = 16777216, // 0x0000000001000000
    LastReserved = 2147483648, // 0x0000000080000000
    NodeAttached = 4294967296, // 0x0000000100000000
    NodeDetached = 8589934592, // 0x0000000200000000
    ForwardReferenceAdded = 17179869184, // 0x0000000400000000
    ForwardReferenceRemoved = 34359738368, // 0x0000000800000000
    InverseReferenceAdded = 68719476736, // 0x0000001000000000
    InverseReferenceRemoved = 137438953472, // 0x0000002000000000
    ForwardReferenceMoved = 274877906944, // 0x0000004000000000
    VariableValueChanged = 549755813888, // 0x0000008000000000
    UAEvent = 1099511627776, // 0x0000010000000000
    LastEvent = UAEvent, // 0x0000010000000000
    AllAttributeChangeEvents = 18446744073709551615, // 0xFFFFFFFFFFFFFFFF
    AllEvents = 2199023255551, // 0x000001FFFFFFFFFF
    SupportedAttributeChanged = ActualDataTypeChanged | ValueForVariableTypeChanged | WriteMaskChanged | ValueRankChanged | UserWriteMaskChanged | UserExecutableChanged | UserAccessLevelChanged | SymmetricChanged | NodeIdChanged | NodeClassChanged | MinimumSamplingIntervalChanged | IsAbstractChanged | InverseNameChanged | HistorizingChanged | ExecutableChanged | EventNotifierChanged | DisplayNameChanged | DescriptionChanged | DataTypeChanged | ContainsNoLoopsChanged | BrowseNameChanged | ArrayDimensionsChanged | AccessLevelChanged, // 0x00000000007FFFFF
    ForwardReferenceChanged = ForwardReferenceRemoved | ForwardReferenceAdded, // 0x0000000C00000000
    InverseReferenceChanged = InverseReferenceRemoved | InverseReferenceAdded, // 0x0000003000000000
    ReferenceChanged = InverseReferenceChanged | ForwardReferenceChanged, // 0x0000003C00000000
    PathResolverSupportedAttributes = DisplayNameChanged | DescriptionChanged | BrowseNameChanged, // 0x0000000000000064
  }
}
