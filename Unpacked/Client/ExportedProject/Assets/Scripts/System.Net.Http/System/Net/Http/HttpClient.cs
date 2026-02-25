namespace System.Net.Http;

[Token(Token = "0x200000B")]
public class HttpClient : HttpMessageInvoker
{
	[CompilerGenerated]
	[Token(Token = "0x200000C")]
	private struct <SendAsyncWorker>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400003C")]
		public HttpClient <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400003D")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400003E")]
		public HttpRequestMessage request; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400003F")]
		public HttpCompletionOption completionOption; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000040")]
		private CancellationTokenSource <lcts>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000041")]
		private HttpResponseMessage <response>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000042")]
		private ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000043")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x60

		[Address(RVA = "0x161FDE0", Offset = "0x161EFE0", Length = "0x78A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<SendAsyncWorker>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<SendAsyncWorker>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<SendAsyncWorker>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<SendAsyncWorker>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(HttpContent), Member = "LoadIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600003A")]
		private override void MoveNext() { }

		[Address(RVA = "0x1620570", Offset = "0x161F770", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600003B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000033")]
	private static readonly TimeSpan TimeoutDefault; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000034")]
	private Uri base_address; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000035")]
	private CancellationTokenSource cts; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	private bool disposed; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000037")]
	private HttpRequestHeaders headers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000038")]
	private long buffer_size; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000039")]
	private TimeSpan timeout; //Field offset: 0x48

	[Token(Token = "0x17000007")]
	public HttpRequestHeaders DefaultRequestHeaders
	{
		[Address(RVA = "0x160CB00", Offset = "0x160BD00", Length = "0xA1")]
		[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000008")]
	public long MaxResponseContentBufferSize
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x160C830", Offset = "0x160BA30", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000038")]
	private static HttpClient() { }

	[Address(RVA = "0x160C9C0", Offset = "0x160BBC0", Length = "0x13D")]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HttpClientHandler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public HttpClient() { }

	[Address(RVA = "0x160C8A0", Offset = "0x160BAA0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	public HttpClient(HttpMessageHandler handler, bool disposeHandler) { }

	[Address(RVA = "0x160C800", Offset = "0x160BA00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[Address(RVA = "0x160BF20", Offset = "0x160B120", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x160CB00", Offset = "0x160BD00", Length = "0xA1")]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000030")]
	public HttpRequestHeaders get_DefaultRequestHeaders() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public long get_MaxResponseContentBufferSize() { }

	[Address(RVA = "0x160BFA0", Offset = "0x160B1A0", Length = "0x214")]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000033")]
	public Task<HttpResponseMessage> GetAsync(string requestUri) { }

	[Address(RVA = "0x160C310", Offset = "0x160B510", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	[Address(RVA = "0x160C7E0", Offset = "0x160B9E0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[Token(Token = "0x6000035")]
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[Address(RVA = "0x160C380", Offset = "0x160B580", Length = "0x453")]
	[CalledBy(Type = typeof(HttpClient), Member = "GetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsyncWorker>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsyncWorker>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpRequestHeaders), Member = "AddHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeaders)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpRequestMessage), Member = "get_Headers", ReturnType = typeof(HttpRequestHeaders))]
	[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000036")]
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[Address(RVA = "0x160C1C0", Offset = "0x160B3C0", Length = "0x149")]
	[AsyncStateMachine(typeof(<SendAsyncWorker>d__47))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsyncWorker>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsyncWorker>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

}

