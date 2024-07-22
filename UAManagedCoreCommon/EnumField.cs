// Decompiled with JetBrains decompiler
// Type: UAManagedCore.EnumField
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  public class EnumField : IEquatable<EnumField>
  {
    public EnumField(string name, int value)
      : this(name, value, (LocalizedText) null, (LocalizedText) null)
    {
    }

    public EnumField(string name, int value, LocalizedText displayName, LocalizedText description)
    {
      this.Name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentNullException(nameof (name));
      this.Value = value;
      LocalizedText localizedText1 = displayName;
      if ((object) localizedText1 == null)
        localizedText1 = LocalizedText.Empty;
      this.DisplayName = localizedText1;
      LocalizedText localizedText2 = description;
      if ((object) localizedText2 == null)
        localizedText2 = LocalizedText.Empty;
      this.Description = localizedText2;
    }

    public string Name { get; }

    public int Value { get; }

    public LocalizedText DisplayName { get; }

    public LocalizedText Description { get; }

    public bool Equals(EnumField other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return string.Equals(this.Name, other.Name) && this.Value == other.Value && this.DisplayName.Equals(other.DisplayName) && this.Description.Equals(other.Description);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((EnumField) obj);
    }

    public override int GetHashCode()
    {
      return ((this.Name.GetHashCode() * 397 ^ this.Value) * 397 ^ this.DisplayName.GetHashCode()) * 397 ^ this.Description.GetHashCode();
    }
  }
}
