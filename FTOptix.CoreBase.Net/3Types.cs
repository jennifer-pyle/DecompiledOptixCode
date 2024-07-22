// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.Objects
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public static class Objects
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase");
    public static readonly NodeId VariableCommands = new NodeId(Objects.namespaceIndex, 22U);
    public static readonly NodeId CoreCommands = new NodeId(Objects.namespaceIndex, 29U);
    public static readonly NodeId CoreContext = new NodeId(Objects.namespaceIndex, 54U);
  }
}
