namespace Mono.Btls;

[Token(Token = "0x2000075")]
internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400013E")]
	private X509Certificate2 remoteCertificate; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400013F")]
	private X509Certificate clientCertificate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000140")]
	private X509CertificateImplBtls nativeServerCertificate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000141")]
	private X509CertificateImplBtls nativeClientCertificate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000142")]
	private MonoBtlsSslCtx ctx; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000143")]
	private MonoBtlsSsl ssl; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000144")]
	private MonoBtlsBio bio; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000145")]
	private MonoBtlsBio errbio; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000146")]
	private MonoTlsConnectionInfo connectionInfo; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000147")]
	private bool certificateValidated; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000148")]
	private bool isAuthenticated; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000149")]
	private bool connected; //Field offset: 0xA2

	[Token(Token = "0x17000062")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x5D49F0", Offset = "0x5D3BF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000063")]
	internal virtual X509Certificate LocalClientCertificate
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D1")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000064")]
	public virtual X509Certificate2 RemoteCertificate
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15F61D0", Offset = "0x15F53D0", Length = "0x44")]
	[CalledBy(Type = typeof(MonoBtlsStream), Member = "CreateContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(MobileTlsContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001B5")]
	public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x15F3E40", Offset = "0x15F3040", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "Dispose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60001CB")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x7050A0", Offset = "0x7042A0", Length = "0x8A")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CA")]
	private void Dispose(ref T disposable) { }

	[Address(RVA = "0x15F3FA0", Offset = "0x15F31A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001BE")]
	private MonoBtlsSslError DoProcessHandshake() { }

	[Address(RVA = "0x15F4000", Offset = "0x15F3200", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[Token(Token = "0x60001BF")]
	public virtual void FinishHandshake() { }

	[Address(RVA = "0x15F4020", Offset = "0x15F3220", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60001C4")]
	public virtual void Flush() { }

	[Address(RVA = "0x5D49F0", Offset = "0x5D3BF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D0")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D1")]
	internal virtual X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D2")]
	public virtual X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x15F4060", Offset = "0x15F3260", Length = "0x453")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoBtlsError), Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001BC")]
	private static Exception GetException(MonoBtlsSslError status) { }

	[Address(RVA = "0x15F44C0", Offset = "0x15F36C0", Length = "0xD0")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetPeerCertificate", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "CreateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C1")]
	private void GetPeerCertificate() { }

	[Address(RVA = "0x15F45A0", Offset = "0x15F37A0", Length = "0x21C")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001B6")]
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x15F47C0", Offset = "0x15F39C0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60001C3")]
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	[Address(RVA = "0x15F4840", Offset = "0x15F3A40", Length = "0x7FB")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSelectCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetMaxVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetMinVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsServerNameCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsVerifyCallback), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "AddDirectoryLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsX509StoreManager), Member = "GetStorePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "AddCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C0")]
	private void InitializeConnection() { }

	[Address(RVA = "0x15F5040", Offset = "0x15F4240", Length = "0x1F7")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "FinishHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetCipher", ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetServerName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001C2")]
	private void InitializeSession() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CF")]
	private override void Mono.Btls.IMonoBtlsBioMono.Close() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CE")]
	private override void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	[Address(RVA = "0x15F5240", Offset = "0x15F4440", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CC")]
	private override int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	[Address(RVA = "0x15F5270", Offset = "0x15F4470", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CD")]
	private override bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15F52A0", Offset = "0x15F44A0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "RenegotiatePending", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C9")]
	public virtual bool PendingRenegotiation() { }

	[Address(RVA = "0x15F52D0", Offset = "0x15F44D0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "PrintErrors", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckLastError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BD")]
	public virtual bool ProcessHandshake() { }

	[Address(RVA = "0x15F5430", Offset = "0x15F4630", Length = "0x2C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001C5")]
	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x15F5700", Offset = "0x15F4900", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60001C7")]
	public virtual void Renegotiate() { }

	[Address(RVA = "0x15F5740", Offset = "0x15F4940", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[Calls(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001B8")]
	private int SelectCallback(String[] acceptableIssuers) { }

	[Address(RVA = "0x15F5810", Offset = "0x15F4A10", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetServerName", ReturnType = typeof(string))]
	[Calls(Type = typeof(MobileTlsContext), Member = "SelectServerCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B9")]
	private int ServerNameCallback() { }

	[Address(RVA = "0x15F5880", Offset = "0x15F4A80", Length = "0x30D")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "get_X509", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_RevocationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BB")]
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	[Address(RVA = "0x15F5B90", Offset = "0x15F4D90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetQuietShutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C8")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x15F5BF0", Offset = "0x15F4DF0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetRenegotiateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslRenegotiateMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	public virtual void StartHandshake() { }

	[Address(RVA = "0x15F5D50", Offset = "0x15F4F50", Length = "0x206")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B7")]
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	[Address(RVA = "0x15F5F60", Offset = "0x15F5160", Length = "0x266")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60001C6")]
	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int size) { }

}

