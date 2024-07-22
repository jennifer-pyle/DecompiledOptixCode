// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUANode
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUANode
  {
    string BrowseName { get; set; }

    QualifiedName QualifiedBrowseName { get; set; }

    LocalizedText DisplayName { get; set; }

    LocalizedText Description { get; set; }

    bool IsValid { get; }

    NodeId NodeId { get; }

    NodeClass NodeClass { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAReferences Refs { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUAReferences InverseRefs { get; }

    IUANode Owner { get; set; }

    void Delete();

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEventRegistration RegisterEventObserver(
      IEventObserver observer,
      EventType eventTypeMask,
      uint affinityId = 0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    ITransactionEventRegistration RegisterTransactionObserver(
      ITransactionObserver observer,
      TransactionObserverType observerTypeMask);

    [EditorBrowsable(EditorBrowsableState.Never)]
    IReadOnlyList<IUANode> GetOwnedNodes();

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetModellingRuleRecursive();

    [EditorBrowsable(EditorBrowsableState.Never)]
    IContext Context { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    NamingRuleType ModellingRule { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    NodeStatus Status { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IUANode Parent { get; }

    ChildNodeCollection Children { get; }
  }
}
