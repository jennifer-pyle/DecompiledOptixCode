// Decompiled with JetBrains decompiler
// Type: UAManagedCore.USBUriInterop
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class USBUriInterop
  {
    public static bool IsRelativeToUSB(string uri)
    {
      InteropCallResult usb = USBUriInterop.Interop.IsUriRelativeToUSB(uri);
      usb.CheckOutcome();
      return usb.GetBool();
    }

    public static string ToAbsolutePath(string uri)
    {
      InteropCallResult absolutePath = USBUriInterop.Interop.USBUriToAbsolutePath(uri);
      absolutePath.CheckOutcome();
      return absolutePath.GetString();
    }

    public static string ToRelativePath(string uri)
    {
      InteropCallResult relativePath = USBUriInterop.Interop.USBUriToRelativePath(uri);
      relativePath.CheckOutcome();
      return relativePath.GetString();
    }

    public static uint ParseUSBNumber(string uri)
    {
      InteropCallResult usbNumberInUsbUri = USBUriInterop.Interop.ParseUSBNumberInUSBUri(uri);
      usbNumberInUsbUri.CheckOutcome();
      return usbNumberInUsbUri.GetUInt();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult IsUriRelativeToUSB([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string uri);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult USBUriToAbsolutePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string uri);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult USBUriToRelativePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string uri);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult ParseUSBNumberInUSBUri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string uri);
    }
  }
}
