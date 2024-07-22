// Decompiled with JetBrains decompiler
// Type: FTOptix.Recipe.RecipeSchemaType
// Assembly: FTOptix.Recipe.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: EFD0D777-9FCB-4D24-B9F7-D873EB52C7CF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Recipe.Net\1.0.8.39\Any\FTOptix.Recipe.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.Recipe
{
  [MapType(NamespaceUri = "urn:FTOptix:Recipe", Number = 2)]
  public class RecipeSchemaType : UAObjectType
  {
    public NodeId Store
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Store))?.GetValue();
      set
      {
        if (value != (NodeId) null)
          (this.Refs.GetVariable(nameof (Store)) ?? this.GetOrCreateVariable(nameof (Store))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (Store))?.Delete();
      }
    }

    public NodePointer StoreVariable => (NodePointer) this.Refs.GetVariable("Store");

    public string TableName
    {
      get => (string) this.GetOptionalVariableValue(nameof (TableName));
      set => this.SetOptionalVariableValue(nameof (TableName), new UAValue(value));
    }

    public IUAVariable TableNameVariable => this.GetOrCreateVariable("TableName");

    public NodeId TargetNode
    {
      get => (NodeId) this.Refs.GetVariable(nameof (TargetNode))?.GetValue();
      set
      {
        if (value != (NodeId) null)
          (this.Refs.GetVariable(nameof (TargetNode)) ?? this.GetOrCreateVariable(nameof (TargetNode))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (TargetNode))?.Delete();
      }
    }

    public NodePointer TargetNodeVariable => (NodePointer) this.Refs.GetVariable("TargetNode");

    public IUAObject Root => this.Refs.GetObject(nameof (Root));

    public double Timeout
    {
      get => (double) this.GetOptionalVariableValue(nameof (Timeout));
      set => this.SetOptionalVariableValue(nameof (Timeout), new UAValue(value));
    }

    public IUAVariable TimeoutVariable => this.GetOrCreateVariable("Timeout");

    public NodeId CreateRecipe(
      QualifiedName newBrowseName,
      NodeId parentId,
      NodeId referenceTypeId,
      ushort namespaceIndex)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (CreateRecipe), new object[4]
      {
        (object) newBrowseName,
        (object) parentId,
        (object) referenceTypeId,
        (object) namespaceIndex
      }, out outputArgs);
      return (NodeId) outputArgs[0];
    }

    public IUAMethod CreateRecipeMethod => this.Refs.GetMethod("CreateRecipe");

    public void RefactorRecipe(NodeId recipe)
    {
      this.ExecuteMethod(nameof (RefactorRecipe), new object[1]
      {
        (object) recipe
      });
    }

    public IUAMethod RefactorRecipeMethod => this.Refs.GetMethod("RefactorRecipe");

    public NodeId CreateEditModelFromRecipe(
      NodeId sourceRecipe,
      NodeId targetNode,
      QualifiedName newBrowseName,
      bool inPlaceEdit,
      NodeId parentId,
      NodeId referenceTypeId,
      ushort namespaceIndex)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (CreateEditModelFromRecipe), new object[7]
      {
        (object) sourceRecipe,
        (object) targetNode,
        (object) newBrowseName,
        (object) inPlaceEdit,
        (object) parentId,
        (object) referenceTypeId,
        (object) namespaceIndex
      }, out outputArgs);
      return (NodeId) outputArgs[0];
    }

    public IUAMethod CreateEditModelFromRecipeMethod
    {
      get => this.Refs.GetMethod("CreateEditModelFromRecipe");
    }

    public NodeId CreateEditModelFromSchema(
      NodeId targetNode,
      QualifiedName newBrowseName,
      bool inPlaceEdit,
      NodeId parentId,
      NodeId referenceTypeId,
      ushort namespaceIndex)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (CreateEditModelFromSchema), new object[6]
      {
        (object) targetNode,
        (object) newBrowseName,
        (object) inPlaceEdit,
        (object) parentId,
        (object) referenceTypeId,
        (object) namespaceIndex
      }, out outputArgs);
      return (NodeId) outputArgs[0];
    }

    public IUAMethod CreateEditModelFromSchemaMethod
    {
      get => this.Refs.GetMethod("CreateEditModelFromSchema");
    }

    public bool ValidateTree(NodeId source, NodeId target)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (ValidateTree), new object[2]
      {
        (object) source,
        (object) target
      }, out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod ValidateTreeMethod => this.Refs.GetMethod("ValidateTree");

    public void Copy(NodeId sourceNode, NodeId destinationNode, CopyErrorPolicy errorPolicy)
    {
      this.ExecuteMethod(nameof (Copy), new object[3]
      {
        (object) sourceNode,
        (object) destinationNode,
        (object) errorPolicy
      });
    }

    public IUAMethod CopyMethod => this.Refs.GetMethod("Copy");

    public void CopyFromEditModel(
      NodeId editModel,
      NodeId destinationNode,
      CopyErrorPolicy errorPolicy)
    {
      this.ExecuteMethod(nameof (CopyFromEditModel), new object[3]
      {
        (object) editModel,
        (object) destinationNode,
        (object) errorPolicy
      });
    }

    public IUAMethod CopyFromEditModelMethod => this.Refs.GetMethod("CopyFromEditModel");

    public void CreateStoreRecipe(string newRecipeName)
    {
      this.ExecuteMethod(nameof (CreateStoreRecipe), new object[1]
      {
        (object) newRecipeName
      });
    }

    public IUAMethod CreateStoreRecipeMethod => this.Refs.GetMethod("CreateStoreRecipe");

    public void DeleteStoreRecipe(string recipeName)
    {
      this.ExecuteMethod(nameof (DeleteStoreRecipe), new object[1]
      {
        (object) recipeName
      });
    }

    public IUAMethod DeleteStoreRecipeMethod => this.Refs.GetMethod("DeleteStoreRecipe");

    public NodeId CreateEditModelFromStoreRecipe(
      string sourceRecipeName,
      NodeId targetNode,
      QualifiedName newBrowseName,
      NodeId parentId,
      NodeId referenceTypeId,
      ushort namespaceIndex)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (CreateEditModelFromStoreRecipe), new object[6]
      {
        (object) sourceRecipeName,
        (object) targetNode,
        (object) newBrowseName,
        (object) parentId,
        (object) referenceTypeId,
        (object) namespaceIndex
      }, out outputArgs);
      return (NodeId) outputArgs[0];
    }

    public IUAMethod CreateEditModelFromStoreRecipeMethod
    {
      get => this.Refs.GetMethod("CreateEditModelFromStoreRecipe");
    }

    public void CopyFromStoreRecipe(
      string recipeName,
      NodeId destinationNode,
      CopyErrorPolicy errorPolicy)
    {
      this.ExecuteMethod(nameof (CopyFromStoreRecipe), new object[3]
      {
        (object) recipeName,
        (object) destinationNode,
        (object) errorPolicy
      });
    }

    public IUAMethod CopyFromStoreRecipeMethod => this.Refs.GetMethod("CopyFromStoreRecipe");

    public void CopyToStoreRecipe(
      NodeId sourceNode,
      string recipeName,
      CopyErrorPolicy errorPolicy)
    {
      this.ExecuteMethod(nameof (CopyToStoreRecipe), new object[3]
      {
        (object) sourceNode,
        (object) recipeName,
        (object) errorPolicy
      });
    }

    public IUAMethod CopyToStoreRecipeMethod => this.Refs.GetMethod("CopyToStoreRecipe");

    public InstanceNodeCollection<RecipeSchema> Instances
    {
      get => new InstanceNodeCollection<RecipeSchema>((IUANode) this);
    }
  }
}
