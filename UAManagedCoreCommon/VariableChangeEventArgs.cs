// Decompiled with JetBrains decompiler
// Type: UAManagedCore.VariableChangeEventArgs
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;

#nullable disable
namespace UAManagedCore
{
  public class VariableChangeEventArgs : EventArgs
  {
    public VariableChangeEventArgs(
      IUAVariable variable,
      UAValue newValue,
      UAValue oldValue,
      uint[] indexes,
      ulong senderId)
    {
      this.Variable = variable;
      this.NewValue = newValue;
      this.OldValue = oldValue;
      this.Indexes = indexes;
      this.SenderId = senderId;
    }

    public IUAVariable Variable { get; }

    public UAValue NewValue { get; }

    public UAValue OldValue { get; }

    public uint[] Indexes { get; }

    public ulong SenderId { get; }
  }
}
