namespace MoonSharp.Interpreter.IO;

[Token(Token = "0x20000C7")]
public class UndisposableStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000386")]
	private Stream m_Stream; //Field offset: 0x28

	[Token(Token = "0x1700010F")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000110")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000114")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x32F240", Offset = "0x32E440", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000111")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000112")]
	public virtual long Length
	{
		[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600085F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000113")]
	public virtual long Position
	{
		[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000860")]
		 get { } //Length: 42
		[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000861")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000115")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x32F300", Offset = "0x32E500", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086E")]
		 get { } //Length: 42
		[Address(RVA = "0x32F390", Offset = "0x32E590", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086F")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000116")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x32F330", Offset = "0x32E530", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000872")]
		 get { } //Length: 42
		[Address(RVA = "0x32F3C0", Offset = "0x32E5C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000873")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x32F170", Offset = "0x32E370", Length = "0x65")]
	[CalledBy(Type = typeof(Script), Member = "LoadStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Dump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000858")]
	public UndisposableStream(Stream stream) { }

	[Address(RVA = "0x32EEB0", Offset = "0x32E0B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000866")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x32EEF0", Offset = "0x32E0F0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000867")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085A")]
	public virtual void Close() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000859")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x32EF30", Offset = "0x32E130", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000869")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x32EF60", Offset = "0x32E160", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000868")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x32EF90", Offset = "0x32E190", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600086B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32EFC0", Offset = "0x32E1C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085E")]
	public virtual void Flush() { }

	[Address(RVA = "0x32F1E0", Offset = "0x32E3E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085B")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x32F210", Offset = "0x32E410", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085C")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x32F240", Offset = "0x32E440", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086A")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x32F270", Offset = "0x32E470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085D")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x32F2A0", Offset = "0x32E4A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600085F")]
	public virtual long get_Length() { }

	[Address(RVA = "0x32F2D0", Offset = "0x32E4D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000860")]
	public virtual long get_Position() { }

	[Address(RVA = "0x32F300", Offset = "0x32E500", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086E")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x32F330", Offset = "0x32E530", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000872")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x32EFF0", Offset = "0x32E1F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32F050", Offset = "0x32E250", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000862")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F020", Offset = "0x32E220", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086D")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x32F080", Offset = "0x32E280", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000863")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x32F360", Offset = "0x32E560", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000861")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x32F390", Offset = "0x32E590", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086F")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x32F3C0", Offset = "0x32E5C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000873")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x32F0B0", Offset = "0x32E2B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000864")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x32F0E0", Offset = "0x32E2E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000870")]
	public virtual string ToString() { }

	[Address(RVA = "0x32F140", Offset = "0x32E340", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000865")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x32F110", Offset = "0x32E310", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000871")]
	public virtual void WriteByte(byte value) { }

}

