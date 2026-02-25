namespace Mirror.Transports.Encryption;

[Token(Token = "0x2000017")]
public class EncryptionCredentials
{
	[Token(Token = "0x2000018")]
	private class SerializedPair
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C9")]
		public string PublicKeyFingerprint; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CA")]
		public string PublicKey; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000CB")]
		public string PrivateKey; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000112")]
		public SerializedPair() { }

	}

	[Token(Token = "0x40000C5")]
	private const int PrivateKeyBits = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C6")]
	public Byte[] PublicKeySerialized; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C7")]
	public ECPrivateKeyParameters PrivateKey; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C8")]
	public string PublicKeyFingerprint; //Field offset: 0x20

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	private EncryptionCredentials() { }

	[Address(RVA = "0x12768A0", Offset = "0x1275AA0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[Token(Token = "0x600010E")]
	public static AsymmetricKeyParameter DeserializePrivateKey(ArraySegment<Byte> privateKey) { }

	[Address(RVA = "0x1276960", Offset = "0x1275B60", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[Token(Token = "0x600010C")]
	public static AsymmetricKeyParameter DeserializePublicKey(ArraySegment<Byte> pubKey) { }

	[Address(RVA = "0x1276A20", Offset = "0x1275C20", Length = "0x29F")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "SetupEncryptionForClient", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(KeyGenerationParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptionCredentials), Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Asn1Encodable), Member = "GetDerEncoded", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[Calls(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[Calls(Type = typeof(SecureRandom), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ECKeyPairGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECKeyPairGenerator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyGenerationParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010A")]
	public static EncryptionCredentials Generate() { }

	[Address(RVA = "0x1276CC0", Offset = "0x1275EC0", Length = "0x332")]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptionCredentials), Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(File), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000111")]
	public static EncryptionCredentials LoadFromFile(string path) { }

	[Address(RVA = "0x1277000", Offset = "0x1276200", Length = "0x164")]
	[CalledBy(Type = typeof(EncryptedConnection), Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionCredentials), Member = "Generate", ReturnType = typeof(EncryptionCredentials))]
	[CalledBy(Type = typeof(EncryptionCredentials), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EncryptionCredentials))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Sha256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GeneralDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600010F")]
	public static string PubKeyFingerprint(ArraySegment<Byte> publicKeyBytes) { }

	[Address(RVA = "0x1277170", Offset = "0x1276370", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(PrivateKeyInfo))]
	[Calls(Type = typeof(Asn1Encodable), Member = "GetDerEncoded", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000110")]
	public void SaveToFile(string path) { }

	[Address(RVA = "0x12772A0", Offset = "0x12764A0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(PrivateKeyInfo))]
	[Calls(Type = typeof(Asn1Encodable), Member = "GetDerEncoded", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010D")]
	public static Byte[] SerializePrivateKey(AsymmetricKeyParameter privateKey) { }

	[Address(RVA = "0x12772E0", Offset = "0x12764E0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[Calls(Type = typeof(Asn1Encodable), Member = "GetDerEncoded", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010B")]
	public static Byte[] SerializePublicKey(AsymmetricKeyParameter publicKey) { }

}

