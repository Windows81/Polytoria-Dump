namespace UnityEngine.Rendering;

[Token(Token = "0x20002F4")]
public struct LightShadowCasterCullingInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400092B")]
	public RangeInt splitRange; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400092C")]
	public BatchCullingProjectionType projectionType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400092D")]
	public ushort splitExclusionMask; //Field offset: 0xC

}

