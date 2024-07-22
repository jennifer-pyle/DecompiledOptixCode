// Decompiled with JetBrains decompiler
// Type: FTOptix.WebUI.WebUIPresentationEngine
// Assembly: FTOptix.WebUI.Net, Version=1.2.0.52, Culture=neutral, PublicKeyToken=null
// MVID: 2B83AA5D-FBF5-48D5-A192-6929F90320F9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.WebUI.Net\1.2.0.52\Any\FTOptix.WebUI.Net.dll

using FTOptix.Core;
using FTOptix.UI;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.WebUI
{
  [MapType(NamespaceUri = "urn:FTOptix:WebUI", Number = 1)]
  public class WebUIPresentationEngine : PresentationEngine
  {
    public double DynamicVariablesPollingTime
    {
      get => (double) this.GetOptionalVariableValue(nameof (DynamicVariablesPollingTime));
      set
      {
        this.SetOptionalVariableValue(nameof (DynamicVariablesPollingTime), new UAValue(value));
      }
    }

    public IUAVariable DynamicVariablesPollingTimeVariable
    {
      get => this.GetOrCreateVariable("DynamicVariablesPollingTime");
    }

    public Protocol Protocol
    {
      get => (Protocol) (int) this.GetOptionalVariableValue(nameof (Protocol));
      set => this.SetOptionalVariableValue(nameof (Protocol), new UAValue((int) value));
    }

    public IUAVariable ProtocolVariable => this.GetOrCreateVariable("Protocol");

    public ResourceUri CertificateFile
    {
      get => this.Certificate.CertificateFile;
      set => this.Certificate.CertificateFile = (ResourceUri) (string) value;
    }

    public IUAVariable CertificateFileVariable => this.Certificate.CertificateFileVariable;

    public ResourceUri PrivateKeyFile
    {
      get => this.Certificate.PrivateKeyFile;
      set => this.Certificate.PrivateKeyFile = (ResourceUri) (string) value;
    }

    public IUAVariable PrivateKeyFileVariable => this.Certificate.PrivateKeyFileVariable;

    public Certificate Certificate
    {
      get => new Certificate((PropertyGroup) this.GetOrCreateObject(nameof (Certificate)));
    }

    public string IPAddress
    {
      get => (string) this.Refs.GetVariable(nameof (IPAddress)).Value.Value;
      set => this.Refs.GetVariable(nameof (IPAddress)).SetValue((object) value);
    }

    public IUAVariable IPAddressVariable => this.Refs.GetVariable("IPAddress");

    public ushort Port
    {
      get => (ushort) this.Refs.GetVariable(nameof (Port)).Value.Value;
      set => this.Refs.GetVariable(nameof (Port)).SetValue((object) value);
    }

    public IUAVariable PortVariable => this.Refs.GetVariable("IPAddress");

    public string Hostname
    {
      get => (string) this.GetOptionalVariableValue(nameof (Hostname));
      set => this.SetOptionalVariableValue(nameof (Hostname), new UAValue(value));
    }

    public IUAVariable HostnameVariable => this.GetOrCreateVariable("Hostname");

    public uint MaxNumberOfConnections
    {
      get => (uint) this.GetOptionalVariableValue(nameof (MaxNumberOfConnections));
      set => this.SetOptionalVariableValue(nameof (MaxNumberOfConnections), new UAValue(value));
    }

    public IUAVariable MaxNumberOfConnectionsVariable
    {
      get => this.GetOrCreateVariable("MaxNumberOfConnections");
    }

    public string[] AllowedRemoteSources
    {
      get => (string[]) this.GetOptionalVariableValue(nameof (AllowedRemoteSources));
      set
      {
        if (value != null)
          this.SetOptionalVariableValue(nameof (AllowedRemoteSources), new UAValue(value));
        else
          this.SetOptionalVariableValue(nameof (AllowedRemoteSources), new UAValue(Array.Empty<string>()));
      }
    }

    public IUAVariable AllowedRemoteSourcesVariable
    {
      get => this.GetOrCreateVariable("AllowedRemoteSources");
    }
  }
}
