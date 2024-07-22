// Decompiled with JetBrains decompiler
// Type: FTOptix.ODBCStore.ODBCStoreType
// Assembly: FTOptix.ODBCStore.Net, Version=1.0.8.40, Culture=neutral, PublicKeyToken=null
// MVID: 84834374-1E7D-4D92-B33A-27ADBA3C996C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.ODBCStore.Net\1.0.8.40\Any\FTOptix.ODBCStore.Net.dll

using FTOptix.Store;
using UAManagedCore;

#nullable disable
namespace FTOptix.ODBCStore
{
  [MapType(NamespaceUri = "urn:FTOptix:ODBCStore", Number = 1)]
  public class ODBCStoreType : StoreType
  {
    public string DSN
    {
      get => (string) this.Refs.GetVariable(nameof (DSN))?.GetValue();
      set
      {
        if (value != null)
          (this.Refs.GetVariable(nameof (DSN)) ?? this.GetOrCreateVariable(nameof (DSN))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (DSN))?.Delete();
      }
    }

    public IUAVariable DSNVariable => this.GetOrCreateVariable("DSN");

    public DBMSType Type
    {
      get => (DBMSType) (int) this.Refs.GetVariable(nameof (Type)).Value;
      set => this.Refs.GetVariable(nameof (Type)).SetValue((object) (int) value);
    }

    public IUAVariable TypeVariable => this.Refs.GetVariable("Type");

    public string Username
    {
      get => (string) this.Refs.GetVariable(nameof (Username)).Value.Value;
      set => this.Refs.GetVariable(nameof (Username)).SetValue((object) value);
    }

    public IUAVariable UsernameVariable => this.Refs.GetVariable("Username");

    public string Password
    {
      get => (string) this.Refs.GetVariable(nameof (Password)).Value.Value;
      set => this.Refs.GetVariable(nameof (Password)).SetValue((object) value);
    }

    public IUAVariable PasswordVariable => this.Refs.GetVariable("Password");

    public string Database
    {
      get => (string) this.Refs.GetVariable(nameof (Database))?.GetValue();
      set
      {
        if (value != null)
          (this.Refs.GetVariable(nameof (Database)) ?? this.GetOrCreateVariable(nameof (Database))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (Database))?.Delete();
      }
    }

    public IUAVariable DatabaseVariable => this.GetOrCreateVariable("Database");

    public string Server
    {
      get => (string) this.Refs.GetVariable(nameof (Server))?.GetValue();
      set
      {
        if (value != null)
          (this.Refs.GetVariable(nameof (Server)) ?? this.GetOrCreateVariable(nameof (Server))).SetValue((object) value);
        else
          this.Refs.GetVariable(nameof (Server))?.Delete();
      }
    }

    public IUAVariable ServerVariable => this.GetOrCreateVariable("Server");

    public ushort Port
    {
      get => (ushort) this.GetOptionalVariableValue(nameof (Port));
      set => this.SetOptionalVariableValue(nameof (Port), new UAValue(value));
    }

    public IUAVariable PortVariable => this.GetOrCreateVariable("Port");

    public InstanceNodeCollection<FTOptix.ODBCStore.ODBCStore> Instances
    {
      get => new InstanceNodeCollection<FTOptix.ODBCStore.ODBCStore>((IUANode) this);
    }
  }
}
