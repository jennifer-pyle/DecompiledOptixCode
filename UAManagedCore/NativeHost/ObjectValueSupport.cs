// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.ObjectValueSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class ObjectValueSupport
  {
    public static IntPtr FromInt8(sbyte value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromInt16(short value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromInt32(int value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromInt64(long value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromUInt8(byte value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromUInt16(ushort value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromUInt32(uint value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromUInt64(ulong value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromBool(int value) => ObjectMarshal.ToIntPtr((object) (value != 0));

    public static IntPtr FromFloat(float value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromDouble(double value) => ObjectMarshal.ToIntPtr((object) value);

    public static IntPtr FromString(IntPtr valuePtr)
    {
      return ObjectMarshal.ToIntPtr((object) StringMarshal.StringFromIntPtr(valuePtr));
    }

    public static IntPtr FromDateTime(long ticks)
    {
      return ObjectMarshal.ToIntPtr((object) DateTimeSupport.DateTimeFromTicksSinceEpoch(ticks));
    }

    public static IntPtr FromGuid(IntPtr nativeBytesPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new Guid(GuidSupport.FromNativeBytes(nativeBytesPtr)));
    }

    public static IntPtr FromByteString(IntPtr nativeBytesPtr, int length)
    {
      byte[] numArray = new byte[length];
      Marshal.Copy(nativeBytesPtr, numArray, 0, length);
      return ObjectMarshal.ToIntPtr((object) new ByteString(numArray));
    }

    public static IntPtr FromInt8Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<sbyte>(ArrayMarshal.ToManagedInt8Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromInt16Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<short>(ArrayMarshal.ToManagedInt16Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromInt32Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<int>(ArrayMarshal.ToManagedInt32Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromInt64Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<long>(ArrayMarshal.ToManagedInt64Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromUInt8Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<byte>(ArrayMarshal.ToManagedUInt8Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromUInt16Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<ushort>(ArrayMarshal.ToManagedUInt16Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromUInt32Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<uint>(ArrayMarshal.ToManagedUInt32Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromUInt64Array(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<ulong>(ArrayMarshal.ToManagedUInt64Array(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromBoolArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<bool>(ArrayMarshal.ToManagedBoolArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromFloatArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<float>(ArrayMarshal.ToManagedFloatArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromDoubleArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<double>(ArrayMarshal.ToManagedDoubleArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromStringArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<string>(StringMarshal.ToManagedStringArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromNodeIdArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<NodeId>(ArrayMarshal.ToManagedArray<NodeId>(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromDateTimeArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<DateTime>(ArrayMarshal.ToManagedDateTimeArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromGuidArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<Guid>(ArrayMarshal.ToManagedGuidArray(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromQualifiedNameArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<QualifiedName>(ArrayMarshal.ToManagedArray<QualifiedName>(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromExpandedNodeIdArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<ExpandedNodeId>(ArrayMarshal.ToManagedArray<ExpandedNodeId>(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromLocalizedTextArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<LocalizedText>(ArrayMarshal.ToManagedArray<LocalizedText>(valuesPtr), dimensionsPtr);
    }

    public static IntPtr FromStructArray(IntPtr valuesPtr, IntPtr dimensionsPtr)
    {
      return ObjectValueSupport.FromLinearizedArray<Struct>(ArrayMarshal.ToManagedArray<Struct>(valuesPtr), dimensionsPtr);
    }

    public static sbyte ToInt8(IntPtr valuePtr)
    {
      return (sbyte) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static short ToInt16(IntPtr valuePtr)
    {
      return (short) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static int ToInt32(IntPtr valuePtr) => (int) ObjectMarshal.FromIntPtr<object>(valuePtr);

    public static long ToInt64(IntPtr valuePtr)
    {
      return (long) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static byte ToUInt8(IntPtr valuePtr)
    {
      return (byte) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static ushort ToUInt16(IntPtr valuePtr)
    {
      return (ushort) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static uint ToUInt32(IntPtr valuePtr)
    {
      return (uint) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static ulong ToUInt64(IntPtr valuePtr)
    {
      return (ulong) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static int ToBool(IntPtr valuePtr)
    {
      return (bool) ObjectMarshal.FromIntPtr<object>(valuePtr) ? 1 : 0;
    }

    public static float ToFloat(IntPtr valuePtr)
    {
      return (float) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static double ToDouble(IntPtr valuePtr)
    {
      return (double) ObjectMarshal.FromIntPtr<object>(valuePtr);
    }

    public static IntPtr ToString(IntPtr valuePtr)
    {
      return StringMarshal.StringToIntPtr(ObjectMarshal.FromIntPtr<string>(valuePtr));
    }

    public static IntPtr ToByteString(IntPtr valuePtr, out int length)
    {
      ByteString byteString = ObjectMarshal.FromIntPtr<ByteString>(valuePtr);
      length = byteString.Bytes.Length;
      IntPtr destination = UAManagedCore.NativeMemory.Allocate(length);
      Marshal.Copy(byteString.Bytes, 0, destination, length);
      return destination;
    }

    public static IntPtr ToInt8Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<sbyte>(array)), array);
    }

    public static IntPtr ToInt16Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<short>(array)), array);
    }

    public static IntPtr ToInt32Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<int>(array)), array);
    }

    public static IntPtr ToInt64Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<long>(array)), array);
    }

    public static IntPtr ToUInt8Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<byte>(array)), array);
    }

    public static IntPtr ToUInt16Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<ushort>(array)), array);
    }

    public static IntPtr ToUInt32Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<uint>(array)), array);
    }

    public static IntPtr ToUInt64Array(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<ulong>(array)), array);
    }

    public static IntPtr ToBoolArray(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<bool>(array)), array);
    }

    public static IntPtr ToFloatArray(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<float>(array)), array);
    }

    public static IntPtr ToDoubleArray(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedValueTypeArray<double>(array)), array);
    }

    public static IntPtr ToStringArray(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(StringMarshal.ToNativeStringArray((IEnumerable<string>) ObjectValueSupport.GetLinearizedReferenceTypeArray<string>(array)), array);
    }

    public static IntPtr ToObjectArray(IntPtr arrayPtr)
    {
      Array array = ObjectMarshal.FromIntPtr<Array>(arrayPtr);
      return ObjectValueSupport.MarshalArrayObjectValueInterop(ArrayMarshal.ToNative(ObjectValueSupport.GetLinearizedReferenceTypeArray<object>(array)), array);
    }

    public static byte ValueTypeFromNetType(IntPtr objectPtr)
    {
      if (objectPtr == IntPtr.Zero)
        return 0;
      Type type = ObjectMarshal.FromIntPtr<object>(objectPtr).GetType();
      if (type.IsArray)
      {
        Type elementType = type.GetElementType();
        switch (Type.GetTypeCode(elementType))
        {
          case TypeCode.Object:
            if (typeof (NodeId).IsAssignableFrom(elementType))
              return 35;
            if (typeof (Guid).IsAssignableFrom(elementType))
              return 37;
            if (typeof (QualifiedName).IsAssignableFrom(elementType))
              return 38;
            if (typeof (LocalizedText).IsAssignableFrom(elementType))
              return 40;
            if (typeof (Struct).IsAssignableFrom(elementType))
              return 41;
            return typeof (ExpandedNodeId).IsAssignableFrom(type) ? (byte) 18 : (byte) 44;
          case TypeCode.Boolean:
            return 31;
          case TypeCode.SByte:
            return 23;
          case TypeCode.Byte:
            return 27;
          case TypeCode.Int16:
            return 24;
          case TypeCode.UInt16:
            return 28;
          case TypeCode.Int32:
            return 25;
          case TypeCode.UInt32:
            return 29;
          case TypeCode.Int64:
            return 26;
          case TypeCode.UInt64:
            return 30;
          case TypeCode.Single:
            return 32;
          case TypeCode.Double:
            return 33;
          case TypeCode.DateTime:
            return 36;
          case TypeCode.String:
            return 34;
          default:
            throw new CoreException("Unexpected array type '" + type.FullName + "' when setting value");
        }
      }
      else
      {
        switch (Type.GetTypeCode(type))
        {
          case TypeCode.Object:
            if (typeof (NodeId).IsAssignableFrom(type))
              return 13;
            if (typeof (Guid).IsAssignableFrom(type))
              return 15;
            if (typeof (QualifiedName).IsAssignableFrom(type))
              return 17;
            if (typeof (LocalizedText).IsAssignableFrom(type))
              return 19;
            if (typeof (Struct).IsAssignableFrom(type))
              return 20;
            if (typeof (ByteString).IsAssignableFrom(type))
              return 16;
            if (typeof (ExpandedNodeId).IsAssignableFrom(type))
              return 18;
            throw new CoreException("Unexpected scalar type '" + type.FullName + "' when setting value");
          case TypeCode.Boolean:
            return 9;
          case TypeCode.SByte:
            return 1;
          case TypeCode.Byte:
            return 5;
          case TypeCode.Int16:
            return 2;
          case TypeCode.UInt16:
            return 6;
          case TypeCode.Int32:
            return 3;
          case TypeCode.UInt32:
            return 7;
          case TypeCode.Int64:
            return 4;
          case TypeCode.UInt64:
            return 8;
          case TypeCode.Single:
            return 10;
          case TypeCode.Double:
            return 11;
          case TypeCode.DateTime:
            return 14;
          case TypeCode.String:
            return 12;
          default:
            throw new CoreException("Unexpected scalar type '" + type.FullName + "' when setting value");
        }
      }
    }

    public static IntPtr CreateObjectArray(IntPtr dimensionsPtr)
    {
      return ObjectMarshal.ToIntPtr((object) Array.CreateInstance(typeof (object), ArrayMarshal.ToManagedInt32Array(dimensionsPtr)));
    }

    public static void SetArrayItem(IntPtr arrayPtr, IntPtr valuePtr, IntPtr indexesPtr)
    {
      ObjectMarshal.FromIntPtr<Array>(arrayPtr).SetValue(ObjectMarshal.ReleaseGCHandle<object>(valuePtr), ArrayMarshal.ToManagedInt32Array(indexesPtr));
    }

    public static IntPtr GetArrayItem(IntPtr arrayPtr, IntPtr indexesPtr)
    {
      return ObjectMarshal.ToIntPtr(ObjectMarshal.FromIntPtr<Array>(arrayPtr).GetValue(ArrayMarshal.ToManagedInt32Array(indexesPtr)));
    }

    private static IntPtr FromLinearizedArray<T>(T[] linearizedArray, IntPtr dimensionsPtr)
    {
      int[] managedInt32Array = ArrayMarshal.ToManagedInt32Array(dimensionsPtr);
      Array instance = Array.CreateInstance(typeof (T), managedInt32Array);
      List<int[]> linearIndexes = ObjectValueSupport.GetLinearIndexes(managedInt32Array);
      for (int index = 0; index < linearIndexes.Count; ++index)
        instance.SetValue((object) linearizedArray[index], linearIndexes[index]);
      return ObjectMarshal.ToIntPtr((object) instance);
    }

    private static T[] GetLinearizedValueTypeArray<T>(Array array) where T : struct
    {
      T[] linearizedValueTypeArray = new T[array.Length];
      int num = 0;
      foreach (object obj in array)
        linearizedValueTypeArray[num++] = (T) obj;
      return linearizedValueTypeArray;
    }

    private static T[] GetLinearizedReferenceTypeArray<T>(Array array) where T : class
    {
      T[] referenceTypeArray = new T[array.Length];
      int num = 0;
      foreach (object obj in array)
        referenceTypeArray[num++] = (T) obj;
      return referenceTypeArray;
    }

    private static IntPtr MarshalArrayObjectValueInterop(
      IntPtr marshaledLinearizedArray,
      Array array)
    {
      ArrayObjectValueInterop structure = new ArrayObjectValueInterop()
      {
        Values = marshaledLinearizedArray,
        Dimensions = ArrayMarshal.ToNative(ObjectValueSupport.GetArrayDimensions(array))
      };
      IntPtr ptr = UAManagedCore.NativeMemory.Allocate(Marshal.SizeOf<ArrayObjectValueInterop>());
      Marshal.StructureToPtr<ArrayObjectValueInterop>(structure, ptr, true);
      return ptr;
    }

    private static int[] GetArrayDimensions(Array array)
    {
      int[] arrayDimensions = new int[array.Rank];
      for (int dimension = 0; dimension < arrayDimensions.Length; ++dimension)
        arrayDimensions[dimension] = array.GetLength(dimension);
      return arrayDimensions;
    }

    private static List<int[]> GetLinearIndexes(int[] dimensions)
    {
      List<int[]> linearIndexes = new List<int[]>();
      if (((IEnumerable<int>) dimensions).Contains<int>(0))
        return linearIndexes;
      int[] numArray = new int[dimensions.Length];
      numArray[dimensions.Length - 1] = -1;
      while (ObjectValueSupport.NextArrayIndexes(numArray, dimensions))
      {
        int[] array = ((IEnumerable<int>) numArray).ToArray<int>();
        linearIndexes.Add(array);
      }
      return linearIndexes;
    }

    private static bool NextArrayIndexes(int[] indexes, int[] dimensions)
    {
      int index1 = indexes.Length - 1;
      ++indexes[index1];
      if (indexes[index1] < dimensions[index1])
        return true;
      if (dimensions.Length > 1)
      {
        indexes[index1] = 0;
        for (int index2 = index1 - 1; index2 >= 0; --index2)
        {
          ++indexes[index2];
          if (indexes[index2] < dimensions[index2])
            return true;
          indexes[index2] = 0;
        }
      }
      return false;
    }

    public delegate IntPtr FromInt8Delegate(sbyte value);

    public delegate IntPtr FromInt16Delegate(short value);

    public delegate IntPtr FromInt32Delegate(int value);

    public delegate IntPtr FromInt64Delegate(long value);

    public delegate IntPtr FromUInt8Delegate(byte value);

    public delegate IntPtr FromUInt16Delegate(ushort value);

    public delegate IntPtr FromUInt32Delegate(uint value);

    public delegate IntPtr FromUInt64Delegate(ulong value);

    public delegate IntPtr FromBoolDelegate(int value);

    public delegate IntPtr FromFloatDelegate(float value);

    public delegate IntPtr FromDoubleDelegate(double value);

    public delegate IntPtr FromStringDelegate(IntPtr valuePtr);

    public delegate IntPtr FromDateTimeDelegate(long ticks);

    public delegate IntPtr FromGuidDelegate(IntPtr nativeBytesPtr);

    public delegate IntPtr FromByteStringDelegate(IntPtr nativeBytesPtr, int length);

    public delegate IntPtr FromInt8ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromInt16ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromInt32ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromInt64ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromUInt8ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromUInt16ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromUInt32ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromUInt64ArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromBoolArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromFloatArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromDoubleArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromStringArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromNodeIdArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromDateTimeArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromGuidArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromQualifiedNameArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromExpandedNodeIdArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromLocalizedTextArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate IntPtr FromStructArrayDelegate(IntPtr valuesPtr, IntPtr dimensionsPtr);

    public delegate sbyte ToInt8Delegate(IntPtr valuePtr);

    public delegate short ToInt16Delegate(IntPtr valuePtr);

    public delegate int ToInt32Delegate(IntPtr valuePtr);

    public delegate long ToInt64Delegate(IntPtr valuePtr);

    public delegate byte ToUInt8Delegate(IntPtr valuePtr);

    public delegate ushort ToUInt16Delegate(IntPtr valuePtr);

    public delegate uint ToUInt32Delegate(IntPtr valuePtr);

    public delegate ulong ToUInt64Delegate(IntPtr valuePtr);

    public delegate int ToBoolDelegate(IntPtr valuePtr);

    public delegate float ToFloatDelegate(IntPtr valuePtr);

    public delegate double ToDoubleDelegate(IntPtr valuePtr);

    public delegate IntPtr ToStringDelegate(IntPtr valuePtr);

    public delegate IntPtr ToByteStringDelegate(IntPtr valuePtr, out int length);

    public delegate IntPtr ToInt8ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToInt16ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToInt32ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToInt64ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToUInt8ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToUInt16ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToUInt32ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToUInt64ArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToBoolArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToFloatArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToDoubleArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToStringArrayDelegate(IntPtr arrayPtr);

    public delegate IntPtr ToObjectArrayDelegate(IntPtr arrayPtr);

    public delegate byte ValueTypeFromNetTypeDelegate(IntPtr objectPtr);

    public delegate IntPtr CreateObjectArrayDelegate(IntPtr dimensionsPtr);

    public delegate void SetArrayItemDelegate(IntPtr arrayPtr, IntPtr valuePtr, IntPtr indexesPtr);

    public delegate IntPtr GetArrayItemDelegate(IntPtr arrayPtr, IntPtr indexesPtr);
  }
}
