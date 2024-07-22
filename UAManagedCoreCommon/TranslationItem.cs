// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TranslationItem
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Serializable]
  public struct TranslationItem
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static TranslationItem Of(string textId, string text)
    {
      return new TranslationItem()
      {
        TextId = textId,
        Text = text
      };
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string TextId { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Text { get; private set; }
  }
}
