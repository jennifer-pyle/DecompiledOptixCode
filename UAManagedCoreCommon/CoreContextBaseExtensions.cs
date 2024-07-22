// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CoreContextBaseExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class CoreContextBaseExtensions
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId NodeIdOfType(Type type, bool throwIfNotFound = true)
    {
      ExpandedNodeIdAttribute mapType = !type.IsConstructedGenericType ? (ExpandedNodeIdAttribute) type.GetCustomAttribute<MapTypeAttribute>() : (ExpandedNodeIdAttribute) CoreContextBaseExtensions.GetTemplatedAttribute(type);
      if (mapType == null)
      {
        if (throwIfNotFound)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
          interpolatedStringHandler.AppendLiteral("Type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("' has not the required MapTypeAttribute");
          throw new ArgumentException(interpolatedStringHandler.ToStringAndClear());
        }
        return NodeId.Empty;
      }
      int namespaceIndex = CoreContextBaseExtensions.GetNamespaceIndex(mapType, type);
      NodeId nodeId = (NodeId) null;
      TypeSwitch.On<object>(mapType.Id).Case<uint>((Action<uint>) (x => nodeId = new NodeId(namespaceIndex, x))).Case<string>((Action<string>) (x => nodeId = new NodeId(namespaceIndex, x))).Case<Guid>((Action<Guid>) (x => nodeId = new NodeId(namespaceIndex, x))).Default((Action<object>) (x =>
      {
        throw new ArgumentException("Invalid id type");
      }));
      return nodeId;
    }

    private static TemplatedMapTypeAttributeBase GetTemplatedAttribute(Type type)
    {
      IEnumerable<TemplatedMapTypeAttributeBase> customAttributes1 = (IEnumerable<TemplatedMapTypeAttributeBase>) type.GetCustomAttributes<TemplatedVariableMapTypeAttribute>();
      if (customAttributes1.Any<TemplatedMapTypeAttributeBase>())
        return customAttributes1.Single<TemplatedMapTypeAttributeBase>((Func<TemplatedMapTypeAttributeBase, bool>) (x => x.NetDataType == type.GenericTypeArguments[0]));
      IEnumerable<TemplatedMapTypeAttributeBase> customAttributes2 = (IEnumerable<TemplatedMapTypeAttributeBase>) type.GetCustomAttributes<TemplatedObjectMapTypeAttribute>();
      return customAttributes2.Any<TemplatedMapTypeAttributeBase>() ? customAttributes2.Single<TemplatedMapTypeAttributeBase>((Func<TemplatedMapTypeAttributeBase, bool>) (x => x.NetDataType == type.GenericTypeArguments[0])) : (TemplatedMapTypeAttributeBase) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId NodeIdOfDataType(Type type, bool throwIfNotFound = true)
    {
      ExpandedNodeIdAttribute customAttribute = (ExpandedNodeIdAttribute) type.GetCustomAttribute<MapDataTypeAttribute>();
      if (customAttribute == null)
      {
        if (throwIfNotFound)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
          interpolatedStringHandler.AppendLiteral("Type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("' has not the required MapDataTypeAttribute");
          throw new ArgumentException(interpolatedStringHandler.ToStringAndClear());
        }
        return NodeId.Empty;
      }
      int namespaceIndex = CoreContextBaseExtensions.GetNamespaceIndex(customAttribute, type);
      NodeId nodeId = (NodeId) null;
      TypeSwitch.On<object>(customAttribute.Id).Case<uint>((Action<uint>) (x => nodeId = new NodeId(namespaceIndex, x))).Case<string>((Action<string>) (x => nodeId = new NodeId(namespaceIndex, x))).Case<Guid>((Action<Guid>) (x => nodeId = new NodeId(namespaceIndex, x))).Default((Action<object>) (x =>
      {
        throw new ArgumentException("Invalid id type");
      }));
      return nodeId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static int GetNamespaceIndex(ExpandedNodeIdAttribute mapType, Type type)
    {
      return NamespaceMapProvider.GetNamespaceIndex(!string.IsNullOrWhiteSpace(mapType.NamespaceUri) ? mapType.NamespaceUri : type.Assembly.GetCustomAttribute<ModuleDefaultNamespaceAttribute>().NamespaceUri);
    }
  }
}
