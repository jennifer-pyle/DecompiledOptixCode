// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.LogEntry
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class LogEntry
  {
    public LogEntry(
      string file,
      uint line,
      string functionName,
      string moduleName,
      DateTime timestamp,
      LogLevel level,
      ushort moduleCode,
      ushort errorCode,
      string message,
      string stackTrace)
    {
      this.File = file;
      this.Line = line;
      this.FunctionName = functionName;
      this.ModuleName = moduleName;
      this.Timestamp = timestamp;
      this.Level = level;
      this.ModuleCode = moduleCode;
      this.ErrorCode = errorCode;
      this.Message = message;
      this.StackTrace = stackTrace;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string File { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint Line { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string FunctionName { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ModuleName { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DateTime Timestamp { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public LogLevel Level { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ushort ModuleCode { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ushort ErrorCode { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Message { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string StackTrace { get; }
  }
}
