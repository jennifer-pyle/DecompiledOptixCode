// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IdTypeExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class IdTypeExtensions
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string ToShortString(this IdType idType)
    {
      switch (idType)
      {
        case IdType.Empty:
          throw new InvalidOperationException("NodeId not found");
        case IdType.String:
          return "s";
        case IdType.Guid:
          return "g";
        case IdType.UInt32:
          return "i";
        case IdType.ByteArray:
          return "b";
        default:
          throw new InvalidOperationException("NodeId type " + idType.ToString() + " conversion not supported");
      }
    }
  }
}
