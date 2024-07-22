// Decompiled with JetBrains decompiler
// Type: UAManagedCore.StructMarshal
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UAManagedCore.ExternalVariableSynchronizer;

#nullable disable
namespace UAManagedCore
{
  internal static class StructMarshal
  {
    public static T ToManaged<T>(IntPtr nativePtr) where T : struct
    {
      T structure = Marshal.PtrToStructure<T>(nativePtr);
      NativeMemory.Free(nativePtr);
      return structure;
    }

    public static T[] ToManagedArray<T>(IntPtr nativePtr) where T : struct
    {
      ArrayInterop managed = StructMarshal.ToManaged<ArrayInterop>(nativePtr);
      if (managed.Length == 0 || managed.Data == IntPtr.Zero)
        return Array.Empty<T>();
      T[] managedArray = new T[managed.Length];
      IntPtr data = managed.Data;
      for (int index = 0; index < managed.Length; ++index)
      {
        managedArray[index] = Marshal.PtrToStructure<T>(data);
        data += (IntPtr) Marshal.SizeOf<T>();
      }
      NativeMemory.Free(managed.Data);
      return managedArray;
    }

    public static IntPtr ToNative(DataValue dataValue)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<DataValueInterop>());
      Marshal.StructureToPtr<DataValueInterop>(new DataValueInterop()
      {
        value = ObjectMarshal.ToIntPtr((object) dataValue.Value),
        statusCode = dataValue.StatusCode,
        sourceTimestamp = ObjectMarshal.ToIntPtr((object) dataValue.SourceTimestamp),
        serverTimestamp = ObjectMarshal.ToIntPtr((object) dataValue.ServerTimestamp)
      }, ptr, true);
      return ptr;
    }

    public static IntPtr ToNative(NetSolutionAssemblyInfo assemblyInfo)
    {
      IntPtr ptr = NativeMemory.Allocate(Marshal.SizeOf<NetSolutionAssemblyInfoInterop>());
      Marshal.StructureToPtr<NetSolutionAssemblyInfoInterop>(new NetSolutionAssemblyInfoInterop()
      {
        Classes = StructMarshal.ToNativeArray(assemblyInfo.Classes),
        ReferencedAssemblies = StringMarshal.ToNativeStringArray((IEnumerable<string>) assemblyInfo.ReferencedAssemblies)
      }, ptr, true);
      return ptr;
    }

    public static IntPtr ToNativeArray(IEnumerable<RemoteVariable> variables)
    {
      RemoteVariableInterop[] managedStructs = new RemoteVariableInterop[variables.Count<RemoteVariable>()];
      int num = 0;
      foreach (RemoteVariable variable1 in variables)
      {
        UAVariable variable2 = (UAVariable) variable1.Variable;
        managedStructs[num++] = new RemoteVariableInterop()
        {
          Variable = ObjectMarshal.ToIntPtr((object) variable2.nodeHandle),
          Index = ArrayMarshal.ToNative(variable1.Index)
        };
      }
      return ArrayMarshal.ToNative<RemoteVariableInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(IEnumerable<RemoteVariableValue> variableValues)
    {
      RemoteVariableValueInterop[] managedStructs = new RemoteVariableValueInterop[variableValues.Count<RemoteVariableValue>()];
      int num = 0;
      foreach (RemoteVariableValue variableValue in variableValues)
      {
        UAVariable variable = (UAVariable) variableValue.Variable;
        managedStructs[num++] = new RemoteVariableValueInterop()
        {
          Variable = ObjectMarshal.ToIntPtr((object) variable.nodeHandle),
          Value = ObjectMarshal.ToIntPtr((object) variableValue.Value),
          Index = ArrayMarshal.ToNative(variableValue.Index)
        };
      }
      return ArrayMarshal.ToNative<RemoteVariableValueInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(IEnumerable<VariableValue> variableValues)
    {
      VariableValueInterop[] managedStructs = new VariableValueInterop[variableValues.Count<VariableValue>()];
      int num = 0;
      foreach (VariableValue variableValue in variableValues)
      {
        UAVariable variable = (UAVariable) variableValue.Variable;
        managedStructs[num++] = new VariableValueInterop()
        {
          Variable = ObjectMarshal.ToIntPtr((object) variable.nodeHandle),
          Value = ObjectMarshal.ToIntPtr(variableValue.Value),
          Index = ArrayMarshal.ToNative(variableValue.Index)
        };
      }
      return ArrayMarshal.ToNative<VariableValueInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(IEnumerable<IndexedVariable> indexedVariables)
    {
      IndexedVariableInterop[] managedStructs = new IndexedVariableInterop[indexedVariables.Count<IndexedVariable>()];
      int num = 0;
      foreach (IndexedVariable indexedVariable in indexedVariables)
      {
        UAVariable variable = (UAVariable) indexedVariable.Variable;
        managedStructs[num++] = new IndexedVariableInterop()
        {
          Variable = ObjectMarshal.ToIntPtr((object) variable.nodeHandle),
          Index = ArrayMarshal.ToNative(indexedVariable.Indexes)
        };
      }
      return ArrayMarshal.ToNative<IndexedVariableInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(IEnumerable<StructField> structFields)
    {
      StructFieldInterop[] managedStructs = new StructFieldInterop[structFields.Count<StructField>()];
      int num = 0;
      foreach (StructField structField in structFields)
        managedStructs[num++] = new StructFieldInterop()
        {
          Name = StringMarshal.StringToIntPtr(structField.Name),
          DataTypeId = ObjectMarshal.ToIntPtr((object) structField.DataTypeId),
          ValueRank = (int) structField.ValueRank,
          ArrayDimensions = ArrayMarshal.ToNative(structField.ArrayDimensions.ToArray<uint>()),
          InitValue = ObjectMarshal.ToIntPtr(structField.InitValue),
          IsOptional = structField.IsOptional ? 1 : 0,
          AllowSubtypes = structField.AllowSubtypes ? 1 : 0,
          MaxStringLength = structField.MaxStringLength,
          Description = ObjectMarshal.ToIntPtr((object) structField.Description)
        };
      return ArrayMarshal.ToNative<StructFieldInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(IEnumerable<EnumField> enumFields)
    {
      EnumFieldInterop[] managedStructs = new EnumFieldInterop[enumFields.Count<EnumField>()];
      int num = 0;
      foreach (EnumField enumField in enumFields)
        managedStructs[num++] = new EnumFieldInterop()
        {
          Name = StringMarshal.StringToIntPtr(enumField.Name),
          Value = enumField.Value,
          DisplayName = ObjectMarshal.ToIntPtr((object) enumField.DisplayName),
          Description = ObjectMarshal.ToIntPtr((object) enumField.Description)
        };
      return ArrayMarshal.ToNative<EnumFieldInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(MappedTypeDescriptor[] descriptors)
    {
      MappedTypeDescriptorInterop[] managedStructs = new MappedTypeDescriptorInterop[descriptors.Length];
      int num = 0;
      foreach (MappedTypeDescriptor descriptor in descriptors)
        managedStructs[num++] = new MappedTypeDescriptorInterop(descriptor);
      return ArrayMarshal.ToNative<MappedTypeDescriptorInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(MappedDataTypeDescriptor[] descriptors)
    {
      MappedDataTypeDescriptorInterop[] managedStructs = new MappedDataTypeDescriptorInterop[descriptors.Length];
      int num = 0;
      foreach (MappedDataTypeDescriptor descriptor in descriptors)
        managedStructs[num++] = new MappedDataTypeDescriptorInterop(descriptor);
      return ArrayMarshal.ToNative<MappedDataTypeDescriptorInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(UABehaviourDescriptor[] descriptors)
    {
      UABehaviourDescriptorInterop[] managedStructs = new UABehaviourDescriptorInterop[descriptors.Length];
      int num = 0;
      foreach (UABehaviourDescriptor descriptor in descriptors)
        managedStructs[num++] = new UABehaviourDescriptorInterop(descriptor);
      return ArrayMarshal.ToNative<UABehaviourDescriptorInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(List<ExportedMethodParameterInfo> argumentInfos)
    {
      ExportedMethodParameterInfoInterop[] managedStructs = new ExportedMethodParameterInfoInterop[argumentInfos.Count];
      int num = 0;
      foreach (ExportedMethodParameterInfo argumentInfo in argumentInfos)
        managedStructs[num++] = new ExportedMethodParameterInfoInterop(argumentInfo);
      return ArrayMarshal.ToNative<ExportedMethodParameterInfoInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(List<ExportedMethodInfo> methodInfos)
    {
      ExportedMethodInfoInterop[] managedStructs = new ExportedMethodInfoInterop[methodInfos.Count];
      int num = 0;
      foreach (ExportedMethodInfo methodInfo in methodInfos)
        managedStructs[num++] = new ExportedMethodInfoInterop(methodInfo);
      return ArrayMarshal.ToNative<ExportedMethodInfoInterop>(managedStructs);
    }

    public static IntPtr ToNativeArray(List<NetSolutionClassInfo> classInfos)
    {
      NetSolutionClassInfoInterop[] managedStructs = new NetSolutionClassInfoInterop[classInfos.Count];
      int num = 0;
      foreach (NetSolutionClassInfo classInfo in classInfos)
        managedStructs[num++] = new NetSolutionClassInfoInterop(classInfo);
      return ArrayMarshal.ToNative<NetSolutionClassInfoInterop>(managedStructs);
    }
  }
}
