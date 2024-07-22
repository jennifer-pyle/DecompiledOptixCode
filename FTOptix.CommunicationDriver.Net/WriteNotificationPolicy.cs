// Decompiled with JetBrains decompiler
// Type: FTOptix.CommunicationDriver.WriteNotificationPolicy
// Assembly: FTOptix.CommunicationDriver.Net, Version=2.1.1.38, Culture=neutral, PublicKeyToken=null
// MVID: 85B3F030-0435-4D45-8599-8E193E2F5CB9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.CommunicationDriver.Net\2.1.1.38\Any\FTOptix.CommunicationDriver.Net.dll

#nullable disable
namespace FTOptix.CommunicationDriver
{
  public enum WriteNotificationPolicy
  {
    NotifyNever = 0,
    NotifyOnSuccessOrError = 1,
    NotifyOnSuccess = 2,
    NotifyOnOperationCompleted = 4,
  }
}
