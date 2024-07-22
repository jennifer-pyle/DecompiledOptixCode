// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.ChangeUserResult
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

#nullable disable
namespace FTOptix.Core
{
  public readonly struct ChangeUserResult
  {
    public ChangeUserResult(ChangeUserResultCode resultCode) => this.ResultCode = resultCode;

    public static implicit operator bool(ChangeUserResult value) => value.Success;

    public bool Success => this.ResultCode == ChangeUserResultCode.Success;

    public ChangeUserResultCode ResultCode { get; }
  }
}
