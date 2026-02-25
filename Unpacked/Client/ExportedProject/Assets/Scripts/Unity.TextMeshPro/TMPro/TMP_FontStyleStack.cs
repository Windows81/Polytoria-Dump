namespace TMPro;

[Token(Token = "0x20000B3")]
public struct TMP_FontStyleStack
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400066B")]
	public byte bold; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400066C")]
	public byte italic; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400066D")]
	public byte underline; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400066E")]
	public byte strikethrough; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400066F")]
	public byte highlight; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000670")]
	public byte superscript; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000671")]
	public byte subscript; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000672")]
	public byte uppercase; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000673")]
	public byte lowercase; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000674")]
	public byte smallcaps; //Field offset: 0x9

	[Address(RVA = "0x18F37D0", Offset = "0x18F29D0", Length = "0xA8")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CC")]
	public byte Add(FontStyles style) { }

	[Address(RVA = "0x18F3880", Offset = "0x18F2A80", Length = "0xE")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CB")]
	public void Clear() { }

	[Address(RVA = "0x18F3890", Offset = "0x18F2A90", Length = "0x128")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CD")]
	public byte Remove(FontStyles style) { }

}

