// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteChildVariable
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public struct RemoteChildVariable
  {
    public RemoteChildVariable(string relativePath)
    {
      this.RelativePath = relativePath;
      this.Index = new uint[0];
    }

    public RemoteChildVariable(string relativePath, uint[] index)
      : this(relativePath)
    {
      this.Index = index;
    }

    public string RelativePath { get; }

    public uint[] Index { get; }
  }
}
