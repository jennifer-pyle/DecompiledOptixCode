// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Ext.ObjectTypes
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.Ext
{
  public static class ObjectTypes
  {
    public const int ConverterId = 16;
    public const int EUConverterId = 3;
    public const int LinearConverterId = 104;
    public const int EventHandlerId = 1;
    public const int UserId = 14;
    public const int RootUserId = 15;
    public const int SessionId = 16;
    public const int GroupId = 17;
    public const int RoleId = 18;
    public const int VariableGroupTypeId = 19;
    public const int DataModelId = 20;
    public const int DataLogId = 21;
    public const int SchedulerId = 22;
    public const int CommandGroupId = 23;
    public const int LocalizationDictionariesTypeId = 97;
    public const int NodeLoaderId = 125;
    public static readonly NodeId Converter = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase"), 16U);
    public static readonly NodeId EUConverter = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase"), 3U);
    public static readonly NodeId LinearConverter = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase"), 104U);
    public static readonly NodeId EventHandler = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase"), 1U);
    public static readonly NodeId User = new NodeId(2, 14U);
    public static readonly NodeId RootUser = new NodeId(2, 15U);
    public static readonly NodeId Session = new NodeId(2, 16U);
    public static readonly NodeId Group = new NodeId(2, 17U);
    public static readonly NodeId Role = new NodeId(2, 18U);
    public static readonly NodeId VariableGroupType = new NodeId(2, 19U);
    public static readonly NodeId DataModel = new NodeId(2, 20U);
    public static readonly NodeId DataLog = new NodeId(2, 21U);
    public static readonly NodeId Scheduler = new NodeId(2, 22U);
    public static readonly NodeId CommandGroup = new NodeId(2, 23U);
    public static readonly NodeId LocalizationDictionariesType = new NodeId(2, 97U);
    public static readonly NodeId NodeLoader = new NodeId(2, 125U);
  }
}
