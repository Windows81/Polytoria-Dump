namespace UnityEngine.Rendering;

[Token(Token = "0x20002D8")]
public struct BatchDrawCommandProcedural
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000858")]
	public BatchDrawCommandFlags flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000859")]
	public BatchID batchID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400085A")]
	public BatchMaterialID materialID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400085B")]
	public ushort splitVisibilityMask; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x400085C")]
	public ushort lightmapIndex; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400085D")]
	public int sortingPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400085E")]
	public uint visibleOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400085F")]
	public uint visibleCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000860")]
	public MeshTopology topology; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000861")]
	public GraphicsBufferHandle indexBufferHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000862")]
	public uint baseVertex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000863")]
	public uint indexOffsetBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000864")]
	public uint elementCount; //Field offset: 0x2C

}

