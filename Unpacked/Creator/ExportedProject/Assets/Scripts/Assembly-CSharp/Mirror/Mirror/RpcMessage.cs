namespace Mirror;

[Token(Token = "0x2000029")]
public struct RpcMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005E")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400005F")]
	public byte componentIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000060")]
	public ushort functionHash; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000061")]
	public ArraySegment<Byte> payload; //Field offset: 0x8

}

