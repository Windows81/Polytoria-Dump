namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000064")]
internal struct FontStyleStack
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000426")]
	public byte bold; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000427")]
	public byte italic; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000428")]
	public byte underline; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000429")]
	public byte strikethrough; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400042A")]
	public byte highlight; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x400042B")]
	public byte superscript; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400042C")]
	public byte subscript; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400042D")]
	public byte uppercase; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400042E")]
	public byte lowercase; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400042F")]
	public byte smallcaps; //Field offset: 0x9

	[Address(RVA = "0x18F37D0", Offset = "0x18F29D0", Length = "0xA8")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E0")]
	public byte Add(FontStyles style) { }

	[Address(RVA = "0x18F3880", Offset = "0x18F2A80", Length = "0xE")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DF")]
	public void Clear() { }

	[Address(RVA = "0x18F3890", Offset = "0x18F2A90", Length = "0x128")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E1")]
	public byte Remove(FontStyles style) { }

}

