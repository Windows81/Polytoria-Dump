namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001BF")]
internal class ConstructedILEncoding : IAsn1Encoding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045F")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000460")]
	private readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000461")]
	private readonly IAsn1Encoding[] m_contentsElements; //Field offset: 0x18

	[Address(RVA = "0x10EF790", Offset = "0x10EE990", Length = "0x50")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600103B")]
	internal ConstructedILEncoding(int tagClass, int tagNo, IAsn1Encoding[] contentsElements) { }

	[Address(RVA = "0x10F0550", Offset = "0x10EF750", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "EncodeContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600103C")]
	private override void Mirror.BouncyCastle.Asn1.IAsn1Encoding.Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x10F05F0", Offset = "0x10EF7F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(int))]
	[Token(Token = "0x600103D")]
	private override int Mirror.BouncyCastle.Asn1.IAsn1Encoding.GetLength() { }

}

