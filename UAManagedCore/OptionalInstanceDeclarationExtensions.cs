// Decompiled with JetBrains decompiler
// Type: UAManagedCore.OptionalInstanceDeclarationExtensions
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

#nullable disable
namespace UAManagedCore
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class OptionalInstanceDeclarationExtensions
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAVariable GetOrCreateVariable(this IUAObject obj, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult variable = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateVariable((IntPtr) ((UANode) obj).nodeHandle, name);
      variable.CheckOutcome();
      return (IUAVariable) variable.Get<UAVariable>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAVariable GetOrCreateVariable(this IUAVariable variable, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult variable1 = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateVariable((IntPtr) ((UANode) variable).nodeHandle, name);
      variable1.CheckOutcome();
      return (IUAVariable) variable1.Get<UAVariable>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAVariable GetOrCreateVariable(this IUAObjectType objectType, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult variable = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateVariable((IntPtr) ((UANode) objectType).nodeHandle, name);
      variable.CheckOutcome();
      return (IUAVariable) variable.Get<UAVariable>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAVariable GetOrCreateVariable(this IUAVariableType variableType, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult variable = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateVariable((IntPtr) ((UANode) variableType).nodeHandle, name);
      variable.CheckOutcome();
      return (IUAVariable) variable.Get<UAVariable>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAObject GetOrCreateObject(this IUAObject obj, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult interopCallResult = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateObject((IntPtr) ((UANode) obj).nodeHandle, name);
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAObject GetOrCreateObject(this IUAVariable variable, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult interopCallResult = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateObject((IntPtr) ((UANode) variable).nodeHandle, name);
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAObject GetOrCreateObject(this IUAObjectType objectType, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult interopCallResult = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateObject((IntPtr) ((UANode) objectType).nodeHandle, name);
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IUAObject GetOrCreateObject(this IUAVariableType variableType, string name)
    {
      Debugger.NotifyOfCrossThreadDependency();
      InteropCallResult interopCallResult = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOrCreateObject((IntPtr) ((UANode) variableType).nodeHandle, name);
      interopCallResult.CheckOutcome();
      return (IUAObject) interopCallResult.Get<UAObject>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static UAValue GetOptionalVariableValue(this IUAObject obj, string name)
    {
      InteropCallResult optionalVariableValue = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOptionalVariableValue((IntPtr) ((UANode) obj).nodeHandle, name);
      optionalVariableValue.CheckOutcome();
      return optionalVariableValue.Get<UAValue>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static UAValue GetOptionalVariableValue(this IUAVariable variable, string name)
    {
      InteropCallResult optionalVariableValue = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOptionalVariableValue((IntPtr) ((UANode) variable).nodeHandle, name);
      optionalVariableValue.CheckOutcome();
      return optionalVariableValue.Get<UAValue>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static UAValue GetOptionalVariableValue(this IUAObjectType objectType, string name)
    {
      InteropCallResult optionalVariableValue = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOptionalVariableValue((IntPtr) ((UANode) objectType).nodeHandle, name);
      optionalVariableValue.CheckOutcome();
      return optionalVariableValue.Get<UAValue>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static UAValue GetOptionalVariableValue(this IUAVariableType variableType, string name)
    {
      InteropCallResult optionalVariableValue = OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsGetOptionalVariableValue((IntPtr) ((UANode) variableType).nodeHandle, name);
      optionalVariableValue.CheckOutcome();
      return optionalVariableValue.Get<UAValue>();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void SetOptionalVariableValue(this IUAObject obj, string name, UAValue value)
    {
      OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsSetOptionalVariableValue((IntPtr) ((UANode) obj).nodeHandle, name, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void SetOptionalVariableValue(
      this IUAVariable variable,
      string name,
      UAValue value)
    {
      OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsSetOptionalVariableValue((IntPtr) ((UANode) variable).nodeHandle, name, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void SetOptionalVariableValue(
      this IUAObjectType objectType,
      string name,
      UAValue value)
    {
      OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsSetOptionalVariableValue((IntPtr) ((UANode) objectType).nodeHandle, name, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void SetOptionalVariableValue(
      this IUAVariableType variableType,
      string name,
      UAValue value)
    {
      OptionalInstanceDeclarationExtensions.Interop.OptionalInstanceDeclarationExtensionsSetOptionalVariableValue((IntPtr) ((UANode) variableType).nodeHandle, name, ObjectMarshal.ToIntPtr((object) value)).CheckOutcome();
    }

    private static class Interop
    {
      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult OptionalInstanceDeclarationExtensionsGetOrCreateVariable(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string name);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult OptionalInstanceDeclarationExtensionsGetOrCreateObject(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string name);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult OptionalInstanceDeclarationExtensionsGetOptionalVariableValue(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string name);

      [DllImport("Net", CallingConvention = (CallingConvention) 2)]
      internal static extern InteropCallResult OptionalInstanceDeclarationExtensionsSetOptionalVariableValue(
        IntPtr nodeHandle,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (StringMarshaler)), In] string name,
        IntPtr value);
    }
  }
}
