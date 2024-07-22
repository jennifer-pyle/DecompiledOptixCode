// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypedChildNodeCollection`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public class TypedChildNodeCollection<T> : 
    TypedReadOnlyChildNodeCollection<T>,
    ICollection<T>,
    IEnumerable<T>,
    IEnumerable
    where T : class, IUANode
  {
    public TypedChildNodeCollection(IUANode node)
      : base(node)
    {
    }

    public void Add(T childNode)
    {
      if ((object) childNode == null)
        throw new ArgumentNullException(nameof (childNode));
      if (childNode.Owner != null)
        LogManager.CoreLogger.Log(LogLevel.Warning, "UAManagedCore", (ushort) 220, (ushort) 0, "Attempting to add node " + childNode.BrowseName + " - " + childNode.NodeId?.ToString() + " as a child, but it is already owned by node " + childNode.Owner.BrowseName + " - " + childNode.Owner.NodeId?.ToString(), string.Empty, "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\ChildNodeCollection.cs", 90, nameof (Add));
      if (this.IsTypeNodeOrInstanceDeclarationInType())
      {
        childNode.ModellingRule = NamingRuleType.Mandatory;
        childNode.SetModellingRuleRecursive();
      }
      this.parentNode.Refs.AttachAndStart(this.GetOwningReferenceType((IUANode) childNode), (IUANode) childNode);
    }

    public bool Remove(T childNode)
    {
      if ((object) childNode == null)
        throw new ArgumentNullException(nameof (childNode));
      if (childNode.Owner != this.parentNode)
        return false;
      childNode.Delete();
      return true;
    }

    public void Remove(QualifiedName browseName)
    {
      if (browseName == (QualifiedName) null)
        throw new ArgumentNullException(nameof (browseName));
      foreach (T obj in this.GetChildNodes().Where<T>((Func<T, bool>) (n => (browseName.NamespaceIndex == NodeId.InvalidNamespaceIndex || n.QualifiedBrowseName.NamespaceIndex == browseName.NamespaceIndex) && n.QualifiedBrowseName.Name == browseName.Name)))
        obj.Delete();
    }

    public void Clear()
    {
      foreach (T childNode in this.GetChildNodes())
        childNode.Delete();
    }

    public bool IsReadOnly => false;

    protected bool IsTypeNodeOrInstanceDeclarationInType()
    {
      return this.parentNode.NodeClass == NodeClass.ObjectType || this.parentNode.NodeClass == NodeClass.VariableType || this.parentNode.ModellingRule != NamingRuleType.None;
    }

    private NodeId GetOwningReferenceType(IUANode childNode)
    {
      if (childNode.NodeClass == NodeClass.Object)
        return this.GetOwningReferenceType((IUAObject) childNode);
      return childNode.NodeClass == NodeClass.Variable ? this.GetOwningReferenceType((IUAVariable) childNode) : UAManagedCore.OpcUa.ReferenceTypes.HasComponent;
    }

    private NodeId GetOwningReferenceType(IUAObject childObject)
    {
      for (IUAObjectType uaObjectType = childObject.ObjectType; uaObjectType != null; uaObjectType = uaObjectType.SuperType)
      {
        IUANode node = uaObjectType.Refs.GetNode(UAManagedCore.Ext.ReferenceTypes.HasOwningReferenceType, false);
        if (node != null)
          return node.NodeId;
      }
      return UAManagedCore.OpcUa.ReferenceTypes.HasComponent;
    }

    private NodeId GetOwningReferenceType(IUAVariable childVariable)
    {
      for (IUAVariableType uaVariableType = childVariable.VariableType; uaVariableType != null; uaVariableType = uaVariableType.SuperType)
      {
        IUANode node = uaVariableType.Refs.GetNode(UAManagedCore.Ext.ReferenceTypes.HasOwningReferenceType, false);
        if (node != null)
          return node.NodeId;
      }
      return UAManagedCore.OpcUa.ReferenceTypes.HasComponent;
    }
  }
}
