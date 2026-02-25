namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000328")]
internal static class X509Helper
{

	[Token(Token = "0x170002A7")]
	private static ISystemCertificateProvider CertificateProvider
	{
		[Address(RVA = "0x1357200", Offset = "0x1356400", Length = "0x465")]
		[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImpl))]
		[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509CertificateImpl))]
		[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600196C")]
		private get { } //Length: 1125
	}

	[Address(RVA = "0x1357200", Offset = "0x1356400", Length = "0x465")]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600196C")]
	private static ISystemCertificateProvider get_CertificateProvider() { }

	[Address(RVA = "0x1356E60", Offset = "0x1356060", Length = "0x6E")]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetPublicKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetRawCertData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001971")]
	internal static Exception GetInvalidContextException() { }

	[Address(RVA = "0x1356FE0", Offset = "0x13561E0", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001972")]
	public static X509CertificateImpl Import(Byte[] rawData) { }

	[Address(RVA = "0x1356ED0", Offset = "0x13560D0", Length = "0x102")]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001973")]
	public static X509CertificateImpl Import(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x13570A0", Offset = "0x13562A0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600196D")]
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	[Address(RVA = "0x1357170", Offset = "0x1356370", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600196E")]
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	[Address(RVA = "0x1357190", Offset = "0x1356390", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600196F")]
	public static bool IsValid(X509CertificateImpl impl) { }

	[Address(RVA = "0x13571B0", Offset = "0x13563B0", Length = "0x50")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Impl", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001970")]
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

}

