// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.CoreLoggerAdapter
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class CoreLoggerAdapter : ILogger
  {
    private const string NullStackTrace = "";
    private const string NullFileName = "";
    private const int NullLine = 0;
    private const string NullFunction = "";
    private const ushort NullModuleCode = 0;
    private readonly string loggerName;
    private readonly ICoreLogger coreLogger;

    public CoreLoggerAdapter(string loggerName, ICoreLogger coreLogger)
    {
      this.loggerName = loggerName;
      this.coreLogger = coreLogger;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsTraceEnabled
    {
      get => this.IsEnabledForEntry(LogLevel.Verbose1) || this.IsEnabledForEntry(LogLevel.Verbose2);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsDebugEnabled => this.IsEnabledForEntry(LogLevel.Debug);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsInfoEnabled => this.IsEnabledForEntry(LogLevel.Info);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsWarnEnabled => this.IsEnabledForEntry(LogLevel.Warning);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsErrorEnabled => this.IsEnabledForEntry(LogLevel.Error);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsFatalEnabled => this.IsEnabledForEntry(LogLevel.Fatal);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Log(
      LogLevel level,
      ushort moduleCode,
      ushort errorCode,
      string message,
      string stackTrace,
      string file,
      int lineNumber,
      string function)
    {
      if (!this.IsEnabledForEntry(level))
        return;
      this.coreLogger.Log(level, this.loggerName, moduleCode, errorCode, message, stackTrace, file, lineNumber, function);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Trace(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Verbose1))
        return;
      this.InternalLog(LogLevel.Verbose1, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Trace(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Verbose1))
        return;
      this.InternalLog(LogLevel.Verbose1, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Trace(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Verbose1))
        return;
      this.InternalLog(LogLevel.Verbose1, (ushort) 0, string.Format(message, args), exception);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Debug(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Debug))
        return;
      this.InternalLog(LogLevel.Debug, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Debug(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Debug))
        return;
      this.InternalLog(LogLevel.Debug, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Debug(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Debug))
        return;
      this.InternalLog(LogLevel.Debug, (ushort) 0, string.Format(message, args), exception);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Info(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Info))
        return;
      this.InternalLog(LogLevel.Info, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Info(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Info))
        return;
      this.InternalLog(LogLevel.Info, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Info(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Info))
        return;
      this.InternalLog(LogLevel.Info, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Warn(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Warning))
        return;
      this.InternalLog(LogLevel.Warning, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Warn(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Warning))
        return;
      this.InternalLog(LogLevel.Warning, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Warn(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Warning))
        return;
      this.InternalLog(LogLevel.Warning, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Error(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Error))
        return;
      this.InternalLogExtractingStack(LogLevel.Error, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Error(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Error))
        return;
      this.InternalLogExtractingStack(LogLevel.Error, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Error(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Error))
        return;
      this.InternalLogExtractingStack(LogLevel.Error, (ushort) 0, string.Format(message, args), exception);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Fatal(string message)
    {
      if (!this.IsEnabledForEntry(LogLevel.Fatal))
        return;
      this.InternalLogExtractingStack(LogLevel.Fatal, (ushort) 0, message);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Fatal(string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Fatal))
        return;
      this.InternalLogExtractingStack(LogLevel.Fatal, (ushort) 0, string.Format(message, args));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Fatal(Exception exception, string message, params object[] args)
    {
      if (!this.IsEnabledForEntry(LogLevel.Fatal))
        return;
      this.InternalLogExtractingStack(LogLevel.Fatal, (ushort) 0, string.Format(message, args), exception);
    }

    private bool IsEnabledForEntry(LogLevel level)
    {
      return this.coreLogger.IsEnabledForEntry(level, this.loggerName);
    }

    private void ExtractFromCallStack(
      int skipFrames,
      out string fileName,
      out int line,
      out string methodName)
    {
      StackFrame frame = new StackTrace(skipFrames, true).GetFrame(0);
      fileName = Path.GetFileName(frame.GetFileName());
      line = frame.GetFileLineNumber();
      methodName = frame.GetMethod().Name;
    }

    private void InternalLog(LogLevel level, ushort errorCode, string message)
    {
      this.coreLogger.Log(level, this.loggerName, (ushort) 0, errorCode, message, "", "", function: "");
    }

    private void InternalLogExtractingStack(LogLevel level, ushort errorCode, string message)
    {
      string fileName;
      int line;
      string methodName;
      this.ExtractFromCallStack(3, out fileName, out line, out methodName);
      this.coreLogger.Log(level, this.loggerName, (ushort) 0, errorCode, message, "", fileName ?? "", line, methodName ?? "");
    }

    private void InternalLog(
      LogLevel level,
      ushort errorCode,
      string message,
      Exception exception)
    {
      this.coreLogger.Log(level, this.loggerName, (ushort) 0, errorCode, message, exception.ToString(), "", function: "");
    }

    private void InternalLogExtractingStack(
      LogLevel level,
      ushort errorCode,
      string message,
      Exception exception)
    {
      string fileName;
      int line;
      string methodName;
      this.ExtractFromCallStack(3, out fileName, out line, out methodName);
      this.coreLogger.Log(level, this.loggerName, (ushort) 0, errorCode, message, exception.ToString(), fileName ?? "", line, methodName ?? "");
    }
  }
}
