// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.ObjectArrayType
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 250)]
  public class ObjectArrayType : UAObjectType
  {
    public uint[] ArrayDimensions
    {
      get => (uint[]) this.Refs.GetVariable(nameof (ArrayDimensions)).Value.Value;
      set => this.Refs.GetVariable(nameof (ArrayDimensions)).SetValue((object) value);
    }

    public IUAVariable ArrayDimensionsVariable => this.Refs.GetVariable("ArrayDimensions");

    public InstanceNodeCollection<ObjectArray> Instances
    {
      get => new InstanceNodeCollection<ObjectArray>((IUANode) this);
    }
  }
}
