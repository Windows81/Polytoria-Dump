namespace UnityEngine.Rendering;

[Token(Token = "0x20002DC")]
public struct BatchCullingOutputDrawCommands
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000882")]
	public BatchDrawCommand* drawCommands; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000883")]
	public BatchDrawCommandIndirect* indirectDrawCommands; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000884")]
	public BatchDrawCommandProcedural* proceduralDrawCommands; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000885")]
	public BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000886")]
	public Int32* visibleInstances; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000887")]
	public BatchDrawRange* drawRanges; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000888")]
	public Single* instanceSortingPositions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000889")]
	public Int32* drawCommandPickingInstanceIDs; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400088A")]
	public int drawCommandCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400088B")]
	public int indirectDrawCommandCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400088C")]
	public int proceduralDrawCommandCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400088D")]
	public int proceduralIndirectDrawCommandCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400088E")]
	public int visibleInstanceCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400088F")]
	public int drawRangeCount; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000890")]
	public int instanceSortingPositionFloatCount; //Field offset: 0x58

}

