// Decompiled with JetBrains decompiler
// Type: FTOptix.WebUI.Certificate
// Assembly: FTOptix.WebUI.Net, Version=1.2.0.52, Culture=neutral, PublicKeyToken=null
// MVID: 2B83AA5D-FBF5-48D5-A192-6929F90320F9
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.WebUI.Net\1.2.0.52\Any\FTOptix.WebUI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.WebUI
{
  public class Certificate
  {
    private PropertyGroup certificateObject;

    public Certificate(PropertyGroup certificateObject)
    {
      this.certificateObject = certificateObject;
    }

    public PropertyGroup Object => this.certificateObject;

    public ResourceUri CertificateFile
    {
      get
      {
        return new ResourceUri(this.certificateObject.GetOptionalVariableValue(nameof (CertificateFile)));
      }
      set
      {
        this.certificateObject.SetOptionalVariableValue(nameof (CertificateFile), (UAValue) (string) value);
      }
    }

    public IUAVariable CertificateFileVariable
    {
      get => this.certificateObject.GetOrCreateVariable("CertificateFile");
    }

    public ResourceUri PrivateKeyFile
    {
      get
      {
        return new ResourceUri(this.certificateObject.GetOptionalVariableValue(nameof (PrivateKeyFile)));
      }
      set
      {
        this.certificateObject.SetOptionalVariableValue(nameof (PrivateKeyFile), (UAValue) (string) value);
      }
    }

    public IUAVariable PrivateKeyFileVariable
    {
      get => this.certificateObject.GetOrCreateVariable("PrivateKeyFile");
    }
  }
}
