// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OpcUa.VariableTypes
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.OpcUa
{
  public static class VariableTypes
  {
    public const int BaseVariableTypeId = 62;
    public const int BaseDataVariableTypeId = 63;
    public const int PropertyTypeId = 68;
    public const int StateVariableTypeId = 2755;
    public const int FiniteStateVariableTypeId = 2760;
    public const int TwoStateVariableTypeId = 8995;
    public const int TransitionVariableTypeId = 2762;
    public const int DataTypeDictionaryTypeId = 72;
    public const int DataTypeDescriptionTypeId = 69;
    public const int FiniteTransitionVariableTypeId = 2767;
    public const int DataItemTypeId = 2365;
    public const int AnalogItemTypeId = 2368;
    public static readonly NodeId BaseVariableType = new NodeId(0, 62U);
    public static readonly NodeId BaseDataVariableType = new NodeId(0, 63U);
    public static readonly NodeId PropertyType = new NodeId(0, 68U);
    public static readonly NodeId StateVariableType = new NodeId(0, 2755U);
    public static readonly NodeId FiniteStateVariableType = new NodeId(0, 2760U);
    public static readonly NodeId TwoStateVariableType = new NodeId(0, 8995U);
    public static readonly NodeId TransitionVariableType = new NodeId(0, 2762U);
    public static readonly NodeId DataTypeDictionaryType = new NodeId(0, 72U);
    public static readonly NodeId DataTypeDescriptionType = new NodeId(0, 69U);
    public static readonly NodeId FiniteTransitionVariableType = new NodeId(0, 2767U);
    public static readonly NodeId DataItemType = new NodeId(0, 2365U);
    public static readonly NodeId AnalogItemType = new NodeId(0, 2368U);
  }
}
