// Decompiled with JetBrains decompiler
// Type: FTOptix.Store.Table
// Assembly: FTOptix.Store.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: F643F557-C95B-47D5-ABBF-593703F6DBCF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Store.Net\1.0.8.38\Any\FTOptix.Store.Net.dll

using UAManagedCore;

#nullable disable
namespace FTOptix.Store
{
  [MapType(NamespaceUri = "urn:FTOptix:Store", Number = 3)]
  public class Table : UAObject
  {
    public uint RecordLimit
    {
      get => (uint) this.GetOptionalVariableValue(nameof (RecordLimit));
      set => this.SetOptionalVariableValue(nameof (RecordLimit), new UAValue(value));
    }

    public IUAVariable RecordLimitVariable => this.GetOrCreateVariable("RecordLimit");

    public void AddColumn(string name, NodeId dataType)
    {
      this.ExecuteMethod(nameof (AddColumn), new object[2]
      {
        (object) name,
        (object) dataType
      });
    }

    public IUAMethod AddColumnMethod => this.Refs.GetMethod("AddColumn");

    public void RemoveColumn(string name)
    {
      this.ExecuteMethod(nameof (RemoveColumn), new object[1]
      {
        (object) name
      });
    }

    public IUAMethod RemoveColumnMethod => this.Refs.GetMethod("RemoveColumn");

    public void RenameColumn(string oldName, string newName)
    {
      this.ExecuteMethod(nameof (RenameColumn), new object[2]
      {
        (object) oldName,
        (object) newName
      });
    }

    public IUAMethod RenameColumnMethod => this.Refs.GetMethod("RenameColumn");

    public void Insert(string[] columnNames, object[,] values)
    {
      this.ExecuteMethod(nameof (Insert), new object[2]
      {
        (object) columnNames,
        (object) values
      });
    }

    public IUAMethod InsertMethod => this.Refs.GetMethod("Insert");

    public PlaceholderChildNodeCollection<StoreColumn> Columns
    {
      get => new PlaceholderChildNodeCollection<StoreColumn>((IUANode) this, nameof (Columns));
    }
  }
}
