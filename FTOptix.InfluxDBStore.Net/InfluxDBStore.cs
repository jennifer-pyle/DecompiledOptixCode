// Decompiled with JetBrains decompiler
// Type: FTOptix.InfluxDBStore.InfluxDBStore
// Assembly: FTOptix.InfluxDBStore.Net, Version=1.0.1.44, Culture=neutral, PublicKeyToken=null
// MVID: D250D165-EF05-42CD-BF7B-B79EF31B07C8
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.InfluxDBStore.Net\1.0.1.44\Any\FTOptix.InfluxDBStore.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.InfluxDBStore
{
  [MapType(NamespaceUri = "urn:FTOptix:InfluxDBStore", Number = 1)]
  public class InfluxDBStore : FTOptix.Store.Store
  {
    public IUAVariable TypeVariable => this.Refs.GetVariable("Type");

    public string Organization
    {
      get => (string) this.Refs.GetVariable(nameof (Organization)).Value.Value;
      set => this.Refs.GetVariable(nameof (Organization)).SetValue((object) value);
    }

    public IUAVariable OrganizationVariable => this.Refs.GetVariable("Organization");

    public string Token
    {
      get => (string) this.Refs.GetVariable(nameof (Token)).Value.Value;
      set => this.Refs.GetVariable(nameof (Token)).SetValue((object) value);
    }

    public IUAVariable TokenVariable => this.Refs.GetVariable("Token");

    public string Bucket
    {
      get => (string) this.Refs.GetVariable(nameof (Bucket)).Value.Value;
      set => this.Refs.GetVariable(nameof (Bucket)).SetValue((object) value);
    }

    public IUAVariable BucketVariable => this.GetVariable("Bucket");

    public string Server
    {
      get => (string) this.Refs.GetVariable(nameof (Server)).Value.Value;
      set => this.Refs.GetVariable(nameof (Server)).SetValue((object) value);
    }

    public IUAVariable ServerVariable => this.GetVariable("Server");

    public ushort Port
    {
      get => (ushort) this.Refs.GetVariable(nameof (Port)).Value.Value;
      set => this.Refs.GetVariable(nameof (Port)).SetValue((object) value);
    }

    public IUAVariable PortVariable => this.GetVariable("Port");

    public bool UseSSL
    {
      get => (bool) this.Refs.GetVariable(nameof (UseSSL)).Value.Value;
      set => this.Refs.GetVariable(nameof (UseSSL)).SetValue((object) value);
    }

    public IUAVariable UseSSLVariable => this.GetVariable("UseSSL");

    public ResourceUri ServerCertificate
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ServerCertificate)));
      set => this.SetOptionalVariableValue(nameof (ServerCertificate), new UAValue((string) value));
    }

    public IUAVariable ServerCertificateVariable => this.GetOrCreateVariable("ServerCertificate");
  }
}
