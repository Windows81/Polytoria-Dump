namespace GLTFast.Vertex;

[Token(Token = "0x2000063")]
internal struct VPosNormTan
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CA")]
	public float3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001CB")]
	public float3 normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CC")]
	public float4 tangent; //Field offset: 0x18

}

