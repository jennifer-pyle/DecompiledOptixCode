// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CoreException
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  [Serializable]
  public class CoreException : Exception
  {
    public CoreException()
    {
    }

    public CoreException(string message)
      : base(message)
    {
    }

    public CoreException(string message, Exception innerException)
      : base(message, innerException)
    {
    }

    public CoreException(
      string message,
      string moduleName,
      ushort moduleCode,
      ushort errorCode,
      string nativeStackTrace)
      : base(message)
    {
      this.ModuleName = moduleName;
      this.ModuleCode = moduleCode;
      this.ErrorCode = errorCode;
      this.NativeStackTrace = nativeStackTrace;
    }

    public string ModuleName { get; }

    public ushort ModuleCode { get; }

    public ushort ErrorCode { get; }

    public string NativeStackTrace { get; }
  }
}
