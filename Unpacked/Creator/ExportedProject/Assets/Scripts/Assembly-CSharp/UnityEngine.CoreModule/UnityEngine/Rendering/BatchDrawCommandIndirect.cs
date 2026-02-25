namespace UnityEngine.Rendering;

[Token(Token = "0x20002D7")]
public struct BatchDrawCommandIndirect
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400084A")]
	public BatchDrawCommandFlags flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400084B")]
	public BatchID batchID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400084C")]
	public BatchMaterialID materialID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400084D")]
	public ushort splitVisibilityMask; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x400084E")]
	public ushort lightmapIndex; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400084F")]
	public int sortingPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000850")]
	public uint visibleOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000851")]
	public BatchMeshID meshID; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000852")]
	public MeshTopology topology; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000853")]
	public GraphicsBufferHandle visibleInstancesBufferHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000854")]
	public uint visibleInstancesBufferWindowOffset; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000855")]
	public uint visibleInstancesBufferWindowSizeBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000856")]
	public GraphicsBufferHandle indirectArgsBufferHandle; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000857")]
	public uint indirectArgsBufferOffset; //Field offset: 0x30

}

