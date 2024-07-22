// Decompiled with JetBrains decompiler
// Type: UAManagedCore.EventIdAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class EventIdAttribute : Attribute
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static EventType GetEventId(Type eventObserverType)
    {
      EventIdAttribute customAttribute = eventObserverType.GetCustomAttribute<EventIdAttribute>();
      if (customAttribute == null)
      {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
        interpolatedStringHandler.AppendLiteral("Type ");
        interpolatedStringHandler.AppendFormatted<Type>(eventObserverType);
        interpolatedStringHandler.AppendLiteral(" has no EventIdAttribute");
        throw new InvalidOperationException(interpolatedStringHandler.ToStringAndClear());
      }
      return customAttribute.EventId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<EventType> GetEventIds(Type eventObserverType)
    {
      Type baseInterfaceType = typeof (IEventObserver);
      if (!eventObserverType.IsInterface || !baseInterfaceType.IsAssignableFrom(eventObserverType))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return ((IEnumerable<Type>) eventObserverType.GetTypeInfo().GetInterfaces()).Where<Type>((Func<Type, bool>) (interfaceType => baseInterfaceType.IsAssignableFrom(interfaceType) && interfaceType != baseInterfaceType)).Select<Type, EventType>(EventIdAttribute.\u003C\u003EO.\u003C0\u003E__GetEventId ?? (EventIdAttribute.\u003C\u003EO.\u003C0\u003E__GetEventId = new Func<Type, EventType>(EventIdAttribute.GetEventId)));
      }
      return (IEnumerable<EventType>) new List<EventType>()
      {
        EventIdAttribute.GetEventId(eventObserverType)
      };
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static EventType GetEventTypeMask(Type eventObserverType)
    {
      EventType eventTypeMask = ~EventType.AllAttributeChangeEvents;
      foreach (EventType eventId in EventIdAttribute.GetEventIds(eventObserverType))
        eventTypeMask |= eventId;
      return eventTypeMask;
    }

    public EventIdAttribute(EventType eventId) => this.EventId = eventId;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public EventType EventId { get; }
  }
}
