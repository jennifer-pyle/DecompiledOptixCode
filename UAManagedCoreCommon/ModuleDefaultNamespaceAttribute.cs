// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ModuleDefaultNamespaceAttribute
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
  public sealed class ModuleDefaultNamespaceAttribute : Attribute
  {
    private readonly string namespaceUri;

    public ModuleDefaultNamespaceAttribute(string namespaceUri)
    {
      this.namespaceUri = namespaceUri == null || !(namespaceUri.Trim() == string.Empty) ? namespaceUri : throw new ArgumentException("NamespaceUri cannot be the empty string", nameof (namespaceUri));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string NamespaceUri => this.namespaceUri;
  }
}
