namespace System.Net;

[Token(Token = "0x2000288")]
public class HttpWebRequest : WebRequest, ISerializable
{
	[CompilerGenerated]
	[Token(Token = "0x200028F")]
	private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AC0")]
		public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AC1")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AC2")]
		private MemoryStream <ms>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AC3")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x17FFBD0", Offset = "0x17FEDD0", Length = "0x3F4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001086")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FFFD0", Offset = "0x17FF1D0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001087")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200028B")]
	private sealed class <>c__241
	{
		[Token(Token = "0x4000A99")]
		public static readonly <>c__241<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000A9A")]
		public static Func<Task`1<T>, Nullable`1<Int32>> <>9__241_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600107D")]
		private static <>c__241`1() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600107E")]
		public <>c__241`1() { }

		[Address(RVA = "0x7FC300", Offset = "0x7FB500", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600107F")]
		internal Nullable<Int32> <RunWithTimeoutWorker>b__241_0(Task<T> t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200028E")]
	private struct <GetResponseFromData>d__244 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AB5")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		public AsyncTaskMethodBuilder<ValueTuple`5<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AB6")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AB7")]
		public WebResponseStream stream; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AB8")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AB9")]
		private HttpWebResponse <response>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000ABA")]
		private WebException <throwMe>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000ABB")]
		private bool <redirect>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x4000ABC")]
		private bool <mustReadAll>5__5; //Field offset: 0x49
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000ABD")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000ABE")]
		private ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x17FD5D0", Offset = "0x17FC7D0", Length = "0x8AA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<GetResponseFromData>d__244)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<GetResponseFromData>d__244&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool), typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebRequestStream), Member = "KillBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponseStream), typeof(HttpWebResponse), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebOperation, System.Boolean>))]
		[Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<GetResponseFromData>d__244)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<GetResponseFromData>d__244&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800024C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001084")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FDE80", Offset = "0x17FD080", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001085")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200028D")]
	private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AA4")]
		public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AA5")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AA6")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AA7")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AA8")]
		private WebOperation <operation>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AA9")]
		private WebException <throwMe>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AAA")]
		private HttpWebResponse <response>5__5; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000AAB")]
		private WebResponseStream <stream>5__6; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AAC")]
		private bool <redirect>5__7; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4000AAD")]
		private bool <mustReadAll>5__8; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AAE")]
		private WebOperation <ntlm>5__9; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000AAF")]
		private BufferOffsetSize <writeBuffer>5__10; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000AB0")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000AB1")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000AB2")]
		private TaskAwaiter<WebResponseStream> <>u__3; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000AB3")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		private ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> <>u__4; //Field offset: 0x98

		[Address(RVA = "0x17FDEF0", Offset = "0x17FD0F0", Length = "0x1183")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpWebRequest+<GetResponseFromData>d__244"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetResponseFromData>d__244&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>))]
		[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[Calls(Type = typeof(WebOperation), Member = "GetResponseStream", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.WebResponseStream>))]
		[Calls(Type = typeof(WebRequestStream), Member = "WriteRequestAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "get_WriteStream", ReturnType = typeof(WebRequestStream))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801A8300")]
		[Calls(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(WebOperation))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "ThrowOnError", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "GetRequestStreamInternal", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.WebRequestStream>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001082")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FF080", Offset = "0x17FE280", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001083")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200028C")]
	private struct <RunWithTimeoutWorker>d__241 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9C")]
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9D")]
		public Task<T> workerTask; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9E")]
		public int timeout; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9F")]
		public CancellationTokenSource cts; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA0")]
		public Action abort; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA1")]
		public Func<Boolean> aborted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA2")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x8162A0", Offset = "0x8154A0", Length = "0x6A3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180032900")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180032920")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800329A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18080BB60")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "get_Result", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(ServicePointScheduler), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(WebException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800329C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180021FF0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001080")]
		private override void MoveNext() { }

		[Address(RVA = "0x816950", Offset = "0x815B50", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001081")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200028A")]
	private struct AuthorizationState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A95")]
		private readonly HttpWebRequest request; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A96")]
		private readonly bool isProxy; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000A97")]
		private bool isCompleted; //Field offset: 0x9
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000A98")]
		private NtlmAuthState ntlm_auth_state; //Field offset: 0xC

		[Token(Token = "0x17000372")]
		public bool IsCompleted
		{
			[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001076")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000374")]
		public bool IsNtlmAuthenticated
		{
			[Address(RVA = "0x17E9360", Offset = "0x17E8560", Length = "0x11")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001078")]
			 get { } //Length: 17
		}

		[Token(Token = "0x17000373")]
		public NtlmAuthState NtlmAuthState
		{
			[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001077")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x17E9320", Offset = "0x17E8520", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001079")]
		public AuthorizationState(HttpWebRequest request, bool isProxy) { }

		[Address(RVA = "0x17E8E10", Offset = "0x17E8010", Length = "0x3B9")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(AuthenticationManager), Member = "DoAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600107A")]
		public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

		[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001076")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x17E9360", Offset = "0x17E8560", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001078")]
		public bool get_IsNtlmAuthenticated() { }

		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001077")]
		public NtlmAuthState get_NtlmAuthState() { }

		[Address(RVA = "0x17E91D0", Offset = "0x17E83D0", Length = "0x75")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600107B")]
		public void Reset() { }

		[Address(RVA = "0x17E9250", Offset = "0x17E8450", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Token(Token = "0x600107C")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000289")]
	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	[Token(Token = "0x4000A83")]
	private static int defaultMaxResponseHeadersLength; //Field offset: 0x0
	[Token(Token = "0x4000A84")]
	private static int defaultMaximumErrorResponseLength; //Field offset: 0x4
	[Token(Token = "0x4000A85")]
	private static RequestCachePolicy defaultCachePolicy; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A58")]
	private Uri requestUri; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A59")]
	private Uri actualUri; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A5A")]
	private bool hostChanged; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000A5B")]
	private bool allowAutoRedirect; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x4000A5C")]
	private bool allowBuffering; //Field offset: 0x4A
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A5D")]
	private X509CertificateCollection certificates; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A5E")]
	private string connectionGroup; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A5F")]
	private bool haveContentLength; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A60")]
	private long contentLength; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A61")]
	private HttpContinueDelegate continueDelegate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A62")]
	private CookieContainer cookieContainer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A63")]
	private ICredentials credentials; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A64")]
	private bool haveResponse; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000A65")]
	private bool requestSent; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A66")]
	private WebHeaderCollection webHeaders; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A67")]
	private bool keepAlive; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000A68")]
	private int maxAutoRedirect; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A69")]
	private string mediaType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A6A")]
	private string method; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A6B")]
	private string initialMethod; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A6C")]
	private bool pipelined; //Field offset: 0xB8
	[FieldOffset(Offset = "0xB9")]
	[Token(Token = "0x4000A6D")]
	private bool preAuthenticate; //Field offset: 0xB9
	[FieldOffset(Offset = "0xBA")]
	[Token(Token = "0x4000A6E")]
	private bool usedPreAuth; //Field offset: 0xBA
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A6F")]
	private Version version; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A70")]
	private bool force_version; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A71")]
	private Version actualVersion; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A72")]
	private IWebProxy proxy; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A73")]
	private bool sendChunked; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A74")]
	private ServicePoint servicePoint; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000A75")]
	private int timeout; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000A76")]
	private int continueTimeout; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000A77")]
	private WebRequestStream writeStream; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000A78")]
	private HttpWebResponse webResponse; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000A79")]
	private WebCompletionSource responseTask; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000A7A")]
	private WebOperation currentOperation; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A7B")]
	private int aborted; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000A7C")]
	private bool gotRequestStream; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000A7D")]
	private int redirects; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000A7E")]
	private bool expectContinue; //Field offset: 0x124
	[FieldOffset(Offset = "0x125")]
	[Token(Token = "0x4000A7F")]
	private bool getResponseCalled; //Field offset: 0x125
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000A80")]
	private object locker; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000A81")]
	private bool finished_reading; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000A82")]
	private DecompressionMethods auto_decomp; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000A86")]
	private int readWriteTimeout; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000A87")]
	private MobileTlsProvider tlsProvider; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000A88")]
	private MonoTlsSettings tlsSettings; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000A89")]
	private ServerCertValidationCallback certValidationCallback; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000A8A")]
	private bool hostHasPort; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000A8B")]
	private Uri hostUri; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000A8C")]
	private AuthorizationState auth_state; //Field offset: 0x168
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000A8D")]
	private AuthorizationState proxy_auth_state; //Field offset: 0x178
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000A8E")]
	internal Func<Stream, Task> ResendContentFactory; //Field offset: 0x188
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000A8F")]
	private bool <ThrowOnError>k__BackingField; //Field offset: 0x190
	[FieldOffset(Offset = "0x191")]
	[Token(Token = "0x4000A90")]
	private bool unsafe_auth_blah; //Field offset: 0x191

	[Token(Token = "0x17000371")]
	internal bool Aborted
	{
		[Address(RVA = "0x17F86E0", Offset = "0x17F78E0", Length = "0x23")]
		[CalledBy(Type = typeof(WebOperation), Member = "get_Closed", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "<RunWithTimeout>b__242_0", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__2", ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001064")]
		internal get { } //Length: 35
	}

	[Token(Token = "0x17000349")]
	public Uri Address
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600101B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700034A")]
	public override bool AllowAutoRedirect
	{
		[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600101C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700034B")]
	public override bool AllowWriteStreamBuffering
	{
		[Address(RVA = "0x168EFB0", Offset = "0x168E1B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600101D")]
		 get { } //Length: 5
		[Address(RVA = "0x17F8BB0", Offset = "0x17F7DB0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600101E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700036C")]
	internal Uri AuthUri
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600104C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700034C")]
	public DecompressionMethods AutomaticDecompression
	{
		[Address(RVA = "0x17F8710", Offset = "0x17F7910", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600101F")]
		 get { } //Length: 7
		[Address(RVA = "0x17F8BC0", Offset = "0x17F7DC0", Length = "0x6A")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001020")]
		 set { } //Length: 106
	}

	[Token(Token = "0x17000351")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x17F8720", Offset = "0x17F7920", Length = "0x69")]
		[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001025")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000352")]
	public virtual string ConnectionGroupName
	{
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001026")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000353")]
	public virtual long ContentLength
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001027")]
		 get { } //Length: 5
		[Address(RVA = "0x17F8C30", Offset = "0x17F7E30", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001028")]
		 set { } //Length: 207
	}

	[Token(Token = "0x17000356")]
	public override CookieContainer CookieContainer
	{
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600102C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000357")]
	public virtual ICredentials Credentials
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600102D")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600102E")]
		 set { } //Length: 16
	}

	[MonoTODO]
	[Token(Token = "0x17000358")]
	public static int DefaultMaximumErrorResponseLength
	{
		[Address(RVA = "0x17F8790", Offset = "0x17F7990", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600102F")]
		 get { } //Length: 78
	}

	[MonoTODO("Use this")]
	[Token(Token = "0x1700035D")]
	public static int DefaultMaximumResponseHeadersLength
	{
		[Address(RVA = "0x17F87E0", Offset = "0x17F79E0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001037")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700036B")]
	internal bool ExpectContinue
	{
		[Address(RVA = "0x17F8830", Offset = "0x17F7A30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600104A")]
		internal get { } //Length: 8
		[Address(RVA = "0x17F8D00", Offset = "0x17F7F00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600104B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000370")]
	internal bool FinishedReading
	{
		[Address(RVA = "0x17F8D10", Offset = "0x17F7F10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001063")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000359")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001030")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700035A")]
	public string Host
	{
		[Address(RVA = "0x17F8840", Offset = "0x17F7A40", Length = "0x108")]
		[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper+<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001031")]
		 get { } //Length: 264
		[Address(RVA = "0x17F8D20", Offset = "0x17F7F20", Length = "0x286")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001032")]
		 set { } //Length: 646
	}

	[Token(Token = "0x1700034D")]
	internal bool InternalAllowBuffering
	{
		[Address(RVA = "0x17F8950", Offset = "0x17F7B50", Length = "0x10")]
		[CalledBy(Type = "System.Net.WebConnection+<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequestStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation), typeof(Stream), typeof(WebConnectionTunnel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6001021")]
		internal get { } //Length: 16
	}

	[Token(Token = "0x17000354")]
	internal long InternalContentLength
	{
		[Address(RVA = "0x96AEB0", Offset = "0x96A0B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001029")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x1700035B")]
	public bool KeepAlive
	{
		[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001034")]
		 get { } //Length: 8
		[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001035")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700035C")]
	public int MaximumAutomaticRedirections
	{
		[Address(RVA = "0x17F8FB0", Offset = "0x17F81B0", Length = "0x81")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001036")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700035F")]
	public virtual string Method
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001039")]
		 get { } //Length: 8
		[Address(RVA = "0x17F9040", Offset = "0x17F8240", Length = "0x2A6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpValidationHelpers), Member = "IsInvalidMethodOrHeaderString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600103A")]
		 set { } //Length: 678
	}

	[Token(Token = "0x1700034E")]
	private bool MethodWithBuffer
	{
		[Address(RVA = "0x17F8960", Offset = "0x17F7B60", Length = "0xE0")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6001022")]
		private get { } //Length: 224
	}

	[Token(Token = "0x17000360")]
	public virtual bool PreAuthenticate
	{
		[Address(RVA = "0x528970", Offset = "0x527B70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600103B")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000361")]
	public Version ProtocolVersion
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600103C")]
		 get { } //Length: 8
		[Address(RVA = "0x17F92F0", Offset = "0x17F84F0", Length = "0x11F")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600103D")]
		 set { } //Length: 287
	}

	[Token(Token = "0x17000362")]
	public virtual IWebProxy Proxy
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600103E")]
		 get { } //Length: 8
		[Address(RVA = "0x17F9410", Offset = "0x17F8610", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600103F")]
		 set { } //Length: 149
	}

	[Token(Token = "0x1700036D")]
	internal bool ProxyQuery
	{
		[Address(RVA = "0x17F8A40", Offset = "0x17F7C40", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600104D")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x1700035E")]
	public int ReadWriteTimeout
	{
		[Address(RVA = "0x17F8A70", Offset = "0x17F7C70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001038")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000363")]
	public virtual Uri RequestUri
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001040")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000364")]
	public bool SendChunked
	{
		[Address(RVA = "0x17F8A80", Offset = "0x17F7C80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001041")]
		 get { } //Length: 8
		[Address(RVA = "0x17F94B0", Offset = "0x17F86B0", Length = "0x6A")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001042")]
		 set { } //Length: 106
	}

	[Token(Token = "0x1700036F")]
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[Address(RVA = "0x17F8A90", Offset = "0x17F7C90", Length = "0x19")]
		[CalledBy(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600104F")]
		 get { } //Length: 25
		[Address(RVA = "0x17F9520", Offset = "0x17F8720", Length = "0xD3")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001050")]
		 set { } //Length: 211
	}

	[Token(Token = "0x1700036E")]
	internal ServerCertValidationCallback ServerCertValidationCallback
	{
		[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600104E")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000365")]
	public ServicePoint ServicePoint
	{
		[Address(RVA = "0x17F8AB0", Offset = "0x17F7CB0", Length = "0x7")]
		[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
		[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetNonFileStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
		[Token(Token = "0x6001043")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000366")]
	internal ServicePoint ServicePointNoLock
	{
		[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001044")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000355")]
	internal bool ThrowOnError
	{
		[Address(RVA = "0x17F8AC0", Offset = "0x17F7CC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600102A")]
		internal get { } //Length: 8
		[Address(RVA = "0x17F9600", Offset = "0x17F8800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600102B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000367")]
	public virtual int Timeout
	{
		[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001045")]
		 get { } //Length: 7
		[Address(RVA = "0x17F9610", Offset = "0x17F8810", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001046")]
		 set { } //Length: 102
	}

	[Token(Token = "0x1700034F")]
	internal MobileTlsProvider TlsProvider
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001023")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000350")]
	internal MonoTlsSettings TlsSettings
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001024")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000368")]
	public string TransferEncoding
	{
		[Address(RVA = "0x17F8AD0", Offset = "0x17F7CD0", Length = "0x4A")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001047")]
		 get { } //Length: 74
	}

	[Token(Token = "0x1700036A")]
	public bool UnsafeAuthenticatedConnectionSharing
	{
		[Address(RVA = "0x17F8B20", Offset = "0x17F7D20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001049")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000369")]
	public virtual bool UseDefaultCredentials
	{
		[Address(RVA = "0x17F8B30", Offset = "0x17F7D30", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001048")]
		 get { } //Length: 121
	}

	[Address(RVA = "0x17F8160", Offset = "0x17F7360", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RequestCachePolicy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestCacheLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001016")]
	private static HttpWebRequest() { }

	[Address(RVA = "0x17F8540", Offset = "0x17F7740", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x6001019")]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F8270", Offset = "0x17F7470", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[Token(Token = "0x6001075")]
	public HttpWebRequest() { }

	[Address(RVA = "0x17F82A0", Offset = "0x17F74A0", Length = "0x297")]
	[CalledBy(Type = typeof(HttpRequestCreator), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(MobileTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001017")]
	public HttpWebRequest(Uri uri) { }

	[Address(RVA = "0x17F8210", Offset = "0x17F7410", Length = "0x5B")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001018")]
	internal HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null) { }

	[Address(RVA = "0x17F8050", Offset = "0x17F7250", Length = "0x101")]
	[AsyncStateMachine(typeof(<<GetRewriteHandler>b__271_0>d))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<GetRewriteHandler>b__271_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<GetRewriteHandler>b__271_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6001074")]
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[Address(RVA = "0x6D8B70", Offset = "0x6D7D70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001073")]
	private bool <RunWithTimeout>b__242_0() { }

	[Address(RVA = "0x17F4C50", Offset = "0x17F3E50", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "TrySetCanceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001065")]
	public virtual void Abort() { }

	[Address(RVA = "0x17F4D20", Offset = "0x17F3F20", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Token(Token = "0x6001054")]
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x17F4DD0", Offset = "0x17F3FD0", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001060")]
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x17F4FA0", Offset = "0x17F41A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthorizationState), Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001070")]
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	[Address(RVA = "0x17F4FD0", Offset = "0x17F41D0", Length = "0x509")]
	[CalledBy(Type = typeof(<GetResponseFromData>d__244), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValueTuple`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AuthorizationState), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AuthorizationState), Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001072")]
	private ValueTuple<Boolean, Boolean, Task`1<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[Address(RVA = "0x17F54E0", Offset = "0x17F46E0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001068")]
	private void CheckRequestStarted() { }

	[Address(RVA = "0x17F5550", Offset = "0x17F4750", Length = "0x9D")]
	[CalledBy(Type = typeof(<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[Token(Token = "0x600105F")]
	internal static WebException CreateRequestAbortedException() { }

	[Address(RVA = "0x17F55F0", Offset = "0x17F47F0", Length = "0x1B")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001069")]
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	[Address(RVA = "0x17F5610", Offset = "0x17F4810", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AuthenticationManager), Member = "PreAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600106D")]
	private void DoPreAuthenticate() { }

	[Address(RVA = "0x17F57A0", Offset = "0x17F49A0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(WebException))]
	[Token(Token = "0x6001055")]
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17F5870", Offset = "0x17F4A70", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(WebException))]
	[Token(Token = "0x6001061")]
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17F5940", Offset = "0x17F4B40", Length = "0xB7")]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(bool), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AggregateException), Member = "Flatten", ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600105C")]
	internal static Exception FlattenException(Exception e) { }

	[Address(RVA = "0x17F86E0", Offset = "0x17F78E0", Length = "0x23")]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__2", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "<RunWithTimeout>b__242_0", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(WebOperation), Member = "get_Closed", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001064")]
	internal bool get_Aborted() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600101B")]
	public Uri get_Address() { }

	[Address(RVA = "0x168EFB0", Offset = "0x168E1B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600101D")]
	public override bool get_AllowWriteStreamBuffering() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600104C")]
	internal Uri get_AuthUri() { }

	[Address(RVA = "0x17F8710", Offset = "0x17F7910", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600101F")]
	public DecompressionMethods get_AutomaticDecompression() { }

	[Address(RVA = "0x17F8720", Offset = "0x17F7920", Length = "0x69")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001025")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001027")]
	public virtual long get_ContentLength() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600102D")]
	public virtual ICredentials get_Credentials() { }

	[Address(RVA = "0x17F8790", Offset = "0x17F7990", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600102F")]
	public static int get_DefaultMaximumErrorResponseLength() { }

	[Address(RVA = "0x17F87E0", Offset = "0x17F79E0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001037")]
	public static int get_DefaultMaximumResponseHeadersLength() { }

	[Address(RVA = "0x17F8830", Offset = "0x17F7A30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600104A")]
	internal bool get_ExpectContinue() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001030")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x17F8840", Offset = "0x17F7A40", Length = "0x108")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper+<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001031")]
	public string get_Host() { }

	[Address(RVA = "0x17F8950", Offset = "0x17F7B50", Length = "0x10")]
	[CalledBy(Type = "System.Net.WebConnection+<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation), typeof(Stream), typeof(WebConnectionTunnel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001021")]
	internal bool get_InternalAllowBuffering() { }

	[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001034")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001039")]
	public virtual string get_Method() { }

	[Address(RVA = "0x17F8960", Offset = "0x17F7B60", Length = "0xE0")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001022")]
	private bool get_MethodWithBuffer() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600103C")]
	public Version get_ProtocolVersion() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600103E")]
	public virtual IWebProxy get_Proxy() { }

	[Address(RVA = "0x17F8A40", Offset = "0x17F7C40", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600104D")]
	internal bool get_ProxyQuery() { }

	[Address(RVA = "0x17F8A70", Offset = "0x17F7C70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001038")]
	public int get_ReadWriteTimeout() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001040")]
	public virtual Uri get_RequestUri() { }

	[Address(RVA = "0x17F8A80", Offset = "0x17F7C80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001041")]
	public bool get_SendChunked() { }

	[Address(RVA = "0x17F8A90", Offset = "0x17F7C90", Length = "0x19")]
	[CalledBy(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600104F")]
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	[Address(RVA = "0x3D66C0", Offset = "0x3D58C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600104E")]
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	[Address(RVA = "0x17F8AB0", Offset = "0x17F7CB0", Length = "0x7")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetNonFileStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
	[Token(Token = "0x6001043")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001044")]
	internal ServicePoint get_ServicePointNoLock() { }

	[Address(RVA = "0x17F8AC0", Offset = "0x17F7CC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600102A")]
	internal bool get_ThrowOnError() { }

	[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001045")]
	public virtual int get_Timeout() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001023")]
	internal MobileTlsProvider get_TlsProvider() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001024")]
	internal MonoTlsSettings get_TlsSettings() { }

	[Address(RVA = "0x17F8AD0", Offset = "0x17F7CD0", Length = "0x4A")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001047")]
	public string get_TransferEncoding() { }

	[Address(RVA = "0x17F8B20", Offset = "0x17F7D20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001049")]
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	[Address(RVA = "0x17F8B30", Offset = "0x17F7D30", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001048")]
	public virtual bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x17F5A00", Offset = "0x17F4C00", Length = "0x90E")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AuthenticationManager), Member = "PreAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600106C")]
	private string GetHeaders() { }

	[Address(RVA = "0x17F6310", Offset = "0x17F5510", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001067")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F6350", Offset = "0x17F5550", Length = "0x3F3")]
	[CalledBy(Type = "System.Net.WebRequestStream+<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Version), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600106E")]
	internal Byte[] GetRequestHeaders() { }

	[Address(RVA = "0x17F6750", Offset = "0x17F5950", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Token(Token = "0x6001056")]
	public virtual Task<Stream> GetRequestStreamAsync() { }

	[Address(RVA = "0x17F6930", Offset = "0x17F5B30", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001062")]
	public virtual WebResponse GetResponse() { }

	[Address(RVA = "0x17F67E0", Offset = "0x17F59E0", Length = "0x14E")]
	[AsyncStateMachine(typeof(<GetResponseFromData>d__244))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetResponseFromData>d__244)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetResponseFromData>d__244&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`5<System.Object, System.Boolean, System.Boolean, System.Object, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600105B")]
	private Task<ValueTuple`5<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17F69D0", Offset = "0x17F5BD0", Length = "0x1F6")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebRequestStream), Member = "get_WriteBufferLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebRequestStream), Member = "GetWriteBuffer", ReturnType = typeof(BufferOffsetSize))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001071")]
	private ValueTuple<Task`1<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	[Address(RVA = "0x17F6BD0", Offset = "0x17F5DD0", Length = "0x10E")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Proxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IWebProxy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(WebOperation))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001051")]
	internal ServicePoint GetServicePoint() { }

	[Address(RVA = "0x17F6CE0", Offset = "0x17F5EE0", Length = "0x24C")]
	[CalledBy(Type = typeof(<RunWithTimeoutWorker>d__241`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(WebException))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AggregateException), Member = "Flatten", ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600105E")]
	private static WebException GetWebException(Exception e, bool aborted) { }

	[Address(RVA = "0x17F6F30", Offset = "0x17F6130", Length = "0x75")]
	[CalledBy(Type = typeof(<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(WebException))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600105D")]
	private WebException GetWebException(Exception e) { }

	[Address(RVA = "0x17F6FB0", Offset = "0x17F61B0", Length = "0x204")]
	[CalledBy(Type = typeof(<GetResponseFromData>d__244), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(BufferOffsetSize), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "SetPriorityRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600106F")]
	private ValueTuple<WebOperation, Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17F71C0", Offset = "0x17F63C0", Length = "0x3D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(WebOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(WebOperation), Member = "GetRequestStream", ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_TransferEncoding", ReturnType = typeof(string))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6001053")]
	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x17F75A0", Offset = "0x17F67A0", Length = "0x110")]
	[AsyncStateMachine(typeof(<MyGetResponseAsync>d__243))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MyGetResponseAsync>d__243)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MyGetResponseAsync>d__243&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600105A")]
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x17F76B0", Offset = "0x17F68B0", Length = "0x4F0")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebRequestStream), Member = "get_WriteBufferLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RewriteRedirectToGet", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600106B")]
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	[Address(RVA = "0x17F7BC0", Offset = "0x17F6DC0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600101A")]
	private void ResetAuthorization() { }

	[Address(RVA = "0x17F7C50", Offset = "0x17F6E50", Length = "0x7F")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600106A")]
	private void RewriteRedirectToGet() { }

	[Address(RVA = "0x6D8720", Offset = "0x6D7920", Length = "0x1EF")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunWithTimeoutWorker>d__241`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001057")]
	internal static Task<T> RunWithTimeout(Func<CancellationToken, Task`1<T>> func, int timeout, Action abort, Func<Boolean> aborted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6D8910", Offset = "0x6D7B10", Length = "0x254")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestStreamAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunWithTimeoutWorker>d__241`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001059")]
	private Task<T> RunWithTimeout(Func<CancellationToken, Task`1<T>> func) { }

	[Address(RVA = "0x6D81D0", Offset = "0x6D73D0", Length = "0x143")]
	[AsyncStateMachine(typeof(<RunWithTimeoutWorker>d__241`1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunWithTimeoutWorker>d__241`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001058")]
	private static Task<T> RunWithTimeoutWorker(Task<T> workerTask, int timeout, Action abort, Func<Boolean> aborted, CancellationTokenSource cts) { }

	[Address(RVA = "0x17F7CD0", Offset = "0x17F6ED0", Length = "0x263")]
	[CalledBy(Type = typeof(<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IO.Stream>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(BufferOffsetSize), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ServicePoint), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x6001052")]
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600101C")]
	public override void set_AllowAutoRedirect(bool value) { }

	[Address(RVA = "0x17F8BB0", Offset = "0x17F7DB0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600101E")]
	public override void set_AllowWriteStreamBuffering(bool value) { }

	[Address(RVA = "0x17F8BC0", Offset = "0x17F7DC0", Length = "0x6A")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001020")]
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001026")]
	public virtual void set_ConnectionGroupName(string value) { }

	[Address(RVA = "0x17F8C30", Offset = "0x17F7E30", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001028")]
	public virtual void set_ContentLength(long value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600102C")]
	public override void set_CookieContainer(CookieContainer value) { }

	[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600102E")]
	public virtual void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x17F8D00", Offset = "0x17F7F00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600104B")]
	internal void set_ExpectContinue(bool value) { }

	[Address(RVA = "0x17F8D10", Offset = "0x17F7F10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001063")]
	internal void set_FinishedReading(bool value) { }

	[Address(RVA = "0x17F8D20", Offset = "0x17F7F20", Length = "0x286")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001032")]
	public void set_Host(string value) { }

	[Address(RVA = "0x96AEB0", Offset = "0x96A0B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001029")]
	internal void set_InternalContentLength(long value) { }

	[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001035")]
	public void set_KeepAlive(bool value) { }

	[Address(RVA = "0x17F8FB0", Offset = "0x17F81B0", Length = "0x81")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001036")]
	public void set_MaximumAutomaticRedirections(int value) { }

	[Address(RVA = "0x17F9040", Offset = "0x17F8240", Length = "0x2A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpValidationHelpers), Member = "IsInvalidMethodOrHeaderString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600103A")]
	public virtual void set_Method(string value) { }

	[Address(RVA = "0x528970", Offset = "0x527B70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600103B")]
	public virtual void set_PreAuthenticate(bool value) { }

	[Address(RVA = "0x17F92F0", Offset = "0x17F84F0", Length = "0x11F")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600103D")]
	public void set_ProtocolVersion(Version value) { }

	[Address(RVA = "0x17F9410", Offset = "0x17F8610", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600103F")]
	public virtual void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x17F94B0", Offset = "0x17F86B0", Length = "0x6A")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001042")]
	public void set_SendChunked(bool value) { }

	[Address(RVA = "0x17F9520", Offset = "0x17F8720", Length = "0xD3")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001050")]
	public void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[Address(RVA = "0x17F9600", Offset = "0x17F8800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600102B")]
	internal void set_ThrowOnError(bool value) { }

	[Address(RVA = "0x17F9610", Offset = "0x17F8810", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001046")]
	public virtual void set_Timeout(int value) { }

	[Address(RVA = "0x17F7F40", Offset = "0x17F7140", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001066")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F7F80", Offset = "0x17F7180", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001033")]
	private bool TryGetHostUri(string hostName, out Uri hostUri) { }

}

