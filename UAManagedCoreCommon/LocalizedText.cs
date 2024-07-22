// Decompiled with JetBrains decompiler
// Type: UAManagedCore.LocalizedText
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  [Serializable]
  public class LocalizedText : IEquatable<LocalizedText>
  {
    public static readonly LocalizedText Empty = new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty);

    private LocalizedText()
    {
    }

    public LocalizedText(string textId)
    {
      this.NamespaceIndex = NodeId.InvalidNamespaceIndex;
      this.TextId = textId;
      this.Text = string.Empty;
      this.LocaleId = string.Empty;
    }

    public LocalizedText(int namespaceIndex, string textId)
    {
      this.NamespaceIndex = namespaceIndex;
      this.TextId = textId;
      this.Text = string.Empty;
      this.LocaleId = string.Empty;
    }

    public LocalizedText(string text, string localeId)
    {
      this.NamespaceIndex = NodeId.InvalidNamespaceIndex;
      this.TextId = string.Empty;
      this.Text = text;
      this.LocaleId = localeId;
    }

    public LocalizedText(string textId, string text, string localeId)
    {
      this.NamespaceIndex = NodeId.InvalidNamespaceIndex;
      this.TextId = textId;
      this.Text = text;
      this.LocaleId = localeId;
    }

    public LocalizedText(int namespaceIndex, string textId, string text, string localeId)
    {
      this.NamespaceIndex = namespaceIndex;
      this.TextId = textId ?? string.Empty;
      this.Text = text ?? string.Empty;
      this.LocaleId = localeId ?? string.Empty;
    }

    public static LocalizedText Of(int namespaceIndex, string textId)
    {
      return new LocalizedText()
      {
        NamespaceIndex = namespaceIndex,
        TextId = textId,
        Text = string.Empty,
        LocaleId = string.Empty
      };
    }

    public static LocalizedText Of(
      int namespaceIndex,
      string textId,
      string text,
      string localeId)
    {
      return new LocalizedText()
      {
        NamespaceIndex = namespaceIndex,
        TextId = textId ?? string.Empty,
        Text = text ?? string.Empty,
        LocaleId = localeId ?? string.Empty
      };
    }

    public int NamespaceIndex { get; set; }

    public string TextId { get; set; }

    public string Text { get; set; }

    public string LocaleId { get; set; }

    public bool HasTextId => this.NamespaceIndex >= 0 && !string.IsNullOrEmpty(this.TextId);

    public bool HasTranslation => !string.IsNullOrEmpty(this.LocaleId);

    public override string ToString()
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 8);
      interpolatedStringHandler.AppendFormatted("NamespaceIndex");
      interpolatedStringHandler.AppendLiteral(": ");
      interpolatedStringHandler.AppendFormatted<int>(this.NamespaceIndex);
      interpolatedStringHandler.AppendLiteral(", ");
      interpolatedStringHandler.AppendFormatted("TextId");
      interpolatedStringHandler.AppendLiteral(": ");
      interpolatedStringHandler.AppendFormatted(this.TextId);
      interpolatedStringHandler.AppendLiteral(", ");
      interpolatedStringHandler.AppendFormatted("Text");
      interpolatedStringHandler.AppendLiteral(": ");
      interpolatedStringHandler.AppendFormatted(this.Text);
      interpolatedStringHandler.AppendLiteral(", ");
      interpolatedStringHandler.AppendFormatted("LocaleId");
      interpolatedStringHandler.AppendLiteral(": ");
      interpolatedStringHandler.AppendFormatted(this.LocaleId);
      return interpolatedStringHandler.ToStringAndClear();
    }

    public bool Equals(LocalizedText other)
    {
      if ((object) other == null)
        return false;
      if ((object) this == (object) other)
        return true;
      return this.NamespaceIndex == other.NamespaceIndex && string.Equals(this.TextId, other.TextId) && string.Equals(this.Text, other.Text) && string.Equals(this.LocaleId, other.LocaleId);
    }

    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if ((object) this == obj)
        return true;
      return !(obj.GetType() != this.GetType()) && this.Equals((LocalizedText) obj);
    }

    public override int GetHashCode()
    {
      int num1 = this.NamespaceIndex * 397;
      string textId = this.TextId;
      int hashCode1 = textId != null ? textId.GetHashCode() : 0;
      int num2 = (num1 ^ hashCode1) * 397;
      string text = this.Text;
      int hashCode2 = text != null ? text.GetHashCode() : 0;
      int num3 = (num2 ^ hashCode2) * 397;
      string localeId = this.LocaleId;
      int hashCode3 = localeId != null ? localeId.GetHashCode() : 0;
      return num3 ^ hashCode3;
    }

    public static bool operator ==(LocalizedText left, LocalizedText right)
    {
      return object.Equals((object) left, (object) right);
    }

    public static bool operator !=(LocalizedText left, LocalizedText right)
    {
      return !object.Equals((object) left, (object) right);
    }

    public bool IsEmpty() => this.Equals(LocalizedText.Empty);
  }
}
