namespace Mono.Unity;

[Token(Token = "0x2000043")]
internal class UnityTlsProvider : MobileTlsProvider
{

	[Token(Token = "0x1700000E")]
	public virtual Guid ID
	{
		[Address(RVA = "0x1604CC0", Offset = "0x1603EC0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700000D")]
	public virtual string Name
	{
		[Address(RVA = "0x1604D20", Offset = "0x1603F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000013")]
	public virtual SslProtocols SupportedProtocols
	{
		[Address(RVA = "0x15FAAC0", Offset = "0x15F9CC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	internal virtual bool SupportsCleanShutdown
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000011")]
	public virtual bool SupportsConnectionInfo
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000010")]
	public virtual bool SupportsMonoExtensions
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000F")]
	public virtual bool SupportsSslStream
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000096")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	public UnityTlsProvider() { }

	[Address(RVA = "0x1604150", Offset = "0x1603350", Length = "0x1EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferOffsetSize2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[Address(RVA = "0x1604CC0", Offset = "0x1603EC0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000095")]
	public virtual Guid get_ID() { }

	[Address(RVA = "0x1604D20", Offset = "0x1603F20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000094")]
	public virtual string get_Name() { }

	[Address(RVA = "0x15FAAC0", Offset = "0x15F9CC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	public virtual SslProtocols get_SupportedProtocols() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000099")]
	internal virtual bool get_SupportsCleanShutdown() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	public virtual bool get_SupportsConnectionInfo() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public virtual bool get_SupportsMonoExtensions() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000096")]
	public virtual bool get_SupportsSslStream() { }

	[Address(RVA = "0x1604340", Offset = "0x1603540", Length = "0x979")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815ECCD0")]
	[Calls(Type = typeof(unitytls_x509verify_callback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Chain), Member = "get_Impl", ReturnType = typeof(X509ChainImpl))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600009D")]
	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	[Address(RVA = "0x1604D50", Offset = "0x1603F50", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(unitytls_x509verify_callback))]
	[Token(Token = "0x600009C")]
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

}

