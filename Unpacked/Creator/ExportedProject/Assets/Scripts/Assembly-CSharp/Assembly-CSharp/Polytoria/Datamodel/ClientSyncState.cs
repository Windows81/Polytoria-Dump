namespace Polytoria.Datamodel;

[Token(Token = "0x2000317")]
public struct ClientSyncState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C1F")]
	public float nextSyncTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000C20")]
	public Vector3 velocity; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C21")]
	public Vector3 angularVelocity; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C22")]
	public bool isKinematic; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000C23")]
	public bool useGravity; //Field offset: 0x1D
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C24")]
	public float drag; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C25")]
	public float angularDrag; //Field offset: 0x24

}

