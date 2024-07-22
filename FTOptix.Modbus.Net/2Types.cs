// Decompiled with JetBrains decompiler
// Type: FTOptix.Modbus.VariableTypes
// Assembly: FTOptix.Modbus.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: C70D0038-6EC8-4D48-89C2-4A031CE99C4E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Modbus.Net\1.0.8.38\Any\FTOptix.Modbus.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Modbus
{
  public static class VariableTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:Modbus");
    public static readonly NodeId Tag = new NodeId(VariableTypes.namespaceIndex, 3U);
  }
}
