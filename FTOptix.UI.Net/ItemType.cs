// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ItemType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System.Collections.Generic;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 6)]
  public class ItemType : BaseUIObjectType
  {
    public bool Visible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Visible));
      set => this.SetOptionalVariableValue(nameof (Visible), new UAValue(value));
    }

    public IUAVariable VisibleVariable => this.GetOrCreateVariable("Visible");

    public bool Enabled
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Enabled));
      set => this.SetOptionalVariableValue(nameof (Enabled), new UAValue(value));
    }

    public IUAVariable EnabledVariable => this.GetOrCreateVariable("Enabled");

    public float Opacity
    {
      get => (float) this.GetOptionalVariableValue(nameof (Opacity));
      set => this.SetOptionalVariableValue(nameof (Opacity), new UAValue(value));
    }

    public IUAVariable OpacityVariable => this.GetOrCreateVariable("Opacity");

    public float LeftMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (LeftMargin));
      set => this.SetOptionalVariableValue(nameof (LeftMargin), new UAValue(value));
    }

    public IUAVariable LeftMarginVariable => this.GetOrCreateVariable("LeftMargin");

    public float TopMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (TopMargin));
      set => this.SetOptionalVariableValue(nameof (TopMargin), new UAValue(value));
    }

    public IUAVariable TopMarginVariable => this.GetOrCreateVariable("TopMargin");

    public float RightMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (RightMargin));
      set => this.SetOptionalVariableValue(nameof (RightMargin), new UAValue(value));
    }

    public IUAVariable RightMarginVariable => this.GetOrCreateVariable("RightMargin");

    public float BottomMargin
    {
      get => (float) this.GetOptionalVariableValue(nameof (BottomMargin));
      set => this.SetOptionalVariableValue(nameof (BottomMargin), new UAValue(value));
    }

    public IUAVariable BottomMarginVariable => this.GetOrCreateVariable("BottomMargin");

    public float Width
    {
      get => (float) this.GetOptionalVariableValue(nameof (Width));
      set => this.SetOptionalVariableValue(nameof (Width), new UAValue(value));
    }

    public IUAVariable WidthVariable => this.GetOrCreateVariable("Width");

    public float Height
    {
      get => (float) this.GetOptionalVariableValue(nameof (Height));
      set => this.SetOptionalVariableValue(nameof (Height), new UAValue(value));
    }

    public IUAVariable HeightVariable => this.GetOrCreateVariable("Height");

    public HorizontalAlignment HorizontalAlignment
    {
      get
      {
        return (HorizontalAlignment) (int) this.GetOptionalVariableValue(nameof (HorizontalAlignment));
      }
      set => this.SetOptionalVariableValue(nameof (HorizontalAlignment), new UAValue((int) value));
    }

    public IUAVariable HorizontalAlignmentVariable
    {
      get => this.GetOrCreateVariable("HorizontalAlignment");
    }

    public VerticalAlignment VerticalAlignment
    {
      get => (VerticalAlignment) (int) this.GetOptionalVariableValue(nameof (VerticalAlignment));
      set => this.SetOptionalVariableValue(nameof (VerticalAlignment), new UAValue((int) value));
    }

    public IUAVariable VerticalAlignmentVariable => this.GetOrCreateVariable("VerticalAlignment");

    public float Rotation
    {
      get => (float) this.GetOptionalVariableValue(nameof (Rotation));
      set => this.SetOptionalVariableValue(nameof (Rotation), new UAValue(value));
    }

    public IUAVariable RotationVariable => this.GetOrCreateVariable("Rotation");

    public override void SetModellingRuleRecursive()
    {
      if (this.NodeClass != NodeClass.ObjectType && this.ModellingRule == NamingRuleType.None)
        return;
      IReadOnlyList<IUANode> ownedNodes = this.GetOwnedNodes();
      List<IUANode> uaNodeList = new List<IUANode>();
      foreach (IUANode uaNode in (IEnumerable<IUANode>) ownedNodes)
      {
        if (uaNode.NodeClass == NodeClass.Object)
        {
          IUAObject uaObject1 = (IUAObject) uaNode;
          if (uaObject1 is GridLayoutProperties)
          {
            uaObject1.ModellingRule = NamingRuleType.Optional;
          }
          else
          {
            IUAObject uaObject2 = uaObject1;
            IUAObject prototype = uaObject1.Prototype;
            int num = prototype != null ? (int) prototype.ModellingRule : 1;
            uaObject2.ModellingRule = (NamingRuleType) num;
          }
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

    public GridLayoutProperties GridLayoutProperties
    {
      get
      {
        QualifiedName browseName = new QualifiedName(ObjectTypes.Item.NamespaceIndex, nameof (GridLayoutProperties));
        IUAObject target = this.Refs.GetObject(browseName);
        if (target == null)
        {
          target = this.Context.NodeFactory.MakeObject(NodeId.Random(this.NodeId.NamespaceIndex), browseName, ObjectTypes.GridLayoutProperties);
          NodeId hasComponent = UAManagedCore.OpcUa.ReferenceTypes.HasComponent;
          IUAObjectType objectType = this.Context.GetObjectType(ObjectTypes.GridLayoutProperties);
          target.DisplayName = objectType.DisplayName;
          this.Refs.AttachAndStart(hasComponent, (IUANode) target);
        }
        return (GridLayoutProperties) target;
      }
    }

    public InstanceNodeCollection<Item> Instances
    {
      get => new InstanceNodeCollection<Item>((IUANode) this);
    }
  }
}
