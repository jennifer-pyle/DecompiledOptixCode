﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.LogEvent
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;
using UAManagedCore.Logging;

#nullable disable
namespace FTOptix.Core
{
  [MapType(NamespaceUri = "urn:FTOptix:Core", Number = 129)]
  public class LogEvent : UAObject
  {
    public LogLevel Level
    {
      get => (LogLevel) (int) this.Refs.GetVariable(nameof (Level)).Value;
      set => this.Refs.GetVariable(nameof (Level)).SetValue((object) (int) value);
    }

    public IUAVariable LevelVariable => this.Refs.GetVariable("Level");

    public uint ModuleCode
    {
      get => (uint) this.Refs.GetVariable(nameof (ModuleCode)).Value.Value;
      set => this.Refs.GetVariable(nameof (ModuleCode)).SetValue((object) value);
    }

    public IUAVariable ModuleCodeVariable => this.Refs.GetVariable("ModuleCode");

    public string ModuleName
    {
      get => (string) this.Refs.GetVariable(nameof (ModuleName)).Value.Value;
      set => this.Refs.GetVariable(nameof (ModuleName)).SetValue((object) value);
    }

    public IUAVariable ModuleNameVariable => this.Refs.GetVariable("ModuleName");

    public uint ErrorCode
    {
      get => (uint) this.Refs.GetVariable(nameof (ErrorCode)).Value.Value;
      set => this.Refs.GetVariable(nameof (ErrorCode)).SetValue((object) value);
    }

    public IUAVariable ErrorCodeVariable => this.Refs.GetVariable("ErrorCode");

    public string StackTrace
    {
      get => (string) this.Refs.GetVariable(nameof (StackTrace)).Value.Value;
      set => this.Refs.GetVariable(nameof (StackTrace)).SetValue((object) value);
    }

    public IUAVariable StackTraceVariable => this.Refs.GetVariable("StackTrace");
  }
}
