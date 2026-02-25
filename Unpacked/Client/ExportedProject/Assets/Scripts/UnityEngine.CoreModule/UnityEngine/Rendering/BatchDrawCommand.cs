namespace UnityEngine.Rendering;

[Token(Token = "0x20002D6")]
public struct BatchDrawCommand
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083F")]
	public BatchDrawCommandFlags flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000840")]
	public BatchID batchID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000841")]
	public BatchMaterialID materialID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000842")]
	public ushort splitVisibilityMask; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000843")]
	public ushort lightmapIndex; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000844")]
	public int sortingPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000845")]
	public uint visibleOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000846")]
	public uint visibleCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000847")]
	public BatchMeshID meshID; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000848")]
	public ushort submeshIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000849")]
	public ushort activeMeshLod; //Field offset: 0x22

}

