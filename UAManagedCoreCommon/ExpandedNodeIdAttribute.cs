// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ExpandedNodeIdAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class ExpandedNodeIdAttribute : Attribute
  {
    private string namespaceUri;
    private string alias;
    private object id;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Guid
    {
      get => ((System.Guid) this.id).ToString();
      set
      {
        this.AssertIdIsNull();
        this.id = (object) System.Guid.Parse(value);
        this.EnsureNodeIdOrAlias();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string String
    {
      get => (string) this.id;
      set
      {
        this.AssertIdIsNull();
        this.id = (object) value;
        this.EnsureNodeIdOrAlias();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public uint Number
    {
      get => (uint) this.id;
      set
      {
        this.AssertIdIsNull();
        this.id = (object) value;
        this.EnsureNodeIdOrAlias();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public object Id => this.id;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string NamespaceUri
    {
      get => this.namespaceUri;
      set
      {
        if (this.namespaceUri != null)
          throw new InvalidOperationException("NamespaceUri can be set only once.");
        this.namespaceUri = value == null || !(value.Trim() == string.Empty) ? value : throw new ArgumentException("NamespaceUri cannot be the empty string", nameof (value));
        this.EnsureNodeIdOrAlias();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Alias
    {
      get => this.alias;
      set
      {
        if (this.alias != null)
          throw new InvalidOperationException("Alias can be set only once");
        this.alias = value == null || !(value.Trim() == string.Empty) ? value : throw new ArgumentException("NamespaceUri cannot be the empty string", nameof (value));
        this.EnsureNodeIdOrAlias();
      }
    }

    private void AssertIdIsNull()
    {
      if (this.id != null)
        throw new InvalidOperationException("Id can be set only once");
    }

    private void EnsureNodeIdOrAlias()
    {
      if ((this.NamespaceUri != null || this.Id != null) && this.Alias != null)
        throw new InvalidOperationException("Should set either Alias or NodeId");
    }
  }
}
