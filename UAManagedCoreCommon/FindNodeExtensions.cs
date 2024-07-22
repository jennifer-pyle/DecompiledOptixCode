// Decompiled with JetBrains decompiler
// Type: UAManagedCore.FindNodeExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public static class FindNodeExtensions
  {
    public static IUANode Find(this IUANode node, string browseName)
    {
      if (node.BrowseName == browseName)
        return node;
      HashSet<NodeId> nodeIdSet = new HashSet<NodeId>();
      Queue<IUANode> uaNodeQueue = new Queue<IUANode>();
      uaNodeQueue.Enqueue(node);
      while (uaNodeQueue.Count > 0)
      {
        IUANode uaNode = uaNodeQueue.Dequeue();
        if (!nodeIdSet.Contains(uaNode.NodeId))
        {
          nodeIdSet.Add(uaNode.NodeId);
          if (uaNode.BrowseName == browseName)
            return uaNode;
          foreach (IUANode child in (TypedReadOnlyChildNodeCollection<IUANode>) uaNode.Children)
          {
            if (!nodeIdSet.Contains(child.NodeId))
              uaNodeQueue.Enqueue(child);
          }
        }
      }
      return (IUANode) null;
    }

    public static IUAObject FindObject(this IUANode node, string browseName)
    {
      return node.Find(browseName) as IUAObject;
    }

    public static IUAVariable FindVariable(this IUANode node, string browseName)
    {
      return node.Find(browseName) as IUAVariable;
    }

    public static T Find<T>(this IUANode node, string browseName) where T : class, IUANode
    {
      return node.Find(browseName) as T;
    }

    public static T FindByType<T>(this IUANode node) where T : class, IUANode
    {
      HashSet<NodeId> nodeIdSet = new HashSet<NodeId>();
      Queue<IUANode> uaNodeQueue = new Queue<IUANode>();
      uaNodeQueue.Enqueue(node);
      while (uaNodeQueue.Count > 0)
      {
        IUANode node1 = uaNodeQueue.Dequeue();
        if (!nodeIdSet.Contains(node1.NodeId))
        {
          nodeIdSet.Add(node1.NodeId);
          T byType = node1.GetByType<T>();
          if ((object) byType != null)
            return byType;
          foreach (IUANode child in (TypedReadOnlyChildNodeCollection<IUANode>) node1.Children)
          {
            if (!nodeIdSet.Contains(child.NodeId))
              uaNodeQueue.Enqueue(child);
          }
        }
      }
      return default (T);
    }

    public static IEnumerable<T> FindNodesByType<T>(this IUANode node) where T : class, IUANode
    {
      List<T> nodesByType1 = new List<T>();
      HashSet<NodeId> nodeIdSet = new HashSet<NodeId>();
      Queue<IUANode> uaNodeQueue = new Queue<IUANode>();
      uaNodeQueue.Enqueue(node);
      while (uaNodeQueue.Count > 0)
      {
        IUANode node1 = uaNodeQueue.Dequeue();
        if (!nodeIdSet.Contains(node1.NodeId))
        {
          nodeIdSet.Add(node1.NodeId);
          IEnumerable<T> nodesByType2 = node1.GetNodesByType<T>();
          if (nodesByType2.Any<T>())
            nodesByType1.AddRange(nodesByType2);
          foreach (IUANode child in (TypedReadOnlyChildNodeCollection<IUANode>) node1.Children)
          {
            if (!nodeIdSet.Contains(child.NodeId))
              uaNodeQueue.Enqueue(child);
          }
        }
      }
      return (IEnumerable<T>) nodesByType1;
    }
  }
}
