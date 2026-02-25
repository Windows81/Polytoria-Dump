namespace System.IO.Compression;

[Token(Token = "0x20001F7")]
public class GZipStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000780")]
	private DeflateStream _deflateStream; //Field offset: 0x28

	[Token(Token = "0x17000267")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x17C0800", Offset = "0x17BFA00", Length = "0x20")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C64")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000269")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x17C0820", Offset = "0x17BFA20", Length = "0x20")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C66")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000268")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x17C0840", Offset = "0x17BFA40", Length = "0x20")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C65")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700026A")]
	public virtual long Length
	{
		[Address(RVA = "0x17C0860", Offset = "0x17BFA60", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000C67")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700026B")]
	public virtual long Position
	{
		[Address(RVA = "0x17C08B0", Offset = "0x17BFAB0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000C68")]
		 get { } //Length: 78
		[Address(RVA = "0x17C0900", Offset = "0x17BFB00", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000C69")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x17C05B0", Offset = "0x17BF7B0", Length = "0xB6")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "DecompressString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Mode)}, ReturnType = typeof(ContentDecodeStream))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C61")]
	public GZipStream(Stream stream, CompressionMode mode) { }

	[Address(RVA = "0x17C0730", Offset = "0x17BF930", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C62")]
	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	[Address(RVA = "0x17C0670", Offset = "0x17BF870", Length = "0xBB")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "CompressString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C63")]
	public GZipStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) { }

	[Address(RVA = "0x17BFB90", Offset = "0x17BED90", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C6E")]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x17BFC40", Offset = "0x17BEE40", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C72")]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x17BFCF0", Offset = "0x17BEEF0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[Token(Token = "0x6000C7D")]
	private void CheckDeflateStream() { }

	[Address(RVA = "0x17BFD50", Offset = "0x17BEF50", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C76")]
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	[Address(RVA = "0x17BFD10", Offset = "0x17BEF10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C7C")]
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17BFD80", Offset = "0x17BEF80", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000C77")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17BFE20", Offset = "0x17BF020", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "TResult")]
	[Token(Token = "0x6000C6F")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1321170", Offset = "0x1320370", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C73")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17BFE60", Offset = "0x17BF060", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C6A")]
	public virtual void Flush() { }

	[Address(RVA = "0x17C0800", Offset = "0x17BFA00", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C64")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x17C0820", Offset = "0x17BFA20", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C66")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x17C0840", Offset = "0x17BFA40", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C65")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x17C0860", Offset = "0x17BFA60", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C67")]
	public virtual long get_Length() { }

	[Address(RVA = "0x17C08B0", Offset = "0x17BFAB0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C68")]
	public virtual long get_Position() { }

	[Address(RVA = "0x17BFFF0", Offset = "0x17BF1F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C70")]
	public virtual int Read(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x17C0030", Offset = "0x17BF230", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C71")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x17BFE90", Offset = "0x17BF090", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C78")]
	public virtual Task<Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17BFED0", Offset = "0x17BF0D0", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C79")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x17BFFC0", Offset = "0x17BF1C0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C6D")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x17C0210", Offset = "0x17BF410", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C6B")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x17C0900", Offset = "0x17BFB00", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C69")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x17C0260", Offset = "0x17BF460", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C6C")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x17C02B0", Offset = "0x17BF4B0", Length = "0x50")]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(GZipStream), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(GZipStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(GZipStream), Member = "CheckDeflateStream", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000C7E")]
	private static void ThrowStreamClosedException() { }

	[Address(RVA = "0x17C0480", Offset = "0x17BF680", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C75")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x17C0440", Offset = "0x17BF640", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C74")]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x17C0350", Offset = "0x17BF550", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C7B")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x17C0310", Offset = "0x17BF510", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C7A")]
	public virtual Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

}

