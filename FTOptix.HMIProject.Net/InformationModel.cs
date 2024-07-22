// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.InformationModel
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public static class InformationModel
  {
    private static ConcurrentDictionary<Type, NodeId> netTypeToNodeIdMap = new ConcurrentDictionary<Type, NodeId>();

    public static T Make<T>(QualifiedName browseName) where T : class
    {
      Type type = typeof (T);
      NodeId nodeIdFromNetType = InformationModel.GetNodeIdFromNetType(type);
      UACoreContext context = ManagedContextStore.Context;
      if (typeof (IUAObject).IsAssignableFrom(type))
      {
        if (context.GetObjectType(nodeIdFromNetType) == null)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
          interpolatedStringHandler.AppendLiteral("Unable to find object type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("'");
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
        }
        return InformationModel.MakeObject(browseName, nodeIdFromNetType) as T;
      }
      if (typeof (IUAVariable).IsAssignableFrom(type))
      {
        IUAVariableType variableType = context.GetVariableType(nodeIdFromNetType);
        if (variableType == null)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
          interpolatedStringHandler.AppendLiteral("Unable to find variable type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("'");
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
        }
        return InformationModel.MakeVariable(browseName, variableType.DataType, nodeIdFromNetType, variableType.ArrayDimensions) as T;
      }
      if (typeof (IUAObjectType).IsAssignableFrom(type))
      {
        if (context.GetObjectType(nodeIdFromNetType) == null)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
          interpolatedStringHandler.AppendLiteral("Unable to find object type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("'");
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
        }
        return InformationModel.MakeObjectType(browseName, nodeIdFromNetType) as T;
      }
      if (typeof (IUAVariableType).IsAssignableFrom(type))
      {
        IUAVariableType variableType = context.GetVariableType(nodeIdFromNetType);
        if (variableType == null)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
          interpolatedStringHandler.AppendLiteral("Unable to find variable type '");
          interpolatedStringHandler.AppendFormatted<Type>(type);
          interpolatedStringHandler.AppendLiteral("'");
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
        }
        return InformationModel.MakeVariableType(browseName, nodeIdFromNetType, variableType.DataType, variableType.ArrayDimensions) as T;
      }
      DefaultInterpolatedStringHandler interpolatedStringHandler1 = new DefaultInterpolatedStringHandler(62, 1);
      interpolatedStringHandler1.AppendLiteral("Type '");
      interpolatedStringHandler1.AppendFormatted<Type>(type);
      interpolatedStringHandler1.AppendLiteral("' does not represent neither an object, nor a variable, ");
      throw new InvalidOperationException(interpolatedStringHandler1.ToStringAndClear() + "nor an object type, nor a variable type");
    }

    public static IUAObject MakeObject(QualifiedName browseName)
    {
      return InformationModel.MakeObject(browseName, UAManagedCore.OpcUa.ObjectTypes.BaseObjectType);
    }

    public static T MakeObject<T>(QualifiedName browseName) where T : class, IUAObject
    {
      Type type = typeof (T);
      if (!typeof (IUAObject).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent an object");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      NodeId nodeIdFromNetType = InformationModel.GetNodeIdFromNetType(type);
      return InformationModel.MakeObject(browseName, nodeIdFromNetType) as T;
    }

    public static T MakeObject<T>(QualifiedName browseName, NodeId objectTypeId) where T : class, IUAObject
    {
      return InformationModel.MakeObject(browseName, objectTypeId) as T;
    }

    public static IUAObject MakeObject(QualifiedName browseName, NodeId objectTypeId)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeObject(NodeId.Random(defaultNamespaceIndex), browseName, objectTypeId);
    }

    public static IUAVariable MakeVariable(
      QualifiedName browseName,
      NodeId dataTypeId,
      uint[] arrayDimensions = null)
    {
      return InformationModel.MakeVariable(browseName, dataTypeId, UAManagedCore.OpcUa.VariableTypes.BaseDataVariableType, arrayDimensions);
    }

    public static T MakeVariable<T>(
      QualifiedName browseName,
      NodeId dataTypeId,
      uint[] arrayDimensions = null)
      where T : class, IUAVariable
    {
      Type type = typeof (T);
      if (!typeof (IUAVariable).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent a variable");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      NodeId nodeIdFromNetType = InformationModel.GetNodeIdFromNetType(type);
      return InformationModel.MakeVariable(browseName, dataTypeId, nodeIdFromNetType, arrayDimensions) as T;
    }

    public static T MakeVariable<T>(
      QualifiedName browseName,
      NodeId dataTypeId,
      NodeId variableTypeId,
      uint[] arrayDimensions = null)
      where T : class, IUAVariable
    {
      return InformationModel.MakeVariable(browseName, dataTypeId, variableTypeId, arrayDimensions) as T;
    }

    public static IUAVariable MakeVariable(
      QualifiedName browseName,
      NodeId dataTypeId,
      NodeId variableTypeId,
      uint[] arrayDimensions = null)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      if (arrayDimensions == null || arrayDimensions.Length == 0)
        return context.NodeFactory.MakeVariable(NodeId.Random(defaultNamespaceIndex), browseName, dataTypeId, variableTypeId);
      ValueRank valueRank = arrayDimensions.Length == 1 ? ValueRank.OneDimension : ValueRank.OneOrMoreDimensions;
      return context.NodeFactory.MakeVariable(NodeId.Random(defaultNamespaceIndex), browseName, dataTypeId, valueRank, arrayDimensions, variableTypeId);
    }

    public static IUAVariable MakeAnalogItem(QualifiedName browseName, NodeId dataTypeId)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeVariable(NodeId.Random(defaultNamespaceIndex), browseName, dataTypeId, UAManagedCore.OpcUa.VariableTypes.AnalogItemType);
    }

    public static IUAVariable MakeNodePointer(QualifiedName browseName)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeVariable(NodeId.Random(defaultNamespaceIndex), browseName, UAManagedCore.OpcUa.DataTypes.NodeId, UAManagedCore.Ext.VariableTypes.NodePointer);
    }

    public static IUAVariable MakeAlias(QualifiedName browseName)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeVariable(NodeId.Random(defaultNamespaceIndex), browseName, UAManagedCore.OpcUa.DataTypes.NodeId, UAManagedCore.Ext.VariableTypes.Alias);
    }

    public static T MakeObjectType<T>(QualifiedName browseName) where T : class, IUAObjectType
    {
      Type type = typeof (T);
      if (!typeof (IUAObjectType).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent an object type");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      NodeId nodeIdFromNetType = InformationModel.GetNodeIdFromNetType(type);
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeObjectType(NodeId.Random(defaultNamespaceIndex), browseName, nodeIdFromNetType) as T;
    }

    public static IUAObjectType MakeObjectType(QualifiedName browseName)
    {
      return InformationModel.MakeObjectType(browseName, UAManagedCore.OpcUa.ObjectTypes.BaseObjectType);
    }

    public static IUAObjectType MakeObjectType(QualifiedName browseName, NodeId superTypeId)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      return context.NodeFactory.MakeObjectType(NodeId.Random(defaultNamespaceIndex), browseName, superTypeId);
    }

    public static T GetObjectType<T>() where T : class, IUAObjectType
    {
      Type type = typeof (T);
      if (!typeof (IUAObjectType).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent an object type");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      return ManagedContextStore.Context.GetObjectType(InformationModel.GetNodeIdFromNetType(type)) as T;
    }

    public static IUAVariableType MakeVariableType(
      QualifiedName browseName,
      NodeId dataTypeId,
      uint[] arrayDimensions = null)
    {
      return InformationModel.MakeVariableType(browseName, UAManagedCore.OpcUa.VariableTypes.BaseDataVariableType, dataTypeId, arrayDimensions);
    }

    public static T MakeVariableType<T>(
      QualifiedName browseName,
      NodeId dataTypeId,
      uint[] arrayDimensions = null)
      where T : class, IUAVariableType
    {
      Type type = typeof (T);
      if (!typeof (IUAVariableType).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent a variable type");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      NodeId nodeIdFromNetType = InformationModel.GetNodeIdFromNetType(type);
      return InformationModel.MakeVariableType(browseName, nodeIdFromNetType, dataTypeId, arrayDimensions) as T;
    }

    public static IUAVariableType MakeVariableType(
      QualifiedName browseName,
      NodeId superTypeId,
      NodeId dataTypeId,
      uint[] arrayDimensions = null)
    {
      UACoreContext context = ManagedContextStore.Context;
      int defaultNamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      ValueRank valueRank = arrayDimensions == null ? ValueRank.Scalar : ValueRank.OneOrMoreDimensions;
      if (arrayDimensions == null)
        arrayDimensions = Array.Empty<uint>();
      return context.NodeFactory.MakeVariableType(NodeId.Random(defaultNamespaceIndex), browseName, dataTypeId, valueRank, arrayDimensions, superTypeId, populateFromType: true);
    }

    public static T GetVariableType<T>() where T : class, IUAVariableType
    {
      Type type = typeof (T);
      if (!typeof (IUAVariableType).IsAssignableFrom(type))
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
        interpolatedStringHandler.AppendLiteral("Type '");
        interpolatedStringHandler.AppendFormatted<Type>(type);
        interpolatedStringHandler.AppendLiteral("' does not represent a variable type");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      return ManagedContextStore.Context.GetVariableType(InformationModel.GetNodeIdFromNetType(type)) as T;
    }

    public static LocalizedText LookupTranslation(LocalizedText localizedText)
    {
      if (localizedText.NamespaceIndex == NodeId.InvalidNamespaceIndex)
        localizedText.NamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) ManagedContextStore.Context);
      return ManagedContextStore.Context.LookupTranslation(localizedText);
    }

    public static LocalizedText LookupTranslation(
      LocalizedText localizedText,
      List<string> localeIds)
    {
      if (localizedText.NamespaceIndex == NodeId.InvalidNamespaceIndex)
        localizedText.NamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) ManagedContextStore.Context);
      return ManagedContextStore.Context.LookupTranslation(localizedText, (IReadOnlyList<string>) localeIds);
    }

    public static void AddTranslation(
      LocalizedText localizedText,
      IUAVariable localizationDictionary = null)
    {
      UACoreContext context = ManagedContextStore.Context;
      int namespaceIndex = localizedText.NamespaceIndex;
      if (namespaceIndex == NodeId.InvalidNamespaceIndex)
        namespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) context);
      if (localizationDictionary == null)
      {
        localizationDictionary = context.GetVariableType(FTOptix.Core.VariableTypes.LocalizationDictionary).InverseRefs.GetNodes(UAManagedCore.OpcUa.ReferenceTypes.HasTypeDefinition, false).OfType<IUAVariable>().FirstOrDefault<IUAVariable>((Func<IUAVariable, bool>) (n => n.NodeId.NamespaceIndex == namespaceIndex));
        if (localizationDictionary == null)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 1);
          interpolatedStringHandler.AppendLiteral("Unable to find a localization dictionary with namespace index ");
          interpolatedStringHandler.AppendFormatted<int>(namespaceIndex);
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
        }
      }
      else if (localizationDictionary.NodeId.NamespaceIndex != namespaceIndex)
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
        interpolatedStringHandler.AppendLiteral("Localization dictionary must have namespace index equal to ");
        interpolatedStringHandler.AppendFormatted<int>(namespaceIndex);
        throw new ArgumentException(interpolatedStringHandler.ToStringAndClear(), nameof (localizationDictionary));
      }
      string[,] strArray1 = (string[,]) localizationDictionary.Value.Value;
      int length1 = strArray1.GetLength(0);
      int length2 = strArray1.GetLength(1);
      int num = -1;
      for (int index = 1; index < length2; ++index)
      {
        if (strArray1[0, index] == localizedText.LocaleId)
        {
          num = index;
          break;
        }
      }
      if (num == -1)
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 2);
        interpolatedStringHandler.AppendLiteral("Localization dictionary ");
        interpolatedStringHandler.AppendFormatted(Log.Node((IUANode) localizationDictionary));
        interpolatedStringHandler.AppendLiteral(" does not contain ");
        interpolatedStringHandler.AppendLiteral("locale ID '");
        interpolatedStringHandler.AppendFormatted(localizedText.LocaleId);
        interpolatedStringHandler.AppendLiteral("'");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      string[,] strArray2 = new string[length1 + 1, length2];
      for (int index1 = 0; index1 < length1; ++index1)
      {
        if (index1 > 0 && strArray1[index1, 0] == localizedText.TextId)
        {
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(72, 2);
          interpolatedStringHandler.AppendLiteral("Localization dictionary ");
          interpolatedStringHandler.AppendFormatted(Log.Node((IUANode) localizationDictionary));
          interpolatedStringHandler.AppendLiteral(" already ");
          interpolatedStringHandler.AppendLiteral("contains a translation for text ID '");
          interpolatedStringHandler.AppendFormatted(localizedText.TextId);
          interpolatedStringHandler.AppendLiteral("'. ");
          throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear() + "Call the InformationModel.SetTranslation method to update the translation instead.");
        }
        for (int index2 = 0; index2 < length2; ++index2)
          strArray2[index1, index2] = strArray1[index1, index2];
      }
      strArray2[length1, 0] = localizedText.TextId;
      for (int index = 1; index < length2; ++index)
        strArray2[length1, index] = index == num ? localizedText.Text : string.Empty;
      localizationDictionary.SetValue((object) strArray2);
    }

    public static void SetTranslation(LocalizedText localizedText)
    {
      if (localizedText.NamespaceIndex == NodeId.InvalidNamespaceIndex)
        localizedText.NamespaceIndex = InformationModel.GetDefaultNamespaceIndex((IContext) ManagedContextStore.Context);
      ManagedContextStore.Context.SetTranslation(localizedText);
    }

    public static IUANode Get(NodeId nodeId) => ManagedContextStore.Context.GetNode(nodeId);

    public static IUAObject GetObject(NodeId nodeId)
    {
      return ManagedContextStore.Context.GetObject(nodeId);
    }

    public static IUAVariable GetVariable(NodeId nodeId)
    {
      return ManagedContextStore.Context.GetVariable(nodeId);
    }

    public static T Get<T>(NodeId nodeId) where T : class, IUANode
    {
      return ManagedContextStore.Context.GetNode(nodeId) as T;
    }

    public static IEnumerable<RemoteVariableValue> RemoteRead(
      IEnumerable<RemoteVariable> variables,
      double timeoutMilliseconds = 30000.0)
    {
      return ManagedContextStore.Context.RemoteRead(variables, timeoutMilliseconds);
    }

    public static void RemoteWrite(
      IEnumerable<RemoteVariableValue> variableValues,
      double timeoutMilliseconds = 30000.0)
    {
      ManagedContextStore.Context.RemoteWrite(variableValues, timeoutMilliseconds);
    }

    private static int GetDefaultNamespaceIndex(IContext context)
    {
      int defaultNamespaceIndex = context.DefaultNamespaceIndex;
      if (defaultNamespaceIndex == NodeId.InvalidNamespaceIndex)
        defaultNamespaceIndex = Project.Current.NodeId.NamespaceIndex;
      return defaultNamespaceIndex;
    }

    private static NodeId GetNodeIdFromNetType(Type type)
    {
      if (InformationModel.netTypeToNodeIdMap.ContainsKey(type))
        return InformationModel.netTypeToNodeIdMap[type];
      NodeId nodeIdFromNetType = CoreContextBaseExtensions.NodeIdOfType(type);
      InformationModel.netTypeToNodeIdMap[type] = nodeIdFromNetType;
      return nodeIdFromNetType;
    }
  }
}
