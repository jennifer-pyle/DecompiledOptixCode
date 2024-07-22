// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.WarningZone
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 305)]
  public class WarningZone : UAObject
  {
    public float From
    {
      get => (float) this.Refs.GetVariable(nameof (From)).Value.Value;
      set => this.Refs.GetVariable(nameof (From)).SetValue((object) value);
    }

    public IUAVariable FromVariable => this.Refs.GetVariable("From");

    public float To
    {
      get => (float) this.Refs.GetVariable(nameof (To)).Value.Value;
      set => this.Refs.GetVariable(nameof (To)).SetValue((object) value);
    }

    public IUAVariable ToVariable => this.Refs.GetVariable("To");

    public Color Color
    {
      get => new Color(this.Refs.GetVariable(nameof (Color)).Value);
      set => this.Refs.GetVariable(nameof (Color)).SetValue((object) value.ARGB);
    }

    public IUAVariable ColorVariable => this.Refs.GetVariable("Color");
  }
}
