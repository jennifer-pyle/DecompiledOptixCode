// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.PresentationEngine
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 46)]
  public class PresentationEngine : UAObject
  {
    public WindowType StartWindow
    {
      get
      {
        NodeId nodeId = (NodeId) this.Refs.GetVariable(nameof (StartWindow)).Value;
        WindowType startWindow = (WindowType) null;
        if (nodeId != (NodeId) null && !nodeId.IsEmpty)
          startWindow = this.Context.GetObjectType(nodeId) as WindowType;
        return startWindow;
      }
      set
      {
        IUAVariable variable = this.Refs.GetVariable(nameof (StartWindow));
        NodeId nodeId = value?.NodeId;
        if ((object) nodeId == null)
          nodeId = NodeId.Empty;
        variable.SetValue((object) nodeId);
      }
    }

    public NodePointer StartWindowVariable => (NodePointer) this.Refs.GetVariable("StartWindow");

    public NodeId StyleSheet
    {
      get => (NodeId) this.Refs.GetVariable(nameof (StyleSheet)).Value.Value;
      set => this.Refs.GetVariable(nameof (StyleSheet)).SetValue((object) value);
    }

    public NodePointer StyleSheetVariable => (NodePointer) this.Refs.GetVariable("StyleSheet");

    public NodeId StartingUser
    {
      get => (NodeId) this.Refs.GetVariable(nameof (StartingUser)).Value.Value;
      set => this.Refs.GetVariable(nameof (StartingUser)).SetValue((object) value);
    }

    public NodePointer StartingUserVariable => (NodePointer) this.Refs.GetVariable("StartingUser");

    public PlaceholderChildNodeCollection<UISession> Sessions
    {
      get => new PlaceholderChildNodeCollection<UISession>((IUANode) this, nameof (Sessions));
    }
  }
}
