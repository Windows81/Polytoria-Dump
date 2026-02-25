namespace UnityEngine;

[Token(Token = "0x20000FA")]
public struct FrustumPlanes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000490")]
	public float left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000491")]
	public float right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000492")]
	public float bottom; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000493")]
	public float top; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000494")]
	public float zNear; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000495")]
	public float zFar; //Field offset: 0x14

}

