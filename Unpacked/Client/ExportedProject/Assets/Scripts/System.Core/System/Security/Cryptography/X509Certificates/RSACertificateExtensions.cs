namespace System.Security.Cryptography.X509Certificates;

[Extension]
[Token(Token = "0x2000016")]
public static class RSACertificateExtensions
{

	[Address(RVA = "0x158DE10", Offset = "0x158D010", Length = "0xE1")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000051")]
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }

}

