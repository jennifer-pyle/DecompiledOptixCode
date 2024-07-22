// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UANode
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore
{
  public abstract class UANode : IUANode
  {
    internal UANodeSafeHandle nodeHandle;
    private NodeId nodeId;

    public IContext Context { get; private set; }

    public IUAReferences Refs { get; private set; }

    public IUAReferences InverseRefs { get; private set; }

    public ChildNodeCollection Children { get; private set; }

    public string BrowseName
    {
      get
      {
        InteropCallResult browseName = UANode.Interop.UANodeGetBrowseName((IntPtr) this.nodeHandle);
        browseName.CheckOutcome();
        return browseName.GetString();
      }
      set => UANode.Interop.UANodeSetBrowseName((IntPtr) this.nodeHandle, value).CheckOutcome();
    }

    public NodeId NodeId
    {
      get
      {
        if (this.nodeId == (NodeId) null)
        {
          InteropCallResult nodeId = UANode.Interop.UANodeGetNodeId((IntPtr) this.nodeHandle);
          nodeId.CheckOutcome();
          this.nodeId = nodeId.Get<NodeId>();
        }
        return this.nodeId;
      }
    }

    public QualifiedName QualifiedBrowseName
    {
      get
      {
        InteropCallResult qualifiedBrowseName = UANode.Interop.UANodeGetQualifiedBrowseName((IntPtr) this.nodeHandle);
        qualifiedBrowseName.CheckOutcome();
        return qualifiedBrowseName.Get<QualifiedName>();
      }
      set
      {
        UANode.Interop.UANodeSetQualifiedBrowseName((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
      }
    }

    public LocalizedText DisplayName
    {
      get
      {
        InteropCallResult displayName = UANode.Interop.UANodeGetDisplayName((IntPtr) this.nodeHandle);
        displayName.CheckOutcome();
        return displayName.Get<LocalizedText>();
      }
      set
      {
        UANode.Interop.UANodeSetDisplayName((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
      }
    }

    public LocalizedText Description
    {
      get
      {
        InteropCallResult description = UANode.Interop.UANodeGetDescription((IntPtr) this.nodeHandle);
        description.CheckOutcome();
        return description.Get<LocalizedText>();
      }
      set
      {
        UANode.Interop.UANodeSetDescription((IntPtr) this.nodeHandle, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
      }
    }

    public bool IsValid
    {
      get
      {
        InteropCallResult interopCallResult = UANode.Interop.UANodeIsValid((IntPtr) this.nodeHandle);
        interopCallResult.CheckOutcome();
        return interopCallResult.GetBool();
      }
    }

    public NodeClass NodeClass => this.GetNodeClass();

    public IUANode Owner
    {
      get
      {
        InteropCallResult owner = UANode.Interop.UANodeGetOwner((IntPtr) this.nodeHandle);
        owner.CheckOutcome();
        return (IUANode) owner.Get<UANode>();
      }
      set
      {
        UANode.Interop.UANodeSetOwner((IntPtr) this.nodeHandle, (IntPtr) ((UANode) value).nodeHandle).CheckOutcome();
      }
    }

    public NamingRuleType ModellingRule
    {
      get
      {
        InteropCallResult modellingRule = UANode.Interop.UANodeGetModellingRule((IntPtr) this.nodeHandle);
        modellingRule.CheckOutcome();
        return (NamingRuleType) modellingRule.GetInt();
      }
      set
      {
        UANode.Interop.UANodeSetModellingRule((IntPtr) this.nodeHandle, (int) value).CheckOutcome();
      }
    }

    public NodeStatus Status
    {
      get
      {
        InteropCallResult nodeStatus = UANode.Interop.UANodeGetNodeStatus((IntPtr) this.nodeHandle);
        nodeStatus.CheckOutcome();
        return (NodeStatus) nodeStatus.GetInt();
      }
    }

    public IUANode Parent
    {
      get => this.Owner != null ? this.Owner : this.InverseRefs.GetNode(ReferenceTypes.Aggregates);
    }

    public void Delete()
    {
      UANode.Interop.UANodeDelete(ObjectMarshal.ToIntPtr((object) this.nodeHandle)).CheckOutcome();
    }

    public IEventRegistration RegisterEventObserver(
      IEventObserver observer,
      EventType eventTypeMask,
      uint affinityId = 0)
    {
      InteropCallResult interopCallResult = UANode.Interop.UANodeRegisterEventObserver(ObjectMarshal.ToIntPtr((object) this.nodeHandle), ObjectMarshal.ToIntPtr((object) observer), (ulong) eventTypeMask, affinityId);
      interopCallResult.CheckOutcome();
      return (IEventRegistration) new EventRegistration(interopCallResult.Get<EventRegistrationSafeHandle>());
    }

    internal void Initialize(UACoreContext context, UANodeSafeHandle safeHandle)
    {
      this.Context = (IContext) context;
      this.nodeHandle = safeHandle;
      this.Refs = (IUAReferences) new UAReferences(this.nodeHandle, UAReferences.ReferenceDirection.Forward);
      this.InverseRefs = (IUAReferences) new UAReferences(this.nodeHandle, UAReferences.ReferenceDirection.Inverse);
      this.Children = new ChildNodeCollection((IUANode) this);
      this.InitializeDerivedNodeClass();
    }

    protected abstract NodeClass GetNodeClass();

    protected abstract void InitializeDerivedNodeClass();

    internal void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      this.nodeHandle.Dispose();
      this.nodeHandle = (UANodeSafeHandle) null;
      this.Context = (IContext) null;
      this.Refs = (IUAReferences) null;
      this.InverseRefs = (IUAReferences) null;
      this.Children = (ChildNodeCollection) null;
    }

    public ITransactionEventRegistration RegisterTransactionObserver(
      ITransactionObserver observer,
      TransactionObserverType observerTypeMask)
    {
      throw new NotImplementedException();
    }

    public IReadOnlyList<IUANode> GetOwnedNodes()
    {
      InteropCallResult ownedNodes = UANode.Interop.UANodeGetOwnedNodes((IntPtr) this.nodeHandle);
      ownedNodes.CheckOutcome();
      return (IReadOnlyList<IUANode>) ownedNodes.GetArray<UANode>();
    }

    public virtual void SetModellingRuleRecursive()
    {
      if (!this.IsTypeNodeOrInstanceDeclarationInType())
        return;
      IReadOnlyList<IUANode> ownedNodes = this.GetOwnedNodes();
      List<IUANode> uaNodeList = new List<IUANode>();
      foreach (IUANode uaNode in (IEnumerable<IUANode>) ownedNodes)
      {
        if (uaNode.NodeClass == NodeClass.Object)
        {
          IUAObject uaObject1 = (IUAObject) uaNode;
          IUAObject uaObject2 = uaObject1;
          IUAObject prototype = uaObject1.Prototype;
          int num = prototype != null ? (int) prototype.ModellingRule : 1;
          uaObject2.ModellingRule = (NamingRuleType) num;
          uaNodeList.Add(uaNode);
        }
        else if (uaNode.NodeClass == NodeClass.Variable)
        {
          IUAVariable uaVariable1 = (IUAVariable) uaNode;
          IUAVariable uaVariable2 = uaVariable1;
          IUAVariable prototype = uaVariable1.Prototype;
          int num = prototype != null ? (int) prototype.ModellingRule : 1;
          uaVariable2.ModellingRule = (NamingRuleType) num;
          uaNodeList.Add(uaNode);
        }
        else if (uaNode.NodeClass == NodeClass.Method)
        {
          uaNode.ModellingRule = NamingRuleType.Mandatory;
          uaNodeList.Add(uaNode);
        }
      }
      foreach (IUANode uaNode in uaNodeList)
        uaNode.SetModellingRuleRecursive();
    }

    private bool IsTypeNodeOrInstanceDeclarationInType()
    {
      return this.NodeClass == NodeClass.ObjectType || this.NodeClass == NodeClass.VariableType || this.ModellingRule != NamingRuleType.None;
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetBrowseName(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetBrowseName(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string browseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetNodeId(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetQualifiedBrowseName(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetQualifiedBrowseName(
        IntPtr nodeHandle,
        IntPtr qualifiedBrowseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetDisplayName(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetDisplayName(
        IntPtr nodeHandle,
        IntPtr qualifiedBrowseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetDescription(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetDescription(
        IntPtr nodeHandle,
        IntPtr qualifiedBrowseName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeIsValid(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetOwner(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetOwner(IntPtr nodeHandle, IntPtr ownerHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetModellingRule(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeSetModellingRule(
        IntPtr nodeHandle,
        int modellingRule);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetNodeStatus(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeDelete(IntPtr nodeHandle);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeRegisterEventObserver(
        IntPtr nodeHandle,
        IntPtr observer,
        ulong eventTypeMask,
        uint affinityId);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult UANodeGetOwnedNodes(IntPtr nodeHandle);
    }
  }
}
