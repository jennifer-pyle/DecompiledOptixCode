// Decompiled with JetBrains decompiler
// Type: ConverterExtensions
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using FTOptix.CoreBase;
using UAManagedCore;

#nullable disable
public static class ConverterExtensions
{
  public static void SetConverter(this IUAVariable variable, Converter converter)
  {
    variable.Refs.GetNode(ReferenceTypes.HasConverter, false)?.Delete();
    variable.Refs.GetVariable(ReferenceTypes.HasDynamicLink, false)?.Delete();
    if (converter == null)
      return;
    variable.Refs.AddReference(ReferenceTypes.HasConverter, (IUANode) converter);
    converter.SetModellingRuleRecursive();
    if (variable.Status != NodeStatus.Started)
      return;
    converter.Start(true);
  }
}
