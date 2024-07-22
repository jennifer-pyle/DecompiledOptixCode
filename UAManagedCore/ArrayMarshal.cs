// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ArrayMarshal
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  internal static class ArrayMarshal
  {
    public static unsafe IntPtr ToNative(sbyte[] managedArray)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<sbyte>());
      Marshal.WriteInt32(ptr, managedArray.Length);
      sbyte* numPtr = (sbyte*) (ptr + (IntPtr) Marshal.SizeOf<int>());
      for (int index = 0; index < managedArray.Length; ++index)
      {
        *numPtr = managedArray[index];
        ++numPtr;
      }
      return ptr;
    }

    public static IntPtr ToNative(short[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<short>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(int[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<int>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(long[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<long>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(byte[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<byte>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static unsafe IntPtr ToNative(ushort[] managedArray)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<ushort>());
      Marshal.WriteInt32(ptr, managedArray.Length);
      ushort* numPtr = (ushort*) (ptr + (IntPtr) Marshal.SizeOf<int>());
      for (int index = 0; index < managedArray.Length; ++index)
      {
        *numPtr = managedArray[index];
        ++numPtr;
      }
      return ptr;
    }

    public static unsafe IntPtr ToNative(uint[] managedArray)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<uint>());
      Marshal.WriteInt32(ptr, managedArray.Length);
      uint* numPtr = (uint*) (ptr + (IntPtr) Marshal.SizeOf<int>());
      for (int index = 0; index < managedArray.Length; ++index)
      {
        *numPtr = managedArray[index];
        ++numPtr;
      }
      return ptr;
    }

    public static unsafe IntPtr ToNative(ulong[] managedArray)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<ulong>());
      Marshal.WriteInt32(ptr, managedArray.Length);
      ulong* numPtr = (ulong*) (ptr + (IntPtr) Marshal.SizeOf<int>());
      for (int index = 0; index < managedArray.Length; ++index)
      {
        *numPtr = managedArray[index];
        ++numPtr;
      }
      return ptr;
    }

    public static IntPtr ToNative(bool[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<byte>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      byte[] source = new byte[managedArray.Length];
      for (int index = 0; index < managedArray.Length; ++index)
        source[index] = (byte) managedArray[index];
      Marshal.Copy(source, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(float[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<float>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(double[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<double>());
      IntPtr ptr = native;
      Marshal.WriteInt32(ptr, managedArray.Length);
      IntPtr destination = ptr + (IntPtr) Marshal.SizeOf<int>();
      Marshal.Copy(managedArray, 0, destination, managedArray.Length);
      return native;
    }

    public static IntPtr ToNative(object[] managedArray)
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedArray.Length * Marshal.SizeOf<IntPtr>());
      IntPtr ptr1 = native;
      Marshal.WriteInt32(ptr1, managedArray.Length);
      IntPtr ptr2 = ptr1 + (IntPtr) Marshal.SizeOf<int>();
      foreach (object managed in managedArray)
      {
        Marshal.WriteIntPtr(ptr2, ObjectMarshal.ToIntPtr(managed));
        ptr2 += (IntPtr) IntPtr.Size;
      }
      return native;
    }

    public static IntPtr ToNative<T>(T[] managedStructs) where T : struct
    {
      IntPtr native = NativeMemory.Allocate(Marshal.SizeOf<int>() + managedStructs.Length * Marshal.SizeOf<T>());
      IntPtr ptr1 = native;
      Marshal.WriteInt32(ptr1, managedStructs.Length);
      IntPtr ptr2 = ptr1 + (IntPtr) Marshal.SizeOf<int>();
      foreach (T managedStruct in managedStructs)
      {
        Marshal.StructureToPtr<T>(managedStruct, ptr2, true);
        ptr2 += (IntPtr) Marshal.SizeOf<T>();
      }
      return native;
    }

    public static unsafe sbyte[] ToManagedInt8Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<sbyte>();
      sbyte[] managedInt8Array = new sbyte[managed.Length];
      sbyte* data = (sbyte*) managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        managedInt8Array[index] = *data;
        ++data;
      }
      NativeMemory.Free(managed.Data);
      return managedInt8Array;
    }

    public static short[] ToManagedInt16Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<short>();
      short[] destination = new short[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static int[] ToManagedInt32Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<int>();
      int[] destination = new int[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static long[] ToManagedInt64Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<long>();
      long[] destination = new long[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static byte[] ToManagedUInt8Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<byte>();
      byte[] destination = new byte[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static unsafe ushort[] ToManagedUInt16Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<ushort>();
      ushort[] managedUint16Array = new ushort[managed.Length];
      ushort* data = (ushort*) managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        managedUint16Array[index] = *data;
        ++data;
      }
      NativeMemory.Free(managed.Data);
      return managedUint16Array;
    }

    public static unsafe uint[] ToManagedUInt32Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<uint>();
      uint[] managedUint32Array = new uint[managed.Length];
      uint* data = (uint*) managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        managedUint32Array[index] = *data;
        ++data;
      }
      NativeMemory.Free(managed.Data);
      return managedUint32Array;
    }

    public static unsafe ulong[] ToManagedUInt64Array(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<ulong>();
      ulong[] managedUint64Array = new ulong[managed.Length];
      ulong* data = (ulong*) managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        managedUint64Array[index] = *data;
        ++data;
      }
      NativeMemory.Free(managed.Data);
      return managedUint64Array;
    }

    public static bool[] ToManagedBoolArray(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<bool>();
      byte[] destination = new byte[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      bool[] managedBoolArray = new bool[managed.Length];
      for (int index = 0; index < managed.Length; ++index)
        managedBoolArray[index] = destination[index] > (byte) 0;
      NativeMemory.Free(managed.Data);
      return managedBoolArray;
    }

    public static float[] ToManagedFloatArray(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<float>();
      float[] destination = new float[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static double[] ToManagedDoubleArray(IntPtr nativePtr)
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<double>();
      double[] destination = new double[managed.Length];
      Marshal.Copy(managed.Data, destination, 0, managed.Length);
      NativeMemory.Free(managed.Data);
      return destination;
    }

    public static DateTime[] ToManagedDateTimeArray(IntPtr nativePtr)
    {
      return ArrayMarshal.ToManagedBoxedTypeArray<DateTime>(nativePtr);
    }

    public static Guid[] ToManagedGuidArray(IntPtr nativePtr)
    {
      return ArrayMarshal.ToManagedBoxedTypeArray<Guid>(nativePtr);
    }

    public static T[] ToManagedArray<T>(IntPtr nativePtr) where T : class
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<T>();
      bool flag = typeof (T).IsAssignableTo(typeof (UANode));
      T[] managedArray = new T[managed.Length];
      IntPtr data = managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        IntPtr pointer = Marshal.ReadIntPtr(data);
        managedArray[index] = flag ? ObjectMarshal.FromIntPtr<T>(pointer) : ObjectMarshal.ReleaseGCHandle<T>(pointer);
        data += (IntPtr) IntPtr.Size;
      }
      NativeMemory.Free(managed.Data);
      return managedArray;
    }

    private static T[] ToManagedBoxedTypeArray<T>(IntPtr nativePtr) where T : struct
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<T>();
      T[] managedBoxedTypeArray = new T[managed.Length];
      IntPtr data = managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        IntPtr pointer = Marshal.ReadIntPtr(data);
        managedBoxedTypeArray[index] = (T) ObjectMarshal.ReleaseGCHandle<object>(pointer);
        data += (IntPtr) IntPtr.Size;
      }
      NativeMemory.Free(managed.Data);
      return managedBoxedTypeArray;
    }
  }
}
