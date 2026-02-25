namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F8")]
public abstract class MD5 : HashAlgorithm
{

	[Address(RVA = "0x12CAE20", Offset = "0x12CA020", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001805")]
	protected MD5() { }

	[Address(RVA = "0x1338870", Offset = "0x1337A70", Length = "0x44")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MD5CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001806")]
	public static MD5 Create() { }

}

