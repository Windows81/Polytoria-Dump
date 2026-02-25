namespace Internal.Cryptography;

[Extension]
[Token(Token = "0x2000090")]
internal static class Helpers
{

	[Address(RVA = "0x12F0860", Offset = "0x12EFA60", Length = "0x78")]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetRawCertData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetPublicKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_RawData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "Mono.Security.X509.X509Certificate")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600026B")]
	public static Byte[] CloneByteArray(Byte[] src) { }

	[Address(RVA = "0x12F08E0", Offset = "0x12EFAE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600026E")]
	private static char NibbleToHex(byte b) { }

	[Address(RVA = "0x12F0900", Offset = "0x12EFB00", Length = "0xDA")]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x600026C")]
	public static Char[] ToHexArrayUpper(Byte[] bytes) { }

	[Address(RVA = "0x12F09E0", Offset = "0x12EFBE0", Length = "0x157")]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Thumbprint", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A610")]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x600026D")]
	public static string ToHexStringUpper(Byte[] bytes) { }

}

