// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypedStructBase
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class TypedStructBase : Struct
  {
    protected static NodeId GetDataTypeId(Type type)
    {
      return CoreContextBaseExtensions.NodeIdOfDataType(type);
    }

    protected static IReadOnlyList<PropertyInfo> GetProperties(Type type)
    {
      return (IReadOnlyList<PropertyInfo>) ((IEnumerable<PropertyInfo>) type.GetProperties()).Select(propertyInfo => new
      {
        propertyInfo = propertyInfo,
        structFieldInfoAttribute = propertyInfo.GetCustomAttribute<StructFieldInfoAttribute>()
      }).Where(_param1 => _param1.structFieldInfoAttribute != null).OrderBy(_param1 => _param1.structFieldInfoAttribute.Order).Select(_param1 => _param1.propertyInfo).ToArray<PropertyInfo>();
    }

    protected TypedStructBase()
      : base()
    {
      this.DataTypeId = this.GetDataTypeId();
      this.ValuesGetter = new Func<IReadOnlyList<object>>(this.GetValuesFromProperties);
    }

    protected abstract NodeId GetDataTypeId();

    protected abstract IReadOnlyList<PropertyInfo> GetPropertyInfos();

    internal override void SetValues(IReadOnlyList<object> values)
    {
      IReadOnlyList<PropertyInfo> propertyInfos = this.GetPropertyInfos();
      for (int index = 0; index < propertyInfos.Count; ++index)
      {
        object obj = values[index];
        PropertyInfo propertyInfo = propertyInfos[index];
        Type propertyType = propertyInfo.PropertyType;
        if (propertyType.IsArray && typeof (Struct[]) != propertyType && typeof (Struct).IsAssignableFrom(propertyType.GetElementType()) && propertyType.GetArrayRank() == 1)
        {
          Struct[] sourceArray = (Struct[]) obj;
          Array instance = Array.CreateInstance(propertyType.GetElementType(), sourceArray.Length);
          Array.Copy((Array) sourceArray, instance, sourceArray.Length);
          obj = (object) instance;
        }
        propertyInfo.SetValue((object) this, obj);
      }
    }

    private IReadOnlyList<object> GetValuesFromProperties()
    {
      IReadOnlyList<PropertyInfo> propertyInfos = this.GetPropertyInfos();
      object[] valuesFromProperties = new object[propertyInfos.Count];
      for (int index = 0; index < propertyInfos.Count; ++index)
        valuesFromProperties[index] = propertyInfos[index].GetValue((object) this);
      return (IReadOnlyList<object>) valuesFromProperties;
    }
  }
}
