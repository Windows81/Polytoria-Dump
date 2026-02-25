namespace Mirror.BouncyCastle.Security;

[Token(Token = "0x2000017")]
public static class DigestUtilities
{
	[Token(Token = "0x2000018")]
	private enum DigestAlgorithm
	{
		BLAKE2B_160 = 0,
		BLAKE2B_256 = 1,
		BLAKE2B_384 = 2,
		BLAKE2B_512 = 3,
		BLAKE2S_128 = 4,
		BLAKE2S_160 = 5,
		BLAKE2S_224 = 6,
		BLAKE2S_256 = 7,
		BLAKE3_256 = 8,
		DSTU7564_256 = 9,
		DSTU7564_384 = 10,
		DSTU7564_512 = 11,
		GOST3411 = 12,
		GOST3411_2012_256 = 13,
		GOST3411_2012_512 = 14,
		KECCAK_224 = 15,
		KECCAK_256 = 16,
		KECCAK_288 = 17,
		KECCAK_384 = 18,
		KECCAK_512 = 19,
		MD2 = 20,
		MD4 = 21,
		MD5 = 22,
		NONE = 23,
		RIPEMD128 = 24,
		RIPEMD160 = 25,
		RIPEMD256 = 26,
		RIPEMD320 = 27,
		SHA_1 = 28,
		SHA_224 = 29,
		SHA_256 = 30,
		SHA_384 = 31,
		SHA_512 = 32,
		SHA_512_224 = 33,
		SHA_512_256 = 34,
		SHA3_224 = 35,
		SHA3_256 = 36,
		SHA3_384 = 37,
		SHA3_512 = 38,
		SHAKE128_256 = 39,
		SHAKE256_512 = 40,
		SM3 = 41,
		TIGER = 42,
		WHIRLPOOL = 43,
	}

	[Token(Token = "0x400001B")]
	private static readonly Dictionary<String, String> AlgorithmMap; //Field offset: 0x0
	[Token(Token = "0x400001C")]
	private static readonly Dictionary<DerObjectIdentifier, String> AlgorithmOidMap; //Field offset: 0x8
	[Token(Token = "0x400001D")]
	private static readonly Dictionary<String, DerObjectIdentifier> Oids; //Field offset: 0x10

	[Address(RVA = "0x10B9D40", Offset = "0x10B8F40", Length = "0x1FA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enums), Member = "GetArbitraryValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, ReturnType = "TEnum")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000084")]
	private static DigestUtilities() { }

	[Address(RVA = "0x10B99A0", Offset = "0x10B8BA0", Length = "0x25C")]
	[CalledBy(Type = typeof(SecureRandom), Member = "CreatePrng", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(DigestRandomGenerator))]
	[CalledBy(Type = typeof(SecureRandom), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerObjectIdentifier), Member = "TryFromID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SecurityUtilityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[Token(Token = "0x6000085")]
	public static IDigest GetDigest(string algorithm) { }

	[Address(RVA = "0x10B9080", Offset = "0x10B8280", Length = "0x864")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NullDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RipeMD256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RipeMD320Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha1Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha224Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha384Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha512tDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RipeMD160Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha3Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShakeDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SM3Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TigerDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WhirlpoolDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sha512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RipeMD128Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MD5Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MD4Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MD2Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012_512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012_256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dstu7564Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake3Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake2sDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blake2bDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enums), Member = "TryGetEnumValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEnum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TEnum&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	private static IDigest GetDigestForMechanism(string mechanism) { }

	[Address(RVA = "0x10B9C00", Offset = "0x10B8E00", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerObjectIdentifier), Member = "TryFromID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DerObjectIdentifier&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000087")]
	private static string GetMechanism(string algorithm) { }

}

