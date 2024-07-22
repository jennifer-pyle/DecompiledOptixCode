// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.LogLevel
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public enum LogLevel
  {
    None = -1, // 0xFFFFFFFF
    Fatal = 0,
    Error = 1,
    Warning = 2,
    Info = 3,
    Debug = 5,
    Verbose1 = 6,
    Verbose2 = 7,
  }
}
