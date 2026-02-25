namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F9")]
public abstract class RandomNumberGenerator : IDisposable
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001807")]
	protected RandomNumberGenerator() { }

	[Address(RVA = "0x133D150", Offset = "0x133C350", Length = "0x44")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetBytes", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Math.BigInteger", Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mono.Math.BigInteger")]
	[CalledBy(Type = "Mono.Math.BigInteger", Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+EncryptedPrivateKeyInfo", Member = "get_Salt", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "EncryptedContentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1", typeof(string)}, ReturnType = "Mono.Security.PKCS7+ContentInfo")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_RNG", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mirror.BouncyCastle.Crypto.Prng.CryptoApiRandomGenerator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.DigestSession", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = typeof(DSAManaged), Member = "get_Random", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = "FinalEncrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = "Random", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "GenerateSecureBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6001808")]
	public static RandomNumberGenerator Create() { }

	[Address(RVA = "0x133D1A0", Offset = "0x133C3A0", Length = "0x61")]
	[CalledBy(Type = "Mirror.BouncyCastle.Crypto.Prng.CryptoApiRandomGenerator", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CalledBy(Type = "Mirror.SimpleWeb.SendLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SendLoop+Config"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MaskHelper", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001809")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600180A")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x600180B")]
	public abstract void GetBytes(Byte[] data) { }

}

