// Decompiled with JetBrains decompiler
// Type: FTOptix.Store.StoreType
// Assembly: FTOptix.Store.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: F643F557-C95B-47D5-ABBF-593703F6DBCF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Store.Net\1.0.8.38\Any\FTOptix.Store.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.Store
{
  [MapType(NamespaceUri = "urn:FTOptix:Store", Number = 1)]
  public class StoreType : UAObjectType
  {
    public uint MaxColumnNameLength
    {
      get => (uint) this.Refs.GetVariable(nameof (MaxColumnNameLength)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaxColumnNameLength)).SetValue((object) value);
    }

    public IUAVariable MaxColumnNameLengthVariable => this.Refs.GetVariable("MaxColumnNameLength");

    public uint MaxColumnCount
    {
      get => (uint) this.Refs.GetVariable(nameof (MaxColumnCount)).Value.Value;
      set => this.Refs.GetVariable(nameof (MaxColumnCount)).SetValue((object) value);
    }

    public IUAVariable MaxColumnCountVariable => this.Refs.GetVariable("MaxColumnCount");

    public PlaceholderChildNodeCollection<Table> Tables
    {
      get => new PlaceholderChildNodeCollection<Table>((IUANode) this, nameof (Tables));
    }

    public StoreStatus Status
    {
      get => (StoreStatus) (int) this.Refs.GetVariable(nameof (Status)).Value;
      set => this.Refs.GetVariable(nameof (Status)).SetValue((object) (int) value);
    }

    public IUAVariable StatusVariable => this.Refs.GetVariable("Status");

    public void AddTable(string name)
    {
      this.ExecuteMethod(nameof (AddTable), new object[1]
      {
        (object) name
      });
    }

    public IUAMethod AddTableMethod => this.Refs.GetMethod("AddTable");

    public void RemoveTable(string name)
    {
      this.ExecuteMethod(nameof (RemoveTable), new object[1]
      {
        (object) name
      });
    }

    public IUAMethod RemoveTableMethod => this.Refs.GetMethod("RemoveTable");

    public void RenameTable(string oldName, string newName)
    {
      this.ExecuteMethod(nameof (RenameTable), new object[2]
      {
        (object) oldName,
        (object) newName
      });
    }

    public IUAMethod RenameTableMethod => this.Refs.GetMethod("RenameTable");

    public void Query(string query, out string[] header, out object[,] resultSet)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Query), new object[1]
      {
        (object) query
      }, out outputArgs);
      header = (string[]) outputArgs[0];
      resultSet = (object[,]) outputArgs[1];
    }

    public IUAMethod QueryMethod => this.Refs.GetMethod("Query");

    public void QueryOpen(
      string query,
      out Guid queryHandle,
      out string[] header,
      out ulong count)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (QueryOpen), new object[1]
      {
        (object) query
      }, out outputArgs);
      queryHandle = (Guid) outputArgs[0];
      header = (string[]) outputArgs[1];
      count = (ulong) outputArgs[2];
    }

    public IUAMethod QueryOpenMethod => this.Refs.GetMethod("QueryOpen");

    public void QueryPage(Guid queryHandle, uint offset, uint size, out object[,] resultSet)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (QueryPage), new object[3]
      {
        (object) queryHandle,
        (object) offset,
        (object) size
      }, out outputArgs);
      resultSet = (object[,]) outputArgs[0];
    }

    public IUAMethod QueryPageMethod => this.Refs.GetMethod("QueryPage");

    public void QueryClose(Guid queryHandle)
    {
      this.ExecuteMethod(nameof (QueryClose), new object[1]
      {
        (object) queryHandle
      });
    }

    public IUAMethod QueryCloseMethod => this.Refs.GetMethod("QueryClose");

    public void AddColumn(string tableName, string name, NodeId dataType)
    {
      this.ExecuteMethod(nameof (AddColumn), new object[3]
      {
        (object) tableName,
        (object) name,
        (object) dataType
      });
    }

    public IUAMethod AddColumnMethod => this.Refs.GetMethod("AddColumn");

    public void RemoveColumn(string tableName, string name)
    {
      this.ExecuteMethod(nameof (RemoveColumn), new object[2]
      {
        (object) tableName,
        (object) name
      });
    }

    public IUAMethod RemoveColumnMethod => this.Refs.GetMethod("RemoveColumn");

    public void RenameColumn(string tableName, string oldName, string newName)
    {
      this.ExecuteMethod(nameof (RenameColumn), new object[3]
      {
        (object) tableName,
        (object) oldName,
        (object) newName
      });
    }

    public IUAMethod RenameColumnMethod => this.Refs.GetMethod("RenameColumn");

    public void Insert(string tableName, string[] columnNames, object[,] values)
    {
      this.ExecuteMethod(nameof (Insert), new object[3]
      {
        (object) tableName,
        (object) columnNames,
        (object) values
      });
    }

    public IUAMethod InsertMethod => this.Refs.GetMethod("Insert");

    public InstanceNodeCollection<FTOptix.Store.Store> Instances
    {
      get => new InstanceNodeCollection<FTOptix.Store.Store>((IUANode) this);
    }
  }
}
