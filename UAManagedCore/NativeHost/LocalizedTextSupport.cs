// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.LocalizedTextSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class LocalizedTextSupport
  {
    public static IntPtr Create(
      int namespaceIndex,
      IntPtr textIdPtr,
      IntPtr textPtr,
      IntPtr localedIdPtr)
    {
      string textId = StringMarshal.StringFromIntPtr(textIdPtr);
      string text = StringMarshal.StringFromIntPtr(textPtr);
      string localeId = StringMarshal.StringFromIntPtr(localedIdPtr);
      return ObjectMarshal.ToIntPtr((object) new LocalizedText(namespaceIndex, textId, text, localeId));
    }

    public static void Decompose(
      IntPtr localizedTextPtr,
      out int namespaceIndex,
      out IntPtr textIdPtr,
      out IntPtr textPtr,
      out IntPtr localedIdPtr)
    {
      LocalizedText localizedText = ObjectMarshal.FromIntPtr<LocalizedText>(localizedTextPtr);
      if (localizedText == (LocalizedText) null)
        localizedText = LocalizedText.Empty;
      namespaceIndex = localizedText.NamespaceIndex;
      textIdPtr = StringMarshal.StringToIntPtr(localizedText.TextId);
      textPtr = StringMarshal.StringToIntPtr(localizedText.Text);
      localedIdPtr = StringMarshal.StringToIntPtr(localizedText.LocaleId);
    }

    public delegate IntPtr CreateDelegate(
      int namespaceIndex,
      IntPtr textIdPtr,
      IntPtr textPtr,
      IntPtr localedIdPtr);

    public delegate void DecomposeDelegate(
      IntPtr localizedTextPtr,
      out int namespaceIndex,
      out IntPtr textIdPtr,
      out IntPtr textPtr,
      out IntPtr localedIdPtr);
  }
}
