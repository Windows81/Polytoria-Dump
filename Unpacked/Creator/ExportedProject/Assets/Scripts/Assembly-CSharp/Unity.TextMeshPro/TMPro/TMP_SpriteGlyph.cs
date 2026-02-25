namespace TMPro;

[Token(Token = "0x200008F")]
public class TMP_SpriteGlyph : Glyph
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004A3")]
	public Sprite sprite; //Field offset: 0x48

	[Address(RVA = "0x18ED210", Offset = "0x18EC410", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C5")]
	public TMP_SpriteGlyph() { }

	[Address(RVA = "0x18ED170", Offset = "0x18EC370", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "set_metrics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphMetrics)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60004C6")]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[Address(RVA = "0x18ED0B0", Offset = "0x18EC2B0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "set_metrics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphMetrics)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60004C7")]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }

}

