// Decompiled with JetBrains decompiler
// Type: FTOptix.OPCUAServer.OPCUAServer
// Assembly: FTOptix.OPCUAServer.Net, Version=1.1.4.39, Culture=neutral, PublicKeyToken=null
// MVID: 8FF3501A-13A0-4017-8C9B-45AF38532B2C
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.OPCUAServer.Net\1.1.4.39\Any\FTOptix.OPCUAServer.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.OPCUAServer
{
  [MapType(NamespaceUri = "urn:FTOptix:OPCUAServer", Number = 1)]
  public class OPCUAServer : UAObject
  {
    public ResourceUri EndpointURL
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (EndpointURL)).Value);
      set => this.Refs.GetVariable(nameof (EndpointURL)).SetValue((object) (string) value);
    }

    public IUAVariable EndpointURLVariable => this.Refs.GetVariable("EndpointURL");

    public PlaceholderChildNodeCollection<NodesToPublishConfigurationEntry> NodesToPublish
    {
      get
      {
        return new PlaceholderChildNodeCollection<NodesToPublishConfigurationEntry>((IUANode) this, nameof (NodesToPublish));
      }
    }

    public bool AllowMultipleConnection
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AllowMultipleConnection));
      set => this.SetOptionalVariableValue(nameof (AllowMultipleConnection), new UAValue(value));
    }

    public IUAVariable AllowMultipleConnectionVariable
    {
      get => this.GetOrCreateVariable("AllowMultipleConnection");
    }

    public bool UseNodePathInNodeIds
    {
      get => (bool) this.GetOptionalVariableValue(nameof (UseNodePathInNodeIds));
      set => this.SetOptionalVariableValue(nameof (UseNodePathInNodeIds), new UAValue(value));
    }

    public IUAVariable UseNodePathInNodeIdsVariable
    {
      get => this.GetOrCreateVariable("UseNodePathInNodeIds");
    }

    public double SamplingInterval
    {
      get => (double) this.GetOptionalVariableValue(nameof (SamplingInterval));
      set => this.SetOptionalVariableValue(nameof (SamplingInterval), new UAValue(value));
    }

    public IUAVariable SamplingIntervalVariable => this.GetOrCreateVariable("SamplingInterval");

    public int MaxArrayLength
    {
      get => (int) this.GetOptionalVariableValue(nameof (MaxArrayLength));
      set => this.SetOptionalVariableValue(nameof (MaxArrayLength), new UAValue(value));
    }

    public IUAVariable MaxArrayLengthVariable => this.GetOrCreateVariable("MaxArrayLength");

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

    public ResourceUri ServerCertificateFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ServerCertificateFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (ServerCertificateFile), new UAValue((string) value));
      }
    }

    public IUAVariable ServerCertificateFileVariable
    {
      get => this.GetOrCreateVariable("ServerCertificateFile");
    }

    public ResourceUri ServerPrivateKeyFile
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ServerPrivateKeyFile)));
      set
      {
        this.SetOptionalVariableValue(nameof (ServerPrivateKeyFile), new UAValue((string) value));
      }
    }

    public IUAVariable ServerPrivateKeyFileVariable
    {
      get => this.GetOrCreateVariable("ServerPrivateKeyFile");
    }

    public string ProductURI
    {
      get => (string) this.GetOptionalVariableValue(nameof (ProductURI));
      set => this.SetOptionalVariableValue(nameof (ProductURI), new UAValue(value));
    }

    public IUAVariable ProductURIVariable => this.GetOrCreateVariable("ProductURI");

    public string ProductName
    {
      get => (string) this.GetOptionalVariableValue(nameof (ProductName));
      set => this.SetOptionalVariableValue(nameof (ProductName), new UAValue(value));
    }

    public IUAVariable ProductNameVariable => this.GetOrCreateVariable("ProductName");

    public string ManufacturerName
    {
      get => (string) this.GetOptionalVariableValue(nameof (ManufacturerName));
      set => this.SetOptionalVariableValue(nameof (ManufacturerName), new UAValue(value));
    }

    public IUAVariable ManufacturerNameVariable => this.GetOrCreateVariable("ManufacturerName");
  }
}
