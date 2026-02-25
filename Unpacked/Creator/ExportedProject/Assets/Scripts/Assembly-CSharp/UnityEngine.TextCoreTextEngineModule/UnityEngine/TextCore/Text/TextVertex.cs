namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000041")]
internal struct TextVertex
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400019A")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400019B")]
	public Vector4 uv; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400019C")]
	public Vector2 uv2; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400019D")]
	public Color32 color; //Field offset: 0x24

}

