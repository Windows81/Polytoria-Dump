namespace System.Net.Http;

[Token(Token = "0x2000006")]
internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c
	{
		[Token(Token = "0x400001E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400001F")]
		public static Func<String, Boolean> <>9__95_0; //Field offset: 0x8
		[Token(Token = "0x4000020")]
		public static Func<String, Boolean> <>9__96_1; //Field offset: 0x10
		[Token(Token = "0x4000021")]
		public static Action<Object> <>9__99_0; //Field offset: 0x18

		[Address(RVA = "0x1620B60", Offset = "0x161FD60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000024")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		public <>c() { }

		[Address(RVA = "0x16205E0", Offset = "0x161F7E0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000027")]
		internal bool <CreateWebRequest>b__96_1(string l) { }

		[Address(RVA = "0x1620620", Offset = "0x161F820", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000026")]
		internal bool <GetConnectionKeepAlive>b__95_0(string l) { }

		[Address(RVA = "0x1620670", Offset = "0x161F870", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		internal void <SendAsync>b__99_0(object l) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private struct <SendAsync>d__99 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000024")]
		public MonoWebRequestHandler <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000025")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000026")]
		public HttpRequestMessage request; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000027")]
		private HttpWebRequest <wrequest>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000028")]
		private HttpWebResponse <wresponse>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000029")]
		private CancellationTokenRegistration <>7__wrap3; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400002A")]
		private HttpContent <content>5__5; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400002B")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400002C")]
		private Stream <stream>5__6; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400002D")]
		private ConfiguredTaskAwaiter<Stream> <>u__2; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400002E")]
		private ConfiguredTaskAwaiter<WebResponse> <>u__3; //Field offset: 0x90
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400002F")]
		private TaskAwaiter<HttpResponseMessage> <>u__4; //Field offset: 0xA0

		[Address(RVA = "0x161DCE0", Offset = "0x161CEE0", Length = "0x2089")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpResponseMessage), Member = "get_Headers", ReturnType = typeof(HttpResponseHeaders))]
		[Calls(Type = typeof(HttpHeaders), Member = "TryAddWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "SetCanceled", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(Stream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(HttpWebRequest), Member = "set_SendChunked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpContent), Member = "get_Headers", ReturnType = typeof(HttpContentHeaders))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E0A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpRequestMessage), Member = "get_Headers", ReturnType = typeof(HttpRequestHeaders))]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(HttpContentHeaders), Member = "get_ContentLength", ReturnType = typeof(System.Nullable`1<System.Int64>))]
		[Calls(Type = typeof(HttpContent), Member = "LoadIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(HttpRequestException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallsUnknownMethods(Count = 25)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000029")]
		private override void MoveNext() { }

		[Address(RVA = "0x161FD70", Offset = "0x161EF70", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600002A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000005")]
	private static long groupCounter; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private bool allowAutoRedirect; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000007")]
	private DecompressionMethods automaticDecompression; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000008")]
	private CookieContainer cookieContainer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000009")]
	private ICredentials credentials; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	private int maxAutomaticRedirections; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000B")]
	private long maxRequestContentBufferSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000C")]
	private bool preAuthenticate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000D")]
	private IWebProxy proxy; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000E")]
	private bool useCookies; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x400000F")]
	private bool useProxy; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000010")]
	private SslClientAuthenticationOptions sslOptions; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000011")]
	private bool allowPipelining; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000012")]
	private RequestCachePolicy cachePolicy; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000013")]
	private AuthenticationLevel authenticationLevel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000014")]
	private TimeSpan continueTimeout; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000015")]
	private TokenImpersonationLevel impersonationLevel; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000016")]
	private int maxResponseHeadersLength; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000017")]
	private int readWriteTimeout; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000018")]
	private RemoteCertificateValidationCallback serverCertificateValidationCallback; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000019")]
	private bool unsafeAuthenticatedConnectionSharing; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x400001A")]
	private bool sentRequest; //Field offset: 0x91
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400001B")]
	private string connectionGroupName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400001C")]
	private Nullable<TimeSpan> timeout; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400001D")]
	private bool disposed; //Field offset: 0xB0

	[Token(Token = "0x17000004")]
	public override CookieContainer CookieContainer
	{
		[Address(RVA = "0x1616E80", Offset = "0x1616080", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CookieContainer), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000005")]
	public override long MaxRequestContentBufferSize
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000006")]
	public override SslClientAuthenticationOptions SslOptions
	{
		[Address(RVA = "0x1616EF0", Offset = "0x16160F0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 106
		[Address(RVA = "0x1616F60", Offset = "0x1616160", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600001A")]
		 set { } //Length: 112
	}

	[Address(RVA = "0x1616CC0", Offset = "0x1615EC0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public MonoWebRequestHandler() { }

	[Address(RVA = "0x1616BF0", Offset = "0x1615DF0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	private X509Certificate <CreateWebRequest>b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	[Address(RVA = "0x1615460", Offset = "0x1614660", Length = "0x437")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpResponseMessage), Member = "get_Headers", ReturnType = typeof(HttpResponseHeaders))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpHeaders), Member = "TryAddWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpContent), Member = "get_Headers", ReturnType = typeof(HttpContentHeaders))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x600001F")]
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	[Address(RVA = "0x16158A0", Offset = "0x1614AA0", Length = "0xE4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "set_MaximumAutomaticRedirections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "set_AutomaticDecompression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecompressionMethods)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CookieContainer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(PlatformHelper), Member = "GetSingleHeaderString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpRequestHeaders), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "set_ServerCertificateValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "GetProviderInternal", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), "Mono.Net.Security.MobileTlsProvider", typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebRequest), Member = "set_ProtocolVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpRequestMessage), Member = "get_Headers", ReturnType = typeof(HttpRequestHeaders))]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Calls(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	internal override HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	[Address(RVA = "0x1616770", Offset = "0x1615970", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public override void Dispose() { }

	[Address(RVA = "0x16166F0", Offset = "0x16158F0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ServicePointManager), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1616790", Offset = "0x1615990", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000016")]
	internal void EnsureModifiability() { }

	[Address(RVA = "0x1616E80", Offset = "0x1616080", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CookieContainer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000017")]
	public override CookieContainer get_CookieContainer() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public override long get_MaxRequestContentBufferSize() { }

	[Address(RVA = "0x1616EF0", Offset = "0x16160F0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public override SslClientAuthenticationOptions get_SslOptions() { }

	[Address(RVA = "0x1616800", Offset = "0x1615A00", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001D")]
	private bool GetConnectionKeepAlive(HttpRequestHeaders headers) { }

	[Address(RVA = "0x1616970", Offset = "0x1615B70", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000020")]
	private static bool MethodHasBody(HttpMethod method) { }

	[Address(RVA = "0x1616A60", Offset = "0x1615C60", Length = "0x12E")]
	[AsyncStateMachine(typeof(<SendAsync>d__99))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsync>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendAsync>d__99&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1616F60", Offset = "0x1616160", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600001A")]
	public override void set_SslOptions(SslClientAuthenticationOptions value) { }

	[Address(RVA = "0x1616B90", Offset = "0x1615D90", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000022")]
	private override void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) { }

}

