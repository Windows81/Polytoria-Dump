namespace Mirror;

[Token(Token = "0x2000031")]
public struct EntityStateMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000072")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000073")]
	public ArraySegment<Byte> payload; //Field offset: 0x8

}

