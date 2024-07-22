// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.ILogger
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface ILogger
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void Trace([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Trace([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Trace(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Debug([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Debug([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Debug(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Info([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Info([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Info(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Warn([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Warn([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Warn(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Error([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Error([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Error(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Fatal([Localizable(false)] string message);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Fatal([Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Fatal(Exception exception, [Localizable(false)] string message, params object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsTraceEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsDebugEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsInfoEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsWarnEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsErrorEnabled { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsFatalEnabled { get; }
  }
}
