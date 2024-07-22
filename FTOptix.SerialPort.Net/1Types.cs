// Decompiled with JetBrains decompiler
// Type: FTOptix.SerialPort.ObjectTypes
// Assembly: FTOptix.SerialPort.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: E3264ECA-77C1-4764-A2BE-A8103A2488FF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.SerialPort.Net\1.0.8.38\Any\FTOptix.SerialPort.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.SerialPort
{
  public static class ObjectTypes
  {
    private static readonly int namespaceIndex = NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:SerialPort");
    public static readonly NodeId SerialPort = new NodeId(ObjectTypes.namespaceIndex, 1U);
  }
}
