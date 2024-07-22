// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAReferences
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public class UAReferences : IUAReferences
  {
    private readonly UANodeSafeHandle nodeHandle;
    private readonly UAReferences.ReferenceDirection direction;

    public bool IsOrdered
    {
      get
      {
        InteropCallResult interopCallResult = UAReferences.Interop.UAReferencesIsOrdered((IntPtr) this.nodeHandle, (int) this.direction);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public void AddReference(NodeId referenceTypeId, IUANode target)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      UANode uaNode = target != null ? (UANode) target : throw new ArgumentNullException(nameof (target));
      UAReferences.Interop.UAReferencesAddReferenceByNode((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), (IntPtr) uaNode.nodeHandle).CheckOutcome();
    }

    public void AddReference(NodeId referenceTypeId, NodeId targetId)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      if (targetId == (NodeId) null)
        throw new ArgumentNullException(nameof (targetId));
      UAReferences.Interop.UAReferencesAddReferenceByNodeId((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), ObjectMarshal.ToIntPtr((object) targetId)).CheckOutcome();
    }

    public void AttachAndStart(NodeId referenceTypeId, IUANode target)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      UANode uaNode = target != null ? (UANode) target : throw new ArgumentNullException(nameof (target));
      UAReferences.Interop.UAReferencesAttachAndStart((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), ObjectMarshal.ToIntPtr((object) uaNode.nodeHandle)).CheckOutcome();
    }

    public IUAMethod GetMethod(string browseName)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult methodByBrowseName = UAReferences.Interop.UAReferencesGetMethodByBrowseName((IntPtr) this.nodeHandle, (int) this.direction, browseName);
      methodByBrowseName.CheckOutcome();
      return (IUAMethod) methodByBrowseName.Get<UAMethod>();
    }

    public IUAMethod GetMethod(QualifiedName browseName)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult qualifiedBrowseName = UAReferences.Interop.UAReferencesGetMethodByQualifiedBrowseName((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName));
      qualifiedBrowseName.CheckOutcome();
      return (IUAMethod) qualifiedBrowseName.Get<UAMethod>();
    }

    public IReadOnlyList<IUAMethod> GetMethods(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult methods = UAReferences.Interop.UAReferencesGetMethods((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      methods.CheckOutcome();
      return (IReadOnlyList<IUAMethod>) methods.GetArray<UAMethod>();
    }

    public IUANode GetNode(string browseName)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult nodeByBrowseName = UAReferences.Interop.UAReferencesGetNodeByBrowseName((IntPtr) this.nodeHandle, (int) this.direction, browseName);
      nodeByBrowseName.CheckOutcome();
      return (IUANode) nodeByBrowseName.Get<UANode>();
    }

    public IUANode GetNode(QualifiedName browseName)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult qualifiedBrowseName = UAReferences.Interop.UAReferencesGetNodeByQualifiedBrowseName((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName));
      qualifiedBrowseName.CheckOutcome();
      return (IUANode) qualifiedBrowseName.Get<UANode>();
    }

    public IUANode GetNode(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult nodeByReferenceType = UAReferences.Interop.UAReferencesGetNodeByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      nodeByReferenceType.CheckOutcome();
      return (IUANode) nodeByReferenceType.Get<UANode>();
    }

    public IUANode GetNode(string browseName, NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetNodeByBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, browseName, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUANode) andReferenceType.Get<UANode>();
    }

    public IUANode GetNode(QualifiedName browseName, NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetNodeByQualifiedBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUANode) andReferenceType.Get<UANode>();
    }

    public IReadOnlyList<IUANode> GetNodes(string browseName)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult nodesByBrowseName = UAReferences.Interop.UAReferencesGetNodesByBrowseName((IntPtr) this.nodeHandle, (int) this.direction, browseName);
      nodesByBrowseName.CheckOutcome();
      return (IReadOnlyList<IUANode>) nodesByBrowseName.GetArray<UANode>();
    }

    public IReadOnlyList<IUANode> GetNodes(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult nodesByReferenceType = UAReferences.Interop.UAReferencesGetNodesByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      nodesByReferenceType.CheckOutcome();
      return (IReadOnlyList<IUANode>) nodesByReferenceType.GetArray<UANode>();
    }

    public IUAObject GetObject(string browseName)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult objectByBrowseName = UAReferences.Interop.UAReferencesGetObjectByBrowseName((IntPtr) this.nodeHandle, (int) this.direction, browseName);
      objectByBrowseName.CheckOutcome();
      return (IUAObject) objectByBrowseName.Get<UAObject>();
    }

    public IUAObject GetObject(QualifiedName browseName)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult qualifiedBrowseName = UAReferences.Interop.UAReferencesGetObjectByQualifiedBrowseName((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName));
      qualifiedBrowseName.CheckOutcome();
      return (IUAObject) qualifiedBrowseName.Get<UAObject>();
    }

    public IUAObject GetObject(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult objectByReferenceType = UAReferences.Interop.UAReferencesGetObjectByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      objectByReferenceType.CheckOutcome();
      return (IUAObject) objectByReferenceType.Get<UAObject>();
    }

    public IUAObject GetObject(string browseName, NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetObjectByBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, browseName, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUAObject) andReferenceType.Get<UAObject>();
    }

    public IUAObject GetObject(QualifiedName browseName, NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetObjectByQualifiedBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUAObject) andReferenceType.Get<UAObject>();
    }

    public IReadOnlyList<IUAObject> GetObjects(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult objects = UAReferences.Interop.UAReferencesGetObjects((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      objects.CheckOutcome();
      return (IReadOnlyList<IUAObject>) objects.GetArray<UAObject>();
    }

    public IUAObjectType GetObjectType(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult typeByReferenceType = UAReferences.Interop.UAReferencesGetObjectTypeByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      typeByReferenceType.CheckOutcome();
      return (IUAObjectType) typeByReferenceType.Get<UAObjectType>();
    }

    public IReadOnlyList<IUAObjectType> GetObjectTypes(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult objectTypes = UAReferences.Interop.UAReferencesGetObjectTypes((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      objectTypes.CheckOutcome();
      return (IReadOnlyList<IUAObjectType>) objectTypes.GetArray<UAObjectType>();
    }

    public UAReference GetReference(NodeId referenceTypeId, NodeId otherNodeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      if (otherNodeId == (NodeId) null)
        throw new ArgumentNullException(nameof (otherNodeId));
      InteropCallResult reference = UAReferences.Interop.UAReferencesGetReference((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), ObjectMarshal.ToIntPtr((object) otherNodeId), pickSubtypes ? 1 : 0);
      reference.CheckOutcome();
      UAReferenceInterop referenceInterop = reference.GetStruct<UAReferenceInterop>();
      return new UAReference(ObjectMarshal.ReleaseGCHandle<NodeId>(referenceInterop.ReferenceTypeId), ObjectMarshal.ReleaseGCHandle<NodeId>(referenceInterop.TargetNodeId), (IUANode) ObjectMarshal.FromIntPtr<UANode>(referenceInterop.TargetNode));
    }

    public IReadOnlyList<UAReference> GetReferences()
    {
      InteropCallResult references1 = UAReferences.Interop.UAReferencesGetReferences((IntPtr) this.nodeHandle, (int) this.direction);
      references1.CheckOutcome();
      UAReferenceInterop[] structArray = references1.GetStructArray<UAReferenceInterop>();
      UAReference[] references2 = new UAReference[structArray.Length];
      for (int index = 0; index < structArray.Length; ++index)
        references2[index] = new UAReference(ObjectMarshal.ReleaseGCHandle<NodeId>(structArray[index].ReferenceTypeId), ObjectMarshal.ReleaseGCHandle<NodeId>(structArray[index].TargetNodeId), (IUANode) ObjectMarshal.FromIntPtr<UANode>(structArray[index].TargetNode));
      return (IReadOnlyList<UAReference>) references2;
    }

    public IUAVariable GetVariable(string browseName)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult variableByBrowseName = UAReferences.Interop.UAReferencesGetVariableByBrowseName((IntPtr) this.nodeHandle, (int) this.direction, browseName);
      variableByBrowseName.CheckOutcome();
      return (IUAVariable) variableByBrowseName.Get<UAVariable>();
    }

    public IUAVariable GetVariable(QualifiedName browseName)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      InteropCallResult qualifiedBrowseName = UAReferences.Interop.UAReferencesGetVariableByQualifiedBrowseName((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName));
      qualifiedBrowseName.CheckOutcome();
      return (IUAVariable) qualifiedBrowseName.Get<UAVariable>();
    }

    public IUAVariable GetVariable(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult variableByReferenceType = UAReferences.Interop.UAReferencesGetVariableByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      variableByReferenceType.CheckOutcome();
      return (IUAVariable) variableByReferenceType.Get<UAVariable>();
    }

    public IUAVariable GetVariable(string browseName, NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (browseName == null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetVariableByBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, browseName, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUAVariable) andReferenceType.Get<UAVariable>();
    }

    public IUAVariable GetVariable(
      QualifiedName browseName,
      NodeId referenceTypeId,
      bool pickSubtypes = true)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult andReferenceType = UAReferences.Interop.UAReferencesGetVariableByQualifiedBrowseNameAndReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) browseName), ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      andReferenceType.CheckOutcome();
      return (IUAVariable) andReferenceType.Get<UAVariable>();
    }

    public IReadOnlyList<IUAVariable> GetVariables(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult variables = UAReferences.Interop.UAReferencesGetVariables((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      variables.CheckOutcome();
      return (IReadOnlyList<IUAVariable>) variables.GetArray<UAVariable>();
    }

    public IUAVariableType GetVariableType(NodeId referenceTypeId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult typeByReferenceType = UAReferences.Interop.UAReferencesGetVariableTypeByReferenceType((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      typeByReferenceType.CheckOutcome();
      return (IUAVariableType) typeByReferenceType.Get<UAVariableType>();
    }

    public IReadOnlyList<IUAVariableType> GetVariableTypes(
      NodeId referenceTypeId,
      bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      InteropCallResult variableTypes = UAReferences.Interop.UAReferencesGetVariableTypes((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), pickSubtypes ? 1 : 0);
      variableTypes.CheckOutcome();
      return (IReadOnlyList<IUAVariableType>) variableTypes.GetArray<UAVariableType>();
    }

    public void MoveOrderedReference(NodeId referenceTypeId, uint from, uint to)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      UAReferences.Interop.UAReferencesMoveOrderedReference((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), from, to).CheckOutcome();
    }

    public void RemoveReference(NodeId referenceTypeId, NodeId targetId, bool pickSubtypes = true)
    {
      if (referenceTypeId == (NodeId) null)
        throw new ArgumentNullException(nameof (referenceTypeId));
      UAReferences.Interop.UAReferencesRemoveReference((IntPtr) this.nodeHandle, (int) this.direction, ObjectMarshal.ToIntPtr((object) referenceTypeId), ObjectMarshal.ToIntPtr((object) targetId), pickSubtypes ? 1 : 0).CheckOutcome();
    }

    internal UAReferences(UANodeSafeHandle nodeHandle, UAReferences.ReferenceDirection direction)
    {
      this.nodeHandle = nodeHandle;
      this.direction = direction;
    }

    internal enum ReferenceDirection
    {
      Forward,
      Inverse,
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesIsOrdered(
        IntPtr nodeHandle,
        int direction);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesAddReferenceByNode(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        IntPtr targetNodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesAddReferenceByNodeId(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        IntPtr targetIdPtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesAttachAndStart(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        IntPtr targetNodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetMethodByBrowseName(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetMethodByQualifiedBrowseName(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetMethods(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodeByBrowseName(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodeByQualifiedBrowseName(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodeByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodeByBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodeByQualifiedBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodesByBrowseName(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetNodesByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectByBrowseName(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectByQualifiedBrowseName(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectByBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectByQualifiedBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjects(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectTypeByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetObjectTypes(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetReference(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        IntPtr otherNodeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetReferences(
        IntPtr nodeHandle,
        int direction);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableByBrowseName(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableByQualifiedBrowseName(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableByBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableByQualifiedBrowseNameAndReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr browseNamePtr,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariables(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableTypeByReferenceType(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesGetVariableTypes(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        int pickSubtypes);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesMoveOrderedReference(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        uint from,
        uint to);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UAReferencesRemoveReference(
        IntPtr nodeHandle,
        int direction,
        IntPtr referenceTypeIdPtr,
        IntPtr targetIdPtr,
        int pickSubtypes);
    }
  }
}
