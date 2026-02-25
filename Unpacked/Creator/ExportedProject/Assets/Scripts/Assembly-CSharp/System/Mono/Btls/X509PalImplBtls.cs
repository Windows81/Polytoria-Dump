namespace Mono.Btls;

[Token(Token = "0x20000AA")]
internal class X509PalImplBtls : X509PalImpl
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000200")]
	private readonly MonoBtlsProvider <Provider>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700008B")]
	private MonoBtlsProvider Provider
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033F")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x174D240", Offset = "0x174C440", Length = "0x340")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600033E")]
	public X509PalImplBtls(MonoTlsProvider provider) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	private MonoBtlsProvider get_Provider() { }

	[Address(RVA = "0x174D210", Offset = "0x174C410", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000340")]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[Address(RVA = "0x174D1C0", Offset = "0x174C3C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000341")]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x174D1F0", Offset = "0x174C3F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000342")]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

