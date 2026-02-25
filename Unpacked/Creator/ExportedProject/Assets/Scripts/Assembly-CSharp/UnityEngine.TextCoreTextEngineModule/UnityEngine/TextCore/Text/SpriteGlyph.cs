namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000035")]
public class SpriteGlyph : Glyph
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000154")]
	public Sprite sprite; //Field offset: 0x48

	[Address(RVA = "0x18ED210", Offset = "0x18EC410", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	public SpriteGlyph() { }

}

