// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ByteString
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class ByteString : IEquatable<ByteString>
  {
    public static readonly ByteString Empty = new ByteString();
    private readonly byte[] underlyingArray;

    public ByteString() => this.underlyingArray = new byte[0];

    public ByteString(byte[] array) => this.underlyingArray = array;

    public byte[] Bytes => this.underlyingArray;

    public bool IsEmpty => this.underlyingArray.Length == 0;

    public override bool Equals(object obj)
    {
      if ((object) this == obj)
        return true;
      ByteString other = obj as ByteString;
      return (object) other != null && this.Equals(other);
    }

    public bool Equals(ByteString other)
    {
      return other != (ByteString) null && ((IEnumerable<byte>) this.Bytes).SequenceEqual<byte>((IEnumerable<byte>) other.Bytes);
    }

    public static bool operator ==(ByteString a, ByteString b)
    {
      if ((object) a == (object) b)
        return true;
      return (object) b != null && a.Equals(b);
    }

    public static bool operator !=(ByteString a, ByteString b) => !(a == b);

    public override int GetHashCode()
    {
      int hashCode = 982177171;
      foreach (byte num in this.Bytes)
        hashCode ^= num.GetHashCode();
      return hashCode;
    }

    public override string ToString()
    {
      return "0x" + BitConverter.ToString(this.underlyingArray).Replace("-", "");
    }
  }
}
