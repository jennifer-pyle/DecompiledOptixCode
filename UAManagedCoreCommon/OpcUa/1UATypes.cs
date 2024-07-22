// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OpcUa.DataTypes
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.OpcUa
{
  public static class DataTypes
  {
    public const int BooleanId = 1;
    public const int SByteId = 2;
    public const int ByteId = 3;
    public const int Int16Id = 4;
    public const int UInt16Id = 5;
    public const int Int32Id = 6;
    public const int UInt32Id = 7;
    public const int Int64Id = 8;
    public const int UInt64Id = 9;
    public const int FloatId = 10;
    public const int DoubleId = 11;
    public const int StringId = 12;
    public const int DateTimeId = 13;
    public const int GuidId = 14;
    public const int ByteStringId = 15;
    public const int NodeIdId = 17;
    public const int ExpandedNodeIdId = 18;
    public const int QualifiedNameId = 20;
    public const int LocalizedTextId = 21;
    public const int StructureId = 22;
    public const int BaseDataTypeId = 24;
    public const int NumberId = 26;
    public const int IntegerId = 27;
    public const int UIntegerId = 28;
    public const int EnumerationId = 29;
    public const int ImageId = 30;
    public const int NamingRuleTypeId = 120;
    public const int NodeClassId = 257;
    public const int DurationId = 290;
    public const int UtcTimeId = 294;
    public const int LocaleIdId = 295;
    public const int ArgumentId = 296;
    public const int AddNodesItemId = 376;
    public const int AddReferencesItemId = 379;
    public const int DeleteNodesItemId = 382;
    public const int DeleteReferencesItemId = 385;
    public const int RangeId = 884;
    public const int EUInformationId = 887;
    public const int ImageBMPId = 2000;
    public const int ImageGIFId = 2001;
    public const int ImageJPGId = 2002;
    public const int ImagePNGId = 2003;
    public const int EnumValueTypeId = 7594;
    public const int TimeZoneDataTypeId = 8912;
    public static readonly NodeId Boolean = new NodeId(0, 1U);
    public static readonly NodeId SByte = new NodeId(0, 2U);
    public static readonly NodeId Byte = new NodeId(0, 3U);
    public static readonly NodeId Int16 = new NodeId(0, 4U);
    public static readonly NodeId UInt16 = new NodeId(0, 5U);
    public static readonly NodeId Int32 = new NodeId(0, 6U);
    public static readonly NodeId UInt32 = new NodeId(0, 7U);
    public static readonly NodeId Int64 = new NodeId(0, 8U);
    public static readonly NodeId UInt64 = new NodeId(0, 9U);
    public static readonly NodeId Float = new NodeId(0, 10U);
    public static readonly NodeId Double = new NodeId(0, 11U);
    public static readonly NodeId String = new NodeId(0, 12U);
    public static readonly NodeId DateTime = new NodeId(0, 13U);
    public static readonly NodeId Guid = new NodeId(0, 14U);
    public static readonly NodeId ByteString = new NodeId(0, 15U);
    public static readonly NodeId NodeId = new NodeId(0, 17U);
    public static readonly NodeId ExpandedNodeId = new NodeId(0, 18U);
    public static readonly NodeId QualifiedName = new NodeId(0, 20U);
    public static readonly NodeId LocalizedText = new NodeId(0, 21U);
    public static readonly NodeId Structure = new NodeId(0, 22U);
    public static readonly NodeId BaseDataType = new NodeId(0, 24U);
    public static readonly NodeId Number = new NodeId(0, 26U);
    public static readonly NodeId Integer = new NodeId(0, 27U);
    public static readonly NodeId UInteger = new NodeId(0, 28U);
    public static readonly NodeId Enumeration = new NodeId(0, 29U);
    public static readonly NodeId Image = new NodeId(0, 30U);
    public static readonly NodeId ImageBMP = new NodeId(0, 2000U);
    public static readonly NodeId ImageGIF = new NodeId(0, 2001U);
    public static readonly NodeId ImageJPG = new NodeId(0, 2002U);
    public static readonly NodeId ImagePNG = new NodeId(0, 2003U);
    public static readonly NodeId NamingRuleType = new NodeId(0, 120U);
    public static readonly NodeId NodeClass = new NodeId(0, 257U);
    public static readonly NodeId Duration = new NodeId(0, 290U);
    public static readonly NodeId UtcTime = new NodeId(0, 294U);
    public static readonly NodeId LocaleId = new NodeId(0, 295U);
    public static readonly NodeId Argument = new NodeId(0, 296U);
    public static readonly NodeId AddNodesItem = new NodeId(0, 376U);
    public static readonly NodeId AddReferencesItem = new NodeId(0, 379U);
    public static readonly NodeId DeleteReferencesItem = new NodeId(0, 385U);
    public static readonly NodeId DeleteNodesItem = new NodeId(0, 382U);
    public static readonly NodeId EUInformation = new NodeId(0, 887U);
    public static readonly NodeId Range = new NodeId(0, 884U);
    public static readonly NodeId EnumValueType = new NodeId(0, 7594U);
    public static readonly NodeId TimeZoneDataType = new NodeId(0, 8912U);
  }
}
