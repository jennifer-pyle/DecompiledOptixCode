// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.Authentication
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public class Authentication
  {
    private PropertyGroup authenticationObject;

    public Authentication(PropertyGroup authenticationObject)
    {
      this.authenticationObject = authenticationObject;
    }

    public PropertyGroup Object => this.authenticationObject;

    public AuthenticationMode AuthenticationMode
    {
      get
      {
        return (AuthenticationMode) this.authenticationObject.GetOptionalVariableValue(nameof (AuthenticationMode)).Value;
      }
      set
      {
        this.authenticationObject.SetOptionalVariableValue(nameof (AuthenticationMode), new UAValue((int) value));
      }
    }

    public IUAVariable AuthenticationModeVariable
    {
      get => this.authenticationObject.GetOrCreateVariable("AuthenticationMode");
    }

    public NodeId DefaultUserFolder
    {
      get
      {
        return (NodeId) this.authenticationObject.GetOptionalVariableValue(nameof (DefaultUserFolder)).Value;
      }
      set
      {
        this.authenticationObject.SetOptionalVariableValue(nameof (DefaultUserFolder), new UAValue(value));
      }
    }

    public NodePointer DefaultUserFolderVariable
    {
      get => (NodePointer) this.authenticationObject.GetOrCreateVariable("DefaultUserFolder");
    }

    public string DefaultDomainName
    {
      get
      {
        return (string) this.authenticationObject.GetOptionalVariableValue(nameof (DefaultDomainName)).Value;
      }
      set
      {
        this.authenticationObject.SetOptionalVariableValue(nameof (DefaultDomainName), new UAValue(value));
      }
    }

    public IUAVariable DefaultDomainNameVariable
    {
      get => this.authenticationObject.GetOrCreateVariable("DefaultDomainName");
    }

    public ResourceUri DomainServerAddress
    {
      get
      {
        return new ResourceUri(this.authenticationObject.GetOptionalVariableValue(nameof (DomainServerAddress)));
      }
      set
      {
        this.authenticationObject.SetOptionalVariableValue(nameof (DomainServerAddress), new UAValue((string) value));
      }
    }

    public IUAVariable DomainServerAddressVariable
    {
      get => this.authenticationObject.GetOrCreateVariable("DomainServerAddress");
    }

    public ResourceUri CACertificateFile
    {
      get
      {
        return new ResourceUri(this.authenticationObject.GetOptionalVariableValue(nameof (CACertificateFile)));
      }
      set
      {
        this.authenticationObject.SetOptionalVariableValue(nameof (CACertificateFile), new UAValue((string) value));
      }
    }

    public IUAVariable CACertificateFileVariable
    {
      get => this.authenticationObject.GetOrCreateVariable("CACertificateFile");
    }
  }
}
