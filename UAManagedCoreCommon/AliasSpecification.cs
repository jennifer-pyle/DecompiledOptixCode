// Decompiled with JetBrains decompiler
// Type: UAManagedCore.AliasSpecification
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class AliasSpecification
  {
    public AliasSpecification(
      IUAVariable aliasVariable,
      IUANode aliasedNode,
      string aliasTokenPath)
    {
      this.AliasVariable = aliasVariable;
      this.AliasedNode = aliasedNode;
      this.AliasTokenPath = aliasTokenPath;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUAVariable AliasVariable { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUANode AliasedNode { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string AliasTokenPath { get; }
  }
}
