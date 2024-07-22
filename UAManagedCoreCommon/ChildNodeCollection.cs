// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ChildNodeCollection
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public class ChildNodeCollection : TypedChildNodeCollection<IUANode>
  {
    public ChildNodeCollection(IUANode node)
      : base(node)
    {
    }

    public IUAObject GetObject(QualifiedName browseName)
    {
      return this.parentNode.Refs.GetObject(browseName.Name);
    }

    public IUAVariable GetVariable(QualifiedName browseName)
    {
      return this.parentNode.Refs.GetVariable(browseName.Name);
    }

    protected override IEnumerable<IUANode> GetChildNodes()
    {
      return (IEnumerable<IUANode>) this.parentNode.GetOwnedNodes();
    }
  }
}
