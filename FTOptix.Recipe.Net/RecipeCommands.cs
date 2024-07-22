// Decompiled with JetBrains decompiler
// Type: FTOptix.Recipe.RecipeCommands
// Assembly: FTOptix.Recipe.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: EFD0D777-9FCB-4D24-B9F7-D873EB52C7CF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Recipe.Net\1.0.8.39\Any\FTOptix.Recipe.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Recipe
{
  public static class RecipeCommands
  {
    private static readonly NodeId commandsObjectNodeId = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Recipe"), 26U);

    public static NodeId CreateSchema(
      IUANode sourceNode,
      NodeId[] sourceParameters,
      QualifiedName newBrowseName,
      IUANode parent,
      NodeId referenceTypeId,
      ushort namespaceIndex)
    {
      object[] outputArgs;
      sourceNode.Context.GetObject(RecipeCommands.commandsObjectNodeId).ExecuteMethod(nameof (CreateSchema), new object[6]
      {
        (object) sourceNode.NodeId,
        (object) sourceParameters,
        (object) newBrowseName,
        (object) parent.NodeId,
        (object) referenceTypeId,
        (object) namespaceIndex
      }, out outputArgs);
      return (NodeId) outputArgs[0];
    }
  }
}
