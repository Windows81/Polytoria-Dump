namespace UnityEngine.Rendering;

[Token(Token = "0x20002EE")]
[UsedByNativeCode]
internal struct GPUDrivenLODGroupDataNative
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008EB")]
	public Int32* lodGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008EC")]
	public Int32* lodOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008ED")]
	public Int32* lodCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008EE")]
	public LODFadeMode* fadeMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008EF")]
	public Vector3* worldSpaceReferencePoint; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008F0")]
	public Single* worldSpaceSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008F1")]
	public Int16* renderersCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008F2")]
	public Boolean* lastLODIsBillboard; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008F3")]
	public Byte* forceLODMask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008F4")]
	public int lodGroupCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008F5")]
	public Int32* invalidLODGroupID; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008F6")]
	public int invalidLODGroupCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008F7")]
	public Int16* lodRenderersCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008F8")]
	public Single* lodScreenRelativeTransitionHeight; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008F9")]
	public Single* lodFadeTransitionWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008FA")]
	public int lodDataCount; //Field offset: 0x78

}

