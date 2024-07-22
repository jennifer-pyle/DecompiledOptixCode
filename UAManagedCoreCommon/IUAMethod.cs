// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAMethod
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUAMethod : IUANode
  {
    bool IsExecutable(IUANode targetNode);

    void Execute(IUANode targetNode);

    void Execute(IUANode targetNode, object[] args);

    void Execute(IUANode targetNode, object[] inputArgs, out object[] outputArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteNoPermissions(IUANode targetNode);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteNoPermissions(IUANode targetNode, object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteNoPermissions(IUANode targetNode, object[] inputArgs, out object[] outputArgs);
  }
}
