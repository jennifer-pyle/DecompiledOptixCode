// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.DynamicLinkPath
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using System.Runtime.CompilerServices;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public static class DynamicLinkPath
  {
    public static string MakeAbsolutePath(IUANode target)
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
      interpolatedStringHandler.AppendLiteral("{NodeId:ns=");
      interpolatedStringHandler.AppendFormatted<int>(target.NodeId.NamespaceIndex);
      interpolatedStringHandler.AppendLiteral(";");
      interpolatedStringHandler.AppendFormatted(target.NodeId.IdTypeShortString);
      interpolatedStringHandler.AppendLiteral("=");
      interpolatedStringHandler.AppendFormatted<object>(target.NodeId.Id);
      interpolatedStringHandler.AppendLiteral("}");
      return interpolatedStringHandler.ToStringAndClear();
    }

    public static string MakeRelativePath(IUANode startNode, IUANode targetNode)
    {
      RelativeNodePathResult pathBetweenNodes = RelativeNodePath.FindRelativePathBetweenNodes(startNode, targetNode);
      return pathBetweenNodes.Type == RelativeNodePathType.OnOwnHierarchy || pathBetweenNodes.Type == RelativeNodePathType.OnParallelHierarchy ? pathBetweenNodes.Path : (string) null;
    }

    public static string MakePath(IUANode startNode, IUANode targetNode)
    {
      return DynamicLinkPath.MakeRelativePath(startNode, targetNode) ?? DynamicLinkPath.MakeAbsolutePath(targetNode);
    }
  }
}
