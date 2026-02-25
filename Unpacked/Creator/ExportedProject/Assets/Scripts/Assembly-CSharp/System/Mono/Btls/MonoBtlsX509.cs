namespace Mono.Btls;

[Token(Token = "0x200008E")]
internal class MonoBtlsX509 : MonoBtlsObject
{
	[Token(Token = "0x200008F")]
	public class BoringX509Handle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600029C")]
		public BoringX509Handle(IntPtr handle) { }

		[Address(RVA = "0x1732430", Offset = "0x1731630", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600029D")]
		protected virtual bool ReleaseHandle() { }

		[Address(RVA = "0x17324C0", Offset = "0x17316C0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600029E")]
		public IntPtr StealHandle() { }

	}


	[Token(Token = "0x17000076")]
	internal BoringX509Handle Handle
	{
		[Address(RVA = "0x1742F60", Offset = "0x1742160", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "AddExplicitTrust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509), typeof(MonoBtlsX509)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectName", ReturnType = typeof(MonoBtlsX509Name))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Token(Token = "0x600028C")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x928660", Offset = "0x927860", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028D")]
	internal MonoBtlsX509(BoringX509Handle handle) { }

	[Address(RVA = "0x17424A0", Offset = "0x17416A0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029B")]
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

	[Address(RVA = "0x1742590", Offset = "0x1741790", Length = "0xC2")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029A")]
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	[Address(RVA = "0x1742660", Offset = "0x1741860", Length = "0x12D")]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Clone", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000295")]
	internal MonoBtlsX509 Copy() { }

	[Address(RVA = "0x1742F60", Offset = "0x1742160", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectName", ReturnType = typeof(MonoBtlsX509Name))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509), typeof(MonoBtlsX509)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "AddExplicitTrust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600028C")]
	internal BoringX509Handle get_Handle() { }

	[Address(RVA = "0x1742790", Offset = "0x1741990", Length = "0x1E6")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "GetRawCertData", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsBioMemory), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(MonoBtlsBio), Member = "get_Handle", ReturnType = typeof(BoringBioHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsBioMemory), Member = "GetData", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000299")]
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	[Address(RVA = "0x1742B80", Offset = "0x1741D80", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000297")]
	public MonoBtlsX509Name GetSubjectName() { }

	[Address(RVA = "0x1742980", Offset = "0x1741B80", Length = "0x1F8")]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000298")]
	public long GetSubjectNameHash() { }

	[Address(RVA = "0x1742CC0", Offset = "0x1741EC0", Length = "0x29F")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportAuthenticode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000296")]
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	[Address(RVA = "0x1742FE0", Offset = "0x17421E0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000294")]
	private static int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	[Address(RVA = "0x1743070", Offset = "0x1742270", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000292")]
	private static int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	[Address(RVA = "0x1743100", Offset = "0x1742300", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000293")]
	private static void mono_btls_x509_free(IntPtr handle) { }

	[Address(RVA = "0x1743180", Offset = "0x1742380", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028F")]
	private static IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	[Address(RVA = "0x1743220", Offset = "0x1742420", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000291")]
	private static int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	[Address(RVA = "0x17432C0", Offset = "0x17424C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000290")]
	private static IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	[Address(RVA = "0x1743340", Offset = "0x1742540", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028E")]
	private static IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

}

