// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ReflectionExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

#nullable enable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class ReflectionExtensions
  {
    private static readonly 
    #nullable disable
    Type[] EmptyTypeArray = new Type[0];

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<Type> GetParentTypes(this Type type, params Type[] stopTypes)
    {
      if (!(type == (Type) null))
      {
        if (stopTypes == null)
          stopTypes = ReflectionExtensions.EmptyTypeArray;
        for (Type currentBaseType = type.BaseType; currentBaseType != (Type) null && !((IEnumerable<Type>) stopTypes).Contains<Type>(currentBaseType); currentBaseType = currentBaseType.BaseType)
          yield return currentBaseType;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<Type> GetSelfAndParentTypes(this Type type, params Type[] stopTypes)
    {
      if (!(type == (Type) null))
      {
        yield return type;
        foreach (Type parentType in type.GetParentTypes(stopTypes))
          yield return parentType;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<Type> GetSelfAndParentTypesIncludingInterfaces(
      this Type type,
      params Type[] stopTypes)
    {
      return type.GetSelfAndParentTypes(stopTypes).Union<Type>(((IEnumerable<Type>) type.GetInterfaces()).Except<Type>((IEnumerable<Type>) stopTypes));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<Type> GetParentTypeIncludingInterfaces(this Type type)
    {
      if (type.BaseType != (Type) null && type.BaseType != typeof (object) && !type.BaseType.IsInterface)
        return (IEnumerable<Type>) new Type[1]
        {
          type.BaseType
        };
      Type[] interfaces = type.GetInterfaces();
      return ((IEnumerable<Type>) interfaces).Except<Type>(((IEnumerable<Type>) interfaces).SelectMany<Type, Type>((Func<Type, IEnumerable<Type>>) (t => (IEnumerable<Type>) t.GetInterfaces())));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<MethodInfo> GetAllMethods(this Type type, params Type[] stopTypes)
    {
      return type.GetSelfAndParentTypesIncludingInterfaces(stopTypes).SelectMany<Type, MethodInfo>((Func<Type, IEnumerable<MethodInfo>>) (t => t.GetTypeInfo().DeclaredMethods));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<PropertyInfo> GetAllProperties(
      this Type type,
      params Type[] stopTypes)
    {
      return type.GetSelfAndParentTypesIncludingInterfaces(stopTypes).SelectMany<Type, PropertyInfo>((Func<Type, IEnumerable<PropertyInfo>>) (t => t.GetTypeInfo().DeclaredProperties));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<MethodInfo> GetRuntimeMethodsStoppingAt<TStopType>(this Type type)
    {
      List<Type> includedTypes = type.GetSelfAndParentTypes(typeof (TStopType)).ToList<Type>();
      return type.GetRuntimeMethods().Where<MethodInfo>((Func<MethodInfo, bool>) (m => includedTypes.Contains(m.DeclaringType)));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<Type> GetTypes<TBaseType, TAttribute>(this Assembly assembly)
      where TBaseType : class
      where TAttribute : Attribute
    {
      return ((IEnumerable<Type>) assembly.GetTypes()).Where<Type>((Func<Type, bool>) (t => typeof (TBaseType).IsAssignableFrom(t) && Attribute.IsDefined((MemberInfo) t, typeof (TAttribute))));
    }
  }
}
