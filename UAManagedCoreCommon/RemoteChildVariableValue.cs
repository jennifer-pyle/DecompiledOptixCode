// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteChildVariableValue
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public struct RemoteChildVariableValue
  {
    public RemoteChildVariableValue(string relativePath, UAValue value)
    {
      this.RelativePath = relativePath;
      this.Value = value;
      this.Index = new uint[0];
    }

    public RemoteChildVariableValue(string relativePath, UAValue value, uint[] index)
      : this(relativePath, value)
    {
      this.Index = index;
    }

    public string RelativePath { get; }

    public UAValue Value { get; }

    public uint[] Index { get; }
  }
}
