// Decompiled with JetBrains decompiler
// Type: UAManagedCore.UAEventArgumentList
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace UAManagedCore
{
  public class UAEventArgumentList
  {
    private IReadOnlyList<object> arguments;
    private IEventArguments localIndex;

    public UAEventArgumentList(IReadOnlyList<object> args, IEventArguments index)
    {
      if (args == null)
        throw new ArgumentNullException(nameof (args));
      if (index == null)
        throw new ArgumentNullException(nameof (index));
      this.arguments = args;
      this.localIndex = index;
    }

    public object GetArgument(string name)
    {
      return this.arguments[(int) this.localIndex.GetFieldIndex(name)];
    }

    public object GetArgument(int index) => this.arguments[index];

    public IReadOnlyList<object> GetRawArguments() => this.arguments;
  }
}
