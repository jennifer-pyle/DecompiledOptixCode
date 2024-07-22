// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CoreLoggerWrapper
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UAManagedCore.Logging;

#nullable disable
namespace UAManagedCore
{
  public class CoreLoggerWrapper : ICoreLogger
  {
    private IntPtr nativeContextPtr;

    public CoreLoggerWrapper(IntPtr nativeContext) => this.nativeContextPtr = nativeContext;

    public void AddSink(ILogSink sink)
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperAddSink(this.nativeContextPtr, ObjectMarshal.ToIntPtr((object) sink)).CheckOutcome();
    }

    public void ClearSinks()
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperClearSinks().CheckOutcome();
    }

    public bool IsEnabledForEntry(LogLevel level, string moduleName)
    {
      InteropCallResult interopCallResult = CoreLoggerWrapper.Interop.CoreLoggerWrapperIsEnabledForEntry((int) level, moduleName);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetBool();
    }

    public void Log(
      LogLevel level,
      string module,
      ushort moduleCode,
      ushort errorCode,
      string message,
      string stackTrace,
      [CallerFilePath] string file = null,
      [CallerLineNumber] int line = 0,
      [CallerMemberName] string function = null)
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperLogEntry((int) level, module, (uint) moduleCode, (uint) errorCode, message, stackTrace, file, (uint) line, function).CheckOutcome();
    }

    public string LogNode(IUANode node, bool verbose = false)
    {
      InteropCallResult interopCallResult = CoreLoggerWrapper.Interop.CoreLoggerWrapperLogNode(ObjectMarshal.ToIntPtr((object) ((UANode) node).nodeHandle), verbose ? 1 : 0);
      interopCallResult.CheckOutcome();
      return interopCallResult.GetString();
    }

    public void ResetModuleLogLevel(string moduleName)
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperResetModuleLogLevel(moduleName).CheckOutcome();
    }

    public void SetDefaultLogLevel(LogLevel level)
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperSetDefaultLogLevel((int) level).CheckOutcome();
    }

    public void SetModuleLogLevel(string moduleName, LogLevel level)
    {
      CoreLoggerWrapper.Interop.CoreLoggerWrapperSetModuleLogLevel(moduleName, (int) level).CheckOutcome();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperAddSink(IntPtr context, IntPtr sink);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperClearSinks();

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperIsEnabledForEntry(
        int level,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperLogEntry(
        int level,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string module,
        uint moduleCode,
        uint errorCode,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string message,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string stackTrace,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string file,
        uint line,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string function);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperLogNode(
        IntPtr nodeHandle,
        int verbose);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperResetModuleLogLevel(
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperSetDefaultLogLevel(int level);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult CoreLoggerWrapperSetModuleLogLevel(
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string moduleName,
        int level);
    }
  }
}
