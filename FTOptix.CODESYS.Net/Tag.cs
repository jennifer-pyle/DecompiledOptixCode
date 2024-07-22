// Decompiled with JetBrains decompiler
// Type: FTOptix.CODESYS.Tag
// Assembly: FTOptix.CODESYS.Net, Version=2.0.4.38, Culture=neutral, PublicKeyToken=null
// MVID: 8A6E538D-4FC1-46A5-B5C8-EC5F861CEF6D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CODESYS.Net\2.0.4.38\Any\FTOptix.CODESYS.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CODESYS
{
  [MapType(NamespaceUri = "urn:FTOptix:CODESYS", Number = 1)]
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
