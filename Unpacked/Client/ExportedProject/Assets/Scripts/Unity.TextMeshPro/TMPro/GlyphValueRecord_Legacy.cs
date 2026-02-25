namespace TMPro;

[Token(Token = "0x2000051")]
public struct GlyphValueRecord_Legacy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024E")]
	public float xPlacement; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400024F")]
	public float yPlacement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000250")]
	public float xAdvance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000251")]
	public float yAdvance; //Field offset: 0xC

	[Address(RVA = "0x189FB10", Offset = "0x189ED10", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029D")]
	internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord) { }

	[Address(RVA = "0x1825960", Offset = "0x1824B60", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029E")]
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

