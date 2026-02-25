namespace Mono.Btls;

[Token(Token = "0x200007A")]
internal abstract class MonoBtlsObject : IDisposable
{
	[Token(Token = "0x200007B")]
	private abstract class MonoBtlsHandle : SafeHandle
	{

		[Token(Token = "0x17000068")]
		public virtual bool IsInvalid
		{
			[Address(RVA = "0x15F68F0", Offset = "0x15F5AF0", Length = "0x9")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FA")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x15F68E0", Offset = "0x15F5AE0", Length = "0x8")]
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001F9")]
		internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) { }

		[Address(RVA = "0x15F68F0", Offset = "0x15F5AF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FA")]
		public virtual bool get_IsInvalid() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014A")]
	private MonoBtlsHandle handle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014B")]
	private Exception lastError; //Field offset: 0x18

	[Token(Token = "0x17000066")]
	internal MonoBtlsHandle Handle
	{
		[Address(RVA = "0x15F7800", Offset = "0x15F6A00", Length = "0x1A")]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[Token(Token = "0x60001EC")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000067")]
	public bool IsValid
	{
		[Address(RVA = "0x15F7820", Offset = "0x15F6A20", Length = "0x33")]
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EB")]
	internal MonoBtlsObject(MonoBtlsHandle handle) { }

	[Address(RVA = "0x15F7170", Offset = "0x15F6370", Length = "0x182")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001F0")]
	protected void CheckError(bool ok, string callerName = null) { }

	[Address(RVA = "0x15F7300", Offset = "0x15F6500", Length = "0xE")]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "AddExplicitTrust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001F1")]
	protected void CheckError(int ret, string callerName = null) { }

	[Address(RVA = "0x15F7310", Offset = "0x15F6510", Length = "0x1F8")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001F2")]
	protected private void CheckLastError(string callerName = null) { }

	[Address(RVA = "0x15F7510", Offset = "0x15F6710", Length = "0x99")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001EE")]
	protected void CheckThrow() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F5")]
	protected override void Close() { }

	[Address(RVA = "0x15F75B0", Offset = "0x15F67B0", Length = "0xDB")]
	[CalledBy(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsObject), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim+TimeoutTracker", Member = "get_RemainingMilliseconds", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815ECDD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F6")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x15F7690", Offset = "0x15F6890", Length = "0x56")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "set_PrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001F7")]
	public override void Dispose() { }

	[Address(RVA = "0x15F76F0", Offset = "0x15F68F0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001F8")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x15F7750", Offset = "0x15F6950", Length = "0x78")]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F4")]
	protected void FreeDataPtr(IntPtr data) { }

	[Address(RVA = "0x15F7800", Offset = "0x15F6A00", Length = "0x1A")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Token(Token = "0x60001EC")]
	internal MonoBtlsHandle get_Handle() { }

	[Address(RVA = "0x15F7820", Offset = "0x15F6A20", Length = "0x33")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001ED")]
	public bool get_IsValid() { }

	[Address(RVA = "0x15F7860", Offset = "0x15F6A60", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F3")]
	private static void mono_btls_free(IntPtr data) { }

	[Address(RVA = "0x15F77D0", Offset = "0x15F69D0", Length = "0x26")]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001EF")]
	protected Exception SetException(Exception ex) { }

}

