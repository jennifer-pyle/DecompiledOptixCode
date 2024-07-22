// Decompiled with JetBrains decompiler
// Type: UAManagedCore.SimplifiedNavigationExtensions
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace UAManagedCore
{
  public static class SimplifiedNavigationExtensions
  {
    public static IUANode Get(this IUANode node, string browsePath)
    {
      string[] strArray = browsePath.Split('/');
      if (strArray.Length == 1)
        return node.Children.Get((QualifiedName) browsePath);
      IUANode uaNode = node;
      foreach (string browseName in strArray)
      {
        uaNode = uaNode.Children.Get((QualifiedName) browseName);
        if (uaNode == null)
          return (IUANode) null;
      }
      return uaNode;
    }

    public static IUAObject GetObject(this IUANode node, string browsePath)
    {
      return node.Get(browsePath) as IUAObject;
    }

    public static IUAVariable GetVariable(this IUANode node, string browsePath)
    {
      return node.Get(browsePath) as IUAVariable;
    }

    public static T Get<T>(this IUANode node, string browsePath) where T : class, IUANode
    {
      return node.Get(browsePath) as T;
    }

    public static void Add(this IUANode node, IUANode child) => node.Children.Add(child);

    public static void Remove(this IUANode node, IUANode child) => node.Children.Remove(child);

    public static T GetByType<T>(this IUANode node) where T : class, IUANode
    {
      return node.GetNodesByType<T>().FirstOrDefault<T>();
    }

    public static IEnumerable<T> GetNodesByType<T>(this IUANode node) where T : class, IUANode
    {
      return node.Children.OfType<T>();
    }
  }
}
