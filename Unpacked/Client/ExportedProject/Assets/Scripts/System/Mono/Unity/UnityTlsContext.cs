namespace Mono.Unity;

[Token(Token = "0x2000041")]
internal class UnityTlsContext : MobileTlsContext
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000082")]
	private unitytls_tlsctx* tlsContext; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000083")]
	private unitytls_x509list* requestedClientCertChain; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000084")]
	private unitytls_key* requestedClientKey; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000085")]
	private unitytls_tlsctx_read_callback readCallback; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000086")]
	private unitytls_tlsctx_write_callback writeCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000087")]
	private unitytls_tlsctx_certificate_callback certificateCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000088")]
	private unitytls_tlsctx_x509verify_callback verifyCallback; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000089")]
	private X509Certificate localClientCertificate; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400008A")]
	private X509Certificate2 remoteCertificate; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400008B")]
	private MonoTlsConnectionInfo connectioninfo; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400008C")]
	private bool isAuthenticated; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x400008D")]
	private bool hasContext; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x400008E")]
	private bool closedGraceful; //Field offset: 0xAA
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400008F")]
	private Byte[] writeBuffer; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000090")]
	private Byte[] readBuffer; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000091")]
	private GCHandle handle; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000092")]
	private Exception lastException; //Field offset: 0xC8

	[Token(Token = "0x1700000A")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000079")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	internal virtual X509Certificate LocalClientCertificate
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public virtual X509Certificate2 RemoteCertificate
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1603430", Offset = "0x1602630", Length = "0xB9E")]
	[CalledBy(Type = typeof(UnityTlsStream), Member = "CreateContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(MobileTlsContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815ECD20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815ECCD0")]
	[Calls(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x6000077")]
	public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x1601660", Offset = "0x1600860", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_certificate_callback))]
	[Token(Token = "0x600008C")]
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x1601310", Offset = "0x1600510", Length = "0x347")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600008D")]
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x16017A0", Offset = "0x16009A0", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000082")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1601900", Offset = "0x1600B00", Length = "0x31D")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000078")]
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	[Address(RVA = "0x1601C20", Offset = "0x1600E20", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000085")]
	public virtual void FinishHandshake() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public virtual void Flush() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000079")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	internal virtual X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public virtual X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public virtual bool PendingRenegotiation() { }

	[Address(RVA = "0x1601DA0", Offset = "0x1600FA0", Length = "0x32E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_errorstate), typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityTlsConversions), Member = "VerifyResultToAlertDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509verify_result), typeof(AlertDescription)}, ReturnType = typeof(AlertDescription))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000084")]
	public virtual bool ProcessHandshake() { }

	[Address(RVA = "0x16024C0", Offset = "0x16016C0", Length = "0x20D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_errorstate), typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007D")]
	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x16020D0", Offset = "0x16012D0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_read_callback))]
	[Token(Token = "0x6000088")]
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x1602210", Offset = "0x1601410", Length = "0x2A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000089")]
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x16026D0", Offset = "0x16018D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600007F")]
	public virtual void Renegotiate() { }

	[Address(RVA = "0x1602710", Offset = "0x1601910", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000081")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x1602850", Offset = "0x1601A50", Length = "0x24B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000083")]
	public virtual void StartHandshake() { }

	[Address(RVA = "0x1602DB0", Offset = "0x1601FB0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_x509verify_callback))]
	[Token(Token = "0x600008A")]
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x1602AA0", Offset = "0x1601CA0", Length = "0x2FF")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x1603220", Offset = "0x1602420", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_errorstate), typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007E")]
	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x16030E0", Offset = "0x16022E0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(IntPtr), typeof(unitytls_errorstate*)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_write_callback))]
	[Token(Token = "0x6000086")]
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x1602ED0", Offset = "0x16020D0", Length = "0x205")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_errorstate*)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000087")]
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

