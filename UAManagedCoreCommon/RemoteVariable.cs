// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RemoteVariable
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore
{
  public struct RemoteVariable
  {
    public RemoteVariable(IUAVariable variable)
    {
      this.Variable = variable;
      this.Index = new uint[0];
    }

    public RemoteVariable(IUAVariable variable, uint index)
      : this(variable)
    {
      this.Index = new uint[1]{ index };
    }

    public RemoteVariable(IUAVariable variable, uint[] index)
      : this(variable)
    {
      this.Index = index;
    }

    public IUAVariable Variable { get; }

    public uint[] Index { get; }
  }
}
