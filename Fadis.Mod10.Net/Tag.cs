// Decompiled with JetBrains decompiler
// Type: Fadis.Mod10.Tag
// Assembly: Fadis.Mod10.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 1099F770-190D-4133-B8B5-E01D40B2BFEB
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\Fadis.Mod10.Net\1.0.8.38\Any\Fadis.Mod10.Net.dll

using UAManagedCore;

#nullable disable
namespace Fadis.Mod10
{
  [MapType(NamespaceUri = "urn:Fadis:Mod10", Number = 1)]
  public class Tag : FTOptix.CommunicationDriver.Tag
  {
    public byte UnitId
    {
      get => (byte) this.GetOptionalVariableValue(nameof (UnitId));
      set => this.SetOptionalVariableValue(nameof (UnitId), new UAValue(value));
    }

    public IUAVariable UnitIdVariable => this.GetOrCreateVariable("UnitId");

    public ushort Index
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (Index));
      set => this.SetOptionalVariableValue(nameof (Index), new UAValue(value));
    }

    public IUAVariable IndexVariable => this.GetOrCreateVariable("Index");

    public byte SubIndex
    {
      get => (byte) this.GetOptionalVariableValue(nameof (SubIndex));
      set => this.SetOptionalVariableValue(nameof (SubIndex), new UAValue(value));
    }

    public IUAVariable SubIndexVariable => this.GetOrCreateVariable("SubIndex");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public bool IgnoreWriteErrors
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IgnoreWriteErrors));
      set => this.SetOptionalVariableValue(nameof (IgnoreWriteErrors), new UAValue(value));
    }

    public IUAVariable IgnoreWriteErrorsVariable => this.GetOrCreateVariable("IgnoreWriteErrors");
  }
}
