// Decompiled with JetBrains decompiler
// Type: UAManagedCore.EventArguments
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public class EventArguments : IEventArguments
  {
    private List<string> fieldIndexer;

    public uint GetFieldsSize() => (uint) this.fieldIndexer.Count;

    public IReadOnlyList<string> GetFields() => (IReadOnlyList<string>) this.fieldIndexer;

    public string GetFieldFromIndex(uint index) => this.fieldIndexer[(int) index];

    public uint GetFieldIndex(string name) => (uint) this.fieldIndexer.IndexOf(name);

    public IReadOnlyList<uint> MakeIndexForFields(IReadOnlyCollection<string> fields)
    {
      List<uint> uintList = new List<uint>(fields.Count);
      foreach (string field in (IEnumerable<string>) fields)
        uintList.Add((uint) this.fieldIndexer.IndexOf(field));
      return (IReadOnlyList<uint>) uintList;
    }

    public object GetFieldValue(IReadOnlyList<object> eventData, string field)
    {
      int index = this.fieldIndexer.IndexOf(field);
      return eventData[index];
    }

    public void SetFieldValue(IList<object> eventData, string field, object value)
    {
      int index = this.fieldIndexer.IndexOf(field);
      eventData[index] = value;
    }

    internal EventArguments(string[] fields)
    {
      this.fieldIndexer = new List<string>(fields.Length);
      foreach (string field in fields)
        this.fieldIndexer.Add(field);
    }
  }
}
