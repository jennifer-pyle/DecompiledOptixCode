// Decompiled with JetBrains decompiler
// Type: FTOptix.S7TiaProfinet.TagType
// Assembly: FTOptix.S7TiaProfinet.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 04D0A327-9B8D-4FD1-B415-024D37158081
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.S7TiaProfinet.Net\1.1.2.38\Any\FTOptix.S7TiaProfinet.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.S7TiaProfinet
{
  [MapType(NamespaceUri = "urn:FTOptix:S7TiaProfinet", Number = 3)]
  public class TagType : FTOptix.CommunicationDriver.TagType
  {
    public string SymbolName
    {
      get => (string) this.Refs.GetVariable(nameof (SymbolName)).Value.Value;
      set => this.Refs.GetVariable(nameof (SymbolName)).SetValue((object) value);
    }

    public IUAVariable SymbolNameVariable => this.Refs.GetVariable("SymbolName");

    public Encoding Encoding
    {
      get => (Encoding) (int) this.GetOptionalVariableValue(nameof (Encoding));
      set => this.SetOptionalVariableValue(nameof (Encoding), new UAValue((int) value));
    }

    public IUAVariable EncodingVariable => this.GetOrCreateVariable("Encoding");

    public int MaximumLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaximumLength));
      set => this.SetOptionalVariableValue(nameof (MaximumLength), new UAValue(value));
    }

    public IUAVariable MaximumLengthVariable => this.GetOrCreateVariable("MaximumLength");

    public uint[] StartArrayIndex
    {
      get => (uint[]) this.GetOptionalVariableValue(nameof (StartArrayIndex));
      set => this.SetOptionalVariableValue(nameof (StartArrayIndex), new UAValue(value));
    }

    public IUAVariable StartArrayIndexVariable => this.GetOrCreateVariable("StartArrayIndex");

    public InstanceNodeCollection<Tag> Instances => new InstanceNodeCollection<Tag>((IUANode) this);
  }
}
