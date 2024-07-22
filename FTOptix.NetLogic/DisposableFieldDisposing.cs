// Decompiled with JetBrains decompiler
// Type: FTOptix.NetLogic.DisposableFieldDisposing
// Assembly: FTOptix.NetLogic, Version=4.0.0.10, Culture=neutral, PublicKeyToken=null
// MVID: 6466FAD9-8165-45A4-B923-20A85AEB507B
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.NetLogic\4.0.0.10\Any\FTOptix.NetLogic.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UAManagedCore;

//#nullable disable
namespace FTOptix.NetLogic
{
  internal static class DisposableFieldDisposing
  {
    public static void DisposeFields(Type classType, object callingObject)
    {
      IEnumerable<FieldInfo> fieldInfos = classType.GetRuntimeFields().Reverse<FieldInfo>();
      List<FieldInfo> fieldInfoList = new List<FieldInfo>();
      foreach (FieldInfo fieldInfo in fieldInfos)
      {
        Type[] interfaces = fieldInfo.FieldType.GetInterfaces();
        if (((IEnumerable<Type>) interfaces).Contains<Type>(typeof (IDisposable)) && !((IEnumerable<Type>) interfaces).Contains<Type>(typeof (IUANode)))
          fieldInfoList.Add(fieldInfo);
      }
      foreach (FieldInfo fieldInfo in fieldInfoList)
        ((IDisposable) fieldInfo.GetValue(callingObject))?.Dispose();
    }
  }
}
