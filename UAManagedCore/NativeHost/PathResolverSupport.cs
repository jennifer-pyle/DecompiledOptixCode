// Decompiled with JetBrains decompiler
// Type: UAManagedCore.NativeHost.PathResolverSupport
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore.NativeHost
{
  internal static class PathResolverSupport
  {
    public static IntPtr CreateAliasSpecification(
      IntPtr aliasVariablePtr,
      IntPtr aliasedNodePtr,
      IntPtr aliasTokenPathPtr)
    {
      return ObjectMarshal.ToIntPtr((object) new AliasSpecification(ObjectMarshal.FromIntPtr<IUAVariable>(aliasVariablePtr), ObjectMarshal.FromIntPtr<IUANode>(aliasedNodePtr), StringMarshal.StringFromIntPtr(aliasTokenPathPtr)));
    }

    public static IntPtr CreatePathResolverResult(
      IntPtr resolvedNodePtr,
      int nodePathKind,
      IntPtr aliasSpecificationPtr,
      IntPtr indexesPtr)
    {
      IUANode resolvedNode = ObjectMarshal.FromIntPtr<IUANode>(resolvedNodePtr);
      AliasSpecification aliasSpecification = ObjectMarshal.ReleaseGCHandle<AliasSpecification>(aliasSpecificationPtr);
      uint[] managedUint32Array = ArrayMarshal.ToManagedUInt32Array(indexesPtr);
      return ObjectMarshal.ToIntPtr((object) new PathResolverResult(resolvedNode, (NodePathKind) nodePathKind, aliasSpecification, managedUint32Array));
    }

    public delegate IntPtr CreateAliasSpecificationDelegate(
      IntPtr aliasVariablePtr,
      IntPtr aliasedNodePtr,
      IntPtr aliasTokenPathPtr);

    public delegate IntPtr CreatePathResolverResultDelegate(
      IntPtr resolvedNodePtr,
      int nodePathKind,
      IntPtr aliasSpecificationPtr,
      IntPtr indexesPtr);
  }
}
