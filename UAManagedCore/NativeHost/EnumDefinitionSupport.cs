// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.EnumDefinitionSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class EnumDefinitionSupport
  {
    public static IntPtr CreateEnumDefinition(
      IntPtr namePtr,
      IntPtr dataTypeIdPtr,
      IntPtr fieldsPtr)
    {
      string name = StringMarshal.ReleaseNativeString(namePtr);
      NodeId dataTypeId = ObjectMarshal.ReleaseGCHandle<NodeId>(dataTypeIdPtr);
      EnumFieldInterop[] managedArray = StructMarshal.ToManagedArray<EnumFieldInterop>(fieldsPtr);
      EnumField[] fields = new EnumField[managedArray.Length];
      for (int index = 0; index < managedArray.Length; ++index)
        fields[index] = new EnumField(StringMarshal.ReleaseNativeString(managedArray[index].Name), managedArray[index].Value, ObjectMarshal.ReleaseGCHandle<LocalizedText>(managedArray[index].DisplayName), ObjectMarshal.ReleaseGCHandle<LocalizedText>(managedArray[index].Description));
      return ObjectMarshal.ToIntPtr((object) new EnumDefinition(name, dataTypeId, (IReadOnlyList<EnumField>) fields));
    }

    public static IntPtr CreateEmptyEnumDefinition()
    {
      return ObjectMarshal.ToIntPtr((object) EnumDefinition.Empty);
    }

    public static IntPtr DecomposeEnumDefinition(
      IntPtr enumDefinitionPtr,
      out IntPtr namePtr,
      out IntPtr dataTypeIdPtr)
    {
      EnumDefinition enumDefinition = ObjectMarshal.FromIntPtr<EnumDefinition>(enumDefinitionPtr);
      namePtr = StringMarshal.StringToIntPtr(enumDefinition.Name);
      dataTypeIdPtr = ObjectMarshal.ToIntPtr((object) enumDefinition.DataTypeId);
      return StructMarshal.ToNativeArray((IEnumerable<EnumField>) enumDefinition.Fields);
    }

    public delegate IntPtr CreateEnumDefinitionDelegate(
      IntPtr namePtr,
      IntPtr dataTypeIdPtr,
      IntPtr fieldsPtr);

    public delegate IntPtr CreateEmptyEnumDefinitionDelegate();

    public delegate IntPtr DecomposeEnumDefinitionDelegate(
      IntPtr enumDefinitionPtr,
      out IntPtr namePtr,
      out IntPtr dataTypeIdPtr);
  }
}
