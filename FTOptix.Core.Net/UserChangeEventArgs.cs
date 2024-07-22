// Decompiled with JetBrains decompiler
// Type: FTOptix.Core.UserChangeEventArgs
// Assembly: FTOptix.Core.Net, Version=1.2.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 515E50DC-D308-4C4A-AF2D-F3A6281282AA
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.Core.Net\1.2.2.38\Any\FTOptix.Core.Net.dll

using System;

#nullable disable
namespace FTOptix.Core
{
  public class UserChangeEventArgs : EventArgs
  {
    public UserChangeEventArgs(User newUser, User oldUser)
    {
      this.newUser = newUser;
      this.oldUser = oldUser;
    }

    public User newUser { get; }

    public User oldUser { get; }
  }
}
