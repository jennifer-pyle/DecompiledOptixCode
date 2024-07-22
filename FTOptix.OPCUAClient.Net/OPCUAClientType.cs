// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAClient.OPCUAClientType
// Assembly: FTOptix.OPCUAClient.Net, Version=1.2.0.14, Culture=neutral, PublicKeyToken=null
// MVID: F06E52A2-2D8D-46E9-85AE-074DAF07FD19
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAClient.Net\1.2.0.14\Any\FTOptix.OPCUAClient.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.OPCUAClient
{
  [MapType(NamespaceUri = "urn:FTOptix:OPCUAClient", Number = 1)]
  public class OPCUAClientType : UAObjectType
  {
    public string ServerEndpointURL
    {
      get => (string) this.Refs.GetVariable(nameof (ServerEndpointURL)).Value.Value;
      set => this.Refs.GetVariable(nameof (ServerEndpointURL)).SetValue((object) value);
    }

    public IUAVariable ServerEndpointURLVariable => this.Refs.GetVariable("ServerEndpointURL");

    public bool VerifyServerIdentity
    {
      get => (bool) this.GetOptionalVariableValue(nameof (VerifyServerIdentity));
      set => this.SetOptionalVariableValue(nameof (VerifyServerIdentity), new UAValue(value));
    }

    public IUAVariable VerifyServerIdentityVariable
    {
      get => this.GetOrCreateVariable("VerifyServerIdentity");
    }

    public double RequestedPublishingInterval
    {
      get => (double) this.GetOptionalVariableValue(nameof (RequestedPublishingInterval));
      set
      {
        this.SetOptionalVariableValue(nameof (RequestedPublishingInterval), new UAValue(value));
      }
    }

    public IUAVariable RequestedPublishingIntervalVariable
    {
      get => this.GetOrCreateVariable("RequestedPublishingInterval");
    }

    public double RequestedSamplingInterval
    {
      get => (double) this.GetOptionalVariableValue(nameof (RequestedSamplingInterval));
      set => this.SetOptionalVariableValue(nameof (RequestedSamplingInterval), new UAValue(value));
    }

    public IUAVariable RequestedSamplingIntervalVariable
    {
      get => this.GetOrCreateVariable("RequestedSamplingInterval");
    }

    public MessageSecurityMode MinimumMessageSecurityMode
    {
      get
      {
        return (MessageSecurityMode) (int) this.Refs.GetVariable(nameof (MinimumMessageSecurityMode)).Value;
      }
      set
      {
        this.Refs.GetVariable(nameof (MinimumMessageSecurityMode)).SetValue((object) (int) value);
      }
    }

    public IUAVariable MinimumMessageSecurityModeVariable
    {
      get => this.Refs.GetVariable("MinimumMessageSecurityMode");
    }

    public SecurityPolicy MinimumSecurityPolicy
    {
      get => (SecurityPolicy) (int) this.Refs.GetVariable(nameof (MinimumSecurityPolicy)).Value;
      set => this.Refs.GetVariable(nameof (MinimumSecurityPolicy)).SetValue((object) (int) value);
    }

    public IUAVariable MinimumSecurityPolicyVariable
    {
      get => this.Refs.GetVariable("MinimumSecurityPolicy");
    }

    public ResourceUri ClientCertificateFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ClientCertificateFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (ClientCertificateFile), new UAValue((string) value));
      }
    }

    public IUAVariable ClientCertificateFileVariable
    {
      get => this.GetOrCreateVariable("ClientCertificateFile");
    }

    public ResourceUri ClientPrivateKeyFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ClientPrivateKeyFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (ClientPrivateKeyFile), new UAValue((string) value));
      }
    }

    public IUAVariable ClientPrivateKeyFileVariable
    {
      get => this.GetOrCreateVariable("ClientPrivateKeyFile");
    }

    public UserIdentityType UserIdentityType
    {
      get => (UserIdentityType) (int) this.Refs.GetVariable(nameof (UserIdentityType)).Value;
      set => this.Refs.GetVariable(nameof (UserIdentityType)).SetValue((object) (int) value);
    }

    public IUAVariable UserIdentityTypeVariable => this.Refs.GetVariable("UserIdentityType");

    public string Username
    {
      get => (string) this.GetOptionalVariableValue(nameof (Username));
      set => this.SetOptionalVariableValue(nameof (Username), new UAValue(value));
    }

    public IUAVariable UsernameVariable => this.GetOrCreateVariable("Username");

    public string Password
    {
      get => (string) this.GetOptionalVariableValue(nameof (Password));
      set => this.SetOptionalVariableValue(nameof (Password), new UAValue(value));
    }

    public IUAVariable PasswordVariable => this.GetOrCreateVariable("Password");

    public ResourceUri UserCertificateFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (UserCertificateFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (UserCertificateFile), new UAValue((string) value));
      }
    }

    public IUAVariable UserCertificateFileVariable
    {
      get => this.GetOrCreateVariable("UserCertificateFile");
    }

    public ResourceUri UserPrivateKeyFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (UserPrivateKeyFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (UserPrivateKeyFile), new UAValue((string) value));
      }
    }

    public IUAVariable UserPrivateKeyFileVariable => this.GetOrCreateVariable("UserPrivateKeyFile");

    public string ApplicationURI
    {
      get => (string) this.GetOptionalVariableValue(nameof (ApplicationURI));
      set => this.SetOptionalVariableValue(nameof (ApplicationURI), new UAValue(value));
    }

    public IUAVariable ApplicationURIVariable => this.GetOrCreateVariable("ApplicationURI");

    public string ApplicationName
    {
      get => (string) this.GetOptionalVariableValue(nameof (ApplicationName));
      set => this.SetOptionalVariableValue(nameof (ApplicationName), new UAValue(value));
    }

    public IUAVariable ApplicationNameVariable => this.GetOrCreateVariable("ApplicationName");

    public string ProductURI
    {
      get => (string) this.GetOptionalVariableValue(nameof (ProductURI));
      set => this.SetOptionalVariableValue(nameof (ProductURI), new UAValue(value));
    }

    public IUAVariable ProductURIVariable => this.GetOrCreateVariable("ProductURI");

    public ConnectionStatus ConnectionStatus
    {
      get => (ConnectionStatus) (int) this.Refs.GetVariable(nameof (ConnectionStatus)).Value;
      set => this.Refs.GetVariable(nameof (ConnectionStatus)).SetValue((object) (int) value);
    }

    public IUAVariable ConnectionStatusVariable => this.Refs.GetVariable("ConnectionStatus");

    public string ConnectionLocaleId
    {
      get => (string) this.GetOptionalVariableValue(nameof (ConnectionLocaleId));
      set => this.SetOptionalVariableValue(nameof (ConnectionLocaleId), new UAValue(value));
    }

    public IUAVariable ConnectionLocaleIdVariable => this.GetOrCreateVariable("ConnectionLocaleId");

    public string ServerUri
    {
      get => (string) this.Refs.GetVariable(nameof (ServerUri)).Value.Value;
      set => this.Refs.GetVariable(nameof (ServerUri)).SetValue((object) value);
    }

    public IUAVariable ServerUriVariable => this.Refs.GetVariable("ServerUri");

    public IUAObject Objects => this.GetOrCreateObject(nameof (Objects));

    public bool Enabled
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Enabled));
      set => this.SetOptionalVariableValue(nameof (Enabled), new UAValue(value));
    }

    public IUAVariable EnabledVariable => this.GetOrCreateVariable("Enabled");

    public Events Events
    {
      get => (Events) (int) this.Refs.GetVariable(nameof (Events)).Value;
      set => this.Refs.GetVariable(nameof (Events)).SetValue((object) (int) value);
    }

    public IUAVariable EventsVariable => this.Refs.GetVariable("Events");

    public PlaceholderChildNodeCollection<RuntimeConfigurationEntry> RuntimeConfigurations
    {
      get
      {
        return new PlaceholderChildNodeCollection<RuntimeConfigurationEntry>((IUANode) this, nameof (RuntimeConfigurations));
      }
    }

    public bool SynchronizeNodeIdsOnStart
    {
      get => (bool) this.GetOptionalVariableValue(nameof (SynchronizeNodeIdsOnStart));
      set => this.SetOptionalVariableValue(nameof (SynchronizeNodeIdsOnStart), new UAValue(value));
    }

    public IUAVariable SynchronizeNodeIdsOnStartVariable
    {
      get => this.GetOrCreateVariable("SynchronizeNodeIdsOnStart");
    }

    public InstanceNodeCollection<FTOptix.OPCUAClient.OPCUAClient> Instances
    {
      get => new InstanceNodeCollection<FTOptix.OPCUAClient.OPCUAClient>((IUANode) this);
    }
  }
}
