// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.NodeIdSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class NodeIdSupport
  {
    public static IntPtr CreateNodeIdFromUInt(int namespaceIndex, uint id)
    {
      return ObjectMarshal.ToIntPtr((object) new NodeId(namespaceIndex, id));
    }

    public static IntPtr CreateNodeIdFromGuid(int namespaceIndex, IntPtr nativeBytesPtr)
    {
      Guid id = new Guid(GuidSupport.FromNativeBytes(nativeBytesPtr));
      return ObjectMarshal.ToIntPtr((object) new NodeId(namespaceIndex, id));
    }

    public static IntPtr CreateNodeIdFromString(int namespaceIndex, IntPtr idPtr)
    {
      string id = StringMarshal.StringFromIntPtr(idPtr);
      return ObjectMarshal.ToIntPtr((object) new NodeId(namespaceIndex, id));
    }

    public static IntPtr DecomposeNodeId(IntPtr nodeIdPtr, out int namespaceIndex, out char idType)
    {
      NodeId nodeId = ObjectMarshal.FromIntPtr<NodeId>(nodeIdPtr);
      if (nodeId == (NodeId) null || nodeId.IsEmpty)
      {
        namespaceIndex = NodeId.InvalidNamespaceIndex;
        idType = ' ';
        return IntPtr.Zero;
      }
      namespaceIndex = nodeId.NamespaceIndex;
      idType = nodeId.IdTypeShortString[0];
      byte[] guidArray = Array.Empty<byte>();
      if (nodeId.IdType == IdType.UInt32)
        guidArray = BitConverter.GetBytes((uint) nodeId.Id);
      else if (nodeId.IdType == IdType.Guid)
      {
        guidArray = ((Guid) nodeId.Id).ToByteArray();
        GuidSupport.ReverseGuidByteArrayEndianness(ref guidArray);
      }
      else if (nodeId.IdType == IdType.String)
      {
        byte[] bytes = new UTF8Encoding(false).GetBytes((string) nodeId.Id);
        guidArray = new byte[bytes.Length + 1];
        guidArray[bytes.Length] = (byte) 0;
        Buffer.BlockCopy((Array) bytes, 0, (Array) guidArray, 0, bytes.Length);
      }
      IntPtr destination = UAManagedCore.NativeMemory.Allocate(guidArray.Length);
      Marshal.Copy(guidArray, 0, destination, guidArray.Length);
      return destination;
    }

    public delegate IntPtr CreateNodeIdFromUIntDelegate(int namespaceIndex, uint id);

    public delegate IntPtr CreateNodeIdFromGuidDelegate(int namespaceIndex, IntPtr nativeBytesPtr);

    public delegate IntPtr CreateNodeIdFromStringDelegate(int namespaceIndex, IntPtr idPtr);

    public delegate IntPtr DecomposeNodeIdDelegate(
      IntPtr nodeIdPtr,
      out int namespaceIndex,
      out char idType);
  }
}
