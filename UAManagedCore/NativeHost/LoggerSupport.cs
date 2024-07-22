// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.LoggerSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class LoggerSupport
  {
    public static IntPtr CreateLogEntry(
      IntPtr filePtr,
      uint line,
      IntPtr functionNamePtr,
      IntPtr moduleNamePtr,
      long timestampTicks,
      int level,
      ushort moduleCode,
      ushort errorCode,
      IntPtr messagePtr,
      IntPtr stackTracePtr)
    {
      string file = StringMarshal.StringFromIntPtr(filePtr);
      string functionName = StringMarshal.StringFromIntPtr(functionNamePtr);
      string moduleName = StringMarshal.StringFromIntPtr(moduleNamePtr);
      DateTime timestamp = DateTimeSupport.DateTimeFromTicksSinceEpoch(timestampTicks);
      string message = StringMarshal.StringFromIntPtr(messagePtr);
      string stackTrace = StringMarshal.StringFromIntPtr(stackTracePtr);
      return ObjectMarshal.ToIntPtr((object) new UAManagedCore.Logging.LogEntry(file, line, functionName, moduleName, timestamp, (LogLevel) level, moduleCode, errorCode, message, stackTrace));
    }

    public static void InitializeLogManager(IntPtr nativeContextPtr)
    {
      if (LogManager.IsCoreLoggerManagerSet)
        return;
      LogManager.Set((ICoreLogger) new CoreLoggerWrapper(nativeContextPtr));
    }

    public static void LogEntry(IntPtr sinkPtr, IntPtr entryPtr)
    {
      ObjectMarshal.FromIntPtr<ILogSink>(sinkPtr).OnLogEntry(ObjectMarshal.ReleaseGCHandle<UAManagedCore.Logging.LogEntry>(entryPtr));
    }

    public static void ResetLogManager() => LogManager.Reset();

    public delegate IntPtr CreateLogEntryDelegate(
      IntPtr filePtr,
      uint line,
      IntPtr functionName,
      IntPtr moduleName,
      long timestampTicks,
      int level,
      ushort moduleCode,
      ushort errorCode,
      IntPtr message,
      IntPtr stackTrace);

    public delegate void InitializeLogManagerDelegate(IntPtr nativeContextPtr);

    public delegate void LogEntryDelegate(IntPtr sinkPtr, IntPtr entryPtr);

    public delegate void ResetLogManagerDelegate();
  }
}
