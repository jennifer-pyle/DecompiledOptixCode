// Decompiled with JetBrains decompiler
// Type: FTOptix.UI.Video
// Assembly: FTOptix.UI.Net, Version=12.4.1.43, Culture=neutral, PublicKeyToken=null
// MVID: 97D6FAF1-B1FF-40AE-8E91-94665C197388
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.UI.Net\12.4.1.43\Any\FTOptix.UI.Net.dll

using FTOptix.Core;
using UAManagedCore;

#nullable disable
namespace FTOptix.UI
{
  [MapType(NamespaceUri = "urn:FTOptix:UI", Number = 372)]
  public class Video : Item
  {
    public ResourceUri Path
    {
      get => new ResourceUri(this.Refs.GetVariable(nameof (Path)).Value);
      set => this.Refs.GetVariable(nameof (Path)).SetValue((object) (string) value);
    }

    public IUAVariable PathVariable => this.Refs.GetVariable("Path");

    public bool AutoPlay
    {
      get => (bool) this.GetOptionalVariableValue(nameof (AutoPlay));
      set => this.SetOptionalVariableValue(nameof (AutoPlay), new UAValue(value));
    }

    public IUAVariable AutoPlayVariable => this.GetOrCreateVariable("AutoPlay");

    public bool Muted
    {
      get => (bool) this.GetOptionalVariableValue(nameof (Muted));
      set => this.SetOptionalVariableValue(nameof (Muted), new UAValue(value));
    }

    public IUAVariable MutedVariable => this.GetOrCreateVariable("Muted");

    public int Loops
    {
      get => (int) this.GetOptionalVariableValue(nameof (Loops));
      set => this.SetOptionalVariableValue(nameof (Loops), new UAValue(value));
    }

    public IUAVariable LoopsVariable => this.GetOrCreateVariable("Loops");

    public void Play() => this.ExecuteMethod(nameof (Play));

    public IUAMethod PlayMethod => this.Refs.GetMethod("Play");

    public void Pause() => this.ExecuteMethod(nameof (Pause));

    public IUAMethod PauseMethod => this.Refs.GetMethod("Pause");

    public void Stop() => this.ExecuteMethod(nameof (Stop));

    public IUAMethod StopMethod => this.Refs.GetMethod("Stop");
  }
}
