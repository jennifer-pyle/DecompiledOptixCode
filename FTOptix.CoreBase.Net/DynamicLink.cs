// Decompiled with JetBrains decompiler
// Type: FTOptix.CoreBase.DynamicLink
// Assembly: FTOptix.CoreBase.Net, Version=1.1.2.38, Culture=neutral, PublicKeyToken=null
// MVID: 39150466-86BC-4FA2-94E1-3CB2615A295F
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.DataLogger.Net\1.0.8.40\Any\FTOptix.CoreBase.Net.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UAManagedCore;

#nullable disable
namespace FTOptix.CoreBase
{
  [MapType(NamespaceUri = "urn:FTOptix:CoreBase", Number = 9)]
  public class DynamicLink : UAVariable
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Array indexes can now be directly specified inside node paths.")]
    public uint[] SourceArrayIndex
    {
      get
      {
        string str = (string) this.Value;
        int num1 = str.LastIndexOf('[');
        int num2 = str.LastIndexOf(']');
        if (num1 == -1 || num2 == -1)
          return new uint[0];
        string[] strArray = str.Substring(num1 + 1, num2 - num1 - 1).Split(',');
        uint[] sourceArrayIndex = new uint[strArray.Length];
        for (int index = 0; index < strArray.Length; ++index)
          sourceArrayIndex[index] = uint.Parse(strArray[index]);
        return sourceArrayIndex;
      }
      set
      {
        string str1 = (string) this.Value;
        int startIndex = str1.LastIndexOf('[');
        if (startIndex != -1)
          str1 = str1.Substring(startIndex);
        if (value.Length != 0)
        {
          string str2 = str1;
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
          interpolatedStringHandler.AppendLiteral("[");
          interpolatedStringHandler.AppendFormatted<uint>(value[0]);
          string stringAndClear1 = interpolatedStringHandler.ToStringAndClear();
          string str3 = str2 + stringAndClear1;
          for (int index = 1; index < value.Length; ++index)
          {
            string str4 = str3;
            interpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
            interpolatedStringHandler.AppendLiteral(",");
            interpolatedStringHandler.AppendFormatted<uint>(value[index]);
            string stringAndClear2 = interpolatedStringHandler.ToStringAndClear();
            str3 = str4 + stringAndClear2;
          }
          str1 = str3 + "]";
        }
        this.SetValue((object) str1);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available. Array indexes can now be directly specified inside node paths.")]
    public uint SourceScalarIndex
    {
      set
      {
        string str = (string) this.Value;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
        interpolatedStringHandler.AppendLiteral("[");
        interpolatedStringHandler.AppendFormatted<uint>(value);
        interpolatedStringHandler.AppendLiteral("]");
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        this.SetValue((object) (str + stringAndClear));
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This property is no longer available.", true)]
    public IUAVariable SourceArrayIndexVariable => (IUAVariable) null;

    public uint[] ParentArrayIndex
    {
      get
      {
        object parentArrayIndex = this.GetOptionalVariableValue(nameof (ParentArrayIndex)).Value;
        if (parentArrayIndex == null || parentArrayIndex.GetType().IsArray)
          return (uint[]) parentArrayIndex;
        return new uint[1]{ (uint) parentArrayIndex };
      }
      set => this.SetOptionalVariableValue(nameof (ParentArrayIndex), new UAValue(value));
    }

    public uint ParentScalarIndex
    {
      set
      {
        this.SetOptionalVariableValue("ParentArrayIndex", new UAValue(new uint[1]
        {
          value
        }));
      }
    }

    public IUAVariable ParentArrayIndexVariable => this.GetOrCreateVariable("ParentArrayIndex");

    public DynamicLinkMode Mode
    {
      get => (DynamicLinkMode) (int) this.GetOptionalVariableValue(nameof (Mode));
      set => this.SetOptionalVariableValue(nameof (Mode), new UAValue((int) value));
    }

    public IUAVariable ModeVariable => this.GetOrCreateVariable("Mode");

    public bool IsPull
    {
      get => (bool) this.GetOptionalVariableValue(nameof (IsPull));
      set => this.SetOptionalVariableValue(nameof (IsPull), new UAValue(value));
    }

    public IUAVariable IsPullVariable => this.GetOrCreateVariable("IsPull");

    public DynamicLinkEUMode EUMode
    {
      get => (DynamicLinkEUMode) (int) this.GetOptionalVariableValue(nameof (EUMode));
      set => this.SetOptionalVariableValue(nameof (EUMode), new UAValue((int) value));
    }

    public IUAVariable EUModeVariable => this.GetOrCreateVariable("EUMode");

    public override void SetModellingRuleRecursive()
    {
      IUANode owner = this.Owner;
      if (owner == null || owner.ModellingRule == NamingRuleType.None)
        return;
      if (owner.ModellingRule == NamingRuleType.Optional)
        owner.ModellingRule = NamingRuleType.Mandatory;
      this.ModellingRule = owner.ModellingRule;
      foreach (IUANode ownedNode in (IEnumerable<IUANode>) this.GetOwnedNodes())
      {
        ownedNode.ModellingRule = NamingRuleType.Mandatory;
        ownedNode.SetModellingRuleRecursive();
      }
    }
  }
}
