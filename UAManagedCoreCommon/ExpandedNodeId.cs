// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExpandedNodeId
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class ExpandedNodeId
  {
    private readonly string namespaceUri;
    private readonly object id;
    private readonly IdType idType;

    private static object CheckByteArray(byte[] id)
    {
      return id != null && id.Length != 0 ? (object) id : throw new ArgumentNullException(nameof (id));
    }

    private static object CheckGuid(Guid id)
    {
      return !(id == Guid.Empty) ? (object) id : throw new ArgumentNullException(nameof (id));
    }

    private static object CheckString(string id)
    {
      return !string.IsNullOrEmpty(id) ? (object) id : throw new ArgumentException(nameof (id));
    }

    public ExpandedNodeId(string namespaceUri, uint id)
      : this(namespaceUri, (object) id, IdType.UInt32)
    {
    }

    public ExpandedNodeId(string namespaceUri, Guid id)
      : this(namespaceUri, ExpandedNodeId.CheckGuid(id), IdType.Guid)
    {
    }

    public ExpandedNodeId(string namespaceUri, string id)
      : this(namespaceUri, ExpandedNodeId.CheckString(id), IdType.String)
    {
    }

    public ExpandedNodeId(string namespaceUri, byte[] byteArrayId)
      : this(namespaceUri, ExpandedNodeId.CheckByteArray(byteArrayId), IdType.ByteArray)
    {
    }

    public ExpandedNodeId(string namespaceUri, object id, IdType idType)
    {
      if (string.IsNullOrWhiteSpace(namespaceUri))
        throw new ArgumentNullException(nameof (namespaceUri));
      if (id == null)
        throw new ArgumentNullException(nameof (id));
      this.namespaceUri = namespaceUri;
      this.id = id;
      this.idType = idType;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string NamespaceUri => this.namespaceUri;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public object Id => this.id;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IdType IdType => this.idType;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IdTypeShortString => this.IdType.ToShortString();

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj)
    {
      if ((object) this == obj)
        return true;
      ExpandedNodeId other = obj as ExpandedNodeId;
      return (object) other != null && this.Equals(other);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool Equals(ExpandedNodeId other)
    {
      return (object) other != null && this.NamespaceUri == other.NamespaceUri && this.id.Equals(other.id);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool operator ==(ExpandedNodeId a, ExpandedNodeId b)
    {
      return (object) a != null ? a.Equals(b) : (object) b == null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool operator !=(ExpandedNodeId a, ExpandedNodeId b) => !(a == b);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode()
    {
      return 982177171 ^ this.NamespaceUri.GetHashCode() ^ this.id.GetHashCode();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => this.NamespaceUri + "/" + this.id?.ToString();
  }
}
