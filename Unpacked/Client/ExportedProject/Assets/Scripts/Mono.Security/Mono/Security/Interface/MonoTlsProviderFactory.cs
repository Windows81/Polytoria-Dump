namespace Mono.Security.Interface;

[Token(Token = "0x2000043")]
public static class MonoTlsProviderFactory
{

	[Address(RVA = "0x12CD6F0", Offset = "0x12CC8F0", Length = "0x68")]
	[CalledBy(Type = "Mono.SystemCertificateProvider", Member = "EnsureInitialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = "GetProvider", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "Mono.Net.Security.NoReflectionHelper", Member = "GetProvider", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600015A")]
	public static MonoTlsProvider GetProvider() { }

}

