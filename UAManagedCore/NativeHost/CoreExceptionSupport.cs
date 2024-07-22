// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.CoreExceptionSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class CoreExceptionSupport
  {
    public static IntPtr CreateCoreException(
      IntPtr messagePtr,
      IntPtr moduleNamePtr,
      ushort moduleCode,
      ushort errorCode,
      IntPtr nativeStackTracePtr)
    {
      string message = StringMarshal.StringFromIntPtr(messagePtr);
      string moduleName = StringMarshal.StringFromIntPtr(moduleNamePtr);
      string nativeStackTrace = StringMarshal.StringFromIntPtr(nativeStackTracePtr);
      return ObjectMarshal.ToIntPtr((object) new CoreException(message, moduleName, moduleCode, errorCode, nativeStackTrace));
    }

    public static IntPtr CreateStdException(IntPtr whatPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new CoreException(StringMarshal.StringFromIntPtr(whatPtr)));
    }

    public delegate IntPtr CreateCoreExceptionDelegate(
      IntPtr messagePtr,
      IntPtr moduleNamePtr,
      ushort moduleCode,
      ushort errorCode,
      IntPtr nativeStackTracePtr);

    public delegate IntPtr CreateStdExceptionDelegate(IntPtr whatPtr);
  }
}
