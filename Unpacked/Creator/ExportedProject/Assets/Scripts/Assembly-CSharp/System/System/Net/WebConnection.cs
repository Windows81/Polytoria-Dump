namespace System.Net;

[Token(Token = "0x20002A8")]
internal class WebConnection : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20002A9")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B61")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B62")]
		public static Func<IPEndPoint, AsyncCallback, Object, IAsyncResult> <>9__16_0; //Field offset: 0x8
		[Token(Token = "0x4000B63")]
		public static Action<IAsyncResult> <>9__16_1; //Field offset: 0x10

		[Address(RVA = "0x170C890", Offset = "0x170BA90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001138")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001139")]
		public <>c() { }

		[Address(RVA = "0x170C580", Offset = "0x170B780", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600113A")]
		internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

		[Address(RVA = "0x170C620", Offset = "0x170B820", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600113B")]
		internal void <Connect>b__16_1(IAsyncResult asyncResult) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002AA")]
	private struct <Connect>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B64")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B65")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B66")]
		public WebConnection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B67")]
		public WebOperation operation; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B68")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B69")]
		private Exception <connectException>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B6A")]
		private IPAddress[] <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B6B")]
		private int <>7__wrap3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B6C")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x1703900", Offset = "0x1702B00", Length = "0x846")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ServicePoint), Member = "CallEndPointDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(IPEndPoint)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ServicePoint), Member = "KeepAliveSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", typeof(object)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600113C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1704150", Offset = "0x1703350", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600113D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002AB")]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B6E")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B6F")]
		public WebConnection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B70")]
		public WebOperation operation; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B71")]
		public bool reused; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B72")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B73")]
		private NetworkStream <stream>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B74")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B75")]
		private ConfiguredTaskAwaiter<Stream> <>u__2; //Field offset: 0x58

		[Address(RVA = "0x17041B0", Offset = "0x17033B0", Length = "0x7C5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoTlsStream), Member = "CreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnectionTunnel), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
		[Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<CreateStream>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<CreateStream>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnectionTunnel+<Initialize>d__42"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Initialize>d__42&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 8)]
		[Token(Token = "0x600113E")]
		private override void MoveNext() { }

		[Address(RVA = "0x1704980", Offset = "0x1703B80", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600113F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002AC")]
	private struct <InitConnection>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B76")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B77")]
		public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B78")]
		public WebOperation operation; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B79")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B7A")]
		public WebConnection <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B7B")]
		private bool <reused>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B7C")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B7D")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1704FE0", Offset = "0x17041E0", Length = "0x84F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<InitConnection>d__19)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<InitConnection>d__19&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnection), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnection), Member = "CheckReusable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_InternalAllowBuffering", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection+<CreateStream>d__18"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection+<Connect>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Connect>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001140")]
		private override void MoveNext() { }

		[Address(RVA = "0x1705840", Offset = "0x1704A40", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001141")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B56")]
	private NetworkCredential ntlm_credentials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B57")]
	private bool ntlm_authenticated; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000B58")]
	private bool unsafe_sharing; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B59")]
	private Stream networkStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B5A")]
	private Socket socket; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B5B")]
	private MonoTlsStream monoTlsStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B5C")]
	private WebConnectionTunnel tunnel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B5D")]
	private int disposed; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B5E")]
	private readonly ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B5F")]
	private DateTime idleSince; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B60")]
	private WebOperation currentOperation; //Field offset: 0x58

	[Token(Token = "0x1700039A")]
	public bool Closed
	{
		[Address(RVA = "0x1710EA0", Offset = "0x17100A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600112B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700039B")]
	public DateTime IdleSince
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x600112C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039C")]
	internal bool NtlmAuthenticated
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001132")]
		internal get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001133")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700039D")]
	internal NetworkCredential NtlmCredential
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001134")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001135")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000399")]
	public ServicePoint ServicePoint
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600111D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700039E")]
	internal bool UnsafeAuthenticatedConnectionSharing
	{
		[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001136")]
		internal get { } //Length: 5
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001137")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x1710E60", Offset = "0x1710060", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600111E")]
	public WebConnection(ServicePoint sPoint) { }

	[Address(RVA = "0x170FE10", Offset = "0x170F010", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600111F")]
	private bool CanReuse() { }

	[Address(RVA = "0x170FAB0", Offset = "0x170ECB0", Length = "0x351")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(WebConnection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001126")]
	internal bool CanReuseConnection(WebOperation operation) { }

	[Address(RVA = "0x170FE40", Offset = "0x170F040", Length = "0x45")]
	[CalledBy(Type = typeof(<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001120")]
	private bool CheckReusable() { }

	[Address(RVA = "0x170FFF0", Offset = "0x170F1F0", Length = "0x9F")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnection), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001129")]
	private void Close(bool reset) { }

	[Address(RVA = "0x170FE90", Offset = "0x170F090", Length = "0x15A")]
	[CalledBy(Type = typeof(<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoTlsStream), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600112A")]
	private void CloseSocket() { }

	[Address(RVA = "0x1710090", Offset = "0x170F290", Length = "0x11E")]
	[AsyncStateMachine(typeof(<Connect>d__16))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Connect>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Connect>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001121")]
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17101B0", Offset = "0x170F3B0", Length = "0x15B")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup", typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WebOperation), Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePoint), typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "Run", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600112E")]
	public bool Continue(WebOperation next) { }

	[Address(RVA = "0x1710310", Offset = "0x170F510", Length = "0x14C")]
	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateStream>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001122")]
	private Task<Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1710460", Offset = "0x170F660", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001130")]
	public override void Dispose() { }

	[Address(RVA = "0x1710460", Offset = "0x170F660", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600112F")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1710EA0", Offset = "0x17100A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600112B")]
	public bool get_Closed() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x600112C")]
	public DateTime get_IdleSince() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001132")]
	internal bool get_NtlmAuthenticated() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001134")]
	internal NetworkCredential get_NtlmCredential() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600111D")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001136")]
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	[Address(RVA = "0x17104A0", Offset = "0x170F6A0", Length = "0x16E")]
	[CalledBy(Type = typeof(<Connect>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateStream>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(WebExceptionInternalStatus), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001124")]
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	[Address(RVA = "0x1710610", Offset = "0x170F810", Length = "0x143")]
	[AsyncStateMachine(typeof(<InitConnection>d__19))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitConnection>d__19)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitConnection>d__19&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001123")]
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1710760", Offset = "0x170F960", Length = "0x24B")]
	[CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001127")]
	private bool PrepareSharingNtlm(WebOperation operation) { }

	[Address(RVA = "0x17109B0", Offset = "0x170FBB0", Length = "0x1E2")]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001125")]
	internal static bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	[Address(RVA = "0x1710BD0", Offset = "0x170FDD0", Length = "0xA7")]
	[CalledBy(Type = typeof(<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001128")]
	private void Reset() { }

	[Address(RVA = "0x1710BA0", Offset = "0x170FDA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001131")]
	private void ResetNtlm() { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001133")]
	internal void set_NtlmAuthenticated(bool value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001135")]
	internal void set_NtlmCredential(NetworkCredential value) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001137")]
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[Address(RVA = "0x1710C80", Offset = "0x170FE80", Length = "0x1D8")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(WebConnection))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "CreateOrReuseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebConnection, System.Boolean>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(WebOperation), Member = "Run", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePoint), typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x600112D")]
	public bool StartOperation(WebOperation operation, bool reused) { }

}

