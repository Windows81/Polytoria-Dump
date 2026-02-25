namespace System.Net.Security;

[Token(Token = "0x200031A")]
public class SslStream : AuthenticatedStream
{
	[CompilerGenerated]
	[Token(Token = "0x200031B")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E75")]
		public LocalCertificateSelectionCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E76")]
		public SslStream <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001418")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x172FD80", Offset = "0x172EF80", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001419")]
		internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E6F")]
	private MobileTlsProvider provider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E70")]
	private MonoTlsSettings settings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E71")]
	private RemoteCertificateValidationCallback validationCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E72")]
	private LocalCertificateSelectionCallback selectionCallback; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E73")]
	private MobileAuthenticatedStream impl; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E74")]
	private bool explicitSettings; //Field offset: 0x60

	[Token(Token = "0x17000435")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x172AD90", Offset = "0x1729F90", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001401")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000434")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001400")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000436")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x32F240", Offset = "0x32E440", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001402")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000437")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x172ADC0", Offset = "0x1729FC0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001403")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000430")]
	internal MobileAuthenticatedStream Impl
	{
		[Address(RVA = "0x172ADF0", Offset = "0x1729FF0", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013F0")]
		internal get { } //Length: 102
	}

	[Token(Token = "0x17000431")]
	internal string InternalTargetHost
	{
		[Address(RVA = "0x172AE60", Offset = "0x172A060", Length = "0x6D")]
		[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper+<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013F1")]
		internal get { } //Length: 109
	}

	[Token(Token = "0x17000432")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x172AED0", Offset = "0x172A0D0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60013FE")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700043A")]
	public virtual long Length
	{
		[Address(RVA = "0x172AF50", Offset = "0x172A150", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001408")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000433")]
	public override X509Certificate LocalCertificate
	{
		[Address(RVA = "0x172AFD0", Offset = "0x172A1D0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MobileAuthenticatedStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013FF")]
		 get { } //Length: 108
	}

	[Token(Token = "0x1700043B")]
	public virtual long Position
	{
		[Address(RVA = "0x172B040", Offset = "0x172A240", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001409")]
		 get { } //Length: 121
		[Address(RVA = "0x172B1C0", Offset = "0x172A3C0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600140A")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000438")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x172B0C0", Offset = "0x172A2C0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001404")]
		 get { } //Length: 121
		[Address(RVA = "0x172B220", Offset = "0x172A420", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001405")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000439")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x172B140", Offset = "0x172A340", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001406")]
		 get { } //Length: 121
		[Address(RVA = "0x172B2A0", Offset = "0x172A4A0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001407")]
		 set { } //Length: 121
	}

	[Address(RVA = "0x172AB50", Offset = "0x1729D50", Length = "0x1A")]
	[CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Socket), typeof(string), typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientSslHelper", Member = "CreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Uri)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = "CreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013F3")]
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	[Address(RVA = "0x172AB70", Offset = "0x1729D70", Length = "0x21F")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SslStream), Member = "SetAndVerifySelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackHelpers), Member = "PublicToMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013F4")]
	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	[Address(RVA = "0x172A9E0", Offset = "0x1729BE0", Length = "0x164")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013F5")]
	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	[Address(RVA = "0x1729F40", Offset = "0x1729140", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013F9")]
	public override void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x1729FC0", Offset = "0x17291C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013F8")]
	public override void AuthenticateAsClient(string targetHost) { }

	[Address(RVA = "0x1729EC0", Offset = "0x17290C0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013FD")]
	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x172A050", Offset = "0x1729250", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(bool), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013FC")]
	public override void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x172A0D0", Offset = "0x17292D0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(SslProtocols), typeof(bool)}, ReturnType = typeof(Task))]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013FA")]
	public override IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x172A170", Offset = "0x1729370", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001414")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x172A200", Offset = "0x1729400", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001416")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x172A290", Offset = "0x1729490", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600140E")]
	private void CheckDisposed() { }

	[Address(RVA = "0x172A300", Offset = "0x1729500", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AuthenticatedStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600140F")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1321170", Offset = "0x1320370", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FB")]
	public override void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	[Address(RVA = "0x172A3B0", Offset = "0x17295B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "TResult")]
	[Token(Token = "0x6001415")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1321170", Offset = "0x1320370", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001417")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x32EFC0", Offset = "0x32E1C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600140D")]
	public virtual void Flush() { }

	[Address(RVA = "0x172AD90", Offset = "0x1729F90", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001401")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001400")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x32F240", Offset = "0x32E440", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001402")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x172ADC0", Offset = "0x1729FC0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001403")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x172ADF0", Offset = "0x1729FF0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013F0")]
	internal MobileAuthenticatedStream get_Impl() { }

	[Address(RVA = "0x172AE60", Offset = "0x172A060", Length = "0x6D")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper+<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013F1")]
	internal string get_InternalTargetHost() { }

	[Address(RVA = "0x172AED0", Offset = "0x172A0D0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013FE")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x172AF50", Offset = "0x172A150", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001408")]
	public virtual long get_Length() { }

	[Address(RVA = "0x172AFD0", Offset = "0x172A1D0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013FF")]
	public override X509Certificate get_LocalCertificate() { }

	[Address(RVA = "0x172B040", Offset = "0x172A240", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001409")]
	public virtual long get_Position() { }

	[Address(RVA = "0x172B0C0", Offset = "0x172A2C0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001404")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x172B140", Offset = "0x172A340", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001406")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x172A3F0", Offset = "0x17295F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60013F2")]
	private static MobileTlsProvider GetProvider() { }

	[Address(RVA = "0x172A4E0", Offset = "0x17296E0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001410")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x172A460", Offset = "0x1729660", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001412")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x172A560", Offset = "0x1729760", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600140C")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x172B1C0", Offset = "0x172A3C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600140A")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x172B220", Offset = "0x172A420", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001405")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x172B2A0", Offset = "0x172A4A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001407")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x172A5C0", Offset = "0x17297C0", Length = "0x1AB")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60013F7")]
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	[Address(RVA = "0x172A770", Offset = "0x1729970", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackHelpers), Member = "PublicToMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013F6")]
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	[Address(RVA = "0x172A860", Offset = "0x1729A60", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600140B")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x172A960", Offset = "0x1729B60", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001411")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x172A8E0", Offset = "0x1729AE0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001413")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

