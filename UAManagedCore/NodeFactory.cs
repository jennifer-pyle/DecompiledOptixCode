// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NodeFactory
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class NodeFactory : INodeFactory
  {
    internal IntPtr contextPtr;

    public void CloneChildrenRecursive(
      IUANode dest,
      IUANode source,
      bool createAsInstanceDeclaration)
    {
      if (dest == null)
        throw new ArgumentNullException(nameof (dest));
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      NodeFactory.Interop.NodeFactoryCloneChildrenRecursive(this.contextPtr, (IntPtr) ((UANode) dest).nodeHandle, (IntPtr) ((UANode) source).nodeHandle, createAsInstanceDeclaration ? 1 : 0).CheckOutcome();
    }

    public TSource CloneNode<TSource>(
      TSource source,
      int namespaceIndex,
      NamingRuleType modellingRule)
      where TSource : IUANode
    {
      return this.CloneNode<TSource>(source, NodeId.Random(namespaceIndex), modellingRule);
    }

    public TSource CloneNode<TSource>(TSource source, NodeId nodeId, NamingRuleType modellingRule) where TSource : IUANode
    {
      if ((object) source == null)
        throw new ArgumentNullException(nameof (source));
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryCloneNode(this.contextPtr, (IntPtr) ((object) source as UANode).nodeHandle, ObjectMarshal.ToIntPtr((object) nodeId), (int) modellingRule);
      interopCallResult.CheckOutcome();
      return (TSource) interopCallResult.Get<IUANode>();
    }

    public TSource CloneSingleNode<TSource>(TSource source, int namespaceIndex) where TSource : IUANode
    {
      return this.CloneSingleNode<TSource>(source, NodeId.Random(namespaceIndex));
    }

    public TSource CloneSingleNode<TSource>(TSource source, NodeId nodeId) where TSource : IUANode
    {
      if ((object) source == null)
        throw new ArgumentNullException(nameof (source));
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryCloneSingleNode(this.contextPtr, (IntPtr) ((object) source as UANode).nodeHandle, ObjectMarshal.ToIntPtr((object) nodeId));
      interopCallResult.CheckOutcome();
      return (TSource) interopCallResult.Get<IUANode>();
    }

    public Type GetNetTypeFromNodeId(NodeId nodeId)
    {
      InteropCallResult interopCallResult = !(nodeId == (NodeId) null) ? NodeFactory.Interop.NodeFactoryGetNetTypeFromNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId)) : throw new ArgumentNullException(nameof (nodeId));
      interopCallResult.CheckOutcome();
      return ObjectMarshal.FromIntPtr<Type>(interopCallResult.ReturnValuePtr);
    }

    public void MakeChildrenRecursive(
      IUANode dest,
      IUANode source,
      bool createAsInstanceDeclaration)
    {
      if (dest == null)
        throw new ArgumentNullException(nameof (dest));
      UANode uaNode = source != null ? (UANode) source : throw new ArgumentNullException(nameof (source));
      NodeFactory.Interop.NodeFactoryMakeChildrenRecursive(this.contextPtr, (IntPtr) ((UANode) dest).nodeHandle, (IntPtr) uaNode.nodeHandle, createAsInstanceDeclaration ? 1 : 0).CheckOutcome();
    }

    public IUADataType MakeDataType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel,
      StructDefinition structDefinition = null,
      EnumDefinition enumDefinition = null)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      if (superTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (superTypeNodeId));
      if (structDefinition != null && enumDefinition != null)
        throw new ArgumentException("Struct definition and enum definition are mututally exclusive");
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeDataType(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) superTypeNodeId), isAbstract ? 1 : 0, (uint) writeMask, ObjectMarshal.ToIntPtr((object) structDefinition), ObjectMarshal.ToIntPtr((object) enumDefinition));
      interopCallResult.CheckOutcome();
      return (IUADataType) interopCallResult.Get<UADataType>();
    }

    public IUAMethod MakeMethod(NodeId nodeId, QualifiedName browseName, WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.Executable | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeMethod(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAMethod) interopCallResult.Get<UAMethod>();
    }

    public IUAMethod MakeMethod(
      NodeId nodeId,
      QualifiedName browseName,
      NamingRuleType modellingRule,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.Executable | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeMethodInstanceDeclaration(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), (int) modellingRule, (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAMethod) interopCallResult.Get<UAMethod>();
    }

    public TSource MakeNode<TSource>(
      TSource source,
      int namespaceIndex,
      NamingRuleType modellingRule)
      where TSource : IUANode
    {
      if ((object) source == null)
        throw new ArgumentNullException(nameof (source));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeNode(this.contextPtr, (IntPtr) ((object) source as UANode).nodeHandle, namespaceIndex, (int) modellingRule);
      interopCallResult.CheckOutcome();
      return (TSource) interopCallResult.Get<IUANode>();
    }

    public IUAObject MakeObject(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId objectTypeNodeId,
      bool populateFromType = true,
      NamingRuleType modellingRule = NamingRuleType.None,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.EventNotifier | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (objectTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (objectTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeObjectWithNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) objectTypeNodeId), populateFromType ? 1 : 0, (int) modellingRule, (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    public IUAObjectType MakeObjectType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      bool populateFromType = true,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (superTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (superTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeObjectType(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) superTypeNodeId), isAbstract ? 1 : 0, populateFromType ? 1 : 0, (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAObjectType) interopCallResult.Get<UAObjectType>();
    }

    public IUAReferenceType MakeReferenceType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      WriteMask writeMask = WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (superTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (superTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeReferenceType(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) superTypeNodeId), isAbstract ? 1 : 0, (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAReferenceType) interopCallResult.Get<UAReferenceType>();
    }

    public IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      NodeId variableTypeNodeId,
      bool populateFromType = true,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (dataTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (dataTypeNodeId));
      if (variableTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (variableTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeVariableWithNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) dataTypeNodeId), ObjectMarshal.ToIntPtr((object) variableTypeNodeId), populateFromType ? 1 : 0, ObjectMarshal.ToIntPtr(initialValue), (uint) writeMask, (uint) accessLevelMask);
      interopCallResult.CheckOutcome();
      return (IUAVariable) interopCallResult.Get<UAVariable>();
    }

    public IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      NodeId variableTypeNodeId,
      bool populateFromType,
      NamingRuleType modellingRule,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (dataTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (dataTypeNodeId));
      if (variableTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (variableTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeVariableInstanceDeclarationWithNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) dataTypeNodeId), ObjectMarshal.ToIntPtr((object) variableTypeNodeId), populateFromType ? 1 : 0, (int) modellingRule, ObjectMarshal.ToIntPtr(initialValue), (uint) writeMask, (uint) accessLevelMask);
      interopCallResult.CheckOutcome();
      return (IUAVariable) interopCallResult.Get<UAVariable>();
    }

    public IUAVariable MakeVariable(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      ValueRank valueRank,
      uint[] arrayDimensions,
      NodeId variableTypeNodeId,
      bool populateFromType = true,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank,
      AccessLevelMask accessLevelMask = AccessLevelMask.Default)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (dataTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (dataTypeNodeId));
      if (variableTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (variableTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeArrayVariableWithNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) dataTypeNodeId), (int) valueRank, ArrayMarshal.ToNative(arrayDimensions), ObjectMarshal.ToIntPtr((object) variableTypeNodeId), populateFromType ? 1 : 0, ObjectMarshal.ToIntPtr(initialValue), (uint) writeMask, (uint) accessLevelMask);
      interopCallResult.CheckOutcome();
      return (IUAVariable) interopCallResult.Get<UAVariable>();
    }

    public IUAVariable MakeVariable(
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
      AccessLevelMask accessLevelMask = AccessLevelMask.Default)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (dataTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (dataTypeNodeId));
      if (variableTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (variableTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeArrayVariableInstanceDeclarationWithNodeId(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) dataTypeNodeId), (int) valueRank, ArrayMarshal.ToNative(arrayDimensions), ObjectMarshal.ToIntPtr((object) variableTypeNodeId), populateFromType ? 1 : 0, (int) modellingRule, ObjectMarshal.ToIntPtr(initialValue), (uint) writeMask, (uint) accessLevelMask);
      interopCallResult.CheckOutcome();
      return (IUAVariable) interopCallResult.Get<UAVariable>();
    }

    public IUAVariableType MakeVariableType(
      NodeId nodeId,
      QualifiedName browseName,
      NodeId dataTypeNodeId,
      ValueRank valueRank,
      uint[] arrayDimensions,
      NodeId superTypeNodeId,
      bool isAbstract = false,
      bool populateFromType = false,
      object initialValue = null,
      WriteMask writeMask = WriteMask.ArrayDimensions | WriteMask.BrowseName | WriteMask.DataType | WriteMask.Description | WriteMask.DisplayName | WriteMask.MinimumSamplingInterval | WriteMask.UserAccessLevel | WriteMask.ValueRank | WriteMask.ValueForVariableType)
    {
      if (nodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeId));
      if (browseName == (QualifiedName) null || string.IsNullOrWhiteSpace(browseName.Name))
        throw new ArgumentNullException(nameof (browseName));
      if (dataTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (dataTypeNodeId));
      if (superTypeNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (superTypeNodeId));
      InteropCallResult interopCallResult = NodeFactory.Interop.NodeFactoryMakeVariableType(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeId), ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) dataTypeNodeId), (int) valueRank, ArrayMarshal.ToNative(arrayDimensions), ObjectMarshal.ToIntPtr((object) superTypeNodeId), isAbstract ? 1 : 0, populateFromType ? 1 : 0, ObjectMarshal.ToIntPtr(initialValue), (uint) writeMask);
      interopCallResult.CheckOutcome();
      return (IUAVariableType) interopCallResult.Get<UAVariableType>();
    }

    public void RegisterBehaviourFactory(Guid guid, IBehaviourFactory behaviourFactory)
    {
      if (behaviourFactory == null)
        throw new ArgumentNullException(nameof (behaviourFactory));
      NodeFactory.Interop.NodeFactoryRegisterBehaviourFactory(this.contextPtr, ObjectMarshal.ToIntPtr((object) guid), ObjectMarshal.ToIntPtr((object) behaviourFactory)).CheckOutcome();
    }

    public void RegisterBehaviourFactoryReference(
      NodeId nodeTypeId,
      Guid guid,
      byte priority,
      BehaviourMode mode = BehaviourMode.Instance)
    {
      if (nodeTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (nodeTypeId));
      NodeFactory.Interop.NodeFactoryRegisterBehaviourFactoryReference(this.contextPtr, ObjectMarshal.ToIntPtr((object) nodeTypeId), ObjectMarshal.ToIntPtr((object) guid), priority, (int) mode).CheckOutcome();
    }

    internal NodeFactory(IntPtr context) => this.contextPtr = context;

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryCloneChildrenRecursive(
        IntPtr context,
        IntPtr dest,
        IntPtr source,
        int createAsInstanceDeclaration);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryCloneNode(
        IntPtr context,
        IntPtr source,
        IntPtr nodeId,
        int modellingRule);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryCloneSingleNode(
        IntPtr context,
        IntPtr source,
        IntPtr nodeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryGetNetTypeFromNodeId(
        IntPtr context,
        IntPtr nodeId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeChildrenRecursive(
        IntPtr context,
        IntPtr dest,
        IntPtr source,
        int createAsInstanceDeclaration);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeDataType(
        IntPtr context,
        IntPtr nodeId,
        IntPtr browseName,
        IntPtr superTypeNodeId,
        int isAbstract,
        uint writeMask,
        IntPtr structDefinition,
        IntPtr enumDefinition);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeMethod(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeMethodInstanceDeclaration(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        int modellingRule,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeNode(
        IntPtr contextPtr,
        IntPtr nodeHandlePtr,
        int namespaceIndex,
        int modellingRule);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeObjectWithNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr objectTypeNodeIdPtr,
        int populateFromType,
        int modellingRule,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeObjectType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr superTypeNodeIdPtr,
        int isAbstract,
        int populateFromType,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeVariableWithNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr dataTypeNodeIdPtr,
        IntPtr variableTypeNodeIdPtr,
        int populateFromType,
        IntPtr initialValuePtr,
        uint writeMask,
        uint accessLevelMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeVariableInstanceDeclarationWithNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr dataTypeNodeIdPtr,
        IntPtr variableTypeNodeIdPtr,
        int populateFromType,
        int modellingRule,
        IntPtr initialValuePtr,
        uint writeMask,
        uint accessLevelMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeArrayVariableWithNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr dataTypeNodeIdPtr,
        int valueRank,
        IntPtr arrayDimensionPtr,
        IntPtr variableTypeNodeIdPtr,
        int populateFromType,
        IntPtr initialValuePtr,
        uint writeMask,
        uint accessLevelMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeArrayVariableInstanceDeclarationWithNodeId(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr dataTypeNodeIdPtr,
        int valueRank,
        IntPtr arrayDimensionPtr,
        IntPtr variableTypeNodeIdPtr,
        int populateFromType,
        int modellingRule,
        IntPtr initialValuePtr,
        uint writeMask,
        uint accessLevelMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeVariableType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr dataTypeNodeIdPtr,
        int valueRank,
        IntPtr arrayDimensionPtr,
        IntPtr superTypeNodeIdPtr,
        int isAbstract,
        int populateFromType,
        IntPtr initialValuePtr,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryMakeReferenceType(
        IntPtr contextPtr,
        IntPtr nodeIdPtr,
        IntPtr browseNamePtr,
        IntPtr superTypeNodeIdPtr,
        int isAbstract,
        uint writeMask);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryRegisterBehaviourFactory(
        IntPtr contextPtr,
        IntPtr guidPtr,
        IntPtr behaviourFactoryPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NodeFactoryRegisterBehaviourFactoryReference(
        IntPtr contextPtr,
        IntPtr nodeTypeIdPtr,
        IntPtr guidPtr,
        byte priority,
        int mode);
    }
  }
}
