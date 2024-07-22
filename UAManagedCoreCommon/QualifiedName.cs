// Decompiled with JetBrains decompiler
// Type: UAManagedCore.QualifiedName
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public class QualifiedName
  {
    public static readonly QualifiedName Empty = new QualifiedName(NodeId.InvalidNamespaceIndex, string.Empty);

    public QualifiedName(int namespaceIndex, string name)
    {
      this.NamespaceIndex = namespaceIndex;
      this.Name = name;
    }

    public QualifiedName(string name)
    {
      this.NamespaceIndex = NodeId.InvalidNamespaceIndex;
      this.Name = name;
    }

    public QualifiedName() => this.NamespaceIndex = NodeId.InvalidNamespaceIndex;

    public int NamespaceIndex { get; set; }

    public string Name { get; set; }

    public override bool Equals(object obj)
    {
      if ((object) this == obj)
        return true;
      QualifiedName other = obj as QualifiedName;
      return (object) other != null && this.Equals(other);
    }

    public bool Equals(QualifiedName other)
    {
      if ((object) this == (object) other)
        return true;
      return (object) other != null && this.NamespaceIndex == other.NamespaceIndex && this.Name == other.Name;
    }

    public static bool operator ==(QualifiedName a, QualifiedName b)
    {
      return (object) a != null ? a.Equals(b) : (object) b == null;
    }

    public static bool operator !=(QualifiedName a, QualifiedName b) => !(a == b);

    public override int GetHashCode()
    {
      int num = this.NamespaceIndex * 397;
      string name = this.Name;
      int hashCode = name != null ? name.GetHashCode() : 0;
      return num ^ hashCode;
    }

    public static implicit operator QualifiedName(string s) => new QualifiedName(s);
  }
}
