// Decompiled with JetBrains decompiler
// Type: UAManagedCore.SessionInfo
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public struct SessionInfo : ISessionInfo
  {
    public SessionInfo(
      IUAObject sessionObject,
      IUAObject user,
      bool isRootUser,
      string actualLocaleId)
    {
      this.SessionObject = sessionObject;
      this.User = user;
      this.IsRootUser = isRootUser;
      this.ActualLocaleId = actualLocaleId;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUAObject SessionObject { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IUAObject User { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsRootUser { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ActualLocaleId { get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsEmpty => this.SessionObject == null;
  }
}
