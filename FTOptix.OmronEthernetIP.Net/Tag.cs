// Decompiled with JetBrains decompiler
// Type: FTOptix.OmronEthernetIP.Tag
// Assembly: FTOptix.OmronEthernetIP.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: 41B722E7-479B-45E5-98C5-B6231316318E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OmronEthernetIP.Net\1.0.8.38\Any\FTOptix.OmronEthernetIP.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.OmronEthernetIP
{
  [MapType(NamespaceUri = "urn:FTOptix:OmronEthernetIP", Number = 1)]
  public class Tag : FTOptix.CommunicationDriver.Tag
  {
    public string SymbolName
    {
      get => (string) this.Refs.GetVariable(nameof (SymbolName)).Value.Value;
      set => this.Refs.GetVariable(nameof (SymbolName)).SetValue((object) value);
    }

    public IUAVariable SymbolNameVariable => this.Refs.GetVariable("SymbolName");

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
  }
}
