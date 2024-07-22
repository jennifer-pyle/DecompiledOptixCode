// Decompiled with JetBrains decompiler
// Type: UAManagedCore.MoveOrderedReferenceExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore
{
  public static class MoveOrderedReferenceExtensions
  {
    public static void MoveUp(this IUANode node) => MoveOrderedReferenceExtensions.Move(node, true);

    public static void MoveDown(this IUANode node)
    {
      MoveOrderedReferenceExtensions.Move(node, false);
    }

    private static void Move(IUANode node, bool moveUp)
    {
      IUANode owner = node.Owner;
      if (owner == null)
        throw new InvalidOperationException("Unable to move node " + Log.Node(node) + ": missing owner");
      NodeId owningReferenceTypeId = MoveOrderedReferenceExtensions.GetOwningReferenceTypeId(node);
      List<UAReference> targetReferences = !owningReferenceTypeId.IsEmpty ? MoveOrderedReferenceExtensions.GetTargetReferences(node, owningReferenceTypeId) : throw new InvalidOperationException("Unable to move node " + Log.Node(node) + ": unable to determine owning reference");
      uint from = (MoveOrderedReferenceExtensions.GetOwningReferenceIndex(targetReferences, node.NodeId) ?? throw new InvalidOperationException("Unable to move node " + Log.Node(node) + ": unable to determine reference index")).Value;
      if (moveUp)
      {
        if (from <= 0U)
          return;
        owner.Refs.MoveOrderedReference(owningReferenceTypeId, from, from - 1U);
      }
      else
      {
        if ((long) from >= (long) (targetReferences.Count - 1))
          return;
        owner.Refs.MoveOrderedReference(owningReferenceTypeId, from, from + 1U);
      }
    }

    private static void FilterOutReferencesExcludedFromMoveOperation(List<UAReference> allReferences)
    {
      allReferences.RemoveAll((Predicate<UAReference>) (r => r.ReferenceTypeId == ReferenceTypes.HasEventSource || r.ReferenceTypeId == ReferenceTypes.HasSubtype || r.ReferenceTypeId == ReferenceTypes.HasTypeDefinition));
    }

    private static NodeId GetOwningReferenceTypeId(IUANode node)
    {
      List<UAReference> list = node.Owner.Refs.GetReferences().ToList<UAReference>();
      MoveOrderedReferenceExtensions.FilterOutReferencesExcludedFromMoveOperation(list);
      NodeId referenceTypeId = list.FirstOrDefault<UAReference>((Func<UAReference, bool>) (r => r.TargetNodeId == node.NodeId)).ReferenceTypeId;
      return (object) referenceTypeId != null ? referenceTypeId : NodeId.Empty;
    }

    private static List<UAReference> GetTargetReferences(IUANode node, NodeId referenceTypeId)
    {
      List<UAReference> list = node.Owner.Refs.GetReferences().ToList<UAReference>();
      MoveOrderedReferenceExtensions.FilterOutReferencesExcludedFromMoveOperation(list);
      IContext context = node.Context;
      return list.Where<UAReference>((Func<UAReference, bool>) (r => context.GetReferenceType(r.ReferenceTypeId).IsSubTypeOf(referenceTypeId))).ToList<UAReference>();
    }

    private static uint? GetOwningReferenceIndex(
      List<UAReference> targetReferences,
      NodeId targetNodeId)
    {
      for (int index = 0; index < targetReferences.Count; ++index)
      {
        if (targetReferences[index].TargetNodeId == targetNodeId)
          return new uint?((uint) index);
      }
      return new uint?();
    }
  }
}
