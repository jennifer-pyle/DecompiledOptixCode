// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.MethodInvocation
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 93)]
  public class MethodInvocation : UAObject
  {
    public NodeId ObjectPointer
    {
      get => (NodeId) this.Refs.GetVariable(nameof (ObjectPointer)).Value.Value;
      set => this.Refs.GetVariable(nameof (ObjectPointer)).SetValue((object) value);
    }

    public NodePointer ObjectPointerVariable
    {
      get => (NodePointer) this.Refs.GetVariable("ObjectPointer");
    }

    public string Method
    {
      get => (string) this.Refs.GetVariable(nameof (Method)).Value.Value;
      set => this.Refs.GetVariable(nameof (Method)).SetValue((object) value);
    }

    public IUAVariable MethodVariable => this.Refs.GetVariable("Method");

    public void Invoke() => this.ExecuteMethod(nameof (Invoke));

    public IUAMethod InvokeMethod => this.Refs.GetMethod("Invoke");
  }
}
