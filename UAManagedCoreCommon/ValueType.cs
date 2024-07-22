// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ValueType
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  internal enum ValueType : byte
  {
    Null = 0,
    FirstIntegral = 1,
    Int8 = 1,
    Int16 = 2,
    Int32 = 3,
    Int64 = 4,
    UInt8 = 5,
    UInt16 = 6,
    UInt32 = 7,
    UInt64 = 8,
    Bool = 9,
    Float = 10, // 0x0A
    Double = 11, // 0x0B
    LastIntegral = 11, // 0x0B
    String = 12, // 0x0C
    NodeId = 13, // 0x0D
    DateTime = 14, // 0x0E
    Guid = 15, // 0x0F
    ByteString = 16, // 0x10
    QualifiedName = 17, // 0x11
    ExpandedNodeId = 18, // 0x12
    LocalizedText = 19, // 0x13
    Struct = 20, // 0x14
    Enumeration = 21, // 0x15
    StatusCode = 22, // 0x16
    FirstArray = 23, // 0x17
    FirstIntegralArray = 23, // 0x17
    Int8Array = 23, // 0x17
    Int16Array = 24, // 0x18
    Int32Array = 25, // 0x19
    Int64Array = 26, // 0x1A
    UInt8Array = 27, // 0x1B
    UInt16Array = 28, // 0x1C
    UInt32Array = 29, // 0x1D
    UInt64Array = 30, // 0x1E
    BoolArray = 31, // 0x1F
    FloatArray = 32, // 0x20
    DoubleArray = 33, // 0x21
    LastIntegralArray = 33, // 0x21
    StringArray = 34, // 0x22
    NodeIdArray = 35, // 0x23
    DateTimeArray = 36, // 0x24
    GuidArray = 37, // 0x25
    QualifiedNameArray = 38, // 0x26
    ExpandedNodeIdArray = 39, // 0x27
    LocalizedTextArray = 40, // 0x28
    StructArray = 41, // 0x29
    EnumerationArray = 42, // 0x2A
    StatusCodeArray = 43, // 0x2B
    LastArray = 44, // 0x2C
    ValueArray = 44, // 0x2C
    LastType = 45, // 0x2D
  }
}
