// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAValue
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  public class UAValue
  {
    private static readonly Dictionary<Type, ValueType> typeToEnum = new Dictionary<Type, ValueType>()
    {
      {
        typeof (sbyte),
        ValueType.FirstIntegral
      },
      {
        typeof (short),
        ValueType.Int16
      },
      {
        typeof (int),
        ValueType.Int32
      },
      {
        typeof (long),
        ValueType.Int64
      },
      {
        typeof (byte),
        ValueType.UInt8
      },
      {
        typeof (ushort),
        ValueType.UInt16
      },
      {
        typeof (uint),
        ValueType.UInt32
      },
      {
        typeof (ulong),
        ValueType.UInt64
      },
      {
        typeof (bool),
        ValueType.Bool
      },
      {
        typeof (float),
        ValueType.Float
      },
      {
        typeof (double),
        ValueType.Double
      },
      {
        typeof (string),
        ValueType.String
      },
      {
        typeof (NodeId),
        ValueType.NodeId
      },
      {
        typeof (DateTime),
        ValueType.DateTime
      },
      {
        typeof (Guid),
        ValueType.Guid
      },
      {
        typeof (Struct),
        ValueType.Struct
      },
      {
        typeof (ByteString),
        ValueType.ByteString
      },
      {
        typeof (QualifiedName),
        ValueType.QualifiedName
      },
      {
        typeof (ExpandedNodeId),
        ValueType.ExpandedNodeId
      },
      {
        typeof (LocalizedText),
        ValueType.LocalizedText
      },
      {
        typeof (sbyte[]),
        ValueType.FirstArray
      },
      {
        typeof (short[]),
        ValueType.Int16Array
      },
      {
        typeof (int[]),
        ValueType.Int32Array
      },
      {
        typeof (long[]),
        ValueType.Int64Array
      },
      {
        typeof (byte[]),
        ValueType.UInt8Array
      },
      {
        typeof (ushort[]),
        ValueType.UInt16Array
      },
      {
        typeof (uint[]),
        ValueType.UInt32Array
      },
      {
        typeof (ulong[]),
        ValueType.UInt64Array
      },
      {
        typeof (bool[]),
        ValueType.BoolArray
      },
      {
        typeof (float[]),
        ValueType.FloatArray
      },
      {
        typeof (double[]),
        ValueType.DoubleArray
      },
      {
        typeof (string[]),
        ValueType.StringArray
      },
      {
        typeof (NodeId[]),
        ValueType.NodeIdArray
      },
      {
        typeof (DateTime[]),
        ValueType.DateTimeArray
      },
      {
        typeof (Guid[]),
        ValueType.GuidArray
      },
      {
        typeof (Struct[]),
        ValueType.StructArray
      },
      {
        typeof (QualifiedName[]),
        ValueType.QualifiedNameArray
      },
      {
        typeof (ExpandedNodeId[]),
        ValueType.ExpandedNodeIdArray
      },
      {
        typeof (LocalizedText[]),
        ValueType.LocalizedTextArray
      },
      {
        typeof (object[]),
        ValueType.ValueArray
      }
    };
    public static readonly UAValue Null = new UAValue(ValueType.Null, (object) null);
    private object value;
    private readonly ValueType type;

    public UAValue(object value)
    {
      if (value == null)
      {
        this.type = ValueType.Null;
      }
      else
      {
        Type type = value.GetType();
        if (!this.TryGetValueType(type, out this.type) && !this.TryGetMultidimensionalArrayValueType(type, out this.type))
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
          interpolatedStringHandler.AppendLiteral("Invalid value type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("' for value '");
          interpolatedStringHandler.AppendFormatted<object>(value);
          interpolatedStringHandler.AppendLiteral("'");
          throw new ArgumentException(interpolatedStringHandler.ToStringAndClear());
        }
      }
      this.value = value;
    }

    private bool TryGetValueType(Type type, out ValueType valueType)
    {
      if (UAValue.typeToEnum.TryGetValue(type, out valueType))
        return true;
      if (typeof (Struct).IsAssignableFrom(type))
      {
        valueType = ValueType.Struct;
        return true;
      }
      if (typeof (Struct[]).IsAssignableFrom(type))
      {
        valueType = ValueType.StructArray;
        return true;
      }
      valueType = ValueType.Null;
      return false;
    }

    private bool TryGetMultidimensionalArrayValueType(Type type, out ValueType valueType)
    {
      if (type.IsArray && type.GetArrayRank() > 1 && this.TryGetValueType(type.GetElementType()?.MakeArrayType(), out valueType))
        return true;
      valueType = ValueType.Null;
      return false;
    }

    private UAValue(ValueType type, object value)
    {
      this.type = type;
      this.value = value;
    }

    public UAValue()
      : this(ValueType.Null, (object) null)
    {
    }

    public UAValue(sbyte value)
      : this(ValueType.FirstIntegral, (object) value)
    {
    }

    public UAValue(short value)
      : this(ValueType.Int16, (object) value)
    {
    }

    public UAValue(int value)
      : this(ValueType.Int32, (object) value)
    {
    }

    public UAValue(long value)
      : this(ValueType.Int64, (object) value)
    {
    }

    public UAValue(byte value)
      : this(ValueType.UInt8, (object) value)
    {
    }

    public UAValue(ushort value)
      : this(ValueType.UInt16, (object) value)
    {
    }

    public UAValue(uint value)
      : this(ValueType.UInt32, (object) value)
    {
    }

    public UAValue(ulong value)
      : this(ValueType.UInt64, (object) value)
    {
    }

    public UAValue(bool value)
      : this(ValueType.Bool, (object) value)
    {
    }

    public UAValue(float value)
      : this(ValueType.Float, (object) value)
    {
    }

    public UAValue(double value)
      : this(ValueType.Double, (object) value)
    {
    }

    public UAValue(string value)
      : this(ValueType.String, (object) value)
    {
    }

    public UAValue(NodeId value)
      : this(ValueType.NodeId, (object) value)
    {
    }

    public UAValue(DateTime value)
      : this(ValueType.DateTime, (object) value)
    {
    }

    public UAValue(Guid value)
      : this(ValueType.Guid, (object) value)
    {
    }

    public UAValue(ByteString value)
      : this(ValueType.ByteString, (object) value)
    {
    }

    public UAValue(QualifiedName value)
      : this(ValueType.QualifiedName, (object) value)
    {
    }

    public UAValue(ExpandedNodeId value)
      : this(ValueType.ExpandedNodeId, (object) value)
    {
    }

    public UAValue(LocalizedText value)
      : this(ValueType.LocalizedText, (object) value)
    {
    }

    public UAValue(Struct value)
      : this(ValueType.Struct, (object) value)
    {
    }

    public UAValue(sbyte[] value)
      : this(ValueType.FirstArray, (object) value)
    {
    }

    public UAValue(short[] value)
      : this(ValueType.Int16Array, (object) value)
    {
    }

    public UAValue(int[] value)
      : this(ValueType.Int32Array, (object) value)
    {
    }

    public UAValue(long[] value)
      : this(ValueType.Int64Array, (object) value)
    {
    }

    public UAValue(byte[] value)
      : this(ValueType.UInt8Array, (object) value)
    {
    }

    public UAValue(ushort[] value)
      : this(ValueType.UInt16Array, (object) value)
    {
    }

    public UAValue(uint[] value)
      : this(ValueType.UInt32Array, (object) value)
    {
    }

    public UAValue(ulong[] value)
      : this(ValueType.UInt64Array, (object) value)
    {
    }

    public UAValue(bool[] value)
      : this(ValueType.BoolArray, (object) value)
    {
    }

    public UAValue(float[] value)
      : this(ValueType.FloatArray, (object) value)
    {
    }

    public UAValue(double[] value)
      : this(ValueType.DoubleArray, (object) value)
    {
    }

    public UAValue(string[] value)
      : this(ValueType.StringArray, (object) value)
    {
    }

    public UAValue(NodeId[] value)
      : this(ValueType.NodeIdArray, (object) value)
    {
    }

    public UAValue(DateTime[] value)
      : this(ValueType.DateTimeArray, (object) value)
    {
    }

    public UAValue(Guid[] value)
      : this(ValueType.GuidArray, (object) value)
    {
    }

    public UAValue(QualifiedName[] value)
      : this(ValueType.QualifiedNameArray, (object) value)
    {
    }

    public UAValue(ExpandedNodeId[] value)
      : this(ValueType.ExpandedNodeIdArray, (object) value)
    {
    }

    public UAValue(LocalizedText[] value)
      : this(ValueType.LocalizedTextArray, (object) value)
    {
    }

    public UAValue(Struct[] value)
      : this(ValueType.StructArray, (object) value)
    {
    }

    public UAValue(object[] value)
      : this(ValueType.ValueArray, (object) value)
    {
    }

    public object Value => this.value;

    internal ValueType ValueType => this.type;

    public override string ToString()
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
      interpolatedStringHandler.AppendFormatted<object>(this.value);
      interpolatedStringHandler.AppendLiteral(" (");
      interpolatedStringHandler.AppendFormatted<ValueType>(this.type);
      interpolatedStringHandler.AppendLiteral(")");
      return interpolatedStringHandler.ToStringAndClear();
    }

    public override bool Equals(object obj)
    {
      if ((object) this == obj)
        return true;
      UAValue other = obj as UAValue;
      return (object) other != null && this.Equals(other);
    }

    public bool Equals(UAValue other)
    {
      if ((object) other == null || this.type != other.type)
        return false;
      if (this.value == null)
        return other.value == null;
      if (this.type < ValueType.FirstArray)
        return this.value.Equals(other.value);
      if (!(this.value is Array array1) || !(other.value is Array array2))
        return false;
      IEnumerator enumerator1 = array1.GetEnumerator();
      IEnumerator enumerator2 = array2.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        if (!enumerator2.MoveNext() || !enumerator1.Current.Equals(enumerator2.Current))
          return false;
      }
      return !enumerator2.MoveNext();
    }

    public static bool operator ==(UAValue a, UAValue b)
    {
      return (object) a != null ? a.Equals(b) : (object) b == null;
    }

    public static bool operator !=(UAValue a, UAValue b) => !(a == b);

    public override int GetHashCode() => this.value.GetHashCode();

    public static implicit operator sbyte(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<sbyte>(v, UAValue.\u003C\u003EO.\u003C0\u003E__ToSByte ?? (UAValue.\u003C\u003EO.\u003C0\u003E__ToSByte = new Converter<object, sbyte>(Convert.ToSByte)));
    }

    public static implicit operator UAValue(sbyte v) => new UAValue(v);

    public static implicit operator short(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<short>(v, UAValue.\u003C\u003EO.\u003C1\u003E__ToInt16 ?? (UAValue.\u003C\u003EO.\u003C1\u003E__ToInt16 = new Converter<object, short>(Convert.ToInt16)));
    }

    public static implicit operator UAValue(short v) => new UAValue(v);

    public static implicit operator int(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<int>(v, UAValue.\u003C\u003EO.\u003C2\u003E__ToInt32 ?? (UAValue.\u003C\u003EO.\u003C2\u003E__ToInt32 = new Converter<object, int>(Convert.ToInt32)));
    }

    public static implicit operator UAValue(int v) => new UAValue(v);

    public static implicit operator long(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<long>(v, UAValue.\u003C\u003EO.\u003C3\u003E__ToInt64 ?? (UAValue.\u003C\u003EO.\u003C3\u003E__ToInt64 = new Converter<object, long>(Convert.ToInt64)));
    }

    public static implicit operator UAValue(long v) => new UAValue(v);

    public static implicit operator byte(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<byte>(v, UAValue.\u003C\u003EO.\u003C4\u003E__ToByte ?? (UAValue.\u003C\u003EO.\u003C4\u003E__ToByte = new Converter<object, byte>(Convert.ToByte)));
    }

    public static implicit operator UAValue(byte v) => new UAValue(v);

    public static implicit operator ushort(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<ushort>(v, UAValue.\u003C\u003EO.\u003C5\u003E__ToUInt16 ?? (UAValue.\u003C\u003EO.\u003C5\u003E__ToUInt16 = new Converter<object, ushort>(Convert.ToUInt16)));
    }

    public static implicit operator UAValue(ushort v) => new UAValue(v);

    public static implicit operator uint(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<uint>(v, UAValue.\u003C\u003EO.\u003C6\u003E__ToUInt32 ?? (UAValue.\u003C\u003EO.\u003C6\u003E__ToUInt32 = new Converter<object, uint>(Convert.ToUInt32)));
    }

    public static implicit operator UAValue(uint v) => new UAValue(v);

    public static implicit operator ulong(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<ulong>(v, UAValue.\u003C\u003EO.\u003C7\u003E__ToUInt64 ?? (UAValue.\u003C\u003EO.\u003C7\u003E__ToUInt64 = new Converter<object, ulong>(Convert.ToUInt64)));
    }

    public static implicit operator UAValue(ulong v) => new UAValue(v);

    public static implicit operator bool(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<bool>(v, UAValue.\u003C\u003EO.\u003C8\u003E__ToBoolean ?? (UAValue.\u003C\u003EO.\u003C8\u003E__ToBoolean = new Converter<object, bool>(Convert.ToBoolean)));
    }

    public static implicit operator UAValue(bool v) => new UAValue(v);

    public static implicit operator float(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<float>(v, UAValue.\u003C\u003EO.\u003C9\u003E__ToSingle ?? (UAValue.\u003C\u003EO.\u003C9\u003E__ToSingle = new Converter<object, float>(Convert.ToSingle)));
    }

    public static implicit operator UAValue(float v) => new UAValue(v);

    public static implicit operator double(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<double>(v, UAValue.\u003C\u003EO.\u003C10\u003E__ToDouble ?? (UAValue.\u003C\u003EO.\u003C10\u003E__ToDouble = new Converter<object, double>(Convert.ToDouble)));
    }

    public static implicit operator UAValue(double v) => new UAValue(v);

    public static implicit operator string(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<string>(v, UAValue.\u003C\u003EO.\u003C11\u003E__ToString ?? (UAValue.\u003C\u003EO.\u003C11\u003E__ToString = new Converter<object, string>(Convert.ToString)));
    }

    public static implicit operator UAValue(string v) => new UAValue(v);

    public static implicit operator NodeId(UAValue v) => (NodeId) v.value;

    public static implicit operator UAValue(NodeId v) => new UAValue(v);

    public static implicit operator DateTime(UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvert<DateTime>(v, UAValue.\u003C\u003EO.\u003C12\u003E__ToDateTime ?? (UAValue.\u003C\u003EO.\u003C12\u003E__ToDateTime = new Converter<object, DateTime>(Convert.ToDateTime)));
    }

    public static implicit operator UAValue(DateTime v) => new UAValue(v);

    public static implicit operator Guid(UAValue v) => (Guid) v.value;

    public static implicit operator UAValue(Guid v) => new UAValue(v);

    public static implicit operator ByteString(UAValue v) => (ByteString) v.value;

    public static implicit operator UAValue(ByteString v) => new UAValue(v);

    public static implicit operator QualifiedName(UAValue v) => (QualifiedName) v.value;

    public static implicit operator UAValue(QualifiedName v) => new UAValue(v);

    public static implicit operator ExpandedNodeId(UAValue v) => (ExpandedNodeId) v.value;

    public static implicit operator UAValue(ExpandedNodeId v) => new UAValue(v);

    public static implicit operator LocalizedText(UAValue v) => (LocalizedText) v.value;

    public static implicit operator UAValue(LocalizedText v) => new UAValue(v);

    public static implicit operator Struct(UAValue v) => (Struct) v.value;

    public static implicit operator UAValue(Struct v) => new UAValue(v);

    public static implicit operator sbyte[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<sbyte>(v, UAValue.\u003C\u003EO.\u003C0\u003E__ToSByte ?? (UAValue.\u003C\u003EO.\u003C0\u003E__ToSByte = new Converter<object, sbyte>(Convert.ToSByte)));
    }

    public static implicit operator UAValue(sbyte[] v) => new UAValue(v);

    public static implicit operator short[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<short>(v, UAValue.\u003C\u003EO.\u003C1\u003E__ToInt16 ?? (UAValue.\u003C\u003EO.\u003C1\u003E__ToInt16 = new Converter<object, short>(Convert.ToInt16)));
    }

    public static implicit operator UAValue(short[] v) => new UAValue(v);

    public static implicit operator int[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<int>(v, UAValue.\u003C\u003EO.\u003C2\u003E__ToInt32 ?? (UAValue.\u003C\u003EO.\u003C2\u003E__ToInt32 = new Converter<object, int>(Convert.ToInt32)));
    }

    public static implicit operator UAValue(int[] v) => new UAValue(v);

    public static implicit operator long[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<long>(v, UAValue.\u003C\u003EO.\u003C3\u003E__ToInt64 ?? (UAValue.\u003C\u003EO.\u003C3\u003E__ToInt64 = new Converter<object, long>(Convert.ToInt64)));
    }

    public static implicit operator UAValue(long[] v) => new UAValue(v);

    public static implicit operator byte[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<byte>(v, UAValue.\u003C\u003EO.\u003C4\u003E__ToByte ?? (UAValue.\u003C\u003EO.\u003C4\u003E__ToByte = new Converter<object, byte>(Convert.ToByte)));
    }

    public static implicit operator UAValue(byte[] v) => new UAValue(v);

    public static implicit operator ushort[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<ushort>(v, UAValue.\u003C\u003EO.\u003C5\u003E__ToUInt16 ?? (UAValue.\u003C\u003EO.\u003C5\u003E__ToUInt16 = new Converter<object, ushort>(Convert.ToUInt16)));
    }

    public static implicit operator UAValue(ushort[] v) => new UAValue(v);

    public static implicit operator uint[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<uint>(v, UAValue.\u003C\u003EO.\u003C6\u003E__ToUInt32 ?? (UAValue.\u003C\u003EO.\u003C6\u003E__ToUInt32 = new Converter<object, uint>(Convert.ToUInt32)));
    }

    public static implicit operator UAValue(uint[] v) => new UAValue(v);

    public static implicit operator ulong[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<ulong>(v, UAValue.\u003C\u003EO.\u003C7\u003E__ToUInt64 ?? (UAValue.\u003C\u003EO.\u003C7\u003E__ToUInt64 = new Converter<object, ulong>(Convert.ToUInt64)));
    }

    public static implicit operator UAValue(ulong[] v) => new UAValue(v);

    public static implicit operator bool[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<bool>(v, UAValue.\u003C\u003EO.\u003C8\u003E__ToBoolean ?? (UAValue.\u003C\u003EO.\u003C8\u003E__ToBoolean = new Converter<object, bool>(Convert.ToBoolean)));
    }

    public static implicit operator UAValue(bool[] v) => new UAValue(v);

    public static implicit operator float[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<float>(v, UAValue.\u003C\u003EO.\u003C9\u003E__ToSingle ?? (UAValue.\u003C\u003EO.\u003C9\u003E__ToSingle = new Converter<object, float>(Convert.ToSingle)));
    }

    public static implicit operator UAValue(float[] v) => new UAValue(v);

    public static implicit operator double[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<double>(v, UAValue.\u003C\u003EO.\u003C10\u003E__ToDouble ?? (UAValue.\u003C\u003EO.\u003C10\u003E__ToDouble = new Converter<object, double>(Convert.ToDouble)));
    }

    public static implicit operator UAValue(double[] v) => new UAValue(v);

    public static implicit operator string[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<string>(v, UAValue.\u003C\u003EO.\u003C11\u003E__ToString ?? (UAValue.\u003C\u003EO.\u003C11\u003E__ToString = new Converter<object, string>(Convert.ToString)));
    }

    public static implicit operator UAValue(string[] v) => new UAValue(v);

    public static implicit operator NodeId[](UAValue v) => (NodeId[]) v.value;

    public static implicit operator UAValue(NodeId[] v) => new UAValue(v);

    public static implicit operator DateTime[](UAValue v)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return UAValue.GetOrConvertArray<DateTime>(v, UAValue.\u003C\u003EO.\u003C12\u003E__ToDateTime ?? (UAValue.\u003C\u003EO.\u003C12\u003E__ToDateTime = new Converter<object, DateTime>(Convert.ToDateTime)));
    }

    public static implicit operator UAValue(DateTime[] v) => new UAValue(v);

    public static implicit operator Guid[](UAValue v) => (Guid[]) v.value;

    public static implicit operator UAValue(Guid[] v) => new UAValue(v);

    public static implicit operator QualifiedName[](UAValue v) => (QualifiedName[]) v.value;

    public static implicit operator UAValue(QualifiedName[] v) => new UAValue(v);

    public static implicit operator ExpandedNodeId[](UAValue v) => (ExpandedNodeId[]) v.value;

    public static implicit operator UAValue(ExpandedNodeId[] v) => new UAValue(v);

    public static implicit operator LocalizedText[](UAValue v) => (LocalizedText[]) v.value;

    public static implicit operator UAValue(LocalizedText[] v) => new UAValue(v);

    public static implicit operator Struct[](UAValue v) => (Struct[]) v.value;

    public static implicit operator UAValue(Struct[] v) => new UAValue(v);

    public static implicit operator object[](UAValue v) => (object[]) v.value;

    public static implicit operator UAValue(object[] v) => new UAValue(v);

    public static UAValue operator ++(UAValue v)
    {
      if ((v.type < ValueType.FirstIntegral || v.type > ValueType.UInt64) && v.type != ValueType.Float && v.type != ValueType.Double)
        throw new InvalidOperationException("Increment operator can be called only on scalar numeric values");
      switch (v.type)
      {
        case ValueType.FirstIntegral:
          return new UAValue(v.type, (object) (sbyte) ((int) (sbyte) v.value + 1));
        case ValueType.Int16:
          return new UAValue(v.type, (object) (short) ((int) (short) v.value + 1));
        case ValueType.Int32:
          return new UAValue(v.type, (object) ((int) v.value + 1));
        case ValueType.Int64:
          return new UAValue(v.type, (object) ((long) v.value + 1L));
        case ValueType.UInt8:
          return new UAValue(v.type, (object) (byte) ((uint) (byte) v.value + 1U));
        case ValueType.UInt16:
          return new UAValue(v.type, (object) (ushort) ((uint) (ushort) v.value + 1U));
        case ValueType.UInt32:
          return new UAValue(v.type, (object) (uint) ((int) (uint) v.value + 1));
        case ValueType.UInt64:
          return new UAValue(v.type, (object) (ulong) ((long) (ulong) v.value + 1L));
        case ValueType.Float:
          return new UAValue(v.type, (object) (float) ((double) (float) v.value + 1.0));
        case ValueType.Double:
          return new UAValue(v.type, (object) ((double) v.value + 1.0));
        default:
          return v;
      }
    }

    public static UAValue operator --(UAValue v)
    {
      if ((v.type < ValueType.FirstIntegral || v.type > ValueType.UInt64) && v.type != ValueType.Float && v.type != ValueType.Double)
        throw new InvalidOperationException("Decrement operator can be called only on scalar numeric values");
      switch (v.type)
      {
        case ValueType.FirstIntegral:
          return new UAValue(v.type, (object) (sbyte) ((int) (sbyte) v.value - 1));
        case ValueType.Int16:
          return new UAValue(v.type, (object) (short) ((int) (short) v.value - 1));
        case ValueType.Int32:
          return new UAValue(v.type, (object) ((int) v.value - 1));
        case ValueType.Int64:
          return new UAValue(v.type, (object) ((long) v.value - 1L));
        case ValueType.UInt8:
          return new UAValue(v.type, (object) (byte) ((uint) (byte) v.value - 1U));
        case ValueType.UInt16:
          return new UAValue(v.type, (object) (ushort) ((uint) (ushort) v.value - 1U));
        case ValueType.UInt32:
          return new UAValue(v.type, (object) (uint) ((int) (uint) v.value - 1));
        case ValueType.UInt64:
          return new UAValue(v.type, (object) (ulong) ((long) (ulong) v.value - 1L));
        case ValueType.Float:
          return new UAValue(v.type, (object) (float) ((double) (float) v.value - 1.0));
        case ValueType.Double:
          return new UAValue(v.type, (object) ((double) v.value - 1.0));
        default:
          return v;
      }
    }

    private static T GetOrConvert<T>(UAValue value, Converter<object, T> converterFunc)
    {
      return value.type != UAValue.typeToEnum[typeof (T)] ? converterFunc(value.value) : (T) value.value;
    }

    private static T[] GetOrConvertArray<T>(UAValue value, Converter<object, T> converterFunc)
    {
      return value.type != UAValue.typeToEnum[typeof (T[])] ? Array.ConvertAll<object, T>((object[]) value.value, converterFunc) : (T[]) value.value;
    }
  }
}
