// Decompiled with JetBrains decompiler
// Type: FTOptix.RAEtherNetIP.TagType
// Assembly: FTOptix.RAEtherNetIP.Net, Version=2.2.0.11, Culture=neutral, PublicKeyToken=null
// MVID: 626313C4-D37E-4FD2-9B56-0300FEB2B54A
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.RAEtherNetIP.Net\2.2.0.11\Any\FTOptix.RAEtherNetIP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.RAEtherNetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:RAEtherNetIP", Number = 1)]
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

    public InstanceNodeCollection<Tag> Instances => new InstanceNodeCollection<Tag>((IUANode) this);
  }
}
