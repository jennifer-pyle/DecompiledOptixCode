// Decompiled with JetBrains decompiler
// Type: AliasExtensions
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
public static class AliasExtensions
{
  public static IUANode GetAlias(this IUANode node, string aliasName)
  {
    NodeId nodeId = (NodeId) AliasExtensions.ResolveAlias(node, aliasName).Value;
    return nodeId == (NodeId) null ? (IUANode) null : node.Context.GetNode(nodeId);
  }

  public static void SetAlias(this IUANode node, string aliasName, IUANode pointedNode)
  {
    node.SetAlias(aliasName, pointedNode.NodeId);
  }

  public static void SetAlias(this IUANode node, string aliasName, NodeId pointedNode)
  {
    AliasExtensions.ResolveAlias(node, aliasName).Value = (UAValue) pointedNode;
  }

  private static Alias ResolveAlias(IUANode node, string aliasName)
  {
    PathResolverResult pathResolverResult = node.Context.ResolvePath(node, "{" + aliasName + "}@Pointer");
    return pathResolverResult.ResolvedNode != null ? (Alias) pathResolverResult.ResolvedNode : throw new CoreException("Alias {" + aliasName + "} not found");
  }
}
