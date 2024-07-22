// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UADateTime
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class UADateTime
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly DateTime MinValue = new DateTime(1601, 1, 1, 0, 0, 0);
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly DateTime MaxValue = DateTime.MaxValue;
  }
}
