// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.StructDefinitionSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class StructDefinitionSupport
  {
    public static IntPtr CreateStructDefinition(
      IntPtr namePtr,
      IntPtr dataTypeIdPtr,
      IntPtr fieldsPtr)
    {
      string name = StringMarshal.ReleaseNativeString(namePtr);
      NodeId dataTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(dataTypeIdPtr);
      StructFieldInterop[] managedArray = StructMarshal.ToManagedArray<StructFieldInterop>(fieldsPtr);
      StructField[] fields = new StructField[managedArray.Length];
      for (int index = 0; index < managedArray.Length; ++index)
        fields[index] = new StructField(StringMarshal.ReleaseNativeString(managedArray[index].Name), ObjectMarshal.ReleaseGCHandle<NodeId>(managedArray[index].DataTypeId), (ValueRank) managedArray[index].ValueRank, (IReadOnlyList<uint>) ArrayMarshal.ToManagedUInt32Array(managedArray[index].ArrayDimensions), ObjectMarshal.ReleaseGCHandle<object>(managedArray[index].InitValue), managedArray[index].IsOptional != 0, managedArray[index].AllowSubtypes != 0, managedArray[index].MaxStringLength, ObjectMarshal.ReleaseGCHandle<LocalizedText>(managedArray[index].Description));
      return ObjectMarshal.ToIntPtr((object) new StructDefinition(name, dataTypeId, (IReadOnlyList<StructField>) fields));
    }

    public static IntPtr CreateEmptyStructDefinition()
    {
      return ObjectMarshal.ToIntPtr((object) StructDefinition.Empty);
    }

    public static IntPtr DecomposeStructDefinition(
      IntPtr structDefinitionPtr,
      out IntPtr namePtr,
      out IntPtr dataTypeIdPtr)
    {
      StructDefinition structDefinition = ObjectMarshal.FromIntPtr<StructDefinition>(structDefinitionPtr);
      namePtr = StringMarshal.StringToIntPtr(structDefinition.Name);
      dataTypeIdPtr = ObjectMarshal.ToIntPtr((object) structDefinition.DataTypeId);
      return StructMarshal.ToNativeArray((IEnumerable<StructField>) structDefinition.Fields);
    }

    public delegate IntPtr CreateStructDefinitionDelegate(
      IntPtr namePtr,
      IntPtr dataTypeIdPtr,
      IntPtr fieldsPtr);

    public delegate IntPtr CreateEmptyStructDefinitionDelegate();

    public delegate IntPtr DecomposeStructDefinitionDelegate(
      IntPtr structDefinitionPtr,
      out IntPtr namePtr,
      out IntPtr dataTypeIdPtr);
  }
}
