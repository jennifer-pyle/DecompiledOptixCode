// Decompiled with JetBrains decompiler
// Type: FTOptix.Recipe.RecipeApplicationEvent
// Assembly: FTOptix.Recipe.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: EFD0D777-9FCB-4D24-B9F7-D873EB52C7CF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Recipe.Net\1.0.8.39\Any\FTOptix.Recipe.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.Recipe
{
  [CustomEventType(NamespaceUri = "urn:FTOptix:Recipe", Number = 73)]
  public class RecipeApplicationEvent : AuditUpdateMethodEvent
  {
    public string RecipeName { get; set; }

    public NodeId DestinationNode { get; set; }
  }
}
