// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExternalVariableSynchronizer.IndexedVariable
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore.ExternalVariableSynchronizer
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class IndexedVariable
  {
    public IndexedVariable(IUAVariable variable, uint[] indexes)
    {
      this.Variable = variable;
      this.Indexes = indexes;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUAVariable Variable { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint[] Indexes { get; }
  }
}
