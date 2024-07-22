// Decompiled with JetBrains decompiler
// Type: UAManagedCore.XMLSerializer
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class XMLSerializer
  {
    private static Dictionary<NodeId, Func<UAValue, string>> builtInSerializer = new Dictionary<NodeId, Func<UAValue, string>>()
    {
      {
        DataTypes.SByte,
        (Func<UAValue, string>) (v => XmlConvert.ToString((sbyte) v))
      },
      {
        DataTypes.Int16,
        (Func<UAValue, string>) (v => XmlConvert.ToString((short) v))
      },
      {
        DataTypes.Int32,
        (Func<UAValue, string>) (v => XmlConvert.ToString((int) v))
      },
      {
        DataTypes.Int64,
        (Func<UAValue, string>) (v => XmlConvert.ToString((long) v))
      },
      {
        DataTypes.Byte,
        (Func<UAValue, string>) (v => XmlConvert.ToString((byte) v))
      },
      {
        DataTypes.UInt16,
        (Func<UAValue, string>) (v => XmlConvert.ToString((ushort) v))
      },
      {
        DataTypes.UInt32,
        (Func<UAValue, string>) (v => XmlConvert.ToString((uint) v))
      },
      {
        DataTypes.UInt64,
        (Func<UAValue, string>) (v => XmlConvert.ToString((ulong) v))
      },
      {
        DataTypes.Boolean,
        (Func<UAValue, string>) (v => XmlConvert.ToString((bool) v))
      },
      {
        DataTypes.Float,
        (Func<UAValue, string>) (v => XmlConvert.ToString((float) v))
      },
      {
        DataTypes.Double,
        (Func<UAValue, string>) (v => XmlConvert.ToString((double) v))
      },
      {
        DataTypes.String,
        (Func<UAValue, string>) (v => (string) v)
      },
      {
        DataTypes.NodeId,
        (Func<UAValue, string>) (v => XMLSerializer.SerializeNodeId((NodeId) v))
      },
      {
        DataTypes.DateTime,
        (Func<UAValue, string>) (v => ((DateTime) v).ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"))
      },
      {
        DataTypes.Guid,
        (Func<UAValue, string>) (v => XmlConvert.ToString((Guid) v))
      },
      {
        DataTypes.ByteString,
        (Func<UAValue, string>) (v => Convert.ToBase64String(((ByteString) v).Bytes))
      },
      {
        DataTypes.QualifiedName,
        (Func<UAValue, string>) (v => XMLSerializer.SerializeQualifiedName((QualifiedName) v))
      }
    };
    private static Dictionary<NodeId, Func<string, UAValue>> builtInDeserializer = new Dictionary<NodeId, Func<string, UAValue>>()
    {
      {
        DataTypes.SByte,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToSByte(s))
      },
      {
        DataTypes.Int16,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToInt16(s))
      },
      {
        DataTypes.Int32,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToInt32(s))
      },
      {
        DataTypes.Int64,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToInt64(s))
      },
      {
        DataTypes.Byte,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToByte(s))
      },
      {
        DataTypes.UInt16,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToUInt16(s))
      },
      {
        DataTypes.UInt32,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToUInt32(s))
      },
      {
        DataTypes.UInt64,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToUInt64(s))
      },
      {
        DataTypes.Boolean,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToBoolean(s))
      },
      {
        DataTypes.Float,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToSingle(s))
      },
      {
        DataTypes.Double,
        (Func<string, UAValue>) (s => (UAValue) XmlConvert.ToDouble(s))
      },
      {
        DataTypes.String,
        (Func<string, UAValue>) (s => (UAValue) s)
      },
      {
        DataTypes.NodeId,
        (Func<string, UAValue>) (s => (UAValue) XMLSerializer.DeserializeNodeId(s))
      },
      {
        DataTypes.DateTime,
        (Func<string, UAValue>) (s => (UAValue) DateTime.ParseExact(s, "yyyy-MM-ddTHH:mm:ss.fffffffZ", (IFormatProvider) null))
      },
      {
        DataTypes.Guid,
        (Func<string, UAValue>) (s => (UAValue) new Guid(s))
      },
      {
        DataTypes.ByteString,
        (Func<string, UAValue>) (s => (UAValue) new ByteString(Convert.FromBase64String(s)))
      },
      {
        DataTypes.QualifiedName,
        (Func<string, UAValue>) (s => (UAValue) XMLSerializer.DeserializeQualifiedName(s))
      }
    };

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string Serialize(UAValue value, NodeId dataTypeNodeId)
    {
      if (!XMLSerializer.builtInSerializer.ContainsKey(dataTypeNodeId))
        throw new NotSupportedException("Serialization of data type {" + dataTypeNodeId?.ToString() + "} is not supported");
      return XMLSerializer.builtInSerializer[dataTypeNodeId](value);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static UAValue Deserialize(string xmlString, NodeId dataTypeNodeId)
    {
      if (!XMLSerializer.builtInSerializer.ContainsKey(dataTypeNodeId))
        throw new NotSupportedException("Deserialization of data type {" + dataTypeNodeId?.ToString() + "} is not supported");
      return XMLSerializer.builtInDeserializer[dataTypeNodeId](xmlString);
    }

    private static string SerializeNodeId(NodeId nodeId)
    {
      return "ns=" + nodeId.NamespaceIndex.ToString() + ";" + nodeId.IdTypeShortString + "=" + XMLSerializer.SerializeNodeIdIdentifier(nodeId.IdType, nodeId.Id);
    }

    private static string SerializeNodeIdIdentifier(IdType idType, object id)
    {
      switch (idType)
      {
        case IdType.String:
          return (string) id;
        case IdType.Guid:
          return XmlConvert.ToString((Guid) id);
        case IdType.UInt32:
          return XmlConvert.ToString((uint) id);
        case IdType.ByteArray:
          return Convert.ToBase64String(((ByteString) id).Bytes);
        default:
          throw new NotSupportedException("Serialization of NodeId type '" + idType.ToString() + "' is not supported");
      }
    }

    private static string SerializeQualifiedName(QualifiedName name)
    {
      return string.Format("<QualifiedName><NamespaceIndex>{0}</NamespaceIndex><Name>{1}</Name></QualifiedName>", (object) XmlConvert.ToString(name.NamespaceIndex), (object) name.Name);
    }

    private static NodeId DeserializeNodeId(string xmlString)
    {
      return NodeIdHelper.FromFormat("{NodeId:" + xmlString + "}");
    }

    private static QualifiedName DeserializeQualifiedName(string xmlString)
    {
      int namespaceIndex = NodeId.InvalidNamespaceIndex;
      string name = "";
      using (StringReader input = new StringReader(xmlString))
      {
        using (XmlReader xmlReader = XmlReader.Create((TextReader) input))
        {
          xmlReader.Read();
          xmlReader.Read();
          xmlReader.Read();
          namespaceIndex = xmlReader.NodeType == XmlNodeType.Text ? XmlConvert.ToInt32(xmlReader.Value) : throw new InvalidOperationException("Invalid QualifiedName XML serialization string");
          xmlReader.Read();
          xmlReader.Read();
          xmlReader.Read();
          name = xmlReader.NodeType == XmlNodeType.Text ? xmlReader.Value : throw new InvalidOperationException("Invalid QualifiedName XML serialization string");
        }
      }
      return new QualifiedName(namespaceIndex, name);
    }
  }
}
