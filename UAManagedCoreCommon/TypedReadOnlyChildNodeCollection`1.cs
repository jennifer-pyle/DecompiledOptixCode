// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypedReadOnlyChildNodeCollection`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public class TypedReadOnlyChildNodeCollection<T> : 
    IReadOnlyCollection<T>,
    IEnumerable<T>,
    IEnumerable
    where T : class, IUANode
  {
    protected IUANode parentNode;

    public TypedReadOnlyChildNodeCollection(IUANode node)
    {
      this.parentNode = node != null ? node : throw new ArgumentNullException(nameof (node));
    }

    public V Get<V>(QualifiedName browseName) where V : class, T
    {
      return this.parentNode.Refs.GetNode(browseName.Name) as V;
    }

    public T Get(QualifiedName browseName) => this.parentNode.Refs.GetNode(browseName.Name) as T;

    public IEnumerator<T> GetEnumerator() => this.GetChildNodes().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public bool Contains(T childNode) => this.GetChildNodes().Contains<T>(childNode);

    public void CopyTo(T[] array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException(nameof (array));
      if (arrayIndex < 0)
        throw new ArgumentOutOfRangeException(nameof (arrayIndex));
      IEnumerable<T> childNodes = this.GetChildNodes();
      if (array.Length - arrayIndex < childNodes.Count<T>())
        throw new ArgumentException("The number of elements in the source collection is greater than the available space in the destination array");
      foreach (T obj in childNodes)
        array[arrayIndex++] = obj;
    }

    public T this[string name] => this.parentNode.Refs.GetNode(name) as T;

    public T this[int index] => this.GetChildNodes().Skip<T>(index).FirstOrDefault<T>();

    public int Count => this.GetChildNodes().Count<T>();

    protected virtual IEnumerable<T> GetChildNodes() => this.parentNode.GetOwnedNodes().OfType<T>();
  }
}
