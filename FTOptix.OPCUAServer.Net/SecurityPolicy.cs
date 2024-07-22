// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAServer.SecurityPolicy
// Assembly: FTOptix.OPCUAServer.Net, Version=1.1.4.39, Culture=neutral, PublicKeyToken=null
// MVID: 8FF3501A-13A0-4017-8C9B-45AF38532B2C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAServer.Net\1.1.4.39\Any\FTOptix.OPCUAServer.Net.dll

#nullable disable
namespace FTOptix.OPCUAServer
{
  public enum SecurityPolicy
  {
    None,
    Basic256Sha256,
    Aes128_Sha256_RsaOaep,
    Aes256_Sha256_RsaPss,
  }
}
