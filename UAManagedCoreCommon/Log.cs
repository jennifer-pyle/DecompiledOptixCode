// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Log
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public static class Log
  {
    public static void Error(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Error))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Error, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 10, nameof (Error));
    }

    public static void Error(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Error, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Error, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 16, nameof (Error));
    }

    public static void Warning(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Warning))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Warning, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 22, nameof (Warning));
    }

    public static void Warning(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Warning, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Warning, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 28, nameof (Warning));
    }

    public static void Info(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Info))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Info, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 34, nameof (Info));
    }

    public static void Info(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Info, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Info, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 40, nameof (Info));
    }

    public static void Debug(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Debug))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Debug, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 46, nameof (Debug));
    }

    public static void Debug(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Debug, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Debug, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 52, nameof (Debug));
    }

    public static void Verbose1(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Verbose1))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Verbose1, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 58, nameof (Verbose1));
    }

    public static void Verbose1(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Verbose1, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Verbose1, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 64, nameof (Verbose1));
    }

    public static void Verbose2(string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Verbose2))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Verbose2, "", (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 70, nameof (Verbose2));
    }

    public static void Verbose2(string category, string message)
    {
      if (!Log.IsLoggerEnabledForEntry(LogLevel.Verbose2, category))
        return;
      LogManager.CoreLogger?.Log(LogLevel.Verbose2, category, (ushort) 0, (ushort) 0, message, "", "C:\\jenkins\\workspace\\FTOptix_BuildDeploy\\src\\UAManagedProxy\\UAManagedCore\\Common\\Log.cs", 76, nameof (Verbose2));
    }

    public static string Node(IUANode node, bool verbose = false)
    {
      return LogManager.CoreLogger?.LogNode(node, verbose) ?? "";
    }

    private static bool IsLoggerEnabledForEntry(LogLevel logLevel, string moduleName = "")
    {
      ICoreLogger coreLogger = LogManager.CoreLogger;
      return coreLogger != null && coreLogger.IsEnabledForEntry(logLevel, moduleName);
    }
  }
}
