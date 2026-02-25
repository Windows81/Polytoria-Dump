namespace UnityEngine.Rendering;

[Token(Token = "0x20002F3")]
internal struct GPUDrivenLODGroupData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091E")]
	public NativeArray<Int32> lodGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400091F")]
	public NativeArray<Int32> lodOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000920")]
	public NativeArray<Int32> lodCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000921")]
	public NativeArray<LODFadeMode> fadeMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000922")]
	public NativeArray<Vector3> worldSpaceReferencePoint; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000923")]
	public NativeArray<Single> worldSpaceSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000924")]
	public NativeArray<Int16> renderersCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000925")]
	public NativeArray<Boolean> lastLODIsBillboard; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000926")]
	public NativeArray<Byte> forceLODMask; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000927")]
	public NativeArray<Int32> invalidLODGroupID; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000928")]
	public NativeArray<Int16> lodRenderersCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000929")]
	public NativeArray<Single> lodScreenRelativeTransitionHeight; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400092A")]
	public NativeArray<Single> lodFadeTransitionWidth; //Field offset: 0xC0

}

