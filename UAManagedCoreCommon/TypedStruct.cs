// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TypedStruct
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

#nullable disable
namespace UAManagedCore
{
  public abstract class TypedStruct : TypedStructBase
  {
    private static readonly Dictionary<Type, Tuple<NodeId, IReadOnlyList<PropertyInfo>>> typingDictionary = new Dictionary<Type, Tuple<NodeId, IReadOnlyList<PropertyInfo>>>();
    private static readonly ReaderWriterLockSlim syncLock = new ReaderWriterLockSlim();

    protected override sealed NodeId GetDataTypeId() => this.GetTuple().Item1;

    protected override sealed IReadOnlyList<PropertyInfo> GetPropertyInfos()
    {
      return this.GetTuple().Item2;
    }

    private Tuple<NodeId, IReadOnlyList<PropertyInfo>> GetTuple()
    {
      Type type = this.GetType();
      TypedStruct.syncLock.EnterReadLock();
      try
      {
        Tuple<NodeId, IReadOnlyList<PropertyInfo>> tuple;
        if (TypedStruct.typingDictionary.TryGetValue(type, out tuple))
          return tuple;
      }
      finally
      {
        TypedStruct.syncLock.ExitReadLock();
      }
      TypedStruct.syncLock.EnterWriteLock();
      try
      {
        Tuple<NodeId, IReadOnlyList<PropertyInfo>> tuple;
        if (TypedStruct.typingDictionary.TryGetValue(type, out tuple))
          return tuple;
        tuple = Tuple.Create<NodeId, IReadOnlyList<PropertyInfo>>(TypedStructBase.GetDataTypeId(type), TypedStructBase.GetProperties(type));
        TypedStruct.typingDictionary.Add(type, tuple);
        return tuple;
      }
      finally
      {
        TypedStruct.syncLock.ExitWriteLock();
      }
    }
  }
}
