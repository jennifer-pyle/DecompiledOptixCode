// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.Color
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Core
{
  public struct Color
  {
    public Color(byte a, byte r, byte g, byte b)
    {
      this.A = a;
      this.R = r;
      this.G = g;
      this.B = b;
      this.ARGB = (uint) ((int) a << 24 | (int) r << 16 | (int) g << 8) | (uint) b;
    }

    public Color(uint argb)
    {
      this.A = (byte) (argb >> 24 & (uint) byte.MaxValue);
      this.R = (byte) (argb >> 16 & (uint) byte.MaxValue);
      this.G = (byte) (argb >> 8 & (uint) byte.MaxValue);
      this.B = (byte) (argb & (uint) byte.MaxValue);
      this.ARGB = argb;
    }

    public Color(UAValue value)
      : this((uint) value)
    {
    }

    public static implicit operator Color(UAValue value) => new Color(value);

    public static implicit operator UAValue(Color color) => new UAValue(color.ARGB);

    public byte A { get; private set; }

    public byte R { get; private set; }

    public byte G { get; private set; }

    public byte B { get; private set; }

    public uint ARGB { get; private set; }
  }
}
