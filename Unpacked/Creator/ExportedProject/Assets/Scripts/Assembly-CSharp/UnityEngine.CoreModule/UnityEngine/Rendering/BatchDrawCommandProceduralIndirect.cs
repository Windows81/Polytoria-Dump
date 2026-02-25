namespace UnityEngine.Rendering;

[Token(Token = "0x20002D9")]
public struct BatchDrawCommandProceduralIndirect
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000865")]
	public BatchDrawCommandFlags flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000866")]
	public BatchID batchID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000867")]
	public BatchMaterialID materialID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000868")]
	public ushort splitVisibilityMask; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000869")]
	public ushort lightmapIndex; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400086A")]
	public int sortingPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400086B")]
	public uint visibleOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400086C")]
	public MeshTopology topology; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400086D")]
	public GraphicsBufferHandle indexBufferHandle; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400086E")]
	public GraphicsBufferHandle visibleInstancesBufferHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400086F")]
	public uint visibleInstancesBufferWindowOffset; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000870")]
	public uint visibleInstancesBufferWindowSizeBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000871")]
	public GraphicsBufferHandle indirectArgsBufferHandle; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000872")]
	public uint indirectArgsBufferOffset; //Field offset: 0x30

}

