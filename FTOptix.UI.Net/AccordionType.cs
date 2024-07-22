// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.AccordionType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 981)]
  public class AccordionType : ContainerType
  {
    public AccordionHeader Header => (AccordionHeader) this.Refs.GetObject(nameof (Header));

    public AccordionContent Content => (AccordionContent) this.Refs.GetObject(nameof (Content));

    public bool Expanded
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Expanded));
      set => this.SetOptionalVariableValue(nameof (Expanded), new UAValue(value));
    }

    public IUAVariable ExpandedVariable => this.GetOrCreateVariable("Expanded");

    public new float Height => (float) this.GetOptionalVariableValue(nameof (Height));

    public string Style
    {
      get => (string) this.GetOptionalVariableValue(nameof (Style));
      set => this.SetOptionalVariableValue(nameof (Style), new UAValue(value));
    }

    public IUAVariable StyleVariable => this.GetOrCreateVariable("Style");

    public InstanceNodeCollection<Accordion> Instances
    {
      get => new InstanceNodeCollection<Accordion>((IUANode) this);
    }
  }
}
