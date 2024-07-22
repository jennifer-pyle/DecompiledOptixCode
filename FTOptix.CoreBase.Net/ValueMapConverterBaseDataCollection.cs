// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.ValueMapConverterDataCollection
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using System.Collections.Generic;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  public class ValueMapConverterDataCollection
  {
    private IUANode converterNode;

    public ValueMapConverterDataCollection(IUANode parentNode) => this.converterNode = parentNode;

    public void SetDictionary(Dictionary<object, object> dictionary)
    {
      IUAVariable variable;
      if (typeof (IUAObject).IsAssignableFrom(this.converterNode.GetType()))
      {
        variable = ((IUAObject) this.converterNode).GetOrCreateVariable("Data");
      }
      else
      {
        if (!typeof (IUAObjectType).IsAssignableFrom(this.converterNode.GetType()))
          return;
        variable = ((IUAObjectType) this.converterNode).GetOrCreateVariable("Data");
      }
      if (dictionary == null)
      {
        variable.Delete();
      }
      else
      {
        Struct[] structArray = new Struct[dictionary.Count];
        int num = 0;
        foreach (KeyValuePair<object, object> keyValuePair in dictionary)
          structArray[num++] = new Struct(DataTypes.ValueMapPairDataType, new object[2]
          {
            keyValuePair.Key,
            keyValuePair.Value
          });
        variable.ActualArrayDimensions = new uint[1]
        {
          (uint) dictionary.Count
        };
        variable.Value = (UAValue) structArray;
      }
    }

    public Dictionary<object, object> GetDictionary()
    {
      Dictionary<object, object> dictionary = new Dictionary<object, object>();
      IUAVariable variable = this.converterNode.Refs.GetVariable("Data");
      if (variable == null)
        return dictionary;
      foreach (Struct @struct in (Struct[]) variable.Value)
        dictionary.Add(@struct.Get(0U), @struct.Get(1U));
      return dictionary;
    }
  }
}
