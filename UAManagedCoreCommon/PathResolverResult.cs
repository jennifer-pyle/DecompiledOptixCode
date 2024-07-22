// Decompiled with JetBrains decompiler
// Type: UAManagedCore.PathResolverResult
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class PathResolverResult
  {
    public PathResolverResult(
      IUANode resolvedNode,
      NodePathKind nodePathKind,
      AliasSpecification aliasSpecification,
      uint[] indexes)
    {
      this.ResolvedNode = resolvedNode;
      this.NodePathKind = nodePathKind;
      this.AliasSpecification = aliasSpecification;
      this.Indexes = indexes;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUANode ResolvedNode { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NodePathKind NodePathKind { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public AliasSpecification AliasSpecification { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint[] Indexes { get; }
  }
}
