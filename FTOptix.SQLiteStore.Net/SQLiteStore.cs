// Decompiled with JetBrains decompiler
// Type: FTOptix.SQLiteStore.SQLiteStore
// Assembly: FTOptix.SQLiteStore.Net, Version=1.0.8.39, Culture=neutral, PublicKeyToken=null
// MVID: 935C598C-845E-4DF3-A45C-6ADE39178AC2
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.SQLiteStore.Net\1.0.8.39\Any\FTOptix.SQLiteStore.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.SQLiteStore
{
  [MapType(NamespaceUri = "urn:FTOptix:SQLiteStore", Number = 1)]
  public class SQLiteStore : FTOptix.Store.Store
  {
    public bool InMemory
    {
      get => (bool) this.GetOptionalVariableValue(nameof (InMemory));
      set => this.SetOptionalVariableValue(nameof (InMemory), new UAValue(value));
    }

    public IUAVariable InMemoryVariable => this.GetOrCreateVariable("InMemory");

    public string Filename
    {
      get => (string) this.GetOptionalVariableValue(nameof (Filename));
      set => this.SetOptionalVariableValue(nameof (Filename), new UAValue(value));
    }

    public IUAVariable FilenameVariable => this.GetOrCreateVariable("Filename");

    public bool Backup(ResourceUri outputFilePath)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Backup), new object[1]
      {
        (object) (string) outputFilePath
      }, out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod BackupMethod => this.Refs.GetMethod("Backup");

    public bool Restore(ResourceUri inputFilePath)
    {
      object[] outputArgs = new object[0];
      this.ExecuteMethod(nameof (Restore), new object[1]
      {
        (object) (string) inputFilePath
      }, out outputArgs);
      return (bool) outputArgs[0];
    }

    public IUAMethod RestoreMethod => this.Refs.GetMethod("Restore");
  }
}
