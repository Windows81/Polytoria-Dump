namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001D7")]
public class DerSequence : Asn1Sequence
{
	[Token(Token = "0x400048C")]
	public static readonly DerSequence Empty; //Field offset: 0x0

	[Address(RVA = "0x110B3B0", Offset = "0x110A5B0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600110E")]
	private static DerSequence() { }

	[Address(RVA = "0x110B460", Offset = "0x110A660", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001101")]
	public DerSequence() { }

	[Address(RVA = "0x110B430", Offset = "0x110A630", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001102")]
	public DerSequence(Asn1Encodable element) { }

	[Address(RVA = "0x110B420", Offset = "0x110A620", Length = "0x8")]
	[CalledBy(Type = typeof(ElGamalParameter), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001103")]
	public DerSequence(Asn1Encodable element1, Asn1Encodable element2) { }

	[Address(RVA = "0x110B450", Offset = "0x110A650", Length = "0x8")]
	[CalledBy(Type = typeof(RsaPrivateKeyStructure), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Gost3410ParamSetParameters), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001104")]
	public DerSequence(Asn1Encodable[] elements) { }

	[Address(RVA = "0x110B440", Offset = "0x110A640", Length = "0x8")]
	[CalledBy(Type = typeof(DHParameter), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(PrivateKeyInfo), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Gost3410PublicKeyAlgParameters), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001105")]
	public DerSequence(Asn1EncodableVector elementVector) { }

	[Address(RVA = "0x110B120", Offset = "0x110A320", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001106")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x110B020", Offset = "0x110A220", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodingsDer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDerEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DerEncoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001108")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x110AF90", Offset = "0x110A190", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodingsDer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDerEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DerEncoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001109")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x110B090", Offset = "0x110A290", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001107")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x110B1A0", Offset = "0x110A3A0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1Sequence), Member = "GetConstructedBitStrings", ReturnType = typeof(DerBitString[]))]
	[Calls(Type = typeof(BerBitString), Member = "FlattenBitStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerBitString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600110A")]
	internal virtual DerBitString ToAsn1BitString() { }

	[Address(RVA = "0x110B220", Offset = "0x110A420", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Token(Token = "0x600110B")]
	internal virtual DerExternal ToAsn1External() { }

	[Address(RVA = "0x110B280", Offset = "0x110A480", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1Sequence), Member = "GetConstructedOctetStrings", ReturnType = typeof(Asn1OctetString[]))]
	[Calls(Type = typeof(BerOctetString), Member = "FlattenOctetStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1OctetString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1OctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600110C")]
	internal virtual Asn1OctetString ToAsn1OctetString() { }

	[Address(RVA = "0x110B320", Offset = "0x110A520", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600110D")]
	internal virtual Asn1Set ToAsn1Set() { }

}

