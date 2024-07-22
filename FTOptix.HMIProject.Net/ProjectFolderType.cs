// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.ProjectFolderType
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using FTOptix.Core;
using System;
using System.ComponentModel;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  [MapType(NamespaceUri = "urn:FTOptix:HMIProject", Number = 6)]
  public class ProjectFolderType : UAObjectType
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Localization object instead.")]
    public string[] Locales
    {
      get => this.Localization.Locales;
      set => this.Localization.Locales = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Localization object instead.")]
    public IUAVariable LocalesVariable => this.Localization.LocalesVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Localization object instead.")]
    public string[] LocaleFallbackList
    {
      get => this.Localization.LocaleFallbackList;
      set => this.Localization.LocaleFallbackList = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Localization object instead.")]
    public IUAVariable LocaleFallbackListVariable => this.Localization.LocaleFallbackListVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the AlarmConfiguration object instead.")]
    public bool BranchingEnabled
    {
      get => this.AlarmConfiguration.BranchingEnabled;
      set => this.AlarmConfiguration.BranchingEnabled = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the AlarmConfiguration object instead.")]
    public IUAVariable BranchingEnabledVariable => this.AlarmConfiguration.BranchingEnabledVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Authentication object instead.")]
    public AuthenticationMode AuthenticationMode
    {
      get => this.Authentication.AuthenticationMode;
      set => this.Authentication.AuthenticationMode = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Authentication object instead.")]
    public IUAVariable AuthenticationModeVariable => this.Authentication.AuthenticationModeVariable;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Authentication object instead.")]
    public NodeId DefaultUserFolder
    {
      get => this.Authentication.DefaultUserFolder;
      set => this.Authentication.DefaultUserFolder = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Please access the Authentication object instead.")]
    public NodePointer DefaultUserFolderVariable => this.Authentication.DefaultUserFolderVariable;

    public Localization Localization
    {
      get => new Localization((PropertyGroup) this.Refs.GetObject(nameof (Localization)));
    }

    public Authentication Authentication
    {
      get => new Authentication((PropertyGroup) this.Refs.GetObject(nameof (Authentication)));
    }

    public PasswordPolicy PasswordPolicy
    {
      get => (PasswordPolicy) this.Refs.GetObject(nameof (PasswordPolicy));
    }

    public AlarmConfiguration AlarmConfiguration
    {
      get
      {
        return new AlarmConfiguration((PropertyGroup) this.Refs.GetObject(nameof (AlarmConfiguration)));
      }
    }

    public InstanceNodeCollection<ProjectFolder> Instances
    {
      get => new InstanceNodeCollection<ProjectFolder>((IUANode) this);
    }
  }
}
