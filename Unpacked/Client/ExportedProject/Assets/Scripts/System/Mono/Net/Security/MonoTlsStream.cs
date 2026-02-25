namespace Mono.Net.Security;

[Token(Token = "0x2000062")]
internal class MonoTlsStream : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000063")]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000124")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000126")]
		public MonoTlsStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000127")]
		public WebConnectionTunnel tunnel; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000128")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000129")]
		private Socket <socket>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012A")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x15FE010", Offset = "0x15FD210", Length = "0x6A6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
		[Calls(Type = typeof(MonoTlsStream), Member = "CloseSslStream", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<CreateStream>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePoint), Member = "UpdateClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_ClientCertificates", ReturnType = typeof(X509CertificateCollection))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(MonoTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(NetworkStream), Member = "get_InternalSocket", ReturnType = typeof(Socket))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Socket), Member = "get_CleanedUp", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000183")]
		private override void MoveNext() { }

		[Address(RVA = "0x15FE6C0", Offset = "0x15FD8C0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000184")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011C")]
	private readonly MobileTlsProvider provider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011D")]
	private readonly NetworkStream networkStream; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011E")]
	private readonly HttpWebRequest request; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011F")]
	private readonly MonoTlsSettings settings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000120")]
	private SslStream sslStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000121")]
	private readonly object sslStreamLock; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000122")]
	private WebExceptionStatus status; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000123")]
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0x44

	[Token(Token = "0x1700005F")]
	internal bool CertificateValidationFailed
	{
		[Address(RVA = "0x53EA60", Offset = "0x53DC60", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600017D")]
		internal get { } //Length: 5
		[Address(RVA = "0x53EA80", Offset = "0x53DC80", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600017E")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700005E")]
	internal WebExceptionStatus ExceptionStatus
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017C")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	internal HttpWebRequest Request
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017B")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x15FC650", Offset = "0x15FB850", Length = "0x26D")]
	[CalledBy(Type = "System.Net.WebConnection+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_ServerCertificateValidationCallback", ReturnType = typeof(RemoteCertificateValidationCallback))]
	[Calls(Type = typeof(MonoRemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
	[Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600017F")]
	public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) { }

	[Address(RVA = "0x15FC440", Offset = "0x15FB640", Length = "0xA3")]
	[CalledBy(Type = typeof(<CreateStream>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoTlsStream), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000182")]
	private void CloseSslStream() { }

	[Address(RVA = "0x15FC4F0", Offset = "0x15FB6F0", Length = "0x149")]
	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	[CalledBy(Type = "System.Net.WebConnection+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateStream>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateStream>d__18&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000180")]
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	[Address(RVA = "0x15FC640", Offset = "0x15FB840", Length = "0x7")]
	[CalledBy(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoTlsStream), Member = "CloseSslStream", ReturnType = typeof(void))]
	[Token(Token = "0x6000181")]
	public override void Dispose() { }

	[Address(RVA = "0x53EA60", Offset = "0x53DC60", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	internal bool get_CertificateValidationFailed() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	internal WebExceptionStatus get_ExceptionStatus() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	internal HttpWebRequest get_Request() { }

	[Address(RVA = "0x53EA80", Offset = "0x53DC80", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600017E")]
	internal void set_CertificateValidationFailed(bool value) { }

}

