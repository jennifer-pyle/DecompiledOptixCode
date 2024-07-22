// Decompiled with JetBrains decompiler
// Type: UAManagedCore.InstanceNodeCollection`1
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UAManagedCore.OpcUa;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class InstanceNodeCollection<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> where T : class, IUANode
  {
    private IUANode typeNode;

    public InstanceNodeCollection(IUANode node)
    {
      if (node == null)
        throw new ArgumentNullException(nameof (node));
      this.typeNode = node.NodeClass == NodeClass.ObjectType || node.NodeClass == NodeClass.VariableType ? node : throw new ArgumentException("The 'node' argument must be either an object type or a variable type");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IEnumerator<T> GetEnumerator()
    {
      return this.typeNode.InverseRefs.GetNodes(ReferenceTypes.HasTypeDefinition, false).OfType<T>().GetEnumerator();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    [EditorBrowsable(EditorBrowsableState.Never)]
    public T this[int index]
    {
      get
      {
        return this.typeNode.InverseRefs.GetNodes(ReferenceTypes.HasTypeDefinition, false).OfType<T>().Skip<T>(index).FirstOrDefault<T>();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public int Count
    {
      get
      {
        return this.typeNode.InverseRefs.GetNodes(ReferenceTypes.HasTypeDefinition, false).OfType<T>().Count<T>();
      }
    }
  }
}
