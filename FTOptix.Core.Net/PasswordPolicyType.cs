// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.PasswordPolicyType
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 257)]
  public class PasswordPolicyType : UAObjectType
  {
    public ushort MaximumPasswordAge
    {
      get => (ushort) this.Refs.GetVariable(nameof (MaximumPasswordAge)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaximumPasswordAge)).SetValue((object) value);
    }

    public IUAVariable MaximumPasswordAgeVariable => this.Refs.GetVariable("MaximumPasswordAge");

    public byte EnforcePasswordHistory
    {
      get => (byte) this.Refs.GetVariable(nameof (EnforcePasswordHistory)).Value.Value;
      set => this.Refs.GetVariable(nameof (EnforcePasswordHistory)).SetValue((object) value);
    }

    public IUAVariable EnforcePasswordHistoryVariable
    {
      get => this.Refs.GetVariable("EnforcePasswordHistory");
    }

    public double MinimumPasswordAge
    {
      get => (double) this.Refs.GetVariable(nameof (MinimumPasswordAge)).Value.Value;
      set => this.Refs.GetVariable(nameof (MinimumPasswordAge)).SetValue((object) value);
    }

    public IUAVariable MinimumPasswordAgeVariable => this.Refs.GetVariable("MinimumPasswordAge");

    public byte MinimumPasswordLength
    {
      get => (byte) this.Refs.GetVariable(nameof (MinimumPasswordLength)).Value.Value;
      set => this.Refs.GetVariable(nameof (MinimumPasswordLength)).SetValue((object) value);
    }

    public IUAVariable MinimumPasswordLengthVariable
    {
      get => this.Refs.GetVariable("MinimumPasswordLength");
    }

    public InstanceNodeCollection<PasswordPolicy> Instances
    {
      get => new InstanceNodeCollection<PasswordPolicy>((IUANode) this);
    }
  }
}
