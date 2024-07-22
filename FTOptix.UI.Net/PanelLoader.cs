// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.PanelLoader
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using FTOptix.HMIProject;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 183)]
  public class PanelLoader : Container
  {
    public NodeId Panel
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Panel)).Value.Value;
      set => this.Refs.GetVariable(nameof (Panel)).SetValue((object) value);
    }

    public NodePointer PanelVariable => (NodePointer) this.Refs.GetVariable("Panel");

    public NodeId PanelAliasNode
    {
      get
      {
        UAValue optionalVariableValue = this.GetOptionalVariableValue(nameof (PanelAliasNode));
        if (optionalVariableValue == (UAValue) null)
          return (NodeId) null;
        return !optionalVariableValue.GetType().IsArray ? (NodeId) optionalVariableValue : throw new InvalidOperationException("The PanelAliasNode variable contains an array value. Please use the PanelAliasNodeArray property instead.");
      }
      set => this.SetOptionalVariableValue(nameof (PanelAliasNode), new UAValue(value));
    }

    public NodeId[] PanelAliasNodeArray
    {
      get
      {
        object panelAliasNodeArray = this.GetOptionalVariableValue("PanelAliasNode").Value;
        if (panelAliasNodeArray == null || panelAliasNodeArray.GetType().IsArray)
          return (NodeId[]) panelAliasNodeArray;
        return new NodeId[1]{ (NodeId) panelAliasNodeArray };
      }
      set => this.SetOptionalVariableValue("PanelAliasNode", new UAValue(value));
    }

    public IUAVariable PanelAliasNodeVariable => this.GetOrCreateVariable("PanelAliasNode");

    public NodeId CurrentPanel
    {
      get => (NodeId) this.Refs.GetVariable(nameof (CurrentPanel)).Value.Value;
      set => this.Refs.GetVariable(nameof (CurrentPanel)).SetValue((object) value);
    }

    public NodePointer CurrentPanelVariable => (NodePointer) this.Refs.GetVariable("CurrentPanel");

    public PanelLoaderAnimationType EnterAnimation
    {
      get
      {
        return (PanelLoaderAnimationType) (int) this.GetOptionalVariableValue(nameof (EnterAnimation));
      }
      set => this.SetOptionalVariableValue(nameof (EnterAnimation), new UAValue((int) value));
    }

    public IUAVariable EnterAnimationVariable => this.GetOrCreateVariable("EnterAnimation");

    public PanelLoaderAnimationType ExitAnimation
    {
      get => (PanelLoaderAnimationType) (int) this.GetOptionalVariableValue(nameof (ExitAnimation));
      set => this.SetOptionalVariableValue(nameof (ExitAnimation), new UAValue((int) value));
    }

    public IUAVariable ExitAnimationVariable => this.GetOrCreateVariable("ExitAnimation");

    public void ChangePanel(NodeId newPanel, NodeId aliasNode = null)
    {
      if (aliasNode == (NodeId) null)
        aliasNode = NodeId.Empty;
      this.ExecuteMethod(nameof (ChangePanel), new object[2]
      {
        (object) newPanel,
        (object) aliasNode
      });
    }

    public void ChangePanel(NodeId newPanel, NodeId[] aliasNodes)
    {
      for (int index = 0; index < aliasNodes.Length; ++index)
      {
        if (aliasNodes[index] == (NodeId) null)
          aliasNodes[index] = NodeId.Empty;
      }
      this.ExecuteMethod(nameof (ChangePanel), new object[2]
      {
        (object) newPanel,
        (object) aliasNodes
      });
    }

    public void ChangePanel(IUANode panelNode, NodeId aliasNode = null)
    {
      this.ChangePanel(this.GetPanelNodeIdByNode((object) panelNode), aliasNode);
    }

    public void ChangePanel(IUANode panelNode, NodeId[] aliasNodes)
    {
      this.ChangePanel(this.GetPanelNodeIdByNode((object) panelNode), aliasNodes);
    }

    public void ChangePanel(string panelBrowseName, NodeId aliasNode = null)
    {
      this.ChangePanel(this.GetPanelNodeIdByBrowseName((object) panelBrowseName), aliasNode);
    }

    public void ChangePanel(string panelBrowseName, NodeId[] aliasNodes)
    {
      this.ChangePanel(this.GetPanelNodeIdByBrowseName((object) panelBrowseName), aliasNodes);
    }

    private NodeId GetPanelNodeIdByNode(object firstArgument)
    {
      if (firstArgument == null)
        return NodeId.Empty;
      IUANode node = (IUANode) firstArgument;
      return node is ItemType ? node.NodeId : throw new CoreException("Node '" + Log.Node(node) + "' cannot be loaded by a PanelLoader");
    }

    private NodeId GetPanelNodeIdByBrowseName(object firstArgument)
    {
      string browseName = (string) firstArgument;
      if (string.IsNullOrEmpty(browseName))
        return NodeId.Empty;
      return (Project.Current.Find<ItemType>(browseName) ?? throw new CoreException("Panel '" + browseName + "' not found")).NodeId;
    }

    public IUAMethod ChangePanelMethod => this.Refs.GetMethod("ChangePanel");

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
