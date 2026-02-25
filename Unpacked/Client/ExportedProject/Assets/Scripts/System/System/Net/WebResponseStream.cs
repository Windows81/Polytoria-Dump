namespace System.Net;

[Token(Token = "0x20002C0")]
internal class WebResponseStream : WebConnectionStream
{
	[CompilerGenerated]
	[Token(Token = "0x20002C2")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C2D")]
		public WebResponseStream <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C2E")]
		public Byte[] buffer; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C2F")]
		public int offset; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C30")]
		public int size; //Field offset: 0x24

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011F7")]
		public <>c__DisplayClass41_0() { }

		[Address(RVA = "0x170C750", Offset = "0x170B950", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60011F8")]
		internal Task<Int32> <ProcessRead>b__0(CancellationToken ct) { }

		[Address(RVA = "0x170C7A0", Offset = "0x170B9A0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60011F9")]
		internal void <ProcessRead>b__1() { }

		[Address(RVA = "0x170C830", Offset = "0x170BA30", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60011FA")]
		internal bool <ProcessRead>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C5")]
	private struct <InitReadAsync>d__52 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C43")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C44")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C45")]
		public WebResponseStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C46")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C47")]
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C48")]
		private ReadState <state>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000C49")]
		private int <position>5__4; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C4A")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x17058B0", Offset = "0x1704AB0", Length = "0x64F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60011FF")]
		private override void MoveNext() { }

		[Address(RVA = "0x1705F10", Offset = "0x1705110", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001200")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C4")]
	private struct <ReadAllAsync>d__48 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C39")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C3A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C3B")]
		public WebResponseStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C3C")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C3D")]
		public bool resending; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C3E")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C3F")]
		private CancellationTokenSource <timeoutCts>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C40")]
		private Task <timeoutTask>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C41")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C42")]
		private ConfiguredTaskAwaiter<Byte[]> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x1707EE0", Offset = "0x17070E0", Length = "0xD06")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<ReadAllAsync>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<ReadAllAsync>d__48&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816FCD20")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebResponseStream+<ReadAllAsyncInner>d__47"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsyncInner>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816FCCD0")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A8300")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60011FD")]
		private override void MoveNext() { }

		[Address(RVA = "0x1708BF0", Offset = "0x1707DF0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011FE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C3")]
	private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C31")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C32")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C33")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C34")]
		public WebResponseStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C35")]
		private long <maximumSize>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C36")]
		private MemoryStream <ms>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C37")]
		private Byte[] <buffer>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C38")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x17078B0", Offset = "0x1706AB0", Length = "0x5BA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60011FB")]
		private override void MoveNext() { }

		[Address(RVA = "0x1707E70", Offset = "0x1707070", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011FC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C1")]
	private struct <ReadAsync>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C21")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C22")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C23")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C24")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C25")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C26")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C27")]
		public WebResponseStream <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C28")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C29")]
		private int <nbytes>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C2A")]
		private Exception <throwMe>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C2B")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C2C")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x68

		[Address(RVA = "0x17091C0", Offset = "0x17083C0", Length = "0x936")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816FCC70")]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A80B0")]
		[Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A1AF0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A8300")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60011F5")]
		private override void MoveNext() { }

		[Address(RVA = "0x1709B00", Offset = "0x1708D00", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011F6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C13")]
	private WebReadStream innerStream; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C14")]
	private bool nextReadCalled; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000C15")]
	private bool bufferedEntireContent; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C16")]
	private WebCompletionSource pendingRead; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C17")]
	private object locker; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C18")]
	private int nestedRead; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000C19")]
	private bool read_eof; //Field offset: 0x7C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C1A")]
	private readonly WebRequestStream <RequestStream>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C1B")]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C1C")]
	private HttpStatusCode <StatusCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C1D")]
	private string <StatusDescription>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C1E")]
	private Version <Version>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C1F")]
	private bool <KeepAlive>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000C20")]
	private bool <ChunkedRead>k__BackingField; //Field offset: 0xA9

	[Token(Token = "0x170003CF")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003D0")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003D1")]
	private bool ChunkedRead
	{
		[Address(RVA = "0x1715D40", Offset = "0x1714F40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E7")]
		private get { } //Length: 8
		[Address(RVA = "0x1715DE0", Offset = "0x1714FE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E8")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170003D2")]
	private bool ExpectContent
	{
		[Address(RVA = "0x1715D50", Offset = "0x1714F50", Length = "0x8F")]
		[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011EC")]
		private get { } //Length: 143
	}

	[Token(Token = "0x170003CA")]
	public private WebHeaderCollection Headers
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DA")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DB")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170003CE")]
	public private bool KeepAlive
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E2")]
		 get { } //Length: 8
		[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E3")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170003C9")]
	public WebRequestStream RequestStream
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011D9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003CB")]
	public private HttpStatusCode StatusCode
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DC")]
		 get { } //Length: 7
		[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DD")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170003CC")]
	public private string StatusDescription
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DE")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011DF")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170003CD")]
	public private Version Version
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E0")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011E1")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x1715CA0", Offset = "0x1714EA0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011E4")]
	public WebResponseStream(WebRequestStream request) { }

	[Address(RVA = "0x1714320", Offset = "0x1713520", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F1")]
	protected virtual void Close_internal(ref bool disposed) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E5")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E6")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1715D40", Offset = "0x1714F40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E7")]
	private bool get_ChunkedRead() { }

	[Address(RVA = "0x1715D50", Offset = "0x1714F50", Length = "0x8F")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EC")]
	private bool get_ExpectContent() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DA")]
	public WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E2")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011D9")]
	public WebRequestStream get_RequestStream() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DC")]
	public HttpStatusCode get_StatusCode() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DE")]
	public string get_StatusDescription() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E0")]
	public Version get_Version() { }

	[Address(RVA = "0x17143C0", Offset = "0x17135C0", Length = "0x2BB")]
	[CalledBy(Type = typeof(<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(WebExceptionInternalStatus), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011F2")]
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[Address(RVA = "0x1714680", Offset = "0x1713880", Length = "0x7C3")]
	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "DoContinueDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(WebConnection), Member = "ReadLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60011F4")]
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

	[Address(RVA = "0x1714F60", Offset = "0x1714160", Length = "0x5B2")]
	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoChunkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedSizeReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Mode)}, ReturnType = typeof(ContentDecodeStream))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebResponseStream), Member = "get_ExpectContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011ED")]
	private void Initialize(BufferOffsetSize buffer) { }

	[Address(RVA = "0x1714E50", Offset = "0x1714050", Length = "0x105")]
	[AsyncStateMachine(typeof(<InitReadAsync>d__52))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitReadAsync>d__52)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitReadAsync>d__52&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F3")]
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1715520", Offset = "0x1714720", Length = "0x284")]
	[CalledBy(Type = typeof(<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadAllAsyncInner>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), typeof(System.Func`1<System.Boolean>), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011EA")]
	private Task<Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17158E0", Offset = "0x1714AE0", Length = "0x116")]
	[AsyncStateMachine(typeof(<ReadAllAsync>d__48))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsync>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsync>d__48&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011EF")]
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17157B0", Offset = "0x17149B0", Length = "0x127")]
	[AsyncStateMachine(typeof(<ReadAllAsyncInner>d__47))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsyncInner>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsyncInner>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011EE")]
	private Task<Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1715A00", Offset = "0x1714C00", Length = "0x156")]
	[AsyncStateMachine(typeof(<ReadAsync>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011E9")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1715DE0", Offset = "0x1714FE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E8")]
	private void set_ChunkedRead(bool value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DB")]
	private void set_Headers(WebHeaderCollection value) { }

	[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E3")]
	private void set_KeepAlive(bool value) { }

	[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DD")]
	private void set_StatusCode(HttpStatusCode value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011DF")]
	private void set_StatusDescription(string value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E1")]
	private void set_Version(Version value) { }

	[Address(RVA = "0x1715B60", Offset = "0x1714D60", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BufferedReadStream), Member = "TryReadFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011EB")]
	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[Address(RVA = "0x1715C20", Offset = "0x1714E20", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Token(Token = "0x60011F0")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

