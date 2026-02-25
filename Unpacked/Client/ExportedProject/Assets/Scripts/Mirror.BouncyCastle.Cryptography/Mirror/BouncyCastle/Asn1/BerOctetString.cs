namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001B4")]
public class BerOctetString : DerOctetString
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400044A")]
	private readonly Asn1OctetString[] elements; //Field offset: 0x18

	[Address(RVA = "0x10EE9A0", Offset = "0x10EDBA0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001006")]
	public BerOctetString(Byte[] contents) { }

	[Address(RVA = "0x10EE950", Offset = "0x10EDB50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BerOctetString), Member = "FlattenOctetStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1OctetString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001007")]
	public BerOctetString(Asn1OctetString[] elements) { }

	[Address(RVA = "0x10EE9D0", Offset = "0x10EDBD0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001008")]
	private BerOctetString(Byte[] contents, Asn1OctetString[] elements) { }

	[Address(RVA = "0x10EE590", Offset = "0x10ED790", Length = "0x1B3")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedOctetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(BerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1OctetString[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BerSequence), Member = "ToAsn1OctetString", ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(DerSequence), Member = "ToAsn1OctetString", ReturnType = typeof(Asn1OctetString))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001005")]
	internal static Byte[] FlattenOctetStrings(Asn1OctetString[] octetStrings) { }

	[Address(RVA = "0x10EE850", Offset = "0x10EDA50", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerOctetString), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001009")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x10EE750", Offset = "0x10ED950", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerOctetString), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600100A")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

}

