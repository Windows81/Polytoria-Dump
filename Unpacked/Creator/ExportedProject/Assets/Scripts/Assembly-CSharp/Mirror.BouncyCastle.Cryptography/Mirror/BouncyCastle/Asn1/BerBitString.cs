namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001B2")]
public class BerBitString : DLBitString
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000447")]
	private readonly DerBitString[] elements; //Field offset: 0x18

	[Address(RVA = "0x10EE360", Offset = "0x10ED560", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DLBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FFC")]
	public BerBitString(Byte[] data, int padBits) { }

	[Address(RVA = "0x10EE310", Offset = "0x10ED510", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BerBitString), Member = "FlattenBitStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerBitString[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DLBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FFD")]
	public BerBitString(DerBitString[] elements) { }

	[Address(RVA = "0x10EDEC0", Offset = "0x10ED0C0", Length = "0x24B")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedBitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(BerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerBitString[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BerSequence), Member = "ToAsn1BitString", ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(DerSequence), Member = "ToAsn1BitString", ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(DLSequence), Member = "ToAsn1BitString", ReturnType = typeof(DerBitString))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FFB")]
	internal static Byte[] FlattenBitStrings(DerBitString[] bitStrings) { }

	[Address(RVA = "0x10EE210", Offset = "0x10ED410", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DLBitString), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FFE")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x10EE110", Offset = "0x10ED310", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DLBitString), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FFF")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

}

