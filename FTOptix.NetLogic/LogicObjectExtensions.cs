﻿// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.LogicObjectExtensions
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using UAManagedCore;

//#nullable disable
namespace FTOptix.NetLogic
{
  internal static class LogicObjectExtensions
  {
    public static bool IsDesignTimeScript(this IUANode node)
    {
      return node is NetLogicObject netLogicObject && netLogicObject.IsDesignTimeScript;
    }
  }
}
