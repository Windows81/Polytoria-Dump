namespace System.Net;

[Token(Token = "0x20002B5")]
internal abstract class WebReadStream : Stream
{
	[CompilerGenerated]
	[Token(Token = "0x20002B6")]
	private struct <ReadAsync>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BC8")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BC9")]
		public WebReadStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BCA")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BCB")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BCC")]
		public int offset; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000BCD")]
		public int size; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BCE")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BCF")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1708C50", Offset = "0x1707E50", Length = "0x4F1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<ReadAsync>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<ReadAsync>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ReadAsync>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ReadAsync>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60011B0")]
		private override void MoveNext() { }

		[Address(RVA = "0x1709150", Offset = "0x1708350", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011B1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BC4")]
	private readonly WebOperation <Operation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BC5")]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC6")]
	private bool disposed; //Field offset: 0x38

	[Token(Token = "0x170003C1")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003C0")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003C2")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003BD")]
	protected Stream InnerStream
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600119C")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170003BE")]
	public virtual long Length
	{
		[Address(RVA = "0x1712DC0", Offset = "0x1711FC0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600119E")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170003BC")]
	public WebOperation Operation
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600119B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003BF")]
	public virtual long Position
	{
		[Address(RVA = "0x1712E00", Offset = "0x1712000", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600119F")]
		 get { } //Length: 62
		[Address(RVA = "0x1712E40", Offset = "0x1712040", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60011A0")]
		 set { } //Length: 62
	}

	[Address(RVA = "0x1712D30", Offset = "0x1711F30", Length = "0x82")]
	[CalledBy(Type = typeof(BufferedReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Mode)}, ReturnType = typeof(ContentDecodeStream))]
	[CalledBy(Type = typeof(ContentDecodeStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedSizeReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600119D")]
	public WebReadStream(WebOperation operation, Stream innerStream) { }

	[Address(RVA = "0x17121F0", Offset = "0x17113F0", Length = "0x272")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011AA")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	[Address(RVA = "0x1712470", Offset = "0x1711670", Length = "0x49")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011AF")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17124C0", Offset = "0x17116C0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "TResult")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Token(Token = "0x60011AB")]
	public virtual int EndRead(IAsyncResult r) { }

	[Address(RVA = "0x1712590", Offset = "0x1711790", Length = "0x10B")]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkStream), Member = "<>n__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011AE")]
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x17126A0", Offset = "0x17118A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A7")]
	public virtual void Flush() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A2")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A1")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A3")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600119C")]
	protected Stream get_InnerStream() { }

	[Address(RVA = "0x1712DC0", Offset = "0x1711FC0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600119E")]
	public virtual long get_Length() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600119B")]
	public WebOperation get_Operation() { }

	[Address(RVA = "0x1712E00", Offset = "0x1712000", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600119F")]
	public virtual long get_Position() { }

	[Address(RVA = "0x17126E0", Offset = "0x17118E0", Length = "0x17D")]
	[CalledBy(Type = typeof(WebReadStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WebReadStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011A8")]
	protected Exception GetException(Exception e) { }

	[Token(Token = "0x60011AD")]
	protected abstract Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17129B0", Offset = "0x1711BB0", Length = "0x2BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "get_Result", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011A9")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x1712860", Offset = "0x1711A60", Length = "0x14C")]
	[AsyncStateMachine(typeof(<ReadAsync>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011AC")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1712C70", Offset = "0x1711E70", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A5")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x1712E40", Offset = "0x1712040", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A0")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1712CB0", Offset = "0x1711EB0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A4")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x1712CF0", Offset = "0x1711EF0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A6")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

