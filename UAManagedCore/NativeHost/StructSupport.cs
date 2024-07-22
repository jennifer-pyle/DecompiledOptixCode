// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.StructSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class StructSupport
  {
    public static IntPtr CreateStruct(IntPtr dataTypeIdPtr, IntPtr fieldsPtr)
    {
      NodeId dataTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(dataTypeIdPtr);
      object[] managedArray = ArrayMarshal.ToManagedArray<object>(fieldsPtr);
      if (dataTypeId != (NodeId) null && dataTypeId != DataTypes.Structure)
      {
        Type typeByDataTypeId = DataTypesHelper.GetNetTypeByDataTypeId(dataTypeId);
        if (typeByDataTypeId != (Type) null)
        {
          Struct instance = (Struct) Activator.CreateInstance(typeByDataTypeId);
          instance.SetValues((IReadOnlyList<object>) managedArray);
          return ObjectMarshal.ToIntPtr((object) instance);
        }
      }
      return ObjectMarshal.ToIntPtr((object) new Struct(dataTypeId, managedArray));
    }

    public static IntPtr DecomposeStruct(
      IntPtr structPtr,
      out IntPtr dataTypeIdPtr,
      out int fieldCount)
    {
      Struct @struct = ObjectMarshal.FromIntPtr<Struct>(structPtr);
      dataTypeIdPtr = ObjectMarshal.ToIntPtr((object) @struct.DataTypeId);
      fieldCount = @struct.Values.Count;
      IntPtr num = UAManagedCore.NativeMemory.Allocate(fieldCount * IntPtr.Size);
      IntPtr ptr = num;
      foreach (object obj in (IEnumerable<object>) @struct.Values)
      {
        Marshal.WriteIntPtr(ptr, ObjectMarshal.ToIntPtr(obj));
        ptr += (IntPtr) IntPtr.Size;
      }
      return num;
    }

    public delegate IntPtr CreateStructDelegate(IntPtr dataTypeIdPtr, IntPtr fieldsPtr);

    public delegate IntPtr DecomposeStructDelegate(
      IntPtr structPtr,
      out IntPtr dataTypeIdPtr,
      out int fieldCount);
  }
}
