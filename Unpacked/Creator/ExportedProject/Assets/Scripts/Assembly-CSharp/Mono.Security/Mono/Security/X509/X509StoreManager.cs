namespace Mono.Security.X509;

[Token(Token = "0x2000019")]
public sealed class X509StoreManager
{
	[Token(Token = "0x4000078")]
	private static string _userPath; //Field offset: 0x0
	[Token(Token = "0x4000079")]
	private static string _localMachinePath; //Field offset: 0x8
	[Token(Token = "0x400007A")]
	private static string _newUserPath; //Field offset: 0x10
	[Token(Token = "0x400007B")]
	private static string _newLocalMachinePath; //Field offset: 0x18
	[Token(Token = "0x400007C")]
	private static X509Stores _userStore; //Field offset: 0x20
	[Token(Token = "0x400007D")]
	private static X509Stores _machineStore; //Field offset: 0x28

	[Token(Token = "0x17000048")]
	public static X509Stores CurrentUser
	{
		[Address(RVA = "0x12BFF60", Offset = "0x12BF160", Length = "0x1D6")]
		[CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 470
	}

	[Token(Token = "0x17000044")]
	internal static string CurrentUserPath
	{
		[Address(RVA = "0x12BFE40", Offset = "0x12BF040", Length = "0x120")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000DE")]
		internal get { } //Length: 288
	}

	[Token(Token = "0x17000049")]
	public static X509Stores LocalMachine
	{
		[Address(RVA = "0x12C0270", Offset = "0x12BF470", Length = "0x1E3")]
		[CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 483
	}

	[Token(Token = "0x17000045")]
	internal static string LocalMachinePath
	{
		[Address(RVA = "0x12C0140", Offset = "0x12BF340", Length = "0x12D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000DF")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x17000046")]
	internal static string NewCurrentUserPath
	{
		[Address(RVA = "0x12C0460", Offset = "0x12BF660", Length = "0x12D")]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "DoInitialize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000E0")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x17000047")]
	internal static string NewLocalMachinePath
	{
		[Address(RVA = "0x12C0590", Offset = "0x12BF790", Length = "0x12D")]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "DoInitialize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000E1")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x1700004A")]
	public static X509CertificateCollection TrustedRootCertificates
	{
		[Address(RVA = "0x12C06C0", Offset = "0x12BF8C0", Length = "0x47F")]
		[CalledBy(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(X509Stores), Member = "get_TrustedRoot", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
		[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 1151
	}

	[Address(RVA = "0x12BFF60", Offset = "0x12BF160", Length = "0x1D6")]
	[CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E2")]
	public static X509Stores get_CurrentUser() { }

	[Address(RVA = "0x12BFE40", Offset = "0x12BF040", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000DE")]
	internal static string get_CurrentUserPath() { }

	[Address(RVA = "0x12C0270", Offset = "0x12BF470", Length = "0x1E3")]
	[CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E3")]
	public static X509Stores get_LocalMachine() { }

	[Address(RVA = "0x12C0140", Offset = "0x12BF340", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000DF")]
	internal static string get_LocalMachinePath() { }

	[Address(RVA = "0x12C0460", Offset = "0x12BF660", Length = "0x12D")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "DoInitialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000E0")]
	internal static string get_NewCurrentUserPath() { }

	[Address(RVA = "0x12C0590", Offset = "0x12BF790", Length = "0x12D")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509StoreManager", Member = "DoInitialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000E1")]
	internal static string get_NewLocalMachinePath() { }

	[Address(RVA = "0x12C06C0", Offset = "0x12BF8C0", Length = "0x47F")]
	[CalledBy(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Stores), Member = "get_TrustedRoot", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000E4")]
	public static X509CertificateCollection get_TrustedRootCertificates() { }

}

