// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypedStruct`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace UAManagedCore
{
  public abstract class TypedStruct<T> : TypedStructBase where T : TypedStruct<T>
  {
    private static readonly NodeId dataTypeId;
    private static readonly IReadOnlyList<PropertyInfo> properties;

    static TypedStruct()
    {
      Type type = typeof (T);
      TypedStruct<T>.dataTypeId = TypedStructBase.GetDataTypeId(type);
      TypedStruct<T>.properties = TypedStructBase.GetProperties(type);
    }

    protected override sealed NodeId GetDataTypeId() => TypedStruct<T>.dataTypeId;

    protected override sealed IReadOnlyList<PropertyInfo> GetPropertyInfos()
    {
      return TypedStruct<T>.properties;
    }
  }
}
