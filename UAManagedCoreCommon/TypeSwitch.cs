// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypeSwitch
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class TypeSwitch
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static TypeSwitch.Switch<TSource> On<TSource>(TSource value)
    {
      return new TypeSwitch.Switch<TSource>(value);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class Switch<TSource>
    {
      private TSource value;
      private bool handled;

      internal Switch(TSource value) => this.value = value;

      [EditorBrowsable(EditorBrowsableState.Never)]
      public TypeSwitch.Switch<TSource> Case<TTarget>(Action action) where TTarget : TSource
      {
        if (action == null)
          throw new ArgumentNullException(nameof (action));
        if (!this.handled)
        {
          if (typeof (TTarget).IsAssignableFrom(this.value.GetType()))
          {
            action();
            this.handled = true;
          }
        }
        return this;
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public TypeSwitch.Switch<TSource> Case<TTarget>(Action<TTarget> action) where TTarget : TSource
      {
        if (action == null)
          throw new ArgumentNullException(nameof (action));
        if (!this.handled)
        {
          if (typeof (TTarget).IsAssignableFrom(this.value.GetType()))
          {
            action((TTarget) (object) this.value);
            this.handled = true;
          }
        }
        return this;
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public void Default(Action action)
      {
        if (action == null)
          throw new ArgumentNullException(nameof (action));
        if (this.handled)
          return;
        action();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public void Default(Action<TSource> action)
      {
        if (action == null)
          throw new ArgumentNullException(nameof (action));
        if (this.handled)
          return;
        action(this.value);
      }
    }
  }
}
