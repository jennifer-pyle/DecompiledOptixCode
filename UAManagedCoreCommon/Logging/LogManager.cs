// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.LogManager
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class LogManager
  {
    private static readonly LogManager.NullLoggerFactory DefaultNullLoggerFactory = new LogManager.NullLoggerFactory();
    private static ICoreLogger coreLogger;
    private static ILoggerFactory defaultLoggerFactory = (ILoggerFactory) LogManager.DefaultNullLoggerFactory;
    private static ILoggerFactory loggerFactory;

    internal static bool IsCoreLoggerManagerSet => LogManager.coreLogger != null;

    internal static void Set(ICoreLogger coreLogger)
    {
      LogManager.coreLogger = coreLogger != null ? coreLogger : throw new ArgumentNullException(nameof (coreLogger));
      LogManager.defaultLoggerFactory = (ILoggerFactory) new CoreLoggerAdapterFactory(coreLogger);
    }

    internal static void Reset()
    {
      LogManager.coreLogger = (ICoreLogger) null;
      LogManager.defaultLoggerFactory = (ILoggerFactory) LogManager.DefaultNullLoggerFactory;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ICoreLogger CoreLogger => LogManager.coreLogger;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void Set(ILoggerFactory loggerFactory)
    {
      LogManager.loggerFactory = loggerFactory;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILogger GetCurrentClassLogger()
    {
      Type declaringType = new StackFrame(1, false).GetMethod().DeclaringType;
      return !(declaringType != (Type) null) ? (ILogger) null : LogManager.GetLogger(declaringType.FullName);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILogger GetCurrentAssemblyLogger()
    {
      return LogManager.GetLogger(Assembly.GetCallingAssembly().GetName().Name);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILogger GetCurrentModuleLogger()
    {
      return LogManager.GetLogger((Assembly.GetCallingAssembly().GetCustomAttribute<ModuleDefaultNamespaceAttribute>() ?? throw new InvalidOperationException("Calling assembly is not a Core Net Module")).NamespaceUri);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ILogger GetLogger(string loggerName)
    {
      return LogManager.loggerFactory == null ? LogManager.defaultLoggerFactory.MakeLoggerFor(loggerName) : LogManager.loggerFactory.MakeLoggerFor(loggerName);
    }

    private class NullLogger : ILogger
    {
      public bool IsTraceEnabled => false;

      public bool IsDebugEnabled => false;

      public bool IsInfoEnabled => false;

      public bool IsWarnEnabled => false;

      public bool IsErrorEnabled => false;

      public bool IsFatalEnabled => false;

      public void Debug([Localizable(false)] string message)
      {
      }

      public void Debug([Localizable(false)] string message, params object[] args)
      {
      }

      public void Debug(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }

      public void Error([Localizable(false)] string message)
      {
      }

      public void Error([Localizable(false)] string message, params object[] args)
      {
      }

      public void Error(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }

      public void Fatal([Localizable(false)] string message)
      {
      }

      public void Fatal([Localizable(false)] string message, params object[] args)
      {
      }

      public void Fatal(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }

      public void Info([Localizable(false)] string message)
      {
      }

      public void Info([Localizable(false)] string message, params object[] args)
      {
      }

      public void Info(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }

      public void Trace([Localizable(false)] string message)
      {
      }

      public void Trace([Localizable(false)] string message, params object[] args)
      {
      }

      public void Trace(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }

      public void Warn([Localizable(false)] string message)
      {
      }

      public void Warn([Localizable(false)] string message, params object[] args)
      {
      }

      public void Warn(Exception exception, [Localizable(false)] string message, params object[] args)
      {
      }
    }

    private class NullLoggerFactory : ILoggerFactory
    {
      private static readonly LogManager.NullLogger DefaultNullLogger = new LogManager.NullLogger();

      public ILogger MakeLoggerFor(string loggerName)
      {
        return (ILogger) LogManager.NullLoggerFactory.DefaultNullLogger;
      }
    }
  }
}
