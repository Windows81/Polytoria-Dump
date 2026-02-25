namespace UnityEngine.Rendering;

[Token(Token = "0x20002EF")]
[UsedByNativeCode]
internal struct GPUDrivenMeshLodInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008FB")]
	public int levelCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40008FC")]
	public float lodSlope; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008FD")]
	public float lodBias; //Field offset: 0x8

}

