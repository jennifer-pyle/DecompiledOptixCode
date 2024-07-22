// Decompiled with JetBrains decompiler
// Type: UAManagedCore.Ext.Objects
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

#nullable disable
namespace UAManagedCore.Ext
{
  public static class Objects
  {
    public const int UsersFolderId = 44;
    public const int RootUserId = 45;
    public const int AnonymousUserId = 46;
    public const int SessionsFolderId = 47;
    public const int LocalizationDictionariesId = 50;
    public const int CoreCommandsId = 29;
    public static readonly NodeId UsersFolder = new NodeId(2, 44U);
    public static readonly NodeId RootUser = new NodeId(2, 45U);
    public static readonly NodeId AnonymousUser = new NodeId(2, 46U);
    public static readonly NodeId SessionsFolder = new NodeId(2, 47U);
    public static readonly NodeId LocalizationDictionaries = new NodeId(2, 50U);
    public static readonly NodeId CoreCommands = new NodeId(NamespaceMapProvider.GetNamespaceIndex("urn:FTOptix:CoreBase"), 29U);
  }
}
