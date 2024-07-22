// Decompiled with JetBrains decompiler
// Type: UAManagedCore.INodeFactory
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface INodeFactory
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAReferenceType MakeReferenceType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAObjectType MakeObjectType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      bool populateFromType = true,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAObject MakeObject(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId objectTypeNodeId,
      bool populateFromType = true,
      NamingRuleType modellingRule = NamingRuleType.None,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.EventNotifier | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariableType MakeVariableType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      ValueRank valueRank,
      uint[] arrayDimensions,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      bool populateFromType = false,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank | WriteMask.ValueForVariableType);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      NodeId variableTypeNodeId,
      bool populateFromType = true,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      NodeId variableTypeNodeId,
      bool populateFromType,
      NamingRuleType modellingRule,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      ValueRank valueRank,
      uint[] arrayDimensions,
      NodeId variableTypeNodeId,
      bool populateFromType = true,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      ValueRank valueRank,
      uint[] arrayDimensions,
      NodeId variableTypeNodeId,
      bool populateFromType,
      NamingRuleType modellingRule,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUADataType MakeDataType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel,
      StructDefinition structDefinition = null,
      EnumDefinition enumDefinition = null);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAMethod MakeMethod(NodeId nodeId, QualifiedName browseName, WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.Executable | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAMethod MakeMethod(
      NodeId nodeId,
      QualifiedName browseName,
      NamingRuleType modellingRule,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.Executable | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RegisterBehaviourFactory(Guid guid, IBehaviourFactory behaviourFactory);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void RegisterBehaviourFactoryReference(
      NodeId nodeTypeId,
      Guid guid,
      byte priority,
      BehaviourMode mode = BehaviourMode.Instance);

    [EditorBrowsable(EditorBrowsableState.Never)]
    TSource MakeNode<TSource>(TSource source, int namespaceIndex, NamingRuleType modellingRule) where TSource : IUANode;

    [EditorBrowsable(EditorBrowsableState.Never)]
    TSource CloneNode<TSource>(TSource source, int namespaceIndex, NamingRuleType modellingRule) where TSource : IUANode;

    [EditorBrowsable(EditorBrowsableState.Never)]
    TSource CloneNode<TSource>(TSource source, NodeId nodeId, NamingRuleType modellingRule) where TSource : IUANode;

    [EditorBrowsable(EditorBrowsableState.Never)]
    TSource CloneSingleNode<TSource>(TSource source, int namespaceIndex) where TSource : IUANode;

    [EditorBrowsable(EditorBrowsableState.Never)]
    TSource CloneSingleNode<TSource>(TSource source, NodeId nodeId) where TSource : IUANode;

    [EditorBrowsable(EditorBrowsableState.Never)]
    void CloneChildrenRecursive(IUANode dest, IUANode source, bool createAsInstanceDeclaration);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void MakeChildrenRecursive(IUANode dest, IUANode source, bool createAsInstanceDeclaration);

    [EditorBrowsable(EditorBrowsableState.Never)]
    Type GetNetTypeFromNodeId(NodeId nodeId);
  }
}
