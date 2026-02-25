namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000042")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct TextElementInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400019E")]
	public uint character; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400019F")]
	public int index; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001A0")]
	public TextElementType elementType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001A1")]
	public int stringLength; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A2")]
	public TextElement textElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A3")]
	public Glyph alternativeGlyph; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A4")]
	public FontAsset fontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A5")]
	public SpriteAsset spriteAsset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001A6")]
	public Material material; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001A7")]
	public int materialReferenceIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001A8")]
	public bool isUsingAlternateTypeface; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A9")]
	public float pointSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001AA")]
	public int lineNumber; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AB")]
	public int vertexIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001AC")]
	public TextVertex vertexTopLeft; //Field offset: 0x4C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001AD")]
	public TextVertex vertexBottomLeft; //Field offset: 0x74
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40001AE")]
	public TextVertex vertexTopRight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40001AF")]
	public TextVertex vertexBottomRight; //Field offset: 0xC4
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40001B0")]
	public Vector3 topLeft; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001B1")]
	public Vector3 bottomLeft; //Field offset: 0xF8
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40001B2")]
	public Vector3 topRight; //Field offset: 0x104
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001B3")]
	public Vector3 bottomRight; //Field offset: 0x110
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40001B4")]
	public float origin; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001B5")]
	public float ascender; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x40001B6")]
	public float baseLine; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001B7")]
	public float descender; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40001B8")]
	internal float adjustedAscender; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40001B9")]
	internal float adjustedDescender; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x40001BA")]
	internal float adjustedHorizontalAdvance; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001BB")]
	public float xAdvance; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40001BC")]
	public float aspectRatio; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001BD")]
	public float scale; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40001BE")]
	public Color32 color; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40001BF")]
	public Color32 underlineColor; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40001C0")]
	public int underlineVertexIndex; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40001C1")]
	public Color32 strikethroughColor; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40001C2")]
	public int strikethroughVertexIndex; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40001C3")]
	public Color32 highlightColor; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40001C4")]
	public HighlightState highlightState; //Field offset: 0x15C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40001C5")]
	public FontStyles style; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x40001C6")]
	public bool isVisible; //Field offset: 0x174

	[Address(RVA = "0x1A5C6B0", Offset = "0x1A5B8B0", Length = "0x20B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B0")]
	public virtual string ToString() { }

}

