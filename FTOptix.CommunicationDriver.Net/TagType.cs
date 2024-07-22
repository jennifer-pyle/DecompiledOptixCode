// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.TagType
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using System.ComponentModel;
using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  [MapType(NamespaceUri = "urn:FTOptix:CommunicationDriver", Number = 2)]
  public class TagType : UAVariableType
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public TagArrayUpdateMode ArrayUpdateMode
    {
      get => (TagArrayUpdateMode) (int) this.GetOptionalVariableValue(nameof (ArrayUpdateMode));
      set => this.SetOptionalVariableValue(nameof (ArrayUpdateMode), new UAValue((int) value));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUAVariable ArrayUpdateModeVariable => this.GetOrCreateVariable("ArrayUpdateMode");

    public NodeId OriginalDataType
    {
      get => (NodeId) this.GetOptionalVariableValue(nameof (OriginalDataType));
    }

    public IUAVariable OriginalDataTypeVariable => this.GetOrCreateVariable("OriginalDataType");

    public InstanceNodeCollection<Tag> Instances => new InstanceNodeCollection<Tag>((IUANode) this);
  }
}
