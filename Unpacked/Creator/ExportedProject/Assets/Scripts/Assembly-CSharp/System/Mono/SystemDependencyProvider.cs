namespace Mono;

[Token(Token = "0x2000003")]
internal class SystemDependencyProvider : ISystemDependencyProvider
{
	[Token(Token = "0x4000005")]
	private static SystemDependencyProvider instance; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static object syncRoot; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000004")]
	public SystemCertificateProvider CertificateProvider
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public static SystemDependencyProvider Instance
	{
		[Address(RVA = "0x15FDF50", Offset = "0x15FD150", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
		[Token(Token = "0x600000B")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000003")]
	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public X509PalImpl X509Pal
	{
		[Address(RVA = "0x15FDFB0", Offset = "0x15FD1B0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x15FDE30", Offset = "0x15FD030", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	private static SystemDependencyProvider() { }

	[Address(RVA = "0x15FDEB0", Offset = "0x15FD0B0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "Mono.DependencyInjector", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.ISystemDependencyProvider"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000010")]
	private SystemDependencyProvider() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public SystemCertificateProvider get_CertificateProvider() { }

	[Address(RVA = "0x15FDF50", Offset = "0x15FD150", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
	[Token(Token = "0x600000B")]
	public static SystemDependencyProvider get_Instance() { }

	[Address(RVA = "0x15FDFB0", Offset = "0x15FD1B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000F")]
	public X509PalImpl get_X509Pal() { }

	[Address(RVA = "0x15FDC60", Offset = "0x15FCE60", Length = "0x1CF")]
	[CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_Instance", ReturnType = typeof(SystemDependencyProvider))]
	[CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "Mono.DependencyInjector", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.ISystemDependencyProvider"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600000C")]
	internal static void Initialize() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

}

