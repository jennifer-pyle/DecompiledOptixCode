// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.NavigationPanelItem
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 547)]
  public class NavigationPanelItem : UAObject
  {
    public string Title
    {
      get
      {
        LocalizedText localizedText = (LocalizedText) this.GetOrCreateVariable(nameof (Title)).Value;
        if (localizedText.HasTextId)
          return this.Context.LookupTranslation(localizedText).Text;
        return localizedText.HasTranslation ? localizedText.Text : string.Empty;
      }
      set
      {
        this.SetOptionalVariableValue(nameof (Title), new UAValue(new LocalizedText(NodeId.InvalidNamespaceIndex, string.Empty, value, this.Context.Sessions.CurrentSessionInfo.ActualLocaleId)));
      }
    }

    public LocalizedText LocalizedTitle
    {
      get => (LocalizedText) this.Refs.GetVariable("Title").Value.Value;
      set => this.Refs.GetVariable("Title").SetValue((object) value);
    }

    public IUAVariable TitleVariable => this.Refs.GetVariable("Title");

    public ResourceUri ImagePath
    {
      get => new ResourceUri(this.GetOptionalVariableValue(nameof (ImagePath)));
      set => this.SetOptionalVariableValue(nameof (ImagePath), new UAValue((string) value));
    }

    public IUAVariable ImagePathVariable => this.GetOrCreateVariable("ImagePath");

    public NodeId Panel
    {
      get => (NodeId) this.Refs.GetVariable(nameof (Panel)).Value.Value;
      set => this.Refs.GetVariable(nameof (Panel)).SetValue((object) value);
    }

    public NodePointer PanelVariable => (NodePointer) this.Refs.GetVariable("Panel");

    public NodeId AliasNode
    {
      get
      {
        UAValue optionalVariableValue = this.GetOptionalVariableValue(nameof (AliasNode));
        if (optionalVariableValue == (UAValue) null)
          return (NodeId) null;
        return !optionalVariableValue.GetType().IsArray ? (NodeId) optionalVariableValue : throw new InvalidOperationException("The AliasNode variable contains an array value. Please use the AliasNodeArray property instead.");
      }
      set => this.SetOptionalVariableValue(nameof (AliasNode), new UAValue(value));
    }

    public NodeId[] AliasNodeArray
    {
      get
      {
        object aliasNodeArray = this.GetOptionalVariableValue("AliasNode").Value;
        if (aliasNodeArray == null || aliasNodeArray.GetType().IsArray)
          return (NodeId[]) aliasNodeArray;
        return new NodeId[1]{ (NodeId) aliasNodeArray };
      }
      set => this.SetOptionalVariableValue("AliasNode", new UAValue(value));
    }

    public IUAVariable AliasNodeVariable => this.GetOrCreateVariable("AliasNode");

    public bool Enabled
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Enabled));
      set => this.SetOptionalVariableValue(nameof (Enabled), new UAValue(value));
    }

    public IUAVariable EnabledVariable => this.GetOrCreateVariable("Enabled");

    public bool Visible
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Visible));
      set => this.SetOptionalVariableValue(nameof (Visible), new UAValue(value));
    }

    public IUAVariable VisibleVariable => this.GetOrCreateVariable("Visible");
  }
}
