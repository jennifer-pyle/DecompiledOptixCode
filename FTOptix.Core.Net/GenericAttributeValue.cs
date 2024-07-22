// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.GenericAttributeValue
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  [MapDataType(NamespaceUri = "http://opcfoundation.org/UA/", Number = 17606)]
  public class GenericAttributeValue : TypedStruct
  {
    [StructFieldInfo(0, null, ValueRank.Scalar, null)]
    public uint AttributeId { get; set; }

    [StructFieldInfo(1, null, ValueRank.Any, null)]
    public object Value { get; set; }
  }
}
