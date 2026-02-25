namespace System.IO;

[Token(Token = "0x200063C")]
public class UnmanagedMemoryStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001941")]
	private SafeBuffer _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001942")]
	private Byte* _mem; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001943")]
	private long _length; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001944")]
	private long _capacity; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001945")]
	private long _position; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001946")]
	private long _offset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001947")]
	private FileAccess _access; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001948")]
	internal bool _isOpen; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001949")]
	private Task<Int32> _lastReadTask; //Field offset: 0x60

	[Token(Token = "0x17000710")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x146D840", Offset = "0x146CA40", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002DB6")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000711")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x146D850", Offset = "0x146CA50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002DB7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000712")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x146D860", Offset = "0x146CA60", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002DB8")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000713")]
	public virtual long Length
	{
		[Address(RVA = "0x146D880", Offset = "0x146CA80", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002DBE")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000714")]
	public virtual long Position
	{
		[Address(RVA = "0x146D9C0", Offset = "0x146CBC0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DBF")]
		 get { } //Length: 81
		[Address(RVA = "0x146DA20", Offset = "0x146CC20", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DC0")]
		 set { } //Length: 193
	}

	[CLSCompliant(False)]
	[Token(Token = "0x17000715")]
	public Byte* PositionPointer
	{
		[Address(RVA = "0x146D8D0", Offset = "0x146CAD0", Length = "0xE8")]
		[CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
		[Token(Token = "0x6002DC1")]
		 get { } //Length: 232
	}

	[Address(RVA = "0x146D7E0", Offset = "0x146C9E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002DB2")]
	protected UnmanagedMemoryStream() { }

	[Address(RVA = "0x146D750", Offset = "0x146C950", Length = "0x85")]
	[CalledBy(Type = typeof(UnmanagedMemoryStreamForModule), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Module)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(long), typeof(FileAccess)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6002DB3")]
	public UnmanagedMemoryStream(Byte* pointer, long length) { }

	[Address(RVA = "0x146D6C0", Offset = "0x146C8C0", Length = "0x89")]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(long), typeof(FileAccess)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6002DB4")]
	public UnmanagedMemoryStream(Byte* pointer, long length, long capacity, FileAccess access) { }

	[Address(RVA = "0x146B440", Offset = "0x146A640", Length = "0xD")]
	[CalledBy(Type = typeof(UnmanagedMemoryStreamForModule), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002DB9")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x146B450", Offset = "0x146A650", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DBA")]
	private void EnsureNotClosed() { }

	[Address(RVA = "0x146B490", Offset = "0x146A690", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DBB")]
	private void EnsureReadable() { }

	[Address(RVA = "0x146B4E0", Offset = "0x146A6E0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DBC")]
	private void EnsureWriteable() { }

	[Address(RVA = "0x146B450", Offset = "0x146A650", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002DBD")]
	public virtual void Flush() { }

	[Address(RVA = "0x146D840", Offset = "0x146CA40", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002DB6")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x146D850", Offset = "0x146CA50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002DB7")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x146D860", Offset = "0x146CA60", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002DB8")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x146D880", Offset = "0x146CA80", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002DBE")]
	public virtual long get_Length() { }

	[Address(RVA = "0x146D9C0", Offset = "0x146CBC0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DBF")]
	public virtual long get_Position() { }

	[Address(RVA = "0x146D8D0", Offset = "0x146CAD0", Length = "0xE8")]
	[CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Token(Token = "0x6002DC1")]
	public Byte* get_PositionPointer() { }

	[Address(RVA = "0x146B530", Offset = "0x146A730", Length = "0x282")]
	[CalledBy(Type = typeof(PinnedBufferMemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(long), typeof(FileAccess)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6002DB5")]
	protected void Initialize(Byte* pointer, long length, long capacity, FileAccess access) { }

	[Address(RVA = "0x146C2A0", Offset = "0x146B4A0", Length = "0x214")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002DC2")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x146C1F0", Offset = "0x146B3F0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002DC3")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x146B7C0", Offset = "0x146A9C0", Length = "0x2FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002DC6")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x146BAC0", Offset = "0x146ACC0", Length = "0x301")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "get_Result", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002DC5")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x146BDD0", Offset = "0x146AFD0", Length = "0x18B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FD30")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DC7")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x146BF60", Offset = "0x146B160", Length = "0x283")]
	[CalledBy(Type = typeof(PinnedBufferMemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FD30")]
	[Calls(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DC4")]
	internal int ReadCore(Span<Byte> buffer) { }

	[Address(RVA = "0x146C4C0", Offset = "0x146B6C0", Length = "0x1D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002DC8")]
	public virtual long Seek(long offset, SeekOrigin loc) { }

	[Address(RVA = "0x146DA20", Offset = "0x146CC20", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DC0")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x146C6A0", Offset = "0x146B8A0", Length = "0x1EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Buffer), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DC9")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x146D3C0", Offset = "0x146C5C0", Length = "0x245")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002DCA")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x146D610", Offset = "0x146C810", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002DCB")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x146C890", Offset = "0x146BA90", Length = "0x288")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181450470")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002DCD")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x146CB20", Offset = "0x146BD20", Length = "0x256")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002DCE")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x146CD80", Offset = "0x146BF80", Length = "0x291")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FD30")]
	[Calls(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DCF")]
	public virtual void WriteByte(byte value) { }

	[Address(RVA = "0x146D020", Offset = "0x146C220", Length = "0x398")]
	[CalledBy(Type = typeof(PinnedBufferMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18144FD30")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002DCC")]
	internal void WriteCore(ReadOnlySpan<Byte> buffer) { }

}

