namespace Mono.Btls;

[Token(Token = "0x20000A3")]
internal static class MonoBtlsX509StoreManager
{
	[Token(Token = "0x40001DE")]
	private static bool initialized; //Field offset: 0x0
	[Token(Token = "0x40001DF")]
	private static string machineTrustedRootPath; //Field offset: 0x8
	[Token(Token = "0x40001E0")]
	private static string machineIntermediateCAPath; //Field offset: 0x10
	[Token(Token = "0x40001E1")]
	private static string machineUntrustedPath; //Field offset: 0x18
	[Token(Token = "0x40001E2")]
	private static string userTrustedRootPath; //Field offset: 0x20
	[Token(Token = "0x40001E3")]
	private static string userIntermediateCAPath; //Field offset: 0x28
	[Token(Token = "0x40001E4")]
	private static string userUntrustedPath; //Field offset: 0x30

	[Address(RVA = "0x1740530", Offset = "0x173F730", Length = "0x1F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[Token(Token = "0x600030C")]
	private static void DoInitialize() { }

	[Address(RVA = "0x1740730", Offset = "0x173F930", Length = "0x11C")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddMachineStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoTlsSettings), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupDefaultCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddUserStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509StoreManager), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030D")]
	public static string GetStorePath(MonoBtlsX509StoreType type) { }

	[Address(RVA = "0x1740870", Offset = "0x173FA70", Length = "0x2D9")]
	[CalledBy(Type = typeof(MonoBtlsX509StoreManager), Member = "GetStorePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18109A080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030B")]
	private static void Initialize() { }

}

