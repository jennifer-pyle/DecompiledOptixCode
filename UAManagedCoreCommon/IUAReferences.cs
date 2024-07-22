// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAReferences
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public interface IUAReferences
  {
    bool IsOrdered { get; }

    IReadOnlyList<UAReference> GetReferences();

    IUANode GetNode(string browseName);

    IUANode GetNode(QualifiedName browseName);

    IUANode GetNode(NodeId referenceTypeId, bool pickSubtypes = true);

    IUANode GetNode(string browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUANode GetNode(QualifiedName browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUAObject GetObject(string browseName);

    IUAObject GetObject(QualifiedName browseName);

    IUAObject GetObject(NodeId referenceTypeId, bool pickSubtypes = true);

    IUAObject GetObject(string browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUAObject GetObject(QualifiedName browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUAVariable GetVariable(string browseName);

    IUAVariable GetVariable(QualifiedName browseName);

    IUAVariable GetVariable(NodeId referenceTypeId, bool pickSubtypes = true);

    IUAVariable GetVariable(string browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUAVariable GetVariable(QualifiedName browseName, NodeId referenceTypeId, bool pickSubtypes = true);

    IUAMethod GetMethod(string browseName);

    IUAMethod GetMethod(QualifiedName browseName);

    IUAObjectType GetObjectType(NodeId referenceTypeId, bool pickSubtypes = true);

    IUAVariableType GetVariableType(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUANode> GetNodes(string browseName);

    IReadOnlyList<IUANode> GetNodes(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUAObject> GetObjects(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUAVariable> GetVariables(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUAMethod> GetMethods(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUAObjectType> GetObjectTypes(NodeId referenceTypeId, bool pickSubtypes = true);

    IReadOnlyList<IUAVariableType> GetVariableTypes(NodeId referenceTypeId, bool pickSubtypes = true);

    UAReference GetReference(NodeId referenceTypeId, NodeId otherNodeId, bool pickSubtypes = true);

    void AddReference(NodeId referenceTypeId, IUANode target);

    void AddReference(NodeId referenceTypeId, NodeId targetId);

    void RemoveReference(NodeId referenceTypeId, NodeId targetId, bool pickSubtypes = true);

    void MoveOrderedReference(NodeId referenceTypeId, uint from, uint to);

    void AttachAndStart(NodeId referenceTypeId, IUANode target);
  }
}
