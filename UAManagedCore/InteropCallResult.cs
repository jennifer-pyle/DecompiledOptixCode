// Decompiled with JetBrains decompiler
// Type: UAManagedCore.InteropCallResult
// Assembly: UAManagedCore, Version=3.0.2.27, Culture=neutral, PublicKeyToken=null
// MVID: A0DFF873-0BC8-4DF9-B11C-5F469EB6460D
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Bindings\Net\3.0.2.27\Win32_x64\UAManagedCore.dll

using System;

#nullable disable
namespace UAManagedCore
{
  internal struct InteropCallResult
  {
    public IntPtr ReturnValuePtr;
    public IntPtr ExceptionPtr;

    internal InteropCallResult(IntPtr returnValuePtr)
    {
      this.ReturnValuePtr = returnValuePtr;
      this.ExceptionPtr = IntPtr.Zero;
    }

    public void CheckOutcome()
    {
      if (this.ExceptionPtr != IntPtr.Zero)
      {
        CoreException coreException = ObjectMarshal.ReleaseGCHandle<CoreException>(this.ExceptionPtr);
        this.ExceptionPtr = IntPtr.Zero;
        throw coreException;
      }
    }

    public T Get<T>() where T : class
    {
      T obj = !typeof (T).IsAssignableTo(typeof (IUANode)) ? ObjectMarshal.ReleaseGCHandle<T>(this.ReturnValuePtr) : ObjectMarshal.FromIntPtr<T>(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return obj;
    }

    public T GetStruct<T>() where T : struct
    {
      T managed = StructMarshal.ToManaged<T>(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return managed;
    }

    public T[] GetStructArray<T>() where T : struct
    {
      T[] managedArray = StructMarshal.ToManagedArray<T>(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return managedArray;
    }

    public string[] GetStringArray()
    {
      string[] managedStringArray = StringMarshal.ToManagedStringArray(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return managedStringArray;
    }

    public T[] GetArray<T>() where T : class
    {
      T[] managedArray = ArrayMarshal.ToManagedArray<T>(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return managedArray;
    }

    public string GetString()
    {
      string str = StringMarshal.ReleaseNativeString(this.ReturnValuePtr);
      this.ReturnValuePtr = IntPtr.Zero;
      return str;
    }

    public int GetInt()
    {
      int int32 = this.ReturnValuePtr.ToInt32();
      this.ReturnValuePtr = IntPtr.Zero;
      return int32;
    }

    public uint GetUInt()
    {
      uint returnValuePtr = (uint) this.ReturnValuePtr;
      this.ReturnValuePtr = IntPtr.Zero;
      return returnValuePtr;
    }

    public bool GetBool() => this.GetInt() != 0;

    public int[] GetIntArray() => ArrayMarshal.ToManagedInt32Array(this.ReturnValuePtr);

    public uint[] GetUIntArray() => ArrayMarshal.ToManagedUInt32Array(this.ReturnValuePtr);

    public DateTime GetDateTime() => (DateTime) this.Get<object>();

    public ulong GetULong()
    {
      ulong returnValuePtr = (ulong) (long) this.ReturnValuePtr;
      this.ReturnValuePtr = IntPtr.Zero;
      return returnValuePtr;
    }
  }
}
