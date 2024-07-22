// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAObjectType
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUAObjectType : IUANode
  {
    bool IsAbstract { get; }

    IUAObjectType SuperType { get; }

    IEventArguments EventArguments { get; }

    bool IsSubTypeOf(NodeId typeNodeId);

    void ExecuteMethod(string methodName);

    void ExecuteMethod(string methodName, object[] args);

    void ExecuteMethod(string methodName, object[] inputArgs, out object[] outputArgs);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName, object[] args);

    [EditorBrowsable(EditorBrowsableState.Never)]
    void ExecuteMethodNoPermissions(string methodName, object[] inputArgs, out object[] outputArgs);
  }
}
