namespace Mono.Btls;

[Token(Token = "0x20000A1")]
internal class MonoBtlsX509StoreCtx : MonoBtlsObject
{
	[Token(Token = "0x20000A2")]
	public class BoringX509StoreCtxHandle : MonoBtlsHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001DD")]
		private bool dontFree; //Field offset: 0x20

		[Address(RVA = "0x1732660", Offset = "0x1731860", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000309")]
		internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true) { }

		[Address(RVA = "0x1732690", Offset = "0x1731890", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600030A")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DC")]
	private Nullable<Int32> verifyResult; //Field offset: 0x20

	[Token(Token = "0x1700007D")]
	internal BoringX509StoreCtxHandle Handle
	{
		[Address(RVA = "0x173FEF0", Offset = "0x173F0F0", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetError", ReturnType = typeof(MonoBtlsX509Error))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetChain", ReturnType = typeof(MonoBtlsX509Chain))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetUntrusted", ReturnType = typeof(MonoBtlsX509Chain))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Verify", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Copy", ReturnType = typeof(MonoBtlsX509StoreCtx))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60002F2")]
		internal get { } //Length: 113
	}

	[Token(Token = "0x1700007E")]
	public int VerifyResult
	{
		[Address(RVA = "0x173FF70", Offset = "0x173F170", Length = "0x84")]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000306")]
		 get { } //Length: 132
	}

	[Address(RVA = "0x173FDF0", Offset = "0x173EFF0", Length = "0xCE")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FD")]
	internal MonoBtlsX509StoreCtx() { }

	[Address(RVA = "0x173FEC0", Offset = "0x173F0C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000300")]
	internal MonoBtlsX509StoreCtx(BoringX509StoreCtxHandle ptr, Nullable<Int32> verifyResult) { }

	[Address(RVA = "0x173FC80", Offset = "0x173EE80", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FF")]
	internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx) { }

	[Address(RVA = "0x173F3D0", Offset = "0x173E5D0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000308")]
	public MonoBtlsX509StoreCtx Copy() { }

	[Address(RVA = "0x173F520", Offset = "0x173E720", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FE")]
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	[Address(RVA = "0x173FEF0", Offset = "0x173F0F0", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetError", ReturnType = typeof(MonoBtlsX509Error))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetChain", ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "GetUntrusted", ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Verify", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Copy", ReturnType = typeof(MonoBtlsX509StoreCtx))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002F2")]
	internal BoringX509StoreCtxHandle get_Handle() { }

	[Address(RVA = "0x173FF70", Offset = "0x173F170", Length = "0x84")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000306")]
	public int get_VerifyResult() { }

	[Address(RVA = "0x173F630", Offset = "0x173E830", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000302")]
	public MonoBtlsX509Chain GetChain() { }

	[Address(RVA = "0x173F760", Offset = "0x173E960", Length = "0xA3")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain), typeof(MonoBtlsX509StoreCtx), typeof(bool), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000301")]
	public MonoBtlsX509Error GetError() { }

	[Address(RVA = "0x173F810", Offset = "0x173EA10", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000303")]
	public MonoBtlsX509Chain GetUntrusted() { }

	[Address(RVA = "0x173F940", Offset = "0x173EB40", Length = "0x136")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000304")]
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	[Address(RVA = "0x1740000", Offset = "0x173F200", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FC")]
	private static void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	[Address(RVA = "0x1740080", Offset = "0x173F280", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F4")]
	private static IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	[Address(RVA = "0x1740100", Offset = "0x173F300", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F6")]
	private static IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	[Address(RVA = "0x1740180", Offset = "0x173F380", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F5")]
	private static MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	[Address(RVA = "0x1740210", Offset = "0x173F410", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FA")]
	private static IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	[Address(RVA = "0x1740290", Offset = "0x173F490", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F7")]
	private static int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	[Address(RVA = "0x1740330", Offset = "0x173F530", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F3")]
	private static IntPtr mono_btls_x509_store_ctx_new() { }

	[Address(RVA = "0x17403A0", Offset = "0x173F5A0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F8")]
	private static int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	[Address(RVA = "0x1740430", Offset = "0x173F630", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FB")]
	private static IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	[Address(RVA = "0x17404B0", Offset = "0x173F6B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F9")]
	private static int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	[Address(RVA = "0x173FA80", Offset = "0x173EC80", Length = "0xFC")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000305")]
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	[Address(RVA = "0x173FB80", Offset = "0x173ED80", Length = "0xFB")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000307")]
	public int Verify() { }

}

