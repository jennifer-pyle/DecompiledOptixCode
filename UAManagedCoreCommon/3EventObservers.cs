// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAEventObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [EventId(EventType.UAEvent)]
  public interface IUAEventObserver : IEventObserver
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void OnEvent(
      IUAObject eventNotifier,
      IUAObjectType eventType,
      IReadOnlyList<object> args,
      ulong senderId);
  }
}
