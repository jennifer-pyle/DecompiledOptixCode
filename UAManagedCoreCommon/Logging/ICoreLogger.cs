// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Logging.ICoreLogger
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore.Logging
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface ICoreLogger
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void ClearSinks();

    [EditorBrowsable(EditorBrowsableState.Never)]
    void AddSink(ILogSink sink);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetDefaultLogLevel(LogLevel level);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void SetModuleLogLevel(string moduleName, LogLevel level);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ResetModuleLogLevel(string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    bool IsEnabledForEntry(LogLevel level, string moduleName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void Log(
      LogLevel level,
      string module,
      ushort moduleCode,
      ushort errorCode,
      string message,
      string stackTrace,
      [CallerFilePath] string file = null,
      [CallerLineNumber] int line = 0,
      [CallerMemberName] string function = null);

    [EditorBrowsable(EditorBrowsableState.Never)]
    string LogNode(IUANode node, bool verbose = false);
  }
}
