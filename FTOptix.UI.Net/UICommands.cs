// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.UICommands
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using System;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  public static class UICommands
  {
    public static Dialog OpenDialog(IUANode parentItem, DialogType dialogType, NodeId aliasNode = null)
    {
      switch (parentItem)
      {
        case Item parentItem1:
          return parentItem1.OpenDialog(dialogType, aliasNode);
        case Window window:
          return window.OpenDialog(dialogType, aliasNode);
        default:
          throw new ArgumentException("The parentItem argument must be an UI Item or a Window");
      }
    }

    public static Dialog OpenDialog(IUANode parentItem, DialogType dialogType, NodeId[] aliasNodes)
    {
      switch (parentItem)
      {
        case Item parentItem1:
          return parentItem1.OpenDialog(dialogType, aliasNodes);
        case Window window:
          return window.OpenDialog(dialogType, aliasNodes);
        default:
          throw new ArgumentException("The parentItem argument must be an UI Item or a Window");
      }
    }
  }
}
