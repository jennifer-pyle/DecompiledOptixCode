// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CoreEventHandler`1
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public class CoreEventHandler<T> where T : EventArgs
  {
    private object lockObject = new object();
    private Action subscribed;
    private Action unsubscribed;
    private List<EventHandler<T>> subscriptions;

    public CoreEventHandler(Action subscribed, Action unsubscribed)
    {
      this.subscribed = subscribed;
      this.unsubscribed = unsubscribed;
      this.subscriptions = new List<EventHandler<T>>();
    }

    public void Add(EventHandler<T> handler)
    {
      lock (this.lockObject)
      {
        if (this.subscriptions.Count == 0)
          this.subscribed();
        bool flag = false;
        foreach (EventHandler<T> subscription in this.subscriptions)
        {
          if (subscription == handler)
          {
            flag = true;
            break;
          }
        }
        if (flag)
          return;
        this.subscriptions.Add(handler);
      }
    }

    public void Remove(EventHandler<T> handler)
    {
      lock (this.lockObject)
      {
        int index = 0;
        while (index < this.subscriptions.Count)
        {
          if (this.subscriptions[index] == handler)
            this.subscriptions.RemoveAt(index);
          else
            ++index;
        }
        if (this.subscriptions.Count != 0)
          return;
        this.unsubscribed();
      }
    }

    public void Raise(object sender, T args)
    {
      List<EventHandler<T>> eventHandlerList = new List<EventHandler<T>>();
      lock (this.lockObject)
      {
        foreach (EventHandler<T> subscription in this.subscriptions)
          eventHandlerList.Add(subscription);
      }
      foreach (EventHandler<T> eventHandler in eventHandlerList)
        eventHandler(sender, args);
    }
  }
}
