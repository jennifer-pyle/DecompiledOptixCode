// Decompiled with JetBrains decompiler
// Type: UAManagedCore.RelativeNodePath
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  public static class RelativeNodePath
  {
    public static RelativeNodePathResult FindRelativePathBetweenNodes(
      IUANode startingNode,
      IUANode targetNode)
    {
      if (startingNode == null)
        throw new ArgumentNullException(nameof (startingNode));
      if (targetNode == null)
        throw new ArgumentNullException(nameof (targetNode));
      UANode uaNode1 = (UANode) startingNode;
      UANode uaNode2 = (UANode) targetNode;
      InteropCallResult pathBetweenNodes = RelativeNodePath.Interop.FindRelativePathBetweenNodes(ObjectMarshal.ToIntPtr((object) uaNode1.nodeHandle), ObjectMarshal.ToIntPtr((object) uaNode2.nodeHandle));
      pathBetweenNodes.CheckOutcome();
      return pathBetweenNodes.Get<RelativeNodePathResult>();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult FindRelativePathBetweenNodes(
        IntPtr startingNode,
        IntPtr targetNode);
    }
  }
}
