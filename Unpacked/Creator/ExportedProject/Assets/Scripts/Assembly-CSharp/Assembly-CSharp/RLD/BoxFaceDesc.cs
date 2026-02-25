namespace RLD;

[Token(Token = "0x2000193")]
public struct BoxFaceDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B5")]
	public BoxFace Face; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006B6")]
	public Plane Plane; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006B7")]
	public Vector3 Center; //Field offset: 0x14

}

