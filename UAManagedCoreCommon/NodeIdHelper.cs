// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NodeIdHelper
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class NodeIdHelper
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string EmptyNodeStringFormat = "{NodeId:ns=-1;}";
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string EmptyNodeStringUriFormat = "{NodeId:nsu=\"\";}";

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string Format(this NodeId nodeId)
    {
      if (nodeId.IsEmpty)
        return NodeIdHelper.EmptyNodeStringFormat;
      return "{NodeId:ns=" + nodeId.NamespaceIndex.ToString() + ";" + nodeId.IdTypeShortString + "=" + nodeId.Id?.ToString() + "}";
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string Format(IContext context, NodeId n)
    {
      if (n.IsEmpty)
        return "nsu=\"\";";
      return "nsu=\"" + context.GetNamespaceUri(n.NamespaceIndex) + "\";" + n.IdTypeShortString + "=" + n.Id?.ToString();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string ToUriFormat(this NodeId nodeId, IContext context)
    {
      if (nodeId.IsEmpty)
        return NodeIdHelper.EmptyNodeStringUriFormat;
      string namespaceUri = context.GetNamespaceUri(nodeId.NamespaceIndex);
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
      interpolatedStringHandler.AppendLiteral("{NodeId:nsu=\"");
      interpolatedStringHandler.AppendFormatted(namespaceUri);
      interpolatedStringHandler.AppendLiteral("\";");
      interpolatedStringHandler.AppendFormatted(nodeId.IdTypeShortString);
      interpolatedStringHandler.AppendLiteral("=");
      interpolatedStringHandler.AppendFormatted<object>(nodeId.Id);
      interpolatedStringHandler.AppendLiteral("}");
      return interpolatedStringHandler.ToStringAndClear();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId FromFormat(string format)
    {
      if (format == NodeIdHelper.EmptyNodeStringFormat)
        return NodeId.Empty;
      if (!format.StartsWith("{NodeId:ns="))
        return (NodeId) null;
      int length = "{NodeId:ns=".Length;
      int num1 = format.IndexOf(";", StringComparison.Ordinal);
      int num2 = format.LastIndexOf("=", StringComparison.Ordinal);
      int num3 = format.LastIndexOf("}", StringComparison.Ordinal);
      if (num1 >= 0 && num2 >= 0)
      {
        if (num3 >= 0)
        {
          try
          {
            return NodeIdHelper.FromFormat(int.Parse(format.Substring(length, num1 - length)), format.Substring(num1 + 1, num2 - (num1 + 1)), format.Substring(num2 + 1, num3 - (num2 + 1)));
          }
          catch
          {
            return (NodeId) null;
          }
        }
      }
      return (NodeId) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId FromUriFormat(string format, IContext context)
    {
      if (format == NodeIdHelper.EmptyNodeStringUriFormat)
        return NodeId.Empty;
      if (!format.StartsWith("{NodeId:nsu=\""))
        return (NodeId) null;
      int length1 = "{NodeId:nsu=\"".Length;
      int num1 = format.IndexOf(";", StringComparison.Ordinal);
      int num2 = format.LastIndexOf("=", StringComparison.Ordinal);
      int num3 = format.LastIndexOf("}", StringComparison.Ordinal);
      int num4 = format.IndexOf("\"", length1, StringComparison.Ordinal);
      if (num1 >= 0 && num2 >= 0 && num3 >= 0)
      {
        if (num4 >= 0)
        {
          try
          {
            int length2 = num4 - length1;
            string namespaceUri = format.Substring(length1, length2);
            return NodeIdHelper.FromFormat(context.GetNamespaceIndex(namespaceUri), format.Substring(num1 + 1, num2 - (num1 + 1)), format.Substring(num2 + 1, num3 - (num2 + 1)));
          }
          catch
          {
            return (NodeId) null;
          }
        }
      }
      return (NodeId) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static NodeId FromAnyFormat(string format, IContext context)
    {
      NodeId nodeId = NodeIdHelper.FromFormat(format);
      return (object) nodeId != null ? nodeId : NodeIdHelper.FromUriFormat(format, context);
    }

    private static NodeId FromFormat(int namespaceIndex, string idType, string id)
    {
      switch (idType)
      {
        case "g":
          return new NodeId(namespaceIndex, new Guid(id));
        case "i":
          return new NodeId(namespaceIndex, uint.Parse(id, (IFormatProvider) CultureInfo.InvariantCulture));
        case "s":
          return new NodeId(namespaceIndex, id);
        default:
          throw new InvalidOperationException("NodeId type " + idType + " conversion not supported");
      }
    }
  }
}
