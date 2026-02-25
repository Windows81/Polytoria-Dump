namespace Mono;

[Token(Token = "0x2000004")]
internal static class X509Pal
{

	[Token(Token = "0x17000006")]
	public static X509PalImpl Instance
	{
		[Address(RVA = "0x1606100", Offset = "0x1605300", Length = "0xDE")]
		[CalledBy(Type = typeof(X509Certificate2), Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid)}, ReturnType = typeof(X509Extension))]
		[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 222
	}

	[Address(RVA = "0x1606100", Offset = "0x1605300", Length = "0xDE")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid)}, ReturnType = typeof(X509Extension))]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000012")]
	public static X509PalImpl get_Instance() { }

}

