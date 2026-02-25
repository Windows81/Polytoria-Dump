namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001F6")]
internal class TaggedILEncoding : IAsn1Encoding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B1")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004B2")]
	private readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B3")]
	private readonly IAsn1Encoding m_contentsElement; //Field offset: 0x18

	[Address(RVA = "0x10EF790", Offset = "0x10EE990", Length = "0x50")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A3")]
	internal TaggedILEncoding(int tagClass, int tagNo, IAsn1Encoding contentsElement) { }

	[Address(RVA = "0x1116980", Offset = "0x1115B80", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60011A4")]
	private override void Mirror.BouncyCastle.Asn1.IAsn1Encoding.Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x1116A40", Offset = "0x1115C40", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfEncodingIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IAsn1Encoding)}, ReturnType = typeof(int))]
	[Token(Token = "0x60011A5")]
	private override int Mirror.BouncyCastle.Asn1.IAsn1Encoding.GetLength() { }

}

