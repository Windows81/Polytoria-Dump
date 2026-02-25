namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001C6")]
internal abstract class DerEncoding : IAsn1Encoding, IComparable<DerEncoding>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046F")]
	protected private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000470")]
	protected private readonly int m_tagNo; //Field offset: 0x14

	[Address(RVA = "0x3A2A70", Offset = "0x3A1C70", Length = "0x34")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001077")]
	protected private DerEncoding(int tagClass, int tagNo) { }

	[Token(Token = "0x6001078")]
	protected private abstract int CompareLengthAndContents(DerEncoding other) { }

	[Address(RVA = "0x1104ED0", Offset = "0x11040D0", Length = "0x3D")]
	[CalledBy(Type = typeof(ConstructedDerEncoding), Member = "CompareLengthAndContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerEncoding)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001079")]
	public override int CompareTo(DerEncoding other) { }

	[Token(Token = "0x600107A")]
	public abstract void Encode(Asn1OutputStream asn1Out) { }

	[Token(Token = "0x600107B")]
	public abstract int GetLength() { }

}

