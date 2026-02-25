namespace Mono.Btls;

[Token(Token = "0x200007C")]
internal class MonoBtlsPkcs12 : MonoBtlsObject
{
	[Token(Token = "0x200007D")]
	public class BoringPkcs12Handle : MonoBtlsHandle
	{

		[Address(RVA = "0x15ED8C0", Offset = "0x15ECAC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000209")]
		public BoringPkcs12Handle(IntPtr handle) { }

		[Address(RVA = "0x15ED950", Offset = "0x15ECB50", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600020A")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014C")]
	private MonoBtlsKey privateKey; //Field offset: 0x20

	[Token(Token = "0x1700006A")]
	public int Count
	{
		[Address(RVA = "0x15F7F50", Offset = "0x15F7150", Length = "0x91")]
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000204")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000069")]
	internal BoringPkcs12Handle Handle
	{
		[Address(RVA = "0x15F7FF0", Offset = "0x15F71F0", Length = "0x75")]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60001FB")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x1700006B")]
	public bool HasPrivateKey
	{
		[Address(RVA = "0x15F8070", Offset = "0x15F7270", Length = "0x9A")]
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000207")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x15F7E70", Offset = "0x15F7070", Length = "0xD6")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000203")]
	internal MonoBtlsPkcs12() { }

	[Address(RVA = "0x15F7F50", Offset = "0x15F7150", Length = "0x91")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000204")]
	public int get_Count() { }

	[Address(RVA = "0x15F7FF0", Offset = "0x15F71F0", Length = "0x75")]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60001FB")]
	internal BoringPkcs12Handle get_Handle() { }

	[Address(RVA = "0x15F8070", Offset = "0x15F7270", Length = "0x9A")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000207")]
	public bool get_HasPrivateKey() { }

	[Address(RVA = "0x15F78E0", Offset = "0x15F6AE0", Length = "0x1FB")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000205")]
	public MonoBtlsX509 GetCertificate(int index) { }

	[Address(RVA = "0x15F7AE0", Offset = "0x15F6CE0", Length = "0x219")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000208")]
	public MonoBtlsKey GetPrivateKey() { }

	[Address(RVA = "0x15F7D00", Offset = "0x15F6F00", Length = "0x169")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000206")]
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	[Address(RVA = "0x15F8110", Offset = "0x15F7310", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FC")]
	private static void mono_btls_pkcs12_free(IntPtr handle) { }

	[Address(RVA = "0x15F8190", Offset = "0x15F7390", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FF")]
	private static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	[Address(RVA = "0x15F8220", Offset = "0x15F7420", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FE")]
	private static int mono_btls_pkcs12_get_count(IntPtr handle) { }

	[Address(RVA = "0x15F82A0", Offset = "0x15F74A0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000202")]
	private static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	[Address(RVA = "0x15F8320", Offset = "0x15F7520", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000201")]
	private static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	[Address(RVA = "0x15F83A0", Offset = "0x15F75A0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_get_exception_argument_null")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000200")]
	private static int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	[Address(RVA = "0x15F8490", Offset = "0x15F7690", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FD")]
	private static IntPtr mono_btls_pkcs12_new() { }

}

