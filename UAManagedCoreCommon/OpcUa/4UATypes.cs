// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OpcUa.ObjectTypes
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.OpcUa
{
  public static class ObjectTypes
  {
    public const int FolderTypeId = 61;
    public const int BaseObjectTypeId = 58;
    public const int BaseEventTypeId = 2041;
    public const int ConditionTypeId = 2782;
    public const int AcknowledgeableConditionTypeId = 2881;
    public const int AlarmConditionTypeId = 2915;
    public const int DiscreteAlarmTypeId = 10523;
    public const int OffNormalAlarmTypeId = 10637;
    public const int LimitAlarmTypeId = 2955;
    public const int ExclusiveLimitAlarmTypeId = 9341;
    public const int ExclusiveLevelAlarmTypeId = 9482;
    public const int ExclusiveDeviationAlarmTypeId = 9764;
    public const int ExclusiveRateOfChangeAlarmTypeId = 9623;
    public const int NonExclusiveLimitAlarmTypeId = 9906;
    public const int NonExclusiveLevelAlarmTypeId = 10060;
    public const int NonExclusiveDeviationAlarmTypeId = 10368;
    public const int NonExclusiveRateOfChangeAlarmTypeId = 10214;
    public const int ExclusiveLimitStateMachineTypeId = 9318;
    public const int AuditEventTypeId = 2052;
    public const int AuditUpdateEventTypeId = 2099;
    public const int AuditWriteUpdateEventTypeId = 2100;
    public const int AuditUpdateMethodEventTypeId = 2127;
    public const int AuditConditionEventTypeId = 2790;
    public const int AuditConditionEnableEventTypeId = 2803;
    public const int AuditConditionAcknowledgeEventTypeId = 8944;
    public const int AuditConditionConfirmEventTypeId = 8961;
    public const int AuditConditionCommentEventTypeId = 2829;
    public const int AuditNodeManagementEventTypeId = 2090;
    public const int AuditAddNodesEventTypeId = 2091;
    public const int AuditDeleteNodesEventTypeId = 2093;
    public const int AuditAddReferencesEventTypeId = 2095;
    public const int AuditDeleteReferencesEventTypeId = 2097;
    public const int TransitionEventTypeId = 2311;
    public const int ModellingRuleTypeId = 77;
    public const int StateMachineTypeId = 2299;
    public const int FiniteStateMachineTypeId = 2771;
    public const int StateTypeId = 2307;
    public const int InitialStateTypeId = 2309;
    public const int TransitionTypeId = 2310;
    public const int DataTypeSystemTypeId = 75;
    public const int DataTypeEncodingTypeId = 76;
    public static readonly NodeId FolderType = new NodeId(0, 61U);
    public static readonly NodeId BaseObjectType = new NodeId(0, 58U);
    public static readonly NodeId BaseEventType = new NodeId(0, 2041U);
    public static readonly NodeId ConditionType = new NodeId(0, 2782U);
    public static readonly NodeId AcknowledgeableConditionType = new NodeId(0, 2881U);
    public static readonly NodeId AlarmConditionType = new NodeId(0, 2915U);
    public static readonly NodeId DiscreteAlarmType = new NodeId(0, 10523U);
    public static readonly NodeId OffNormalAlarmType = new NodeId(0, 10637U);
    public static readonly NodeId LimitAlarmType = new NodeId(0, 2955U);
    public static readonly NodeId ExclusiveLimitStateMachineType = new NodeId(0, 9318U);
    public static readonly NodeId ExclusiveLimitAlarmType = new NodeId(0, 9341U);
    public static readonly NodeId ExclusiveLevelAlarmType = new NodeId(0, 9482U);
    public static readonly NodeId ExclusiveDeviationAlarmType = new NodeId(0, 9764U);
    public static readonly NodeId ExclusiveRateOfChangeAlarmType = new NodeId(0, 9623U);
    public static readonly NodeId NonExclusiveLimitAlarmType = new NodeId(0, 9906U);
    public static readonly NodeId NonExclusiveLevelAlarmType = new NodeId(0, 10060U);
    public static readonly NodeId NonExclusiveDeviationAlarmType = new NodeId(0, 10368U);
    public static readonly NodeId NonExclusiveRateOfChangeAlarmType = new NodeId(0, 10214U);
    public static readonly NodeId AuditEventType = new NodeId(0, 2052U);
    public static readonly NodeId AuditUpdateEventType = new NodeId(0, 2099U);
    public static readonly NodeId AuditWriteUpdateEventType = new NodeId(0, 2100U);
    public static readonly NodeId AuditUpdateMethodEventType = new NodeId(0, 2127U);
    public static readonly NodeId AuditConditionEventType = new NodeId(0, 2790U);
    public static readonly NodeId AuditConditionEnableEventType = new NodeId(0, 2803U);
    public static readonly NodeId AuditConditionAcknowledgeEventType = new NodeId(0, 8944U);
    public static readonly NodeId AuditConditionConfirmEventType = new NodeId(0, 8961U);
    public static readonly NodeId AuditConditionCommentEventType = new NodeId(0, 2829U);
    public static readonly NodeId AuditNodeManagementEventType = new NodeId(0, 2090U);
    public static readonly NodeId AuditAddNodesEventType = new NodeId(0, 2091U);
    public static readonly NodeId AuditDeleteNodesEventType = new NodeId(0, 2093U);
    public static readonly NodeId AuditAddReferencesEventType = new NodeId(0, 2095U);
    public static readonly NodeId AuditDeleteReferencesEventType = new NodeId(0, 2097U);
    public static readonly NodeId TransitionEventType = new NodeId(0, 2311U);
    public static readonly NodeId ModellingRuleType = new NodeId(0, 77U);
    public static readonly NodeId StateMachineType = new NodeId(0, 2299U);
    public static readonly NodeId FiniteStateMachineType = new NodeId(0, 2771U);
    public static readonly NodeId StateType = new NodeId(0, 2307U);
    public static readonly NodeId InitialStateType = new NodeId(0, 2309U);
    public static readonly NodeId TransitionType = new NodeId(0, 2310U);
    public static readonly NodeId DataTypeSystemType = new NodeId(0, 75U);
    public static readonly NodeId DataTypeEncodingType = new NodeId(0, 76U);
  }
}
