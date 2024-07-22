// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.ReferenceTypes
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public static class ReferenceTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:HMIProject");
    public static readonly NodeId OrganizesType = new NodeId(ReferenceTypes.namespaceIndex, 1U);
  }
}
