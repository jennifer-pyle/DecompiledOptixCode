// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.ExpandedNodeIdSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class ExpandedNodeIdSupport
  {
    public static IntPtr CreateExpandedNodeIdFromUInt(IntPtr namespaceUriPtr, uint id)
    {
      return ObjectMarshal.ToIntPtr((object) new ExpandedNodeId(StringMarshal.StringFromIntPtr(namespaceUriPtr), id));
    }

    public static IntPtr CreateExpandedNodeIdFromGuid(IntPtr namespaceUriPtr, IntPtr nativeBytesPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new ExpandedNodeId(StringMarshal.StringFromIntPtr(namespaceUriPtr), new Guid(GuidSupport.FromNativeBytes(nativeBytesPtr))));
    }

    public static IntPtr CreateExpandedNodeIdFromString(IntPtr namespaceUriPtr, IntPtr idPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new ExpandedNodeId(StringMarshal.StringFromIntPtr(namespaceUriPtr), StringMarshal.StringFromIntPtr(idPtr)));
    }

    public static IntPtr DecomposeExpandedNodeId(
      IntPtr expandedNodeIdPtr,
      out IntPtr namespaceUriPtr,
      out char idType)
    {
      ExpandedNodeId expandedNodeId = ObjectMarshal.FromIntPtr<ExpandedNodeId>(expandedNodeIdPtr);
      if (expandedNodeId == (ExpandedNodeId) null)
      {
        namespaceUriPtr = IntPtr.Zero;
        idType = ' ';
        return IntPtr.Zero;
      }
      namespaceUriPtr = StringMarshal.StringToIntPtr(expandedNodeId.NamespaceUri);
      idType = expandedNodeId.IdTypeShortString[0];
      byte[] guidArray = Array.Empty<byte>();
      if (expandedNodeId.IdType == IdType.UInt32)
        guidArray = BitConverter.GetBytes((uint) expandedNodeId.Id);
      else if (expandedNodeId.IdType == IdType.Guid)
      {
        guidArray = ((Guid) expandedNodeId.Id).ToByteArray();
        GuidSupport.ReverseGuidByteArrayEndianness(ref guidArray);
      }
      else if (expandedNodeId.IdType == IdType.String)
      {
        byte[] bytes = new UTF8Encoding(false).GetBytes((string) expandedNodeId.Id);
        guidArray = new byte[bytes.Length + 1];
        guidArray[bytes.Length] = (byte) 0;
        Buffer.BlockCopy((Array) bytes, 0, (Array) guidArray, 0, bytes.Length);
      }
      IntPtr destination = UAManagedCore.NativeMemory.Allocate(guidArray.Length);
      Marshal.Copy(guidArray, 0, destination, guidArray.Length);
      return destination;
    }

    public delegate IntPtr CreateExpandedNodeIdFromUIntDelegate(IntPtr namespaceUriPtr, uint id);

    public delegate IntPtr CreateExpandedNodeIdFromGuidDelegate(
      IntPtr namespaceUriPtr,
      IntPtr nativeBytesPtr);

    public delegate IntPtr CreateExpandedNodeIdFromStringDelegate(
      IntPtr namespaceUriPtr,
      IntPtr idPtr);

    public delegate IntPtr DecomposeExpandedNodeIdDelegate(
      IntPtr expandedNodeIdPtr,
      out IntPtr namespaceUriPtr,
      out char idType);
  }
}
