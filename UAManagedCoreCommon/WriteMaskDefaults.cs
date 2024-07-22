// Decompiled with JetBrains decompiler
// Type: UAManagedCore.WriteMaskDefaults
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public static class WriteMaskDefaults
  {
    public const WriteMask All = WriteMask.AccessLevel | WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.ContainsNoLoop | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.EventNotifier | WriteMask.Executable | WriteMask.Historizing | WriteMask.InverseName | WriteMask.IsAbstract | WriteMask.MinimumSamplingInterval | WriteMask.NodeClass | WriteMask.NodeId | WriteMask.Symmetric | WriteMask.UserAccessLevel | WriteMask.UserExecutable | WriteMask.UserWriteMask | WriteMask.ValueRank | WriteMask.WriteMask;
    public const WriteMask Base = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
    public const WriteMask ObjectDefault = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.EventNotifier | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
    public const WriteMask VariableDefault = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank;
    public const WriteMask MethodDefault = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.Executable | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
    public const WriteMask ObjectTypeDefault = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
    public const WriteMask VariableTypeDefault = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank | WriteMask.ValueForVariableType;
    public const WriteMask ReferenceTypeDefault = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
    public const WriteMask DataTypeDefault = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel;
  }
}
