// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAReference
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public struct UAReference
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly NodeId ReferenceTypeId;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly NodeId TargetNodeId;
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly IUANode TargetNode;

    public UAReference(NodeId referenceTypeId, NodeId targetNodeId, IUANode targetNode)
    {
      this.ReferenceTypeId = referenceTypeId;
      this.TargetNodeId = targetNodeId;
      this.TargetNode = targetNode;
    }
  }
}
