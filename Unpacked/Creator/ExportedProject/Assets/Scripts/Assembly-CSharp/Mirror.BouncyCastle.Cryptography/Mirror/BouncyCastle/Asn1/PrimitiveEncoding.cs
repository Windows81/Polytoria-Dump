namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001F2")]
internal class PrimitiveEncoding : IAsn1Encoding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A4")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004A5")]
	private readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A6")]
	private readonly Byte[] m_contentsOctets; //Field offset: 0x18

	[Address(RVA = "0x10EF790", Offset = "0x10EE990", Length = "0x50")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001196")]
	internal PrimitiveEncoding(int tagClass, int tagNo, Byte[] contentsOctets) { }

	[Address(RVA = "0x11112F0", Offset = "0x11104F0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001197")]
	private override void Mirror.BouncyCastle.Asn1.IAsn1Encoding.Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x11110A0", Offset = "0x11102A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfEncodingDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001198")]
	private override int Mirror.BouncyCastle.Asn1.IAsn1Encoding.GetLength() { }

}

