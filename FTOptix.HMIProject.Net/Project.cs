// Decompiled with JetBrains decompiler
// Type: FTOptix.HMIProject.Project
// Assembly: FTOptix.HMIProject.Net, Version=4.4.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 4C1C2AE5-CD7D-409F-9220-4FEA072F8BAA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.HMIProject.Net\4.4.2.38\Any\FTOptix.HMIProject.Net.dll

using System;
using System.Linq;
using UAManagedCore;

#nullable disable
namespace FTOptix.HMIProject
{
  public static class Project
  {
    private static ProjectFolder current;

    public static ProjectFolder Current
    {
      get
      {
        if (Project.current == null || !Project.current.IsValid)
        {
          if (ManagedContextStore.Context == null)
            return (ProjectFolder) null;
          ProjectFolderType objectType = InformationModel.GetObjectType<ProjectFolderType>();
          InstanceNodeCollection<ProjectFolder> instances = objectType.Instances;
          Project.current = instances.Count<ProjectFolder>() != 1 ? objectType.Instances.FirstOrDefault<ProjectFolder>((Func<ProjectFolder, bool>) (p => p.NodeId.NamespaceIndex == ManagedContextStore.Context.DefaultNamespaceIndex)) : instances.First<ProjectFolder>();
        }
        return Project.current;
      }
    }
  }
}
