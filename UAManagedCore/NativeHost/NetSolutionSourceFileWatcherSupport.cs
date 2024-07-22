// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.NetSolutionSourceFileWatcherSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class NetSolutionSourceFileWatcherSupport
  {
    public static IntPtr CreateNetSolutionSourceFileWatcher(
      IntPtr sourceFileChangeProcessorPtr,
      IntPtr solutionDirectoryPtr)
    {
      string solutionDirectory = StringMarshal.StringFromIntPtr(solutionDirectoryPtr);
      return ObjectMarshal.ToIntPtr((object) new NetSolutionSourceFileWatcher(sourceFileChangeProcessorPtr, solutionDirectory));
    }

    public static void EnableFileSystemWatcher(IntPtr sourceFileWatcherPtr)
    {
      ObjectMarshal.FromIntPtr<NetSolutionSourceFileWatcher>(sourceFileWatcherPtr).EnableFileSystemWatcher();
    }

    public static void DisableFileSystemWatcher(IntPtr sourceFileWatcherPtr)
    {
      ObjectMarshal.FromIntPtr<NetSolutionSourceFileWatcher>(sourceFileWatcherPtr).DisableFileSystemWatcher();
    }

    public static void DisposeNetSolutionSourceFileWatcher(IntPtr sourceFileWatcherPtr)
    {
      ObjectMarshal.FromIntPtr<NetSolutionSourceFileWatcher>(sourceFileWatcherPtr).Dispose();
    }

    public delegate IntPtr CreateNetSolutionSourceFileWatcherDelegate(
      IntPtr sourceFileChangeProcessorPtr,
      IntPtr solutionDirectoryPtr);

    public delegate void EnableFileSystemWatcherDelegate(IntPtr sourceFileWatcherPtr);

    public delegate void DisableFileSystemWatcherDelegate(IntPtr sourceFileWatcherPtr);

    public delegate void DisposeNetSolutionSourceFileWatcherDelegate(IntPtr sourceFileWatcherPtr);
  }
}
