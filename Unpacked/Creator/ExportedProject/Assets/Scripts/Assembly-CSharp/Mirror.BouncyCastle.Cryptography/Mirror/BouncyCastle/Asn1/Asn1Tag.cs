namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001AC")]
internal sealed class Asn1Tag
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400043B")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400043C")]
	private readonly int m_tagNo; //Field offset: 0x14

	[Address(RVA = "0x3A2A70", Offset = "0x3A1C70", Length = "0x34")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCC")]
	private Asn1Tag(int tagClass, int tagNo) { }

	[Address(RVA = "0x10EBF20", Offset = "0x10EB120", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FCB")]
	internal static Asn1Tag Create(int tagClass, int tagNo) { }

}

