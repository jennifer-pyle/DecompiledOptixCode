// Decompiled with JetBrains decompiler
// Type: UAManagedCore.TransactionObserverType
// Assembly: UAManagedCoreCommon, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: 112CBBC4-199A-41CD-AD80-B5EB5D2D335E
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCoreCommon.dll

using System;
using System.ComponentModel;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Flags]
  public enum TransactionObserverType : ulong
  {
    FirstType = 1,
    StartTransaction = FirstType, // 0x0000000000000001
    BeforeCommitTransaction = 2,
    AfterCommitTransaction = 4,
    AbortTransaction = 8,
    BeforeGetVariable = 16, // 0x0000000000000010
    AfterGetVariable = 32, // 0x0000000000000020
    BeforeTrySetVariable = 64, // 0x0000000000000040
    AfterTrySetVariable = 128, // 0x0000000000000080
    VerifyVariable = 256, // 0x0000000000000100
    BeforeCommitVariable = 512, // 0x0000000000000200
    AfterCommitVariable = 1024, // 0x0000000000000400
    TryExecuteMethod = 2048, // 0x0000000000000800
    AllTypes = TryExecuteMethod | AfterCommitVariable | BeforeCommitVariable | VerifyVariable | AfterTrySetVariable | BeforeTrySetVariable | AfterGetVariable | BeforeGetVariable | AbortTransaction | AfterCommitTransaction | BeforeCommitTransaction | StartTransaction, // 0x0000000000000FFF
    TransactionVariable = AfterCommitVariable | BeforeCommitVariable | VerifyVariable | AfterTrySetVariable | BeforeTrySetVariable | AfterGetVariable | BeforeGetVariable, // 0x00000000000007F0
  }
}
