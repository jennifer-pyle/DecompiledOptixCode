﻿// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ContextDecorationExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public static class ContextDecorationExtensions
  {
    public static IContext GetRootContext(this IContext context)
    {
      return !(context is IContextDecorator contextDecorator) ? context : contextDecorator.RootContext;
    }
  }
}
