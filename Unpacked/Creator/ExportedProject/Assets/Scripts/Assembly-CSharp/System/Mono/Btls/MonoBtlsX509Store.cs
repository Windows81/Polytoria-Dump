namespace Mono.Btls;

[Token(Token = "0x200009F")]
internal class MonoBtlsX509Store : MonoBtlsObject
{
	[Token(Token = "0x20000A0")]
	public class BoringX509StoreHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F0")]
		public BoringX509StoreHandle(IntPtr handle) { }

		[Address(RVA = "0x1732720", Offset = "0x1731920", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002F1")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DB")]
	private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; //Field offset: 0x20

	[Token(Token = "0x1700007C")]
	internal BoringX509StoreHandle Handle
	{
		[Address(RVA = "0x1741560", Offset = "0x1740760", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(BoringX509LookupHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60002E2")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x1741320", Offset = "0x1740520", Length = "0x107")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E9")]
	internal MonoBtlsX509Store() { }

	[Address(RVA = "0x1741430", Offset = "0x1740630", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EA")]
	internal MonoBtlsX509Store(BoringSslCtxHandle ctx) { }

	[Address(RVA = "0x1740B50", Offset = "0x173FD50", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EB")]
	public void AddCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x1740C50", Offset = "0x173FE50", Length = "0xC0")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoTlsSettings), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddTrustedRoots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoTlsSettings), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002EE")]
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	[Address(RVA = "0x1740D20", Offset = "0x173FF20", Length = "0x42")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoTlsSettings), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupDefaultCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddUserStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddMachineStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002ED")]
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x1740D70", Offset = "0x173FF70", Length = "0x1CE")]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddDirectoryLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.IntPtr, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.IntPtr, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.IntPtr, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.IntPtr, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EC")]
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x1740F40", Offset = "0x1740140", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60002EF")]
	protected virtual void Close() { }

	[Address(RVA = "0x1741220", Offset = "0x1740420", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E7")]
	private static BoringX509StoreHandle Create_internal() { }

	[Address(RVA = "0x1741100", Offset = "0x1740300", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E8")]
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	[Address(RVA = "0x1741560", Offset = "0x1740760", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(BoringX509LookupHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002E2")]
	internal BoringX509StoreHandle get_Handle() { }

	[Address(RVA = "0x17415E0", Offset = "0x17407E0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E5")]
	private static int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x1741670", Offset = "0x1740870", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E6")]
	private static void mono_btls_x509_store_free(IntPtr handle) { }

	[Address(RVA = "0x17416F0", Offset = "0x17408F0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E4")]
	private static IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	[Address(RVA = "0x1741770", Offset = "0x1740970", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E3")]
	private static IntPtr mono_btls_x509_store_new() { }

}

