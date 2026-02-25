namespace Mirror;

[Token(Token = "0x2000028")]
public struct CommandMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005A")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400005B")]
	public byte componentIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400005C")]
	public ushort functionHash; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005D")]
	public ArraySegment<Byte> payload; //Field offset: 0x8

}

