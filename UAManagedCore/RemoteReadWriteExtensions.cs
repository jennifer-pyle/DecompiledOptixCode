// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteReadWriteExtensions
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public static class RemoteReadWriteExtensions
  {
    public static IEnumerable<RemoteChildVariableValue> ChildrenRemoteRead(
      this IUANode node,
      double timeoutMilliseconds = 30000.0)
    {
      List<RemoteVariable> variables = RemoteReadWriteExtensions.CollectRemoteVariables(node);
      IEnumerable<RemoteVariableValue> values = node.Context.RemoteRead((IEnumerable<RemoteVariable>) variables, timeoutMilliseconds);
      return RemoteReadWriteExtensions.CreateOutputCollection(node, values);
    }

    public static IEnumerable<RemoteChildVariableValue> ChildrenRemoteRead(
      this IUANode node,
      IEnumerable<RemoteChildVariable> childVariables,
      double timeoutMilliseconds = 30000.0)
    {
      List<RemoteVariable> variables = new List<RemoteVariable>(childVariables.Count<RemoteChildVariable>());
      foreach (RemoteChildVariable childVariable in childVariables)
        variables.Add(RemoteReadWriteExtensions.CreateRemoteVariable(node, childVariable.RelativePath));
      IEnumerable<RemoteVariableValue> values = node.Context.RemoteRead((IEnumerable<RemoteVariable>) variables, timeoutMilliseconds);
      return RemoteReadWriteExtensions.CreateOutputCollection(node, values);
    }

    public static void ChildrenRemoteWrite(
      this IUANode node,
      IEnumerable<RemoteChildVariableValue> childVariableValues,
      double timeoutMilliseconds = 30000.0)
    {
      List<RemoteVariableValue> variableValues = new List<RemoteVariableValue>(childVariableValues.Count<RemoteChildVariableValue>());
      foreach (RemoteChildVariableValue childVariableValue in childVariableValues)
        variableValues.Add(RemoteReadWriteExtensions.CreateRemoteVariableValue(node, childVariableValue.RelativePath, childVariableValue.Value));
      node.Context.RemoteWrite((IEnumerable<RemoteVariableValue>) variableValues, timeoutMilliseconds);
    }

    private static List<RemoteVariable> CollectRemoteVariables(IUANode node)
    {
      List<RemoteVariable> remoteVariableList = new List<RemoteVariable>();
      foreach (IUANode ownedNode in (IEnumerable<IUANode>) node.GetOwnedNodes())
      {
        if (ownedNode.NodeClass == NodeClass.Variable)
        {
          IUAVariable variable = (IUAVariable) ownedNode;
          if (!TagStructureInstance.IsLocalTagStructureInstance(variable))
            remoteVariableList.Add(new RemoteVariable(variable, Array.Empty<uint>()));
          else
            remoteVariableList.AddRange((IEnumerable<RemoteVariable>) RemoteReadWriteExtensions.CollectRemoteVariables(ownedNode));
        }
        else if (ownedNode.NodeClass == NodeClass.Object)
          remoteVariableList.AddRange((IEnumerable<RemoteVariable>) RemoteReadWriteExtensions.CollectRemoteVariables(ownedNode));
      }
      return remoteVariableList;
    }

    private static IEnumerable<RemoteChildVariableValue> CreateOutputCollection(
      IUANode node,
      IEnumerable<RemoteVariableValue> values)
    {
      List<RemoteChildVariableValue> outputCollection = new List<RemoteChildVariableValue>();
      foreach (RemoteVariableValue remoteVariableValue in values)
      {
        string pathFromParentNode = RemoteReadWriteExtensions.CreateRelativePathFromParentNode(node, remoteVariableValue.Variable);
        outputCollection.Add(new RemoteChildVariableValue(pathFromParentNode, remoteVariableValue.Value, remoteVariableValue.Index));
      }
      return (IEnumerable<RemoteChildVariableValue>) outputCollection;
    }

    private static string CreateRelativePathFromParentNode(IUANode parentNode, IUAVariable variable)
    {
      string pathFromParentNode = (string) null;
      for (IUANode uaNode = (IUANode) variable; uaNode != parentNode; uaNode = uaNode.Owner)
        pathFromParentNode = string.IsNullOrEmpty(pathFromParentNode) ? uaNode.BrowseName : uaNode.BrowseName + "/" + pathFromParentNode;
      return pathFromParentNode;
    }

    private static RemoteVariable CreateRemoteVariable(IUANode parentNode, string relativePath)
    {
      return new RemoteVariable(RemoteReadWriteExtensions.RetrieveChildVariable(parentNode, relativePath), new uint[0]);
    }

    private static RemoteVariableValue CreateRemoteVariableValue(
      IUANode parentNode,
      string relativePath,
      UAValue value)
    {
      return new RemoteVariableValue(RemoteReadWriteExtensions.RetrieveChildVariable(parentNode, relativePath), value, new uint[0]);
    }

    private static IUAVariable RetrieveChildVariable(IUANode parentNode, string relativePath)
    {
      return parentNode.GetVariable(relativePath) ?? throw new ArgumentException("Unable to find variable '" + relativePath + "' from parent node '" + parentNode.BrowseName + "'");
    }
  }
}
