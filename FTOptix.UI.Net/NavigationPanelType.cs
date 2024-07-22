// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.NavigationPanelType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 546)]
  public class NavigationPanelType : ContainerType
  {
    public PlaceholderChildNodeCollection<NavigationPanelItem> Panels
    {
      get
      {
        return new PlaceholderChildNodeCollection<NavigationPanelItem>((IUANode) this, nameof (Panels));
      }
    }

    public NodeId CurrentPanel
    {
      get => (NodeId) this.Refs.GetVariable(nameof (CurrentPanel)).Value.Value;
      set => this.Refs.GetVariable(nameof (CurrentPanel)).SetValue((object) value);
    }

    public NodePointer CurrentPanelVariable => (NodePointer) this.Refs.GetVariable("CurrentPanel");

    public NavigationPanelTabPosition TabPosition
    {
      get => (NavigationPanelTabPosition) (int) this.GetOptionalVariableValue(nameof (TabPosition));
      set => this.SetOptionalVariableValue(nameof (TabPosition), new UAValue((int) value));
    }

    public IUAVariable TabPositionVariable => this.GetOrCreateVariable("TabPosition");

    public float TabWidth
    {
      get => (float) this.GetOptionalVariableValue(nameof (TabWidth));
      set => this.SetOptionalVariableValue(nameof (TabWidth), new UAValue(value));
    }

    public IUAVariable TabWidthVariable => this.GetOrCreateVariable("TabWidth");

    public float TabHeight
    {
      get => (float) this.GetOptionalVariableValue(nameof (TabHeight));
      set => this.SetOptionalVariableValue(nameof (TabHeight), new UAValue(value));
    }

    public IUAVariable TabHeightVariable => this.GetOrCreateVariable("TabHeight");

    public string Appearance
    {
      get => (string) this.GetOptionalVariableValue(nameof (Appearance));
      set => this.SetOptionalVariableValue(nameof (Appearance), new UAValue(value));
    }

    public IUAVariable AppearanceVariable => this.GetOrCreateVariable("Appearance");

    public int CurrentTabIndex
    {
      get => (int) this.GetOptionalVariableValue(nameof (CurrentTabIndex));
      set => this.SetOptionalVariableValue(nameof (CurrentTabIndex), new UAValue(value));
    }

    public IUAVariable CurrentTabIndexVariable => this.GetOrCreateVariable("CurrentTabIndex");

    public NodeId AttachedPanelLoader
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (AttachedPanelLoader));
      set => this.SetOptionalVariableValue(nameof (AttachedPanelLoader), new UAValue(value));
    }

    public IUAVariable AttachedPanelLoaderVariable
    {
      get => this.GetOrCreateVariable("AttachedPanelLoader");
    }

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public void ChangePanelByTabIndex(int index, NodeId aliasNode = null)
    {
      if (aliasNode == (NodeId) null)
        aliasNode = NodeId.Empty;
      this.ExecuteMethod(nameof (ChangePanelByTabIndex), new object[2]
      {
        (object) index,
        (object) aliasNode
      });
    }

    public void ChangePanelByTabIndex(int index, NodeId[] aliasNodes)
    {
      for (int index1 = 0; index1 < aliasNodes.Length; ++index1)
      {
        if (aliasNodes[index1] == (NodeId) null)
          aliasNodes[index1] = NodeId.Empty;
      }
      this.ExecuteMethod(nameof (ChangePanelByTabIndex), new object[2]
      {
        (object) index,
        (object) aliasNodes
      });
    }

    public IUAMethod ChangePanelByTabIndexMethod => this.Refs.GetMethod("ChangePanelByTabIndex");

    public void ChangePanelByTabName(string browseName, NodeId aliasNode = null)
    {
      if (aliasNode == (NodeId) null)
        aliasNode = NodeId.Empty;
      this.ExecuteMethod(nameof (ChangePanelByTabName), new object[2]
      {
        (object) browseName,
        (object) aliasNode
      });
    }

    public void ChangePanelByTabName(string browseName, NodeId[] aliasNodes)
    {
      for (int index = 0; index < aliasNodes.Length; ++index)
      {
        if (aliasNodes[index] == (NodeId) null)
          aliasNodes[index] = NodeId.Empty;
      }
      this.ExecuteMethod(nameof (ChangePanelByTabName), new object[2]
      {
        (object) browseName,
        (object) aliasNodes
      });
    }

    public IUAMethod ChangePanelByTabNameMethod => this.Refs.GetMethod("ChangePanelByTabName");

    public InstanceNodeCollection<NavigationPanel> Instances
    {
      get => new InstanceNodeCollection<NavigationPanel>((IUANode) this);
    }

    public ChildItemCollection Children => new ChildItemCollection((IUANode) this);
  }
}
