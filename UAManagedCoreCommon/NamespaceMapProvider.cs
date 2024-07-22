// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NamespaceMapProvider
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class NamespaceMapProvider
  {
    private static INamespaceMap _provider;

    internal static bool IsProviderSet => NamespaceMapProvider._provider != null;

    internal static void SetProvider(INamespaceMap provider)
    {
      NamespaceMapProvider._provider = provider != null ? provider : throw new ArgumentNullException(nameof (provider));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static int GetNamespaceIndex(string namespaceName)
    {
      return NamespaceMapProvider._provider != null ? NamespaceMapProvider._provider.GetNamespaceIndex(namespaceName) : throw new InvalidOperationException("Provider not initialized");
    }
  }
}
