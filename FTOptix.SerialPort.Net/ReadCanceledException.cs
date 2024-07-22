// Decompiled with JetBrains decompiler
// Type: FTOptix.SerialPort.ReadCanceledException
// Assembly: FTOptix.SerialPort.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: E3264ECA-77C1-4764-A2BE-A8103A2488FF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.SerialPort.Net\1.0.8.38\Any\FTOptix.SerialPort.Net.dll

using System;

#nullable disable
namespace FTOptix.SerialPort
{
  [Serializable]
  public class ReadCanceledException : Exception
  {
    public ReadCanceledException()
    {
    }

    public ReadCanceledException(string message)
      : base(message)
    {
    }
  }
}
