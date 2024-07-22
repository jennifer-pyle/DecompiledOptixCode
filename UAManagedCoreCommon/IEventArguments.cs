// Decompiled with JetBrains decompiler
// Type: UAManagedCore.IEventArguments
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public interface IEventArguments
  {
    uint GetFieldsSize();

    IReadOnlyList<string> GetFields();

    string GetFieldFromIndex(uint index);

    uint GetFieldIndex(string name);

    IReadOnlyList<uint> MakeIndexForFields(IReadOnlyCollection<string> fields);

    object GetFieldValue(IReadOnlyList<object> eventData, string field);

    void SetFieldValue(IList<object> eventData, string field, object value);
  }
}
