// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.DropDownButton
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 526)]
  public class DropDownButton : Button
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

    public DropDownButtonAnimationType AnimationType
    {
      get
      {
        return (DropDownButtonAnimationType) (int) this.GetOptionalVariableValue(nameof (AnimationType));
      }
      set => this.SetOptionalVariableValue(nameof (AnimationType), new UAValue((int) value));
    }

    public IUAVariable AnimationTypeVariable => this.GetOrCreateVariable("AnimationType");

    public bool CloseOnClickInside
    {
      get => (bool) this.GetOptionalVariableValue(nameof (CloseOnClickInside));
      set => this.SetOptionalVariableValue(nameof (CloseOnClickInside), new UAValue(value));
    }

    public IUAVariable CloseOnClickInsideVariable => this.GetOrCreateVariable("CloseOnClickInside");

    public bool CloseOnClickOutside
    {
      get => (bool) this.GetOptionalVariableValue(nameof (CloseOnClickOutside));
      set => this.SetOptionalVariableValue(nameof (CloseOnClickOutside), new UAValue(value));
    }

    public IUAVariable CloseOnClickOutsideVariable
    {
      get => this.GetOrCreateVariable("CloseOnClickOutside");
    }

    public Orientation Direction
    {
      get => (Orientation) (int) this.GetOptionalVariableValue(nameof (Direction));
      set => this.SetOptionalVariableValue(nameof (Direction), new UAValue((int) value));
    }

    public IUAVariable DirectionVariable => this.GetOrCreateVariable("Direction");
  }
}
