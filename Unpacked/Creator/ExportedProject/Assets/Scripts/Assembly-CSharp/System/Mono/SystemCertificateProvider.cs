namespace Mono;

[Token(Token = "0x2000002")]
internal class SystemCertificateProvider : ISystemCertificateProvider
{
	[Token(Token = "0x4000001")]
	private static MonoTlsProvider provider; //Field offset: 0x0
	[Token(Token = "0x4000002")]
	private static int initialized; //Field offset: 0x8
	[Token(Token = "0x4000003")]
	private static X509PalImpl x509pal; //Field offset: 0x10
	[Token(Token = "0x4000004")]
	private static object syncRoot; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public X509PalImpl X509Pal
	{
		[Address(RVA = "0x15FDBB0", Offset = "0x15FCDB0", Length = "0x53")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[Token(Token = "0x6000003")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x15FDB30", Offset = "0x15FCD30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private static SystemCertificateProvider() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public SystemCertificateProvider() { }

	[Address(RVA = "0x15FD250", Offset = "0x15FC450", Length = "0x193")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000002")]
	private static void EnsureInitialized() { }

	[Address(RVA = "0x15FDBB0", Offset = "0x15FCDB0", Length = "0x53")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[Token(Token = "0x6000003")]
	public X509PalImpl get_X509Pal() { }

	[Address(RVA = "0x15FD3F0", Offset = "0x15FC5F0", Length = "0x22A")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509PalImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsProvider)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	private static X509PalImpl GetX509Pal() { }

	[Address(RVA = "0x15FD620", Offset = "0x15FC820", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public override X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x15FD6C0", Offset = "0x15FC8C0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x15FD780", Offset = "0x15FC980", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000008")]
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x15FD8F0", Offset = "0x15FCAF0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	[Address(RVA = "0x15FD9B0", Offset = "0x15FCBB0", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000007")]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

}

