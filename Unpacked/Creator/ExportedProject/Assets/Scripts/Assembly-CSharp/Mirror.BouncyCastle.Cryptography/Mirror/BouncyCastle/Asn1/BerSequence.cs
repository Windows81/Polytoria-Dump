namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001B6")]
public class BerSequence : DLSequence
{
	[Token(Token = "0x400044C")]
	public static readonly BerSequence Empty; //Field offset: 0x0

	[Address(RVA = "0x10EF010", Offset = "0x10EE210", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DLSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001019")]
	private static BerSequence() { }

	[Address(RVA = "0x10EF0B0", Offset = "0x10EE2B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DLSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001010")]
	public BerSequence() { }

	[Address(RVA = "0x10EF160", Offset = "0x10EE360", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DLSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001011")]
	public BerSequence(Asn1Encodable element) { }

	[Address(RVA = "0x10EF100", Offset = "0x10EE300", Length = "0x59")]
	[CalledBy(Type = typeof(DerExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerExternalParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DerExternalParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(DerExternal))]
	[CalledBy(Type = typeof(DLExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DLSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001012")]
	public BerSequence(Asn1EncodableVector elementVector) { }

	[Address(RVA = "0x10EEAF0", Offset = "0x10EDCF0", Length = "0xC9")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "LoadTaggedIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1TaggedObject), Member = "CreateConstructedIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Asn1EncodableVector)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(BerSequenceParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerSequence))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DLSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600100F")]
	public static BerSequence FromVector(Asn1EncodableVector elementVector) { }

	[Address(RVA = "0x10EEC80", Offset = "0x10EDE80", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DLSequence), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001013")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x10EEBC0", Offset = "0x10EDDC0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DLSequence), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001014")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x10EED20", Offset = "0x10EDF20", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(BerBitString), Member = "FlattenBitStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerBitString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DLBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001015")]
	internal virtual DerBitString ToAsn1BitString() { }

	[Address(RVA = "0x10EEE20", Offset = "0x10EE020", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DLExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001016")]
	internal virtual DerExternal ToAsn1External() { }

	[Address(RVA = "0x10EEE80", Offset = "0x10EE080", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(BerOctetString), Member = "FlattenOctetStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1OctetString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001017")]
	internal virtual Asn1OctetString ToAsn1OctetString() { }

	[Address(RVA = "0x10EEF80", Offset = "0x10EE180", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DLSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001018")]
	internal virtual Asn1Set ToAsn1Set() { }

}

