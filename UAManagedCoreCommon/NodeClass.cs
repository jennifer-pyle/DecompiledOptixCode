// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NodeClass
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public enum NodeClass
  {
    Unspecified = 0,
    Object = 1,
    Variable = 2,
    Method = 4,
    ObjectType = 8,
    VariableType = 16, // 0x00000010
    ReferenceType = 32, // 0x00000020
    DataType = 64, // 0x00000040
    View = 128, // 0x00000080
  }
}
