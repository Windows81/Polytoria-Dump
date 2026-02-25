namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x2000199")]
public abstract class Asn1Encodable : IAsn1Convertible
{
	[Token(Token = "0x400041E")]
	public const string Ber = "BER"; //Field offset: 0x0
	[Token(Token = "0x400041F")]
	public const string Der = "DER"; //Field offset: 0x0
	[Token(Token = "0x4000420")]
	public const string DL = "DL"; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F11")]
	protected Asn1Encodable() { }

	[Address(RVA = "0x10E2DB0", Offset = "0x10E1FB0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10E2EA0", Offset = "0x10E20A0", Length = "0x7B")]
	[CalledBy(Type = typeof(DerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerBitString), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SubjectPublicKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlgorithmIdentifier), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "Generate", ReturnType = "Mirror.Transports.Encryption.EncryptionCredentials")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "SerializePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "SerializePrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0D")]
	public Byte[] GetDerEncoded() { }

	[Address(RVA = "0x10E2F70", Offset = "0x10E2170", Length = "0x68")]
	[CalledBy(Type = typeof(Asn1TaggedObject), Member = "Asn1Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0B")]
	public Byte[] GetEncoded() { }

	[Address(RVA = "0x10E2F20", Offset = "0x10E2120", Length = "0x45")]
	[CalledBy(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0C")]
	public Byte[] GetEncoded(string encoding) { }

	[Address(RVA = "0x10E2FE0", Offset = "0x10E21E0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F0E")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6000F10")]
	public abstract Asn1Object ToAsn1Object() { }

}

