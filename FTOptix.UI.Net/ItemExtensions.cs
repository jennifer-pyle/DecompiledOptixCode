// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.ItemExtensions
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  public static class ItemExtensions
  {
    private static readonly NodeId commandsObjectNodeId = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:UI"), 121U);

    public static Dialog OpenDialog(this Item parentItem, DialogType dialogType, NodeId aliasNode = null)
    {
      IUAObject uaObject = parentItem.Context.GetObject(ItemExtensions.commandsObjectNodeId);
      object[] objArray = new object[3]
      {
        (object) dialogType.NodeId,
        null,
        null
      };
      NodeId nodeId1 = aliasNode;
      if ((object) nodeId1 == null)
        nodeId1 = NodeId.Empty;
      objArray[1] = (object) nodeId1;
      objArray[2] = (object) parentItem.NodeId;
      object[] inputArgs = objArray;
      object[] outputArgs;
      uaObject.ExecuteMethod(nameof (OpenDialog), inputArgs, out outputArgs);
      NodeId nodeId2 = (NodeId) outputArgs[0];
      return parentItem.Context.GetNode(nodeId2) as Dialog;
    }

    public static Dialog OpenDialog(
      this Item parentItem,
      DialogType dialogType,
      NodeId[] aliasNodes)
    {
      for (int index = 0; index < aliasNodes.Length; ++index)
      {
        if (aliasNodes[index] == (NodeId) null)
          aliasNodes[index] = NodeId.Empty;
      }
      object[] outputArgs;
      parentItem.Context.GetObject(ItemExtensions.commandsObjectNodeId).ExecuteMethod(nameof (OpenDialog), new object[3]
      {
        (object) dialogType.NodeId,
        (object) aliasNodes,
        (object) parentItem.NodeId
      }, out outputArgs);
      NodeId nodeId = (NodeId) outputArgs[0];
      return parentItem.Context.GetNode(nodeId) as Dialog;
    }
  }
}
