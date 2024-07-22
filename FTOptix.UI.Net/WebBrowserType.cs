// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.WebBrowserType
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 350)]
  public class WebBrowserType : ItemType
  {
    public ResourceUri URL
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (URL)).Value);
      set => this.Refs.GetVariable(nameof (URL)).SetValue((object) (string) value);
    }

    public IUAVariable URLVariable => this.Refs.GetVariable("URL");

    public bool IncognitoMode
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IncognitoMode));
      set => this.SetOptionalVariableValue(nameof (IncognitoMode), new UAValue(value));
    }

    public IUAVariable IncognitoModeVariable => this.GetOrCreateVariable("IncognitoMode");

    public string ScrollBarStyle
    {
      get => (string) this.GetOptionalVariableValue(nameof (ScrollBarStyle));
      set => this.SetOptionalVariableValue(nameof (ScrollBarStyle), new UAValue(value));
    }

    public IUAVariable ScrollBarStyleVariable => this.GetOrCreateVariable("ScrollBarStyle");

    public string CustomHeaders
    {
      get => (string) this.GetOptionalVariableValue(nameof (CustomHeaders));
      set => this.SetOptionalVariableValue(nameof (CustomHeaders), new UAValue(value));
    }

    public IUAVariable CustomHeadersVariable => this.GetOrCreateVariable("CustomHeaders");

    public bool IgnoreInvalidCAErrors
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IgnoreInvalidCAErrors));
      set => this.SetOptionalVariableValue(nameof (IgnoreInvalidCAErrors), new UAValue(value));
    }

    public IUAVariable IgnoreInvalidCAErrorsVariable
    {
      get => this.GetOrCreateVariable("IgnoreInvalidCAErrors");
    }

    public void NavigateNext() => this.ExecuteMethod(nameof (NavigateNext));

    public IUAMethod NavigateNextMethod => this.Refs.GetMethod("NavigateNext");

    public void NavigateBack() => this.ExecuteMethod(nameof (NavigateBack));

    public IUAMethod NavigateBackMethod => this.Refs.GetMethod("NavigateBack");

    public void Refresh() => this.ExecuteMethod(nameof (Refresh));

    public IUAMethod RefreshMethod => this.Refs.GetMethod("Refresh");

    public InstanceNodeCollection<WebBrowser> Instances
    {
      get => new InstanceNodeCollection<WebBrowser>((IUANode) this);
    }
  }
}
