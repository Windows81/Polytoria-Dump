namespace GLTFast.Vertex;

[Token(Token = "0x2000064")]
internal struct VPosNorm
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CD")]
	public float3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001CE")]
	public float3 normal; //Field offset: 0xC

}

