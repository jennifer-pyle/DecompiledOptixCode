// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NodeId
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  [Serializable]
  public class NodeId
  {
    public static readonly int InvalidNamespaceIndex = -1;
    public static readonly NodeId Empty = new NodeId();
    private readonly int namespaceIndex = NodeId.InvalidNamespaceIndex;
    private readonly object id;
    private readonly IdType idType;

    public static NodeId Random(int namespaceIndex) => new NodeId(namespaceIndex, Guid.NewGuid());

    public static NodeId OfVariantId(int namespaceIndex, object id)
    {
      Type type = id.GetType();
      if (type == typeof (uint))
        return new NodeId(namespaceIndex, (uint) id);
      if (type == typeof (Guid))
        return new NodeId(namespaceIndex, (Guid) id);
      if (type == typeof (string))
        return new NodeId(namespaceIndex, (string) id);
      throw new NotSupportedException("Id type not supported " + type.Name);
    }

    public static NodeId OfVariantId(int namespaceIndex, object id, IdType idType)
    {
      switch (idType)
      {
        case IdType.Empty:
        case IdType.ByteArray:
          throw new NotSupportedException("idType: " + idType.ToString());
        case IdType.String:
          return new NodeId(namespaceIndex, (string) id);
        case IdType.Guid:
          return new NodeId(namespaceIndex, (Guid) id);
        case IdType.UInt32:
          return new NodeId(namespaceIndex, (uint) id);
        default:
          throw new ArgumentOutOfRangeException(nameof (idType), (object) idType, (string) null);
      }
    }

    public static NodeId Of(int namespaceIndex, uint id) => new NodeId(namespaceIndex, id);

    public static NodeId Of(int namespaceIndex, Guid id) => new NodeId(namespaceIndex, id);

    public static NodeId Of(int namespaceIndex, string id) => new NodeId(namespaceIndex, id);

    private NodeId()
    {
      this.namespaceIndex = NodeId.InvalidNamespaceIndex;
      this.id = (object) null;
      this.idType = IdType.Empty;
    }

    private NodeId(int namespaceIndex, object id, IdType idType)
    {
      this.namespaceIndex = namespaceIndex;
      this.id = id;
      this.idType = idType;
    }

    public NodeId(int namespaceIndex, uint id)
      : this(namespaceIndex, (object) id, IdType.UInt32)
    {
    }

    public NodeId(int namespaceIndex, Guid id)
      : this(namespaceIndex, (object) id, IdType.Guid)
    {
      this.namespaceIndex = namespaceIndex;
      this.id = (object) id;
      this.idType = IdType.Guid;
    }

    public NodeId(int namespaceIndex, string id)
      : this(namespaceIndex, (object) id, IdType.String)
    {
      if (string.IsNullOrEmpty(id))
        throw new ArgumentException(nameof (id));
    }

    public int NamespaceIndex => this.namespaceIndex;

    public object Id => this.id;

    public IdType IdType => this.idType;

    public bool IsEmpty => object.Equals((object) this, (object) NodeId.Empty);

    public override bool Equals(object obj) => (object) this == obj || this.Equals(obj as NodeId);

    public bool Equals(NodeId other)
    {
      if ((object) this == (object) other)
        return true;
      return (object) other != null && this.namespaceIndex == other.namespaceIndex && this.id.Equals(other.id);
    }

    public static bool operator ==(NodeId a, NodeId b)
    {
      return (object) a != null ? a.Equals(b) : (object) b == null;
    }

    public static bool operator !=(NodeId a, NodeId b) => !(a == b);

    public override int GetHashCode()
    {
      return 982177171 ^ this.namespaceIndex.GetHashCode() ^ this.id.GetHashCode();
    }

    public override string ToString() => this.namespaceIndex.ToString() + "/" + this.id?.ToString();

    public string IdTypeShortString => this.IdType.ToShortString();
  }
}
