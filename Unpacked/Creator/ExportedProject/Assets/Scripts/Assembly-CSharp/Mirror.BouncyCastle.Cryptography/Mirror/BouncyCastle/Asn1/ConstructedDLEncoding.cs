namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001BE")]
internal class ConstructedDLEncoding : IAsn1Encoding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045B")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400045C")]
	private readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045D")]
	private readonly IAsn1Encoding[] m_contentsElements; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045E")]
	private readonly int m_contentsLength; //Field offset: 0x20

	[Address(RVA = "0x10F02B0", Offset = "0x10EF4B0", Length = "0x5E")]
	[CalledBy(Type = typeof(DerSequence), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerSequence), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLSequence), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLSequence), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLSet), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLSet), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001038")]
	internal ConstructedDLEncoding(int tagClass, int tagNo, IAsn1Encoding[] contentsElements) { }

	[Address(RVA = "0x10F01F0", Offset = "0x10EF3F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "EncodeContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001039")]
	private override void Mirror.BouncyCastle.Asn1.IAsn1Encoding.Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x10F0250", Offset = "0x10EF450", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600103A")]
	private override int Mirror.BouncyCastle.Asn1.IAsn1Encoding.GetLength() { }

}

