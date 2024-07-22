// Decompiled with JetBrains decompiler
// Type: UAManagedCore.CustomEventHandler
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#nullable disable
namespace UAManagedCore
{
  public class CustomEventHandler
  {
    private object lockObject = new object();
    private NodeId eventTypeId;
    private Type eventHandlerType;
    private Type eventArgsType;
    private Action<NodeId> subscribed;
    private Action<NodeId> unsubscribed;
    private List<Delegate> subscriptions;

    public CustomEventHandler(
      NodeId eventTypeId,
      Type eventHandlerType,
      Type eventArgsType,
      Action<NodeId> subscribed,
      Action<NodeId> unsubscribed)
    {
      this.eventTypeId = eventTypeId;
      this.eventHandlerType = eventHandlerType;
      this.eventArgsType = eventArgsType;
      this.subscribed = subscribed;
      this.unsubscribed = unsubscribed;
      this.subscriptions = new List<Delegate>();
    }

    public void Add(Delegate handler)
    {
      lock (this.lockObject)
      {
        if (this.subscriptions.Count == 0)
          this.subscribed(this.eventTypeId);
        bool flag = false;
        foreach (Delegate subscription in this.subscriptions)
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

    public void Remove(Delegate handler)
    {
      lock (this.lockObject)
      {
        if (this.subscriptions.Count == 0)
          return;
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
        this.unsubscribed(this.eventTypeId);
      }
    }

    public void Raise(object sender, UAEventArgs uaEventArgs)
    {
      List<object> objectList = new List<object>();
      lock (this.lockObject)
      {
        for (int index = 0; index < this.subscriptions.Count; ++index)
          objectList.Add((object) this.subscriptions[index]);
      }
      object argsFromUaEventArgs = this.CreateEventArgsFromUAEventArgs(uaEventArgs);
      foreach (object obj in objectList)
        this.eventHandlerType.GetMethod("Invoke").Invoke(obj, new object[2]
        {
          sender,
          argsFromUaEventArgs
        });
    }

    private object CreateEventArgsFromUAEventArgs(UAEventArgs uaEventArgs)
    {
      object instance = Activator.CreateInstance(this.eventArgsType);
      foreach (PropertyInfo property in this.eventArgsType.GetProperties())
      {
        object obj = uaEventArgs.Arguments.GetArgument(property.Name);
        if (obj == null)
        {
          property.SetValue(instance, obj);
        }
        else
        {
          Type type1 = obj.GetType();
          Type type2 = property.GetType();
          if (type2.IsAssignableFrom(type1))
          {
            property.SetValue(instance, obj);
          }
          else
          {
            this.ConvertEventArgumentValue(obj, type1, type2);
            property.SetValue(instance, obj);
          }
        }
      }
      return instance;
    }

    private object ConvertEventArgumentValue(object value, Type valueType, Type propertyType)
    {
      MethodInfo methodInfo = ((IEnumerable<MethodInfo>) propertyType.GetMethods(BindingFlags.Static | BindingFlags.Public)).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (m => m.Name == "op_Implicit" && m.ReturnType.Equals(propertyType) && m.GetParameters()[0].ParameterType.Equals(valueType)));
      if (!(methodInfo != (MethodInfo) null))
        return value;
      return methodInfo.Invoke((object) null, new object[1]
      {
        value
      });
    }
  }
}
