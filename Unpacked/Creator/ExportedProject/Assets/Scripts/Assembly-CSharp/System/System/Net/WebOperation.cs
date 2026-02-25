namespace System.Net;

[Token(Token = "0x20002B2")]
internal class WebOperation
{
	[CompilerGenerated]
	[Token(Token = "0x20002B3")]
	private struct <GetRequestStream>d__50 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BBA")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BBB")]
		public WebOperation <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BBC")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1704D60", Offset = "0x1703F60", Length = "0x205")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001197")]
		private override void MoveNext() { }

		[Address(RVA = "0x1704F70", Offset = "0x1704170", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001198")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002B4")]
	private struct <Run>d__58 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BBE")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BBF")]
		public WebOperation <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BC0")]
		private WebRequestStream <requestStream>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BC1")]
		private WebResponseStream <stream>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BC2")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BC3")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x170B580", Offset = "0x170A780", Length = "0x91F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequestStream+<Initialize>d__36"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Initialize>d__36&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<Run>d__58)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<Run>d__58&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebResponseStream+<InitReadAsync>d__52"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitReadAsync>d__52&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection+<InitConnection>d__19"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitConnection>d__19&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[Token(Token = "0x6001199")]
		private override void MoveNext() { }

		[Address(RVA = "0x10712D0", Offset = "0x10704D0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600119A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA8")]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA9")]
	private WebConnection <Connection>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BAA")]
	private ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BAB")]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BAC")]
	private readonly bool <IsNtlmChallenge>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BAD")]
	private CancellationTokenSource cts; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BAE")]
	private WebCompletionSource<WebRequestStream> requestTask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BAF")]
	private WebCompletionSource<WebRequestStream> requestWrittenTask; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BB0")]
	private WebCompletionSource<WebResponseStream> responseTask; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BB1")]
	private WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> finishedTask; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BB2")]
	private WebRequestStream writeStream; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BB3")]
	private WebResponseStream responseStream; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BB4")]
	private ExceptionDispatchInfo disposedInfo; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BB5")]
	private ExceptionDispatchInfo closedInfo; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BB6")]
	private WebOperation priorityRequest; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000BB7")]
	private int requestSent; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000BB8")]
	private int finished; //Field offset: 0x8C

	[Token(Token = "0x170003B8")]
	public bool Aborted
	{
		[Address(RVA = "0x17120E0", Offset = "0x17112E0", Length = "0x4F")]
		[CalledBy(Type = "System.Net.WebConnection+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600117F")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170003B9")]
	public bool Closed
	{
		[Address(RVA = "0x1712130", Offset = "0x1711330", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001180")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170003B4")]
	public private WebConnection Connection
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001178")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001179")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003BB")]
	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> Finished
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001192")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B7")]
	public bool IsNtlmChallenge
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600117D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003B3")]
	public HttpWebRequest Request
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001177")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003B5")]
	public private ServicePoint ServicePoint
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600117A")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600117B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003B6")]
	public BufferOffsetSize WriteBuffer
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600117C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003BA")]
	public WebRequestStream WriteStream
	{
		[Address(RVA = "0x1712190", Offset = "0x1711390", Length = "0x59")]
		[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001190")]
		 get { } //Length: 89
	}

	[Address(RVA = "0x1711F20", Offset = "0x1711120", Length = "0x1B8")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(WebOperation))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponseStream), typeof(HttpWebResponse), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebOperation, System.Boolean>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebCompletionSource`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600117E")]
	public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1711EE0", Offset = "0x17110E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6001196")]
	private void <RegisterRequest>b__48_0() { }

	[Address(RVA = "0x1710EB0", Offset = "0x17100B0", Length = "0x52")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
	[Token(Token = "0x6001181")]
	public void Abort() { }

	[Address(RVA = "0x1710F10", Offset = "0x1710110", Length = "0xD4")]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001186")]
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1710FF0", Offset = "0x17101F0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600118B")]
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	[Address(RVA = "0x1711060", Offset = "0x1710260", Length = "0x52")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001182")]
	public void Close() { }

	[Address(RVA = "0x17110C0", Offset = "0x17102C0", Length = "0x82")]
	[CalledBy(Type = "System.Net.WebRequestStream+<FinishWriting>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<ProcessWrite>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "CheckWriteOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "Close_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001194")]
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null) { }

	[Address(RVA = "0x1711150", Offset = "0x1710350", Length = "0x27D")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Close_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<System.Boolean, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001195")]
	internal void Finish(bool ok, Exception error = null) { }

	[Address(RVA = "0x17120E0", Offset = "0x17112E0", Length = "0x4F")]
	[CalledBy(Type = "System.Net.WebConnection+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600117F")]
	public bool get_Aborted() { }

	[Address(RVA = "0x1712130", Offset = "0x1711330", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001180")]
	public bool get_Closed() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001178")]
	public WebConnection get_Connection() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001192")]
	internal WebCompletionSource<ValueTuple`2<Boolean, WebOperation>> get_Finished() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600117D")]
	public bool get_IsNtlmChallenge() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001177")]
	public HttpWebRequest get_Request() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600117A")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600117C")]
	public BufferOffsetSize get_WriteBuffer() { }

	[Address(RVA = "0x1712190", Offset = "0x1711390", Length = "0x59")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001190")]
	public WebRequestStream get_WriteStream() { }

	[Address(RVA = "0x1711420", Offset = "0x1710620", Length = "0xF6")]
	[AsyncStateMachine(typeof(<GetRequestStream>d__50))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetRequestStream>d__50)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetRequestStream>d__50&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600118E")]
	public Task<Stream> GetRequestStream() { }

	[Address(RVA = "0x17113D0", Offset = "0x17105D0", Length = "0x44")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600118F")]
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	[Address(RVA = "0x1711520", Offset = "0x1710720", Length = "0x44")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001191")]
	public Task<WebResponseStream> GetResponseStream() { }

	[Address(RVA = "0x1711570", Offset = "0x1710770", Length = "0x274")]
	[CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600118C")]
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	[Address(RVA = "0x17117F0", Offset = "0x17109F0", Length = "0xB1")]
	[AsyncStateMachine(typeof(<Run>d__58))]
	[CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Run>d__58)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Run>d__58&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001193")]
	internal void Run() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001179")]
	private void set_Connection(WebConnection value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600117B")]
	private void set_ServicePoint(ServicePoint value) { }

	[Address(RVA = "0x17118B0", Offset = "0x1710AB0", Length = "0xC1")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationCanceledException)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001183")]
	private void SetCanceled() { }

	[Address(RVA = "0x1711980", Offset = "0x1710B80", Length = "0xD8")]
	[CalledBy(Type = typeof(WebOperation), Member = "CheckThrowDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "<RegisterRequest>b__48_0", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001185")]
	private ValueTuple<ExceptionDispatchInfo, Boolean> SetDisposed(ref ExceptionDispatchInfo field) { }

	[Address(RVA = "0x1711A60", Offset = "0x1710C60", Length = "0x9F")]
	[CalledBy(Type = typeof(<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequestStream), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001184")]
	private void SetError(Exception error) { }

	[Address(RVA = "0x1711B00", Offset = "0x1710D00", Length = "0x156")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponseStream), typeof(HttpWebResponse), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebOperation, System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600118D")]
	public void SetPriorityRequest(WebOperation operation) { }

	[Address(RVA = "0x1711CC0", Offset = "0x1710EC0", Length = "0xD9")]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer_inner>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<ProcessWrite>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<Initialize>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebReadStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(WebReadStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<Run>d__58), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebConnection+<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<FinishWriting>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Token(Token = "0x600118A")]
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1711C60", Offset = "0x1710E60", Length = "0x54")]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001189")]
	internal void ThrowIfClosedOrDisposed() { }

	[Address(RVA = "0x1711E80", Offset = "0x1711080", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001187")]
	internal void ThrowIfDisposed() { }

	[Address(RVA = "0x1711DA0", Offset = "0x1710FA0", Length = "0xD2")]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "get_WriteStream", ReturnType = typeof(WebRequestStream))]
	[CalledBy(Type = "System.Net.WebReadStream+<ReadAsync>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001188")]
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

}

