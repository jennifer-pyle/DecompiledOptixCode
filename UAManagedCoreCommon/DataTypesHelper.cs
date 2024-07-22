// Decompiled with JetBrains decompiler
// Type: UAManagedCore.DataTypesHelper
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

#nullable enable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class DataTypesHelper
  {
    private static readonly 
    #nullable disable
    Dictionary<string, NodeId> DataTypeNameToDataTypeId = new Dictionary<string, NodeId>()
    {
      {
        "BaseDataType",
        UAManagedCore.OpcUa.DataTypes.BaseDataType
      },
      {
        "Boolean",
        UAManagedCore.OpcUa.DataTypes.Boolean
      },
      {
        "Number",
        UAManagedCore.OpcUa.DataTypes.Number
      },
      {
        "Double",
        UAManagedCore.OpcUa.DataTypes.Double
      },
      {
        "Float",
        UAManagedCore.OpcUa.DataTypes.Float
      },
      {
        "Integer",
        UAManagedCore.OpcUa.DataTypes.Integer
      },
      {
        "Int16",
        UAManagedCore.OpcUa.DataTypes.Int16
      },
      {
        "Int32",
        UAManagedCore.OpcUa.DataTypes.Int32
      },
      {
        "Int64",
        UAManagedCore.OpcUa.DataTypes.Int64
      },
      {
        "SByte",
        UAManagedCore.OpcUa.DataTypes.SByte
      },
      {
        "UInteger",
        UAManagedCore.OpcUa.DataTypes.UInteger
      },
      {
        "Byte",
        UAManagedCore.OpcUa.DataTypes.Byte
      },
      {
        "UInt16",
        UAManagedCore.OpcUa.DataTypes.UInt16
      },
      {
        "UInt32",
        UAManagedCore.OpcUa.DataTypes.UInt32
      },
      {
        "UInt64",
        UAManagedCore.OpcUa.DataTypes.UInt64
      },
      {
        "DateTime",
        UAManagedCore.OpcUa.DataTypes.DateTime
      },
      {
        "UtcTime",
        UAManagedCore.OpcUa.DataTypes.DateTime
      },
      {
        "Guid",
        UAManagedCore.OpcUa.DataTypes.Guid
      },
      {
        "String",
        UAManagedCore.OpcUa.DataTypes.String
      },
      {
        "ByteString",
        UAManagedCore.OpcUa.DataTypes.ByteString
      },
      {
        "NodeId",
        UAManagedCore.OpcUa.DataTypes.NodeId
      },
      {
        "Enumeration",
        UAManagedCore.OpcUa.DataTypes.Enumeration
      },
      {
        "LocalizedText",
        UAManagedCore.OpcUa.DataTypes.LocalizedText
      },
      {
        "Structure",
        UAManagedCore.OpcUa.DataTypes.Structure
      },
      {
        "LocaleId",
        UAManagedCore.OpcUa.DataTypes.LocaleId
      },
      {
        "NodePath",
        UAManagedCore.Ext.DataTypes.NodePath
      }
    };
    private static readonly Dictionary<Type, string> NetTypeToDataTypeName = new Dictionary<Type, string>()
    {
      {
        typeof (object),
        "BaseDataType"
      },
      {
        typeof (bool),
        "Boolean"
      },
      {
        typeof (double),
        "Double"
      },
      {
        typeof (float),
        "Float"
      },
      {
        typeof (short),
        "Int16"
      },
      {
        typeof (int),
        "Int32"
      },
      {
        typeof (long),
        "Int64"
      },
      {
        typeof (sbyte),
        "SByte"
      },
      {
        typeof (byte),
        "Byte"
      },
      {
        typeof (ushort),
        "UInt16"
      },
      {
        typeof (uint),
        "UInt32"
      },
      {
        typeof (ulong),
        "UInt64"
      },
      {
        typeof (DateTime),
        "DateTime"
      },
      {
        typeof (Guid),
        "Guid"
      },
      {
        typeof (string),
        "String"
      },
      {
        typeof (ByteString),
        "ByteString"
      },
      {
        typeof (NodeId),
        "NodeId"
      },
      {
        typeof (LocalizedText),
        "LocalizedText"
      },
      {
        typeof (Struct),
        "Structure"
      }
    };
    private static readonly Dictionary<string, Type> DataTypeNameToNetType = new Dictionary<string, Type>()
    {
      {
        "BaseDataType",
        typeof (object)
      },
      {
        "Boolean",
        typeof (bool)
      },
      {
        "Double",
        typeof (double)
      },
      {
        "Float",
        typeof (float)
      },
      {
        "Int16",
        typeof (short)
      },
      {
        "Int32",
        typeof (int)
      },
      {
        "Int64",
        typeof (long)
      },
      {
        "SByte",
        typeof (sbyte)
      },
      {
        "Byte",
        typeof (byte)
      },
      {
        "UInt16",
        typeof (ushort)
      },
      {
        "UInt32",
        typeof (uint)
      },
      {
        "UInt64",
        typeof (ulong)
      },
      {
        "DateTime",
        typeof (DateTime)
      },
      {
        "UtcTime",
        typeof (DateTime)
      },
      {
        "Guid",
        typeof (Guid)
      },
      {
        "String",
        typeof (string)
      },
      {
        "ByteString",
        typeof (ByteString)
      },
      {
        "NodeId",
        typeof (NodeId)
      },
      {
        "LocalizedText",
        typeof (LocalizedText)
      },
      {
        "Structure",
        typeof (Struct)
      },
      {
        "LocaleId",
        typeof (string)
      },
      {
        "NodePath",
        typeof (string)
      }
    };
    private static readonly Dictionary<Type, NodeId> NetTypeToDataType = DataTypesHelper.NetTypeToDataTypeName.ToDictionary<KeyValuePair<Type, string>, Type, NodeId>((Func<KeyValuePair<Type, string>, Type>) (kvp => kvp.Key), (Func<KeyValuePair<Type, string>, NodeId>) (kvp => DataTypesHelper.DataTypeNameToDataTypeId[kvp.Value]));
    private static readonly Dictionary<NodeId, Type> DataTypeIdToNetType = DataTypesHelper.NetTypeToDataType.ToDictionary<KeyValuePair<Type, NodeId>, NodeId, Type>((Func<KeyValuePair<Type, NodeId>, NodeId>) (kvp => kvp.Value), (Func<KeyValuePair<Type, NodeId>, Type>) (kvp => kvp.Key));

    internal static void AddMappedDataType(Type type, NodeId nodeId)
    {
      string fullName = type.FullName;
      if (!DataTypesHelper.DataTypeNameToDataTypeId.ContainsKey(fullName))
        DataTypesHelper.DataTypeNameToDataTypeId.Add(fullName, nodeId);
      if (!DataTypesHelper.DataTypeNameToNetType.ContainsKey(fullName))
        DataTypesHelper.DataTypeNameToNetType.Add(fullName, type);
      if (!DataTypesHelper.NetTypeToDataType.ContainsKey(type))
        DataTypesHelper.NetTypeToDataType.Add(type, nodeId);
      if (!DataTypesHelper.NetTypeToDataTypeName.ContainsKey(type))
        DataTypesHelper.NetTypeToDataTypeName.Add(type, fullName);
      if (DataTypesHelper.DataTypeIdToNetType.ContainsKey(nodeId))
        return;
      DataTypesHelper.DataTypeIdToNetType.Add(nodeId, type);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId GetDataTypeIdByName(string dataTypeName)
    {
      NodeId nodeId;
      return !DataTypesHelper.DataTypeNameToDataTypeId.TryGetValue(dataTypeName, out nodeId) ? (NodeId) null : nodeId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string GetDataTypeNameByNetType(TypeInfo typeInfo)
    {
      string str;
      return !DataTypesHelper.NetTypeToDataTypeName.TryGetValue((Type) typeInfo, out str) ? (string) null : str;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Type GetNetTypeByDataTypeName(string dataTypeName)
    {
      Type type;
      return !DataTypesHelper.DataTypeNameToNetType.TryGetValue(dataTypeName, out type) ? (Type) null : type;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId GetDataTypeIdByNetType(Type type)
    {
      NodeId nodeId;
      return !DataTypesHelper.NetTypeToDataType.TryGetValue(type, out nodeId) ? (NodeId) null : nodeId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Type GetNetTypeByDataTypeId(NodeId dataTypeId)
    {
      Type type;
      return !DataTypesHelper.DataTypeIdToNetType.TryGetValue(dataTypeId, out type) ? (Type) null : type;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool IsAbstractDataType(string dataTypeName)
    {
      return DataTypesHelper.GetNetTypeByDataTypeName(dataTypeName) == (Type) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool TryConvert(string dataType, string value)
    {
      return DataTypesHelper.TryConvert(dataType, value, out object _);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool TryConvert(string dataType, string value, out object result)
    {
      Type typeByDataTypeName = DataTypesHelper.GetNetTypeByDataTypeName(dataType);
      try
      {
        result = Convert.ChangeType((object) value, typeByDataTypeName, (IFormatProvider) CultureInfo.InvariantCulture);
        return true;
      }
      catch (Exception ex)
      {
        result = (object) null;
        return false;
      }
    }
  }
}
