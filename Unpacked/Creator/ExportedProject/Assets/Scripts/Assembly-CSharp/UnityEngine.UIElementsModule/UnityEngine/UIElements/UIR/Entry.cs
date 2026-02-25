namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000568")]
internal class Entry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001286")]
	public EntryType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4001287")]
	public EntryFlags flags; //Field offset: 0x12
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001288")]
	public NativeSlice<Vertex> vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001289")]
	public NativeSlice<UInt16> indices; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400128A")]
	public Texture texture; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400128B")]
	public float textScale; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400128C")]
	public float fontSharpness; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400128D")]
	public VectorImage gradientsOwner; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400128E")]
	public Material material; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400128F")]
	public Action immediateCallback; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001290")]
	public TextureId textureId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001291")]
	public Entry nextSibling; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001292")]
	public Entry firstChild; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001293")]
	public Entry lastChild; //Field offset: 0x78

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C0")]
	public Entry() { }

	[Address(RVA = "0x1B81E10", Offset = "0x1B81010", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60026BF")]
	public void Reset() { }

}

