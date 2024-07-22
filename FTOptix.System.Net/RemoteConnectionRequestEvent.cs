// Decompiled with JetBrains decompiler
// Type: FTOptix.System.RemoteConnectionRequestEvent
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.System
{
  [CustomEventType(NamespaceUri = "urn:FTOptix:System", Number = 361)]
  public class RemoteConnectionRequestEvent
  {
    public ByteString SupervisorId { get; set; }

    public string Username { get; set; }

    public string IpAddress { get; set; }
  }
}
