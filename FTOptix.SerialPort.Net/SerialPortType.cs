// Decompiled with JetBrains decompiler
// Type: FTOptix.SerialPort.SerialPortType
// Assembly: FTOptix.SerialPort.Net, Version=1.0.8.38, Culture=neutral, PublicKeyToken=null
// MVID: E3264ECA-77C1-4764-A2BE-A8103A2488FF
// Assembly location: C:\Program Files\Rockwell Automation\FactoryTalk Optix\Studio 1.5.0.221\Modules\FTOptix.SerialPort.Net\1.0.8.38\Any\FTOptix.SerialPort.Net.dll

using FTOptix.CommunicationDriver;
using System;
using System.Text;
using UAManagedCore;

#nullable disable
namespace FTOptix.SerialPort
{
  [MapType(NamespaceUri = "urn:FTOptix:SerialPort", Number = 1)]
  public class SerialPortType : UAObjectType
  {
    private readonly Encoding encoding = (Encoding) new ASCIIEncoding();
    private string newLine = "\n";

    public string PortName
    {
      get => (string) this.Refs.GetVariable(nameof (PortName)).Value.Value;
      set => this.Refs.GetVariable(nameof (PortName)).SetValue((object) value);
    }

    public IUAVariable PortNameVariable => this.Refs.GetVariable("PortName");

    public uint Baudrate
    {
      get => (uint) this.Refs.GetVariable(nameof (Baudrate)).Value.Value;
      set => this.Refs.GetVariable(nameof (Baudrate)).SetValue((object) value);
    }

    public IUAVariable BaudrateVariable => this.Refs.GetVariable("Baudrate");

    public byte DataSize
    {
      get => (byte) this.Refs.GetVariable(nameof (DataSize)).Value.Value;
      set => this.Refs.GetVariable(nameof (DataSize)).SetValue((object) value);
    }

    public IUAVariable DataSizeVariable => this.Refs.GetVariable("DataSize");

    public Parity Parity
    {
      get => (Parity) (int) this.Refs.GetVariable(nameof (Parity)).Value;
      set => this.Refs.GetVariable(nameof (Parity)).SetValue((object) (int) value);
    }

    public IUAVariable ParityVariable => this.Refs.GetVariable("Parity");

    public StopBits StopBits
    {
      get => (StopBits) (int) this.Refs.GetVariable(nameof (StopBits)).Value;
      set => this.Refs.GetVariable(nameof (StopBits)).SetValue((object) (int) value);
    }

    public IUAVariable StopBitsVariable => this.Refs.GetVariable("StopBits");

    public FlowControl FlowControl
    {
      get => (FlowControl) (int) this.Refs.GetVariable(nameof (FlowControl)).Value;
      set => this.Refs.GetVariable(nameof (FlowControl)).SetValue((object) (int) value);
    }

    public IUAVariable FlowControlVariable => this.Refs.GetVariable("FlowControl");

    public CommunicationStatus CommunicationStatus
    {
      get => (CommunicationStatus) (int) this.Refs.GetVariable(nameof (CommunicationStatus)).Value;
    }

    public IUAVariable CommunicationStatusVariable => this.Refs.GetVariable("CommunicationStatus");

    public TimeSpan Timeout
    {
      get
      {
        return TimeSpan.FromMilliseconds((double) this.Refs.GetVariable(nameof (Timeout)).Value.Value);
      }
      set => this.Refs.GetVariable(nameof (Timeout)).SetValue((object) value.TotalMilliseconds);
    }

    public IUAVariable TimeoutVariable => this.Refs.GetVariable("Timeout");

    public bool LowLatency
    {
      get => (bool) this.GetOptionalVariableValue(nameof (LowLatency));
      set => this.SetOptionalVariableValue(nameof (LowLatency), new UAValue(value));
    }

    public IUAVariable LowLatencyVariable => this.GetOrCreateVariable("LowLatency");

    public string NewLine
    {
      get => this.newLine;
      set
      {
        this.newLine = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof (NewLine));
      }
    }

    public void Open() => this.ExecuteMethod(nameof (Open));

    public IUAMethod OpenMethod => this.Refs.GetMethod("Open");

    public void Close() => this.ExecuteMethod(nameof (Close));

    public IUAMethod CloseMethod => this.Refs.GetMethod("Close");

    public byte[] ReadBytes(uint count)
    {
      object[] outputArgs = new object[0];
      try
      {
        ((IUAObject) this).ExecuteMethod("Read", new object[1]
        {
          (object) count
        }, out outputArgs);
      }
      catch (CoreException ex)
      {
        this.ThrowReadCanceledException(ex);
        throw;
      }
      return (byte[]) outputArgs[0];
    }

    public char[] ReadChars(uint count)
    {
      return this.encoding.GetString(this.ReadBytes(count)).ToCharArray();
    }

    public byte ReadByte() => this.ReadBytes(1U)[0];

    public char ReadChar() => this.ReadChars(1U)[0];

    public string ReadLine() => this.encoding.GetString(this.ReadBytesUntil(this.newLine));

    public IUAMethod ReadMethod => this.Refs.GetMethod("Read");

    public byte[] ReadBytesUntil(string delimiter)
    {
      object[] outputArgs = new object[0];
      try
      {
        ((IUAObject) this).ExecuteMethod("ReadUntil", new object[1]
        {
          (object) delimiter
        }, out outputArgs);
      }
      catch (CoreException ex)
      {
        this.ThrowReadCanceledException(ex);
        throw;
      }
      return (byte[]) outputArgs[0];
    }

    public char[] ReadCharsUntil(string delimiter)
    {
      return this.encoding.GetString(this.ReadBytesUntil(delimiter)).ToCharArray();
    }

    public IUAMethod ReadUntilMethod => this.Refs.GetMethod("ReadUntil");

    public void WriteBytes(byte[] buffer)
    {
      this.ExecuteMethod("Write", new object[1]
      {
        (object) buffer
      });
    }

    public void WriteChars(char[] buffer)
    {
      this.ExecuteMethod("Write", new object[1]
      {
        (object) this.encoding.GetBytes(buffer)
      });
    }

    public void WriteLine(string text) => this.WriteChars((text + this.newLine).ToCharArray());

    public IUAMethod WriteMethod => this.Refs.GetMethod("Write");

    public void CancelRead() => this.ExecuteMethod(nameof (CancelRead));

    public IUAMethod CancelReadMethod => this.Refs.GetMethod("CancelRead");

    private void ThrowReadCanceledException(CoreException ex)
    {
      if (ex.ErrorCode == (ushort) 8)
        throw new ReadCanceledException(ex.Message);
    }

    public InstanceNodeCollection<FTOptix.SerialPort.SerialPort> Instances
    {
      get => new InstanceNodeCollection<FTOptix.SerialPort.SerialPort>((IUANode) this);
    }
  }
}
