﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAClient.SecurityPolicy
// Assembly: FTOptix.OPCUAClient.Net, Version=1.2.0.14, Culture=neutral, PublicKeyToken=null
// MVID: F06E52A2-2D8D-46E9-85AE-074DAF07FD19
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAClient.Net\1.2.0.14\Any\FTOptix.OPCUAClient.Net.dll

#nullable disable
namespace FTOptix.OPCUAClient
{
  public enum SecurityPolicy
  {
    None,
    Basic128Rsa15,
    Basic256,
    Basic256Sha256,
    Aes128_Sha256_RsaOaep,
    Aes256_Sha256_RsaPss,
  }
}
