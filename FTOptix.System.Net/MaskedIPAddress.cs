// Decompiled with JetBrains decompiler
// Type: FTOptix.System.MaskedIPAddress
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [MapType(NamespaceUri = "urn:FTOptix:System", Number = 8)]
  public class MaskedIPAddress : UAVariable
  {
    public string Mask
    {
      get => (string) this.Refs.GetVariable(nameof (Mask)).Value.Value;
      set => this.Refs.GetVariable(nameof (Mask)).SetValue((object) value);
    }

    public IUAVariable MaskVariable => this.Refs.GetVariable("Mask");
  }
}
