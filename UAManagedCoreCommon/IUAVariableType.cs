// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IUAVariableType
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  public interface IUAVariableType : IUANode
  {
    bool IsAbstract { get; }

    IUAVariableType SuperType { get; }

    NodeId DataType { get; }

    ValueRank ValueRank { get; }

    uint[] ArrayDimensions { get; }

    bool IsSubTypeOf(NodeId typeNodeId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    uint GetArrayDimension(uint dimension);
  }
}
