// Decompiled with JetBrains decompiler
// Type: UAManagedCore.ModuleAssemblyScanner
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace UAManagedCore
{
  internal class ModuleAssemblyScanner
  {
    private readonly UACoreContext context;
    private readonly Assembly assembly;
    private string namespaceUri;

    public ModuleAssemblyScanner(UACoreContext context, Assembly assembly)
    {
      this.context = context;
      this.assembly = assembly;
    }

    public AssemblyDescriptor Scan()
    {
      this.namespaceUri = this.ReadNamespaceUri();
      return this.ScanMappedTypesAndBehaviours();
    }

    private string ReadNamespaceUri()
    {
      return this.assembly.GetCustomAttribute<ModuleDefaultNamespaceAttribute>()?.NamespaceUri;
    }

    private ExpandedNodeId CreateExpandedNodeId(
      ExpandedNodeIdAttribute attribute,
      ExpandedNodeId defaultNodeId)
    {
      if (attribute == null)
        return defaultNodeId;
      if (attribute.Id.GetType() == typeof (uint))
        return new ExpandedNodeId(attribute.NamespaceUri ?? this.namespaceUri, (uint) attribute.Id);
      if (attribute.Id.GetType() == typeof (string))
        return new ExpandedNodeId(attribute.NamespaceUri ?? this.namespaceUri, (string) attribute.Id);
      return attribute.Id.GetType() == typeof (Guid) ? new ExpandedNodeId(attribute.NamespaceUri ?? this.namespaceUri, (Guid) attribute.Id) : defaultNodeId;
    }

    private NodeId FromExpandedNodeIdToNodeId(ExpandedNodeId id)
    {
      int namespaceIndex = this.context.GetNamespaceIndex(id.NamespaceUri);
      if (namespaceIndex == NodeId.InvalidNamespaceIndex)
        namespaceIndex = this.context.AssignNamespaceIndex(id.NamespaceUri, "", NamespaceType.Static);
      switch (id.IdType)
      {
        case IdType.String:
          return new NodeId(namespaceIndex, (string) id.Id);
        case IdType.Guid:
          return new NodeId(namespaceIndex, (Guid) id.Id);
        case IdType.UInt32:
          return new NodeId(namespaceIndex, (uint) id.Id);
        default:
          throw new ArgumentOutOfRangeException(nameof (id));
      }
    }

    private AssemblyDescriptor ScanMappedTypesAndBehaviours()
    {
      List<MappedTypeDescriptor> mappedTypeDescriptorList = new List<MappedTypeDescriptor>();
      List<MappedDataTypeDescriptor> dataTypeDescriptorList = new List<MappedDataTypeDescriptor>();
      List<UABehaviourDescriptor> behaviourDescriptorList = new List<UABehaviourDescriptor>();
      foreach (Type exportedType in this.assembly.GetExportedTypes())
      {
        MapTypeAttribute customAttribute1 = exportedType.GetCustomAttribute<MapTypeAttribute>();
        BehaviourAttribute customAttribute2 = exportedType.GetCustomAttribute<BehaviourAttribute>();
        MapDataTypeAttribute customAttribute3 = exportedType.GetCustomAttribute<MapDataTypeAttribute>();
        if (customAttribute1 != null)
        {
          NodeId nodeId = this.FromExpandedNodeIdToNodeId(this.CreateExpandedNodeId((ExpandedNodeIdAttribute) customAttribute1, (ExpandedNodeId) null));
          if (typeof (IUAObject).IsAssignableFrom(exportedType) || typeof (IUAVariable).IsAssignableFrom(exportedType))
          {
            mappedTypeDescriptorList.Add(new MappedTypeDescriptor(exportedType, nodeId, true));
          }
          else
          {
            if (!typeof (IUAObjectType).IsAssignableFrom(exportedType) && !typeof (IUAVariableType).IsAssignableFrom(exportedType))
              throw new InvalidOperationException("Invalid MapType attribute found in type '" + exportedType.FullName + "'");
            mappedTypeDescriptorList.Add(new MappedTypeDescriptor(exportedType, nodeId, false));
          }
        }
        else if (customAttribute2 != null)
          behaviourDescriptorList.Add(new UABehaviourDescriptor(exportedType, customAttribute2.BehaviourGuid));
        else if (customAttribute3 != null)
        {
          NodeId nodeId = this.FromExpandedNodeIdToNodeId(this.CreateExpandedNodeId((ExpandedNodeIdAttribute) customAttribute3, (ExpandedNodeId) null));
          dataTypeDescriptorList.Add(new MappedDataTypeDescriptor(exportedType, nodeId));
          DataTypesHelper.AddMappedDataType(exportedType, nodeId);
        }
      }
      return new AssemblyDescriptor()
      {
        MappedTypes = mappedTypeDescriptorList.ToArray(),
        MappedDataTypes = dataTypeDescriptorList.ToArray(),
        Behaviours = behaviourDescriptorList.ToArray()
      };
    }
  }
}
