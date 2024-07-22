// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Ext.VariableTypes
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.Ext
{
  public static class VariableTypes
  {
    public const int RightTypeId = 2;
    public const int UserBasedRightTypeId = 3;
    public const int FilePathId = 40;
    public const int BehaviourStartPriorityTypeId = 41;
    public const int AliasId = 43;
    public const int LocalizationDictionaryId = 42;
    public const int BehaviourStartPriorityVariableTypeId = 41;
    public const int EUInformationTypeId = 4;
    public const int NodePointerId = 121;
    public static readonly NodeId RightType = new NodeId(2, 2U);
    public static readonly NodeId UserBasedRightType = new NodeId(2, 3U);
    public static readonly NodeId FilePath = new NodeId(2, 40U);
    public static readonly NodeId BehaviourStartPriorityType = new NodeId(2, 41U);
    public static readonly NodeId Alias = new NodeId(2, 43U);
    public static readonly NodeId LocalizationDictionary = new NodeId(2, 42U);
    public static readonly NodeId BehaviourStartPriorityVariableType = new NodeId(2, 41U);
    public static readonly NodeId EUInformationType = new NodeId(2, 4U);
    public static readonly NodeId NodePointer = new NodeId(2, 121U);
  }
}
