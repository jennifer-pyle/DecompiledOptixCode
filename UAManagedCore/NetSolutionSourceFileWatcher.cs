// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NetSolutionSourceFileWatcher
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

#nullable enable
namespace UAManagedCore
{
  internal class NetSolutionSourceFileWatcher : IDisposable
  {
    private readonly IntPtr sourceFileChangeProcessorPtr;
    private readonly 
    #nullable disable
    FileSystemWatcher watcher;
    private bool disposed;
    private readonly object changeProcessingLock = new object();
    private Timer changeProcessingTimer;
    private readonly HashSet<string> filesWithChangedContents;
    private readonly HashSet<string> addedFiles;
    private readonly HashSet<string> removedFiles;

    public NetSolutionSourceFileWatcher(
      IntPtr sourceFileChangeProcessorPtr,
      string solutionDirectory)
    {
      this.sourceFileChangeProcessorPtr = sourceFileChangeProcessorPtr;
      this.watcher = new FileSystemWatcher(solutionDirectory);
      this.watcher.Filters.Add("*.cs");
      this.watcher.Filters.Add("*.csproj");
      this.watcher.IncludeSubdirectories = true;
      this.watcher.Renamed += new RenamedEventHandler(this.OnFileRenamed);
      this.watcher.Changed += new FileSystemEventHandler(this.OnFileChanged);
      this.watcher.Created += new FileSystemEventHandler(this.OnFileCreated);
      this.watcher.Deleted += new FileSystemEventHandler(this.OnFileDeleted);
      this.watcher.EnableRaisingEvents = true;
      this.filesWithChangedContents = new HashSet<string>();
      this.addedFiles = new HashSet<string>();
      this.removedFiles = new HashSet<string>();
    }

    public void EnableFileSystemWatcher()
    {
      lock (this.changeProcessingLock)
        this.watcher.EnableRaisingEvents = true;
    }

    public void DisableFileSystemWatcher()
    {
      lock (this.changeProcessingLock)
        this.watcher.EnableRaisingEvents = false;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing)
      {
        lock (this.changeProcessingLock)
        {
          this.watcher.EnableRaisingEvents = false;
          this.watcher.Renamed -= new RenamedEventHandler(this.OnFileRenamed);
          this.watcher.Changed -= new FileSystemEventHandler(this.OnFileChanged);
          this.watcher.Created -= new FileSystemEventHandler(this.OnFileCreated);
          this.watcher.Deleted -= new FileSystemEventHandler(this.OnFileDeleted);
          this.watcher.Dispose();
        }
        if (this.changeProcessingTimer != null)
        {
          AutoResetEvent notifyObject = new AutoResetEvent(false);
          if (this.changeProcessingTimer.Dispose((WaitHandle) notifyObject))
            notifyObject.WaitOne();
        }
      }
      this.disposed = true;
    }

    private void OnFileDeleted(object sender, FileSystemEventArgs e)
    {
      if (NetSolutionSourceFileWatcher.IsFileToBeSkipped(e.Name))
        return;
      lock (this.changeProcessingLock)
      {
        if (NetSolutionSourceFileWatcher.IsCSharpSourceFile(e.Name))
        {
          string name = e.Name;
          string fileName = name.Substring(0, name.Length - 3);
          if (!NetSolutionSourceFileWatcher.IsFileInSubdirectory(fileName))
          {
            if (!this.removedFiles.Contains(fileName))
              this.removedFiles.Add(fileName);
            if (this.filesWithChangedContents.Contains(fileName))
              this.filesWithChangedContents.Remove(fileName);
          }
        }
        this.EnsureChangeProcessingTimerIsRunning();
      }
    }

    private void OnFileCreated(object sender, FileSystemEventArgs e)
    {
      if (NetSolutionSourceFileWatcher.IsFileToBeSkipped(e.Name))
        return;
      lock (this.changeProcessingLock)
      {
        if (NetSolutionSourceFileWatcher.IsCSharpSourceFile(e.Name))
        {
          string name = e.Name;
          string fileName = name.Substring(0, name.Length - 3);
          if (!NetSolutionSourceFileWatcher.IsFileInSubdirectory(fileName))
          {
            if (!this.addedFiles.Contains(fileName))
              this.addedFiles.Add(fileName);
            if (!this.filesWithChangedContents.Contains(fileName))
              this.filesWithChangedContents.Add(fileName);
          }
        }
        this.EnsureChangeProcessingTimerIsRunning();
      }
    }

    private void OnFileChanged(object sender, FileSystemEventArgs e)
    {
      if (NetSolutionSourceFileWatcher.IsFileToBeSkipped(e.Name))
        return;
      lock (this.changeProcessingLock)
      {
        if (NetSolutionSourceFileWatcher.IsCSharpSourceFile(e.Name))
        {
          string name = e.Name;
          string fileName = name.Substring(0, name.Length - 3);
          if (!NetSolutionSourceFileWatcher.IsFileInSubdirectory(fileName) && !this.filesWithChangedContents.Contains(fileName))
            this.filesWithChangedContents.Add(fileName);
        }
        this.EnsureChangeProcessingTimerIsRunning();
      }
    }

    private void OnFileRenamed(object sender, RenamedEventArgs e)
    {
      if (NetSolutionSourceFileWatcher.IsFileToBeSkipped(e.Name))
        return;
      lock (this.changeProcessingLock)
      {
        if (NetSolutionSourceFileWatcher.IsCSharpSourceFile(e.Name))
        {
          string name = e.Name;
          string fileName = name.Substring(0, name.Length - 3);
          if (!NetSolutionSourceFileWatcher.IsFileInSubdirectory(fileName) && !this.filesWithChangedContents.Contains(fileName))
          {
            this.filesWithChangedContents.Add(fileName);
            if (this.removedFiles.Contains(fileName))
              this.removedFiles.Remove(fileName);
          }
        }
        this.EnsureChangeProcessingTimerIsRunning();
      }
    }

    private static bool IsFileToBeSkipped(string fileName)
    {
      return NetSolutionSourceFileWatcher.IsTemporaryNewFileName(fileName) || NetSolutionSourceFileWatcher.IsInObjSubdirectory(fileName) || NetSolutionSourceFileWatcher.IsNodeIdConstantsFile(fileName) || NetSolutionSourceFileWatcher.IsUITypeDefinitionsFile(fileName);
    }

    private static bool IsTemporaryNewFileName(string fileName)
    {
      if (fileName.EndsWith(".TMP"))
        return true;
      if (!NetSolutionSourceFileWatcher.IsCSharpSourceFile(fileName))
        return false;
      string str = fileName;
      fileName = str.Substring(0, str.Length - 3);
      return Guid.TryParse(fileName, out Guid _);
    }

    private static bool IsInObjSubdirectory(string fileName)
    {
      return fileName.StartsWith("obj" + Path.DirectorySeparatorChar.ToString());
    }

    private static bool IsFileInSubdirectory(string fileName)
    {
      return fileName.Contains(Path.DirectorySeparatorChar);
    }

    private static bool IsNodeIdConstantsFile(string fileName)
    {
      return fileName == "Private" + Path.DirectorySeparatorChar.ToString() + "TypeConstants.cs";
    }

    private static bool IsUITypeDefinitionsFile(string fileName)
    {
      return fileName == "Private" + Path.DirectorySeparatorChar.ToString() + "UITypeDefinitions.cs";
    }

    private static bool IsCSharpSourceFile(string fileName) => fileName.EndsWith(".cs");

    private void EnsureChangeProcessingTimerIsRunning()
    {
      if (this.changeProcessingTimer != null)
        return;
      this.changeProcessingTimer = new Timer((TimerCallback) (state => this.ChangeProcessingTimerCallback(state)), (object) new Thread((ThreadStart) (() => this.ProcessSourceFilesChanges())), TimeSpan.FromMilliseconds(500.0), Timeout.InfiniteTimeSpan);
    }

    private void ChangeProcessingTimerCallback(object state) => ((Thread) state).Start();

    private void ProcessSourceFilesChanges()
    {
      lock (this.changeProcessingLock)
        NetSolutionSourceFileWatcher.Interop.NetSolutionSourceFileWatcherProcessSourceFilesChanges(this.sourceFileChangeProcessorPtr, StringMarshal.ToNativeStringArray((IEnumerable<string>) this.addedFiles), StringMarshal.ToNativeStringArray((IEnumerable<string>) this.filesWithChangedContents), StringMarshal.ToNativeStringArray((IEnumerable<string>) this.removedFiles)).CheckOutcome();
      this.changeProcessingTimer.Dispose();
      this.changeProcessingTimer = (Timer) null;
      this.filesWithChangedContents.Clear();
      this.addedFiles.Clear();
      this.removedFiles.Clear();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult NetSolutionSourceFileWatcherProcessSourceFilesChanges(
        IntPtr processorPtr,
        IntPtr addedFilesPtr,
        IntPtr filesWithChangedContentsPtr,
        IntPtr removedFilesPtr);
    }
  }
}
