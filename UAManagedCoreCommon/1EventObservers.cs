// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IAttributeChangeObserver
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [EventId(EventType.PathResolverSupportedAttributes | EventType.FirstEvent | EventType.ArrayDimensionsChanged | EventType.ContainsNoLoopsChanged | EventType.DataTypeChanged | EventType.EventNotifierChanged | EventType.ExecutableChanged | EventType.HistorizingChanged | EventType.InverseNameChanged | EventType.IsAbstractChanged | EventType.MinimumSamplingIntervalChanged | EventType.NodeClassChanged | EventType.NodeIdChanged | EventType.UserAccessLevelChanged | EventType.UserExecutableChanged | EventType.UserWriteMaskChanged | EventType.ValueRankChanged | EventType.WriteMaskChanged | EventType.ValueForVariableTypeChanged | EventType.ActualDataTypeChanged)]
  public interface IAttributeChangeObserver : IEventObserver
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    void OnAttributeChanged(
      IUANode node,
      AttributeId attributeId,
      UAValue newValue,
      UAValue oldValue,
      ulong senderId);
  }
}
