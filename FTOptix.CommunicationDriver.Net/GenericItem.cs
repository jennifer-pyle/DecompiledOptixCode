// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.GenericItem
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CommunicationDriver
{
  [MapDataType(NamespaceUri = "urn:FTOptix:CommunicationDriver", Number = 103)]
  public class GenericItem : BasePlcItem
  {
    [StructFieldInfo(3, null, ValueRank.Scalar, null)]
    public NodeId Type { get; set; }
  }
}
