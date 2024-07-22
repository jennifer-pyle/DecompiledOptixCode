// Decompiled with JetBrains decompiler
// Type: FTOptix.Retentivity.ObjectTypes
// Assembly: FTOptix.Retentivity.Net, Version=1.0.8.46, Culture=neutral, PublicKeyToken=null
// MVID: 27AC4578-28B3-4DBE-BFC1-C6B2253C6E5D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Retentivity.Net\1.0.8.46\Any\FTOptix.Retentivity.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Retentivity
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Retentivity");
    public static readonly NodeId RetentivityStorage = new NodeId(ObjectTypes.namespaceIndex, 1U);
  }
}
