namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000050")]
internal class TailoringInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015B")]
	public readonly int LCID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400015C")]
	public readonly int TailoringIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015D")]
	public readonly int TailoringCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400015E")]
	public readonly bool FrenchSort; //Field offset: 0x1C

	[Address(RVA = "0x10154E0", Offset = "0x10146E0", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BB")]
	public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }

}

