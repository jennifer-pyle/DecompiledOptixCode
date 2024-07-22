// Decompiled with JetBrains decompiler
// Type: FTOptix.System.LoadApplicationStatus
// Assembly: FTOptix.System.Net, Version=2.0.3.39, Culture=neutral, PublicKeyToken=null
// MVID: 2CB0A6CF-E541-4E16-BCC4-5A76CC1832FC
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.System.Net\2.0.3.39\Any\FTOptix.System.Net.dll

#nullable disable
namespace FTOptix.System
{
  public enum LoadApplicationStatus
  {
    Success = 0,
    InternalError = 1,
    InvalidFilePath = 2,
    InvalidProjectDescriptorFile = 3,
    InvalidProjectFile = 4,
    ProtectionModeActive = 6,
    UnencryptedFile = 7,
    WrongPassword = 8,
    ImportAlreadyInProgress = 9,
  }
}
