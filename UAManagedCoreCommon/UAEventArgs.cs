// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAEventArgs
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  public class UAEventArgs : EventArgs
  {
    internal UAEventArgs(IUAObjectType eventType, UAEventArgumentList args, ulong senderId)
    {
      this.EventType = eventType;
      this.Arguments = args;
      this.SenderId = senderId;
    }

    public IUAObjectType EventType { get; }

    public UAEventArgumentList Arguments { get; }

    public ulong SenderId { get; }
  }
}
